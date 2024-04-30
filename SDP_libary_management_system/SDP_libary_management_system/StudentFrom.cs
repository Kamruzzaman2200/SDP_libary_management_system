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
    public partial class StudentFrom : Form
    {
        public StudentFrom()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahfu\Documents\LMSdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentFrom_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {             con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(StdId.Text==""|| StdName.Text==""|| Stdsec.Text==""|| Stdsem.Text=="" || Stdphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "insert into StudentTbl values(" + StdId.Text + ",'" + StdName.Text + "','" + StdDep.Text + "','" + Stdsem.SelectedItem.ToString() + "','" + Stdsec.SelectedItem.ToString() + "','" + Stdphone.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");
                con.Close();
                populate();
            }
        }

        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId.Text= StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdDep.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            Stdsem.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Stdsec.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            Stdphone.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StdId.Text=="")
            {                 MessageBox.Show("Enter The Student Id");
            }
            else
            {
                con.Open();
                string query = "delete from StudentTbl where StdId=" + StdId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(StdId.Text=="" || StdName.Text=="" || StdDep.Text=="" || Stdsem.Text=="" || Stdsec.Text=="" || Stdphone.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update StudentTbl set StdName='" + StdName.Text + "',StdDep='" + StdDep.Text + "',Stdsem='" + Stdsem.SelectedItem.ToString() + "',Stdsec='" + Stdsec.SelectedItem.ToString() + "',Stdphone='" + Stdphone.Text + "' where StdId=" + StdId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated Successfully");
                con.Close();
                populate();
            }
        }
    }
}
