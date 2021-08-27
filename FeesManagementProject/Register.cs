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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void lblusernameR_Click(object sender, EventArgs e)
        {

        }

        private void btnresetR_Click(object sender, EventArgs e)
        {
            txtusernameR.Clear();
            txtemailR.Clear();
            txtmobileR.Clear();

        }

        private void btncloseR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregisterR_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True");

            con.Open();
            
            try
            {
                string str = " INSERT INTO Employee(emp_username,emp_email,emp_mobile,emp_password) VALUES('" + txtusernameR.Text + "','" + txtemailR.Text + "','" + txtmobileR.Text + "','" + txtCpassword.Text + "'); ";      // saving new custmer info

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(emp_id) from Employee ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Your Account created Successfully. ");
                    Welcome obj1 = new Welcome();
                    obj1.ShowDialog();
                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void txtCpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemailR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
