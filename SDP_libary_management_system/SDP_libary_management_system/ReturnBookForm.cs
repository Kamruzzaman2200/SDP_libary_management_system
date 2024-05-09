using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SDP_libary_management_system
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public void populate()
        {
            con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IssueBookDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        public void populatereturn()
        {
            con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReturnedBookDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FillBook()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty > 0", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookch.ValueMember = "BookName";
            Bookch.DataSource = dt;

            // Modify the code to populate StdCb with StdId from IssueTbl
            SqlCommand cmd2 = new SqlCommand("select StdId from IssueTbl", con);
            SqlDataReader rdr2;
            rdr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("StdId", typeof(int));
            dt2.Load(rdr2);
            StdCb.ValueMember = "StdId";
            StdCb.DataSource = dt2;

            con.Close();
        }


        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            populate();
            populatereturn();
            FillBook();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IssueBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdCb.SelectedValue = IssueBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdnameTb.Text = IssueBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            StdDeptTb.Text = IssueBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            StdphnTb.Text = IssueBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookch.SelectedValue = IssueBookDGV.SelectedRows[0].Cells[5].Value.ToString();
            IssueDate.Value = Convert.ToDateTime(IssueBookDGV.SelectedRows[0].Cells[6].Value.ToString());
        }

        private void UpdateBook()
        {
            int Qty, newQty;
            con.Open();
            string query = "select * from BookTbl where BookName='" + Bookch.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Qty = Convert.ToInt32(rdr["Qty"].ToString());
                newQty = Qty + 1;
                rdr.Close();
                string query1 = "update BookTbl set Qty=" + newQty + " where BookName='" + Bookch.SelectedValue.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReturnNumTb.Text == "" || StdnameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string issuedate = IssueDate.Value.ToString("yyyy-MM-dd");
                string returndate = ReturnDate.Value.ToString("yyyy-MM-dd");
                con.Open();
                string stdCbSelected = StdCb.SelectedValue?.ToString();
                string bookchSelected = Bookch.SelectedValue?.ToString();
                if (stdCbSelected == null || bookchSelected == null)
                {
                    MessageBox.Show("Please select an item");
                    return;
                }
                string query = "insert into ReturnTbl values(" + ReturnNumTb.Text + "," + stdCbSelected + ",'" + StdnameTb.Text + "','" + StdDeptTb.Text + "','" + StdphnTb.Text + "','" + bookchSelected + "','" + issuedate + "','" + returndate + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Return Successfully");
                con.Close();
                UpdateBook();
                populate();
                populatereturn();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
 