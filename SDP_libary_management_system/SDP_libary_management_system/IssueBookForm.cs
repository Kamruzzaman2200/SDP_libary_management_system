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
using System.Diagnostics;
using System.Security.Policy;
namespace SDP_libary_management_system
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void FillStudents() {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);
            StdCb.ValueMember = "StdId";
                StdCb.DataSource = dt;
            con.Close();
        }
        private void FillBook() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty>"+0+"", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookch.ValueMember = "BookName";
            Bookch.DataSource = dt;
            con.Close();
        }
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
        private void fetchstddata()
        {
            con.Open();
            string query = "select * from StudentTbl where StdId=" + StdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StdnameTb.Text = rdr["StdName"].ToString();
                StdDeptTb.Text = rdr["StdDep"].ToString();
                StdphnTb.Text= rdr["StdPhone"].ToString();
            }
            con.Close();
        }
      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateBook()
        {
            con.Open();
            string query = "update BookTbl set Qty=Qty-1 where BookName='" + Bookch.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Updated Successfully");
            con.Close();
        }
        private void UpdateBookCancle()
            {
            con.Open();
            string bookName = Bookch.SelectedItem != null ? Bookch.SelectedItem.ToString() : string.Empty;
            string query = "update BookTbl set Qty=Qty+1 where BookName='" + bookName + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Updated Successfully");
            con.Close();
        }
        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudents();
            FillBook();
            populate();
            
        }

        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "" || StdnameTb.Text == "" || StdDeptTb.Text == "" || StdphnTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string issuedate = IssueDate.Value.ToString("yyyy-MM-dd");
                con.Open();

                int issueNum;
                if (int.TryParse(IssueNumTb.Text, out issueNum))
                {
                    string query = "insert into IssueTbl values(" + issueNum + ",'" + StdCb.SelectedValue.ToString() + "','" + StdnameTb.Text + "','" + StdDeptTb.Text + "','" + StdphnTb.Text + "','" + Bookch.SelectedValue.ToString() + "','" + issuedate + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Issued");
                }
                else
                {
                    MessageBox.Show("Invalid Issue Number");
                }

                con.Close();
                populate();
                UpdateBook();
            }


        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(IssueNumTb.Text=="")
            {
                MessageBox.Show("Enter Issue Number");
            }
            else
            {
                con.Open();
                string query = "delete from IssueTbl where IssueName=" + IssueNumTb.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Returned Successfully");
                con.Close();
                populate();
                UpdateBookCancle();

            }
        }

        private void IssueBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueNumTb.Text= IssueBookDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.SelectedValue = IssueBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdnameTb.Text = IssueBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            StdDeptTb.Text = IssueBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            StdphnTb.Text = IssueBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookch.SelectedValue = IssueBookDGV.SelectedRows[0].Cells[5].Value.ToString();
            IssueDate.Value = Convert.ToDateTime(IssueBookDGV.SelectedRows[0].Cells[6].Value.ToString());

        }
    }
}
