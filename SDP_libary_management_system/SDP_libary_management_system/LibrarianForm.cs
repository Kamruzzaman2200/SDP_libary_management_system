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
    public partial class LibrarianForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
                        con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            con.Close();
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
                populate();
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibId.Text= LibrarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            LibName.Text = LibrarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            Libpass.Text = LibrarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            Libphone.Text = LibrarianDGV.SelectedRows[0].Cells[3].Value.ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(LibId.Text=="" )
            {
                MessageBox.Show("Enter the Librarian Id");
            }
            else
            {
                con.Open();
                string query = "delete from LibrarianTbl where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update LibrarianTbl set LibName='" + LibName.Text + "',LibPassword='" + Libpass.Text + "',LibPhone='" + Libphone.Text + "' where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Updated Successfully");
                con.Close();
                populate();
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
