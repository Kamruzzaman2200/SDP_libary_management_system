using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDP_libary_management_system
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void FillStudents()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            StdCb.ValueMember = "BookName";
            StdCb.DataSource = dt;
            con.Close();
        }
        private void fetchstddata()
        {
            con.Open();
            string query = "select * from BookTbl where BookName = @bookName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bookName", StdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                bookname.Text = dr["BookName"].ToString();
                author.Text = dr["Author"].ToString();
                publisher.Text = dr["Publisher"].ToString();
                price.Text = dr["Price"].ToString();
                quantity.Text = dr["Qty"].ToString();
            }
            con.Close();
        }

        public void populate()
        {             con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            FillStudents();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bookname.Text==""|| author.Text==""||publisher.Text==""|| price.Text=="" || quantity.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "insert into BookTbl values('" + bookname.Text + "','" + author.Text + "','" + publisher.Text + "'," + price.Text + "," + quantity.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                con.Close();
                populate();
            }
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookname.Text=="")
            {
                MessageBox.Show("Enter the Book Name");
            }
            else
            {
                con.Open();
                string query = "delete from BookTbl where BookName='" + bookname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bookname.Text==""|| author.Text==""||publisher.Text==""|| price.Text=="" || quantity.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update BookTbl set Author='" + author.Text + "',Publisher='" + publisher.Text + "',Price=" + price.Text + ",Qty=" + quantity.Text + " where BookName='" + bookname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Updated Successfully");
                con.Close();
                populate();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookname.Text= BookDGV.SelectedRows[0].Cells[0].Value.ToString();
            author.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            publisher.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            quantity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
