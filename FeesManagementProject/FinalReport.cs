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
    public partial class FinalReport : Form
    {
        
        public FinalReport()
        {
            InitializeComponent();
        }

        

        private void btncloseF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FinalReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentFeesSyetmDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.studentFeesSyetmDataSet1.Student);

        }

        private void btncompleteviewF_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
            {
                string str = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewFinalReport.DataSource = new BindingSource(dt, null);
            }
        }

        private void btnpaidstudentF_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
            {

                string str = "SELECT * FROM Student WHERE std_remain = 0";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewFinalReport.DataSource = new BindingSource(dt, null);
            }
        }

        private void btnunpaidstudentF_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
            {
                string str = "SELECT * FROM Student WHERE std_remain > 0";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewFinalReport.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
