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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from BookTbl", con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            Booklbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from StudentTbl", con);
            DataTable dt1 = new DataTable();
            sda2.Fill(dt1);
            Studentlbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from LibrarianTbl", con);
            DataTable dt2 = new DataTable();
            sda3.Fill(dt2);
            Librarianlbl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from IssueTbl", con);
            DataTable dt3 = new DataTable();
            sda4.Fill(dt3);
            IssuedBooklbl.Text= dt3.Rows[0][0].ToString();
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from ReturnTbl", con);
            DataTable dt4 = new DataTable();
            sda5.Fill(dt4);
            ReturnBooklbl.Text = dt4.Rows[0][0].ToString();
            con.Close();
        }
    }
}
