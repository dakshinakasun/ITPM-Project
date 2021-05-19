
namespace StudentAndTagProject
{
    partial class concutive
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstLectureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondLectureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet9 = new StudentAndTagProject.ITPMDataSet9();
            this.sessionTableAdapter = new StudentAndTagProject.ITPMDataSet9TableAdapters.SessionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericCon = new System.Windows.Forms.NumericUpDown();
            this.cmbCtag = new System.Windows.Forms.ComboBox();
            this.cmbCsub = new System.Windows.Forms.ComboBox();
            this.cmbCsubg = new System.Windows.Forms.ComboBox();
            this.btnCCon = new System.Windows.Forms.Button();
            this.btnCclear = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.firstLectureNameDataGridViewTextBoxColumn,
            this.secondLectureNameDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.studentGroupDataGridViewTextBoxColumn,
            this.studentSubGroupDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.noOfStudentsDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            this.sessionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstLectureNameDataGridViewTextBoxColumn
            // 
            this.firstLectureNameDataGridViewTextBoxColumn.DataPropertyName = "FirstLectureName";
            this.firstLectureNameDataGridViewTextBoxColumn.HeaderText = "FirstLectureName";
            this.firstLectureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstLectureNameDataGridViewTextBoxColumn.Name = "firstLectureNameDataGridViewTextBoxColumn";
            this.firstLectureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // secondLectureNameDataGridViewTextBoxColumn
            // 
            this.secondLectureNameDataGridViewTextBoxColumn.DataPropertyName = "SecondLectureName";
            this.secondLectureNameDataGridViewTextBoxColumn.HeaderText = "SecondLectureName";
            this.secondLectureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondLectureNameDataGridViewTextBoxColumn.Name = "secondLectureNameDataGridViewTextBoxColumn";
            this.secondLectureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentGroupDataGridViewTextBoxColumn
            // 
            this.studentGroupDataGridViewTextBoxColumn.DataPropertyName = "StudentGroup";
            this.studentGroupDataGridViewTextBoxColumn.HeaderText = "StudentGroup";
            this.studentGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentGroupDataGridViewTextBoxColumn.Name = "studentGroupDataGridViewTextBoxColumn";
            this.studentGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentSubGroupDataGridViewTextBoxColumn
            // 
            this.studentSubGroupDataGridViewTextBoxColumn.DataPropertyName = "StudentSubGroup";
            this.studentSubGroupDataGridViewTextBoxColumn.HeaderText = "StudentSubGroup";
            this.studentSubGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSubGroupDataGridViewTextBoxColumn.Name = "studentSubGroupDataGridViewTextBoxColumn";
            this.studentSubGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOfStudentsDataGridViewTextBoxColumn
            // 
            this.noOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NoOfStudents";
            this.noOfStudentsDataGridViewTextBoxColumn.HeaderText = "NoOfStudents";
            this.noOfStudentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfStudentsDataGridViewTextBoxColumn.Name = "noOfStudentsDataGridViewTextBoxColumn";
            this.noOfStudentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.iTPMDataSet9;
            // 
            // iTPMDataSet9
            // 
            this.iTPMDataSet9.DataSetName = "ITPMDataSet9";
            this.iTPMDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD CONSECUTIVE SESSION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SessionID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "GroupID";
            // 
            // numericCon
            // 
            this.numericCon.Location = new System.Drawing.Point(172, 287);
            this.numericCon.Name = "numericCon";
            this.numericCon.Size = new System.Drawing.Size(154, 22);
            this.numericCon.TabIndex = 6;
            // 
            // cmbCtag
            // 
            this.cmbCtag.FormattingEnabled = true;
            this.cmbCtag.Items.AddRange(new object[] {
            "Lecture",
            "Lab",
            "Practical"});
            this.cmbCtag.Location = new System.Drawing.Point(172, 340);
            this.cmbCtag.Name = "cmbCtag";
            this.cmbCtag.Size = new System.Drawing.Size(154, 24);
            this.cmbCtag.TabIndex = 7;
            // 
            // cmbCsub
            // 
            this.cmbCsub.FormattingEnabled = true;
            this.cmbCsub.Items.AddRange(new object[] {
            "ITPM",
            "Mobile Application Devalopment",
            "Object Oriented Programming"});
            this.cmbCsub.Location = new System.Drawing.Point(496, 283);
            this.cmbCsub.Name = "cmbCsub";
            this.cmbCsub.Size = new System.Drawing.Size(154, 24);
            this.cmbCsub.TabIndex = 8;
            // 
            // cmbCsubg
            // 
            this.cmbCsubg.FormattingEnabled = true;
            this.cmbCsubg.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.cmbCsubg.Location = new System.Drawing.Point(496, 345);
            this.cmbCsubg.Name = "cmbCsubg";
            this.cmbCsubg.Size = new System.Drawing.Size(154, 24);
            this.cmbCsubg.TabIndex = 9;
            // 
            // btnCCon
            // 
            this.btnCCon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCCon.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCon.ForeColor = System.Drawing.Color.White;
            this.btnCCon.Location = new System.Drawing.Point(124, 394);
            this.btnCCon.Name = "btnCCon";
            this.btnCCon.Size = new System.Drawing.Size(173, 44);
            this.btnCCon.TabIndex = 10;
            this.btnCCon.Text = "ADD CONSECUTIVE";
            this.btnCCon.UseVisualStyleBackColor = false;
            this.btnCCon.Click += new System.EventHandler(this.btnCCon_Click);
            // 
            // btnCclear
            // 
            this.btnCclear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCclear.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCclear.ForeColor = System.Drawing.Color.White;
            this.btnCclear.Location = new System.Drawing.Point(367, 394);
            this.btnCclear.Name = "btnCclear";
            this.btnCclear.Size = new System.Drawing.Size(173, 44);
            this.btnCclear.TabIndex = 11;
            this.btnCclear.Text = "CLEAR";
            this.btnCclear.UseVisualStyleBackColor = false;
            this.btnCclear.Click += new System.EventHandler(this.btnCclear_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(686, 23);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(75, 23);
            this.buttonP.TabIndex = 12;
            this.buttonP.Text = "button1";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // concutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.btnCclear);
            this.Controls.Add(this.btnCCon);
            this.Controls.Add(this.cmbCsubg);
            this.Controls.Add(this.cmbCsub);
            this.Controls.Add(this.cmbCtag);
            this.Controls.Add(this.numericCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "concutive";
            this.Text = "concutive";
            this.Load += new System.EventHandler(this.concutive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ITPMDataSet9 iTPMDataSet9;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private ITPMDataSet9TableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstLectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondLectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCon;
        private System.Windows.Forms.ComboBox cmbCtag;
        private System.Windows.Forms.ComboBox cmbCsub;
        private System.Windows.Forms.ComboBox cmbCsubg;
        private System.Windows.Forms.Button btnCCon;
        private System.Windows.Forms.Button btnCclear;
        private System.Windows.Forms.Button buttonP;
    }
}