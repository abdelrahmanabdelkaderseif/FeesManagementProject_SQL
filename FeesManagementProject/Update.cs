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
    public partial class Update : Form
    {
        private int tot, paid, remain;
        public Update()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (txtamountU.Text != "")
            {
                tot = Convert.ToInt32(txtamountU.Text);
            }
            if(txtpaidU.Text != "")
            {
                paid = Convert.ToInt32(txtpaidU.Text);
            }
            remain = tot - paid;
            txtremainU.Text = remain.ToString();
        }

        private void btnresetU_Click(object sender, EventArgs e)
        {
            txtfullnameU.Text = "";
            txtcellnoU.Text = "";
            txtemailU.Text = "";
            txteducationU.Text = "";
            txtamountU.Text = "";
            txtpaidU.Text = "";
            txtremainU.Text = "";
            cmbcourseU.Text = "--Select--";
            cmbdurationU.Text = "--Select--";
            cmbtypeU.Text = "--Select--";
        }

        private void btncloseU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaveU_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True");
            con.Open();
            try
            {
                string str = " insert into student(std_name,std_contact,std_email,std_education,std_course,std_duration,std_type,std_date,std_amount,std_paid,std_remain) values('" + txtfullnameU.Text + "','" + txtcellnoU.Text + "','" + txtemailU.Text + "','" + txteducationU.Text + "','" + cmbcourseU.Text + "','" + cmbdurationU.Text + "','" + cmbtypeU.Text + "','" + dateTimePicker1.Text + "','" + txtamountU.Text + "','" + txtpaidU.Text + "','" + txtremainU.Text +"'); ";     

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(std_id) from student ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Student Record saved Successfully. ");
                    txtfullnameU.Text = "";
                    txtcellnoU.Text = "";
                    txtemailU.Text = "";
                    txteducationU.Text = "";
                    txtamountU.Text = "";
                    txtpaidU.Text = "";
                    txtremainU.Text = "";
                    cmbcourseU.Text = "--Select--";
                    cmbdurationU.Text = "--Select--";
                    cmbtypeU.Text = "--Select--";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void studentfessprojectSQLDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_fess_project_SQLDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.student_fess_project_SQLDataSet1.Student);

        }

        private void txtamountU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdateU_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9B16OJ7;Initial Catalog=student_fess_project_SQL;Integrated Security=True"))
            {
                string str = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1Update.DataSource = new BindingSource(dt, null);
            }
        }

        private void lbltypeU_Click(object sender, EventArgs e)
        {

        }
    }
}
