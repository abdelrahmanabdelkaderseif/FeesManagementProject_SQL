namespace FeesManagementProject
{
    partial class DeleteStudentRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtstudentidD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdeducationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stddurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdremainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_fess_project_SQLDataSet2 = new FeesManagementProject.student_fess_project_SQLDataSet2();
            this.btncloseD = new System.Windows.Forms.Button();
            this.btnresetD = new System.Windows.Forms.Button();
            this.btnsaveD = new System.Windows.Forms.Button();
            this.lblstudentidD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentTableAdapter = new FeesManagementProject.student_fess_project_SQLDataSet2TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fess_project_SQLDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentidD
            // 
            this.txtstudentidD.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentidD.Location = new System.Drawing.Point(370, 60);
            this.txtstudentidD.Name = "txtstudentidD";
            this.txtstudentidD.Size = new System.Drawing.Size(238, 24);
            this.txtstudentidD.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdidDataGridViewTextBoxColumn,
            this.stdnameDataGridViewTextBoxColumn,
            this.stdcontactDataGridViewTextBoxColumn,
            this.stdemailDataGridViewTextBoxColumn,
            this.stdeducationDataGridViewTextBoxColumn,
            this.stdcourseDataGridViewTextBoxColumn,
            this.stddurationDataGridViewTextBoxColumn,
            this.stdtypeDataGridViewTextBoxColumn,
            this.stddateDataGridViewTextBoxColumn,
            this.stdamountDataGridViewTextBoxColumn,
            this.stdpaidDataGridViewTextBoxColumn,
            this.stdremainDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(991, 269);
            this.dataGridView1.TabIndex = 29;
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "std_id";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "std_id";
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stdnameDataGridViewTextBoxColumn
            // 
            this.stdnameDataGridViewTextBoxColumn.DataPropertyName = "std_name";
            this.stdnameDataGridViewTextBoxColumn.HeaderText = "std_name";
            this.stdnameDataGridViewTextBoxColumn.Name = "stdnameDataGridViewTextBoxColumn";
            // 
            // stdcontactDataGridViewTextBoxColumn
            // 
            this.stdcontactDataGridViewTextBoxColumn.DataPropertyName = "std_contact";
            this.stdcontactDataGridViewTextBoxColumn.HeaderText = "std_contact";
            this.stdcontactDataGridViewTextBoxColumn.Name = "stdcontactDataGridViewTextBoxColumn";
            // 
            // stdemailDataGridViewTextBoxColumn
            // 
            this.stdemailDataGridViewTextBoxColumn.DataPropertyName = "std_email";
            this.stdemailDataGridViewTextBoxColumn.HeaderText = "std_email";
            this.stdemailDataGridViewTextBoxColumn.Name = "stdemailDataGridViewTextBoxColumn";
            // 
            // stdeducationDataGridViewTextBoxColumn
            // 
            this.stdeducationDataGridViewTextBoxColumn.DataPropertyName = "std_education";
            this.stdeducationDataGridViewTextBoxColumn.HeaderText = "std_education";
            this.stdeducationDataGridViewTextBoxColumn.Name = "stdeducationDataGridViewTextBoxColumn";
            // 
            // stdcourseDataGridViewTextBoxColumn
            // 
            this.stdcourseDataGridViewTextBoxColumn.DataPropertyName = "std_course";
            this.stdcourseDataGridViewTextBoxColumn.HeaderText = "std_course";
            this.stdcourseDataGridViewTextBoxColumn.Name = "stdcourseDataGridViewTextBoxColumn";
            // 
            // stddurationDataGridViewTextBoxColumn
            // 
            this.stddurationDataGridViewTextBoxColumn.DataPropertyName = "std_duration";
            this.stddurationDataGridViewTextBoxColumn.HeaderText = "std_duration";
            this.stddurationDataGridViewTextBoxColumn.Name = "stddurationDataGridViewTextBoxColumn";
            // 
            // stdtypeDataGridViewTextBoxColumn
            // 
            this.stdtypeDataGridViewTextBoxColumn.DataPropertyName = "std_type";
            this.stdtypeDataGridViewTextBoxColumn.HeaderText = "std_type";
            this.stdtypeDataGridViewTextBoxColumn.Name = "stdtypeDataGridViewTextBoxColumn";
            // 
            // stddateDataGridViewTextBoxColumn
            // 
            this.stddateDataGridViewTextBoxColumn.DataPropertyName = "std_date";
            this.stddateDataGridViewTextBoxColumn.HeaderText = "std_date";
            this.stddateDataGridViewTextBoxColumn.Name = "stddateDataGridViewTextBoxColumn";
            // 
            // stdamountDataGridViewTextBoxColumn
            // 
            this.stdamountDataGridViewTextBoxColumn.DataPropertyName = "std_amount";
            this.stdamountDataGridViewTextBoxColumn.HeaderText = "std_amount";
            this.stdamountDataGridViewTextBoxColumn.Name = "stdamountDataGridViewTextBoxColumn";
            // 
            // stdpaidDataGridViewTextBoxColumn
            // 
            this.stdpaidDataGridViewTextBoxColumn.DataPropertyName = "std_paid";
            this.stdpaidDataGridViewTextBoxColumn.HeaderText = "std_paid";
            this.stdpaidDataGridViewTextBoxColumn.Name = "stdpaidDataGridViewTextBoxColumn";
            // 
            // stdremainDataGridViewTextBoxColumn
            // 
            this.stdremainDataGridViewTextBoxColumn.DataPropertyName = "std_remain";
            this.stdremainDataGridViewTextBoxColumn.HeaderText = "std_remain";
            this.stdremainDataGridViewTextBoxColumn.Name = "stdremainDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.student_fess_project_SQLDataSet2;
            // 
            // student_fess_project_SQLDataSet2
            // 
            this.student_fess_project_SQLDataSet2.DataSetName = "student_fess_project_SQLDataSet2";
            this.student_fess_project_SQLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncloseD
            // 
            this.btncloseD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncloseD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncloseD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseD.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btncloseD.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncloseD.Location = new System.Drawing.Point(661, 165);
            this.btncloseD.Name = "btncloseD";
            this.btncloseD.Size = new System.Drawing.Size(97, 29);
            this.btncloseD.TabIndex = 28;
            this.btncloseD.Text = "Close";
            this.btncloseD.UseVisualStyleBackColor = true;
            this.btncloseD.Click += new System.EventHandler(this.btncloseD_Click);
            // 
            // btnresetD
            // 
            this.btnresetD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresetD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresetD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetD.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnresetD.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnresetD.Location = new System.Drawing.Point(479, 165);
            this.btnresetD.Name = "btnresetD";
            this.btnresetD.Size = new System.Drawing.Size(98, 29);
            this.btnresetD.TabIndex = 27;
            this.btnresetD.Text = "Reset";
            this.btnresetD.UseVisualStyleBackColor = true;
            this.btnresetD.Click += new System.EventHandler(this.btnresetD_Click);
            // 
            // btnsaveD
            // 
            this.btnsaveD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsaveD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveD.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnsaveD.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnsaveD.Location = new System.Drawing.Point(312, 165);
            this.btnsaveD.Name = "btnsaveD";
            this.btnsaveD.Size = new System.Drawing.Size(101, 29);
            this.btnsaveD.TabIndex = 26;
            this.btnsaveD.Text = "Delete";
            this.btnsaveD.UseVisualStyleBackColor = true;
            this.btnsaveD.Click += new System.EventHandler(this.btnsaveD_Click);
            // 
            // lblstudentidD
            // 
            this.lblstudentidD.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentidD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstudentidD.Image = global::FeesManagementProject.Properties.Resources.header;
            this.lblstudentidD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblstudentidD.Location = new System.Drawing.Point(187, 60);
            this.lblstudentidD.Name = "lblstudentidD";
            this.lblstudentidD.Size = new System.Drawing.Size(147, 28);
            this.lblstudentidD.TabIndex = 4;
            this.lblstudentidD.Text = "Student ID";
            this.lblstudentidD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FeesManagementProject.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncloseD);
            this.Controls.Add(this.btnresetD);
            this.Controls.Add(this.btnsaveD);
            this.Controls.Add(this.txtstudentidD);
            this.Controls.Add(this.lblstudentidD);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteStudentRecord";
            this.Text = "DeleteStudentRecord";
            this.Load += new System.EventHandler(this.DeleteStudentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fess_project_SQLDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstudentidD;
        private System.Windows.Forms.TextBox txtstudentidD;
        private System.Windows.Forms.Button btnsaveD;
        private System.Windows.Forms.Button btnresetD;
        private System.Windows.Forms.Button btncloseD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private student_fess_project_SQLDataSet2 student_fess_project_SQLDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private student_fess_project_SQLDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdeducationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stddurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdpaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdremainDataGridViewTextBoxColumn;
    }
}