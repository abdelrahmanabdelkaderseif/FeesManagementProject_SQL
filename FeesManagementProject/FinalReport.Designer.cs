namespace FeesManagementProject
{
    partial class FinalReport
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncompleteviewF = new System.Windows.Forms.Button();
            this.btnpaidstudentF = new System.Windows.Forms.Button();
            this.btnunpaidstudentF = new System.Windows.Forms.Button();
            this.btncloseF = new System.Windows.Forms.Button();
            this.dataGridViewFinalReport = new System.Windows.Forms.DataGridView();
            this.studentFeesSyetmDataSet1 = new FeesManagementProject.StudentFeesSyetmDataSet1();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new FeesManagementProject.StudentFeesSyetmDataSet1TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesSyetmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FeesManagementProject.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btncompleteviewF
            // 
            this.btncompleteviewF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompleteviewF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncompleteviewF.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompleteviewF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncompleteviewF.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btncompleteviewF.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncompleteviewF.Location = new System.Drawing.Point(65, 57);
            this.btncompleteviewF.Name = "btncompleteviewF";
            this.btncompleteviewF.Size = new System.Drawing.Size(175, 29);
            this.btncompleteviewF.TabIndex = 27;
            this.btncompleteviewF.Text = "Complete View";
            this.btncompleteviewF.UseVisualStyleBackColor = true;
            this.btncompleteviewF.Click += new System.EventHandler(this.btncompleteviewF_Click);
            // 
            // btnpaidstudentF
            // 
            this.btnpaidstudentF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpaidstudentF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpaidstudentF.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaidstudentF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpaidstudentF.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnpaidstudentF.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnpaidstudentF.Location = new System.Drawing.Point(328, 57);
            this.btnpaidstudentF.Name = "btnpaidstudentF";
            this.btnpaidstudentF.Size = new System.Drawing.Size(175, 29);
            this.btnpaidstudentF.TabIndex = 28;
            this.btnpaidstudentF.Text = "Paid Student";
            this.btnpaidstudentF.UseVisualStyleBackColor = true;
            this.btnpaidstudentF.Click += new System.EventHandler(this.btnpaidstudentF_Click);
            // 
            // btnunpaidstudentF
            // 
            this.btnunpaidstudentF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnunpaidstudentF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnunpaidstudentF.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunpaidstudentF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnunpaidstudentF.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btnunpaidstudentF.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnunpaidstudentF.Location = new System.Drawing.Point(588, 57);
            this.btnunpaidstudentF.Name = "btnunpaidstudentF";
            this.btnunpaidstudentF.Size = new System.Drawing.Size(175, 29);
            this.btnunpaidstudentF.TabIndex = 29;
            this.btnunpaidstudentF.Text = "Unpaid Student";
            this.btnunpaidstudentF.UseVisualStyleBackColor = true;
            this.btnunpaidstudentF.Click += new System.EventHandler(this.btnunpaidstudentF_Click);
            // 
            // btncloseF
            // 
            this.btncloseF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncloseF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncloseF.Font = new System.Drawing.Font("Baskerville Old Face", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncloseF.Image = global::FeesManagementProject.Properties.Resources.header;
            this.btncloseF.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncloseF.Location = new System.Drawing.Point(870, 57);
            this.btncloseF.Name = "btncloseF";
            this.btncloseF.Size = new System.Drawing.Size(113, 29);
            this.btncloseF.TabIndex = 30;
            this.btncloseF.Text = "Close";
            this.btncloseF.UseVisualStyleBackColor = true;
            this.btncloseF.Click += new System.EventHandler(this.btncloseF_Click);
            // 
            // dataGridViewFinalReport
            // 
            this.dataGridViewFinalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinalReport.Location = new System.Drawing.Point(12, 242);
            this.dataGridViewFinalReport.Name = "dataGridViewFinalReport";
            this.dataGridViewFinalReport.Size = new System.Drawing.Size(1026, 269);
            this.dataGridViewFinalReport.TabIndex = 32;
            // 
            // studentFeesSyetmDataSet1
            // 
            this.studentFeesSyetmDataSet1.DataSetName = "StudentFeesSyetmDataSet1";
            this.studentFeesSyetmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentFeesSyetmDataSet1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // FinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 533);
            this.Controls.Add(this.dataGridViewFinalReport);
            this.Controls.Add(this.btncloseF);
            this.Controls.Add(this.btnunpaidstudentF);
            this.Controls.Add(this.btnpaidstudentF);
            this.Controls.Add(this.btncompleteviewF);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FinalReport";
            this.Text = "FinalReport";
            this.Load += new System.EventHandler(this.FinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesSyetmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncompleteviewF;
        private System.Windows.Forms.Button btnpaidstudentF;
        private System.Windows.Forms.Button btnunpaidstudentF;
        private System.Windows.Forms.Button btncloseF;
        private System.Windows.Forms.DataGridView dataGridViewFinalReport;
        private StudentFeesSyetmDataSet1 studentFeesSyetmDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentFeesSyetmDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
    }
}