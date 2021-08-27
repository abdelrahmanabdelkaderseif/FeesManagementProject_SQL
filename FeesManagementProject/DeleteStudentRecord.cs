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
    public partial class DeleteStudentRecord : Form
    {
        public DeleteStudentRecord()
        {
            InitializeComponent();
        }

        private void btnresetD_Click(object sender, EventArgs e)
        {
            txtstudentidD.Text = "";
        }

        private void btncloseD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStudentRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_fess_project_SQLDataSet2.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.student_fess_project_SQLDataSet2.Student);

        }

        private void btnsaveD_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True");
                con.Open();
                
                string str = "DELETE FROM Student WHERE std_id = '"+ txtstudentidD.Text +"'";
                
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");

                using (SqlConnection newcon = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
                {
                    string str1 = @"SELECT * from Student";
                    SqlCommand cmd1 = new SqlCommand(str1, newcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt,null);
                   
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Numbers in Student Id");
            }
        }
    }
}
