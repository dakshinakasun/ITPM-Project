
namespace StudentAndTagProject
{
    partial class addparallel
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.iTPMDataSet10 = new StudentAndTagProject.ITPMDataSet10();
            this.sessionTableAdapter = new StudentAndTagProject.ITPMDataSet10TableAdapters.SessionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericP = new System.Windows.Forms.NumericUpDown();
            this.cmbPtag = new System.Windows.Forms.ComboBox();
            this.cmdPsub = new System.Windows.Forms.ComboBox();
            this.cmdPgroup = new System.Windows.Forms.ComboBox();
            this.btnPsave = new System.Windows.Forms.Button();
            this.btnPclear = new System.Windows.Forms.Button();
            this.btnn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PARALLEL SESSION";
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
            this.dataGridView1.Location = new System.Drawing.Point(83, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 150);
            this.dataGridView1.TabIndex = 1;
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
            this.sessionBindingSource.DataSource = this.iTPMDataSet10;
            // 
            // iTPMDataSet10
            // 
            this.iTPMDataSet10.DataSetName = "ITPMDataSet10";
            this.iTPMDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SessionID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "GroupID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tag";
            // 
            // numericP
            // 
            this.numericP.Location = new System.Drawing.Point(176, 283);
            this.numericP.Name = "numericP";
            this.numericP.Size = new System.Drawing.Size(180, 22);
            this.numericP.TabIndex = 6;
            // 
            // cmbPtag
            // 
            this.cmbPtag.FormattingEnabled = true;
            this.cmbPtag.Items.AddRange(new object[] {
            "Lecture",
            "Practical",
            "Tutorial"});
            this.cmbPtag.Location = new System.Drawing.Point(176, 341);
            this.cmbPtag.Name = "cmbPtag";
            this.cmbPtag.Size = new System.Drawing.Size(180, 24);
            this.cmbPtag.TabIndex = 7;
            // 
            // cmdPsub
            // 
            this.cmdPsub.FormattingEnabled = true;
            this.cmdPsub.Items.AddRange(new object[] {
            "ITPM",
            "Mobile Application Development",
            "Object Oriented Programming",
            "Introduction to Programming"});
            this.cmdPsub.Location = new System.Drawing.Point(479, 285);
            this.cmdPsub.Name = "cmdPsub";
            this.cmdPsub.Size = new System.Drawing.Size(180, 24);
            this.cmdPsub.TabIndex = 8;
            // 
            // cmdPgroup
            // 
            this.cmdPgroup.FormattingEnabled = true;
            this.cmdPgroup.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.cmdPgroup.Location = new System.Drawing.Point(479, 343);
            this.cmdPgroup.Name = "cmdPgroup";
            this.cmdPgroup.Size = new System.Drawing.Size(180, 24);
            this.cmdPgroup.TabIndex = 9;
            // 
            // btnPsave
            // 
            this.btnPsave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPsave.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPsave.Location = new System.Drawing.Point(202, 386);
            this.btnPsave.Name = "btnPsave";
            this.btnPsave.Size = new System.Drawing.Size(167, 41);
            this.btnPsave.TabIndex = 10;
            this.btnPsave.Text = "ADD PARALLEL";
            this.btnPsave.UseVisualStyleBackColor = false;
            this.btnPsave.Click += new System.EventHandler(this.btnPsave_Click);
            // 
            // btnPclear
            // 
            this.btnPclear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPclear.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPclear.ForeColor = System.Drawing.Color.White;
            this.btnPclear.Location = new System.Drawing.Point(433, 386);
            this.btnPclear.Name = "btnPclear";
            this.btnPclear.Size = new System.Drawing.Size(142, 41);
            this.btnPclear.TabIndex = 11;
            this.btnPclear.Text = "CLEAR";
            this.btnPclear.UseVisualStyleBackColor = false;
            this.btnPclear.Click += new System.EventHandler(this.btnPclear_Click);
            // 
            // btnn
            // 
            this.btnn.Location = new System.Drawing.Point(697, 43);
            this.btnn.Name = "btnn";
            this.btnn.Size = new System.Drawing.Size(75, 23);
            this.btnn.TabIndex = 12;
            this.btnn.Text = "button1";
            this.btnn.UseVisualStyleBackColor = true;
            this.btnn.Click += new System.EventHandler(this.btnn_Click);
            // 
            // addparallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.btnn);
            this.Controls.Add(this.btnPclear);
            this.Controls.Add(this.btnPsave);
            this.Controls.Add(this.cmdPgroup);
            this.Controls.Add(this.cmdPsub);
            this.Controls.Add(this.cmbPtag);
            this.Controls.Add(this.numericP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "addparallel";
            this.Text = "addparallel";
            this.Load += new System.EventHandler(this.addparallel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ITPMDataSet10 iTPMDataSet10;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private ITPMDataSet10TableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstLectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondLectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericP;
        private System.Windows.Forms.ComboBox cmbPtag;
        private System.Windows.Forms.ComboBox cmdPsub;
        private System.Windows.Forms.ComboBox cmdPgroup;
        private System.Windows.Forms.Button btnPsave;
        private System.Windows.Forms.Button btnPclear;
        private System.Windows.Forms.Button btnn;
    }
}