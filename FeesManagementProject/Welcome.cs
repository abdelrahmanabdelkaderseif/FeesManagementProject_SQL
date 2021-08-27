using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeesManagementProject
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update obj1 = new Update();
            obj1.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Update obj2 = new Update();
            obj2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchStudent obj3 = new SearchStudent();
            obj3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteStudentRecord obj4 = new DeleteStudentRecord();
            obj4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want to Exit Click Ok.", "Important Message");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalReport obj5 = new FinalReport();
            obj5.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
