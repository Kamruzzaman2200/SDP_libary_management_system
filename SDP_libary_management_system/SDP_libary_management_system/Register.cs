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

namespace SDP_libary_management_system
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
       

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarianTbl values(" + LibId.Text + ",'" + LibName.Text + "','" + Libpass.Text + "','" + Libphone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian added successfully");
                con.Close();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
