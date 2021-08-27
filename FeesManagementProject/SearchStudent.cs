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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void btnresetS_Click(object sender, EventArgs e)
        {
            txtstudentidS.Text = "";
        }

        private void btncloseS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaveS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection newcon = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
                {
                    string str1 = @"SELECT * from Student where std_id = '" + txtstudentidS.Text+ "'";
                    SqlCommand cmd1 = new SqlCommand(str1, newcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1SearchStudent.DataSource = new BindingSource(dt, null);
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Enter Number");
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_fess_project_SQLDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.student_fess_project_SQLDataSet.Student);

        }
    }
}
