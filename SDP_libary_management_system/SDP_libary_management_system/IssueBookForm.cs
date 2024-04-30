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
            SqlCommand cmd = new SqlCommand("select * from BookTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookId", typeof(int));
            dt.Load(rdr);
            Bookch.ValueMember = "BookId";
            Bookch.DataSource = dt;
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

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudents();
            FillBook();
        }

        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
