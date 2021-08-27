using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FeesManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True");
            con.Open();
            string str = "SELECT emp_id FROM Employee WHERE emp_username = '" + txtusername.Text + "' and emp_password = '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Welcome obj2 = new Welcome();
                obj2.ShowDialog();   
            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }
           
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register obj1 = new Register();
            obj1.ShowDialog();

            this.Close();
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }
    }
}
