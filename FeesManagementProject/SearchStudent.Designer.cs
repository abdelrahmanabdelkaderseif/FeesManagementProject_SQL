namespace FeesManagementProject
{
    partial class SearchStudent
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
            this.txtstudentidS = new System.Windows.Forms.TextBox();
            this.dataGridView1SearchStudent = new System.Windows.Forms.DataGridView();
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
            this.student_fess_project_SQLDataSet = new FeesManagementProject.student_fess_project_SQLDataSet();
            this.btncloseS = new System.Windows.Forms.Button();
            this.btnresetS = new System.Windows.Forms.Button();
            this.btnsaveS = new System.Windows.Forms.Button();
            this.lblstudentidS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentTableAdapter = new FeesManagementProject.student_fess_project_SQLDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SearchStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fess_project_SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentidS
            // 
            this.txtstudentidS.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentidS.Location = new System.Drawing.Point(426, 58);
            this.txtstudentidS.Name = "txtstudentidS";
            this.txtstudentidS.Size = new System.Drawing.Size(238, 24);
            this.txtstudentidS.TabIndex = 11;
            // 
            // dataGridView1SearchStudent
            // 
            this.dataGridView1SearchStudent.AutoGenerateColumns = false;
            this.dataGridView1SearchStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1SearchStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1SearchStudent.DataSource = this.studentBindingSource;
            this.dataGridView1SearchStudent.Location = new System.Drawing.Point(29, 240);
            this.dataGridView1SearchStudent.Name = "dataGridView1SearchStudent";
            this.dataGridView1SearchStudent.Size = new System.Drawing.Size(991, 269);
            this.dataGridView1SearchStudent.TabIndex = 28;
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
            this.studentBindingSource.DataSource = this.student_fess_project_SQLDataSet;
            // 
            // student_fess_project_SQLDataSet
            // 
            this.student_fess_project_SQLDataSet.DataSetName = "student_fess_project_SQLDataSet";
            this.student_fess_project_SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncloseS
            // 
            this.btncloseS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncloseS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncloseS.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseS.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btncloseS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncloseS.Location = new System.Drawing.Point(671, 149);
            this.btncloseS.Name = "btncloseS";
            this.btncloseS.Size = new System.Drawing.Size(97, 29);
            this.btncloseS.TabIndex = 27;
            this.btncloseS.Text = "Close";
            this.btncloseS.UseVisualStyleBackColor = true;
            this.btncloseS.Click += new System.EventHandler(this.btncloseS_Click);
            // 
            // btnresetS
            // 
            this.btnresetS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresetS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresetS.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetS.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnresetS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnresetS.Location = new System.Drawing.Point(495, 149);
            this.btnresetS.Name = "btnresetS";
            this.btnresetS.Size = new System.Drawing.Size(98, 29);
            this.btnresetS.TabIndex = 26;
            this.btnresetS.Text = "Reset";
            this.btnresetS.UseVisualStyleBackColor = true;
            this.btnresetS.Click += new System.EventHandler(this.btnresetS_Click);
            // 
            // btnsaveS
            // 
            this.btnsaveS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsaveS.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveS.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnsaveS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnsaveS.Location = new System.Drawing.Point(318, 149);
            this.btnsaveS.Name = "btnsaveS";
            this.btnsaveS.Size = new System.Drawing.Size(101, 29);
            this.btnsaveS.TabIndex = 25;
            this.btnsaveS.Text = "Search";
            this.btnsaveS.UseVisualStyleBackColor = true;
            this.btnsaveS.Click += new System.EventHandler(this.btnsaveS_Click);
            // 
            // lblstudentidS
            // 
            this.lblstudentidS.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentidS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstudentidS.Image = global::FeesManagementProject.Properties.Resources.header;
            this.lblstudentidS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblstudentidS.Location = new System.Drawing.Point(199, 54);
            this.lblstudentidS.Name = "lblstudentidS";
            this.lblstudentidS.Size = new System.Drawing.Size(147, 28);
            this.lblstudentidS.TabIndex = 3;
            this.lblstudentidS.Text = "Student ID";
            this.lblstudentidS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FeesManagementProject.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 533);
            this.Controls.Add(this.dataGridView1SearchStudent);
            this.Controls.Add(this.btncloseS);
            this.Controls.Add(this.btnresetS);
            this.Controls.Add(this.btnsaveS);
            this.Controls.Add(this.txtstudentidS);
            this.Controls.Add(this.lblstudentidS);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.Load += new System.EventHandler(this.SearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SearchStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fess_project_SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstudentidS;
        private System.Windows.Forms.TextBox txtstudentidS;
        private System.Windows.Forms.Button btnsaveS;
        private System.Windows.Forms.Button btnresetS;
        private System.Windows.Forms.Button btncloseS;
        private System.Windows.Forms.DataGridView dataGridView1SearchStudent;
        private student_fess_project_SQLDataSet student_fess_project_SQLDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private student_fess_project_SQLDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
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