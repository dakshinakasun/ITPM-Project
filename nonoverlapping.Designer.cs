
namespace StudentAndTagProject
{
    partial class nonoverlapping
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
            this.sessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet12 = new StudentAndTagProject.ITPMDataSet12();
            this.iTPMDataSet11 = new StudentAndTagProject.ITPMDataSet11();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new StudentAndTagProject.ITPMDataSet11TableAdapters.SessionTableAdapter();
            this.sessionTableAdapter1 = new StudentAndTagProject.ITPMDataSet12TableAdapters.SessionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNon = new System.Windows.Forms.NumericUpDown();
            this.cmbNotag = new System.Windows.Forms.ComboBox();
            this.cmbSubN = new System.Windows.Forms.ComboBox();
            this.cmbNgroup = new System.Windows.Forms.ComboBox();
            this.btnNsave = new System.Windows.Forms.Button();
            this.btnNclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NON-OVERLAPPING SESSION";
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
            this.dataGridView1.DataSource = this.sessionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(126, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 150);
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
            // sessionBindingSource1
            // 
            this.sessionBindingSource1.DataMember = "Session";
            this.sessionBindingSource1.DataSource = this.iTPMDataSet12;
            // 
            // iTPMDataSet12
            // 
            this.iTPMDataSet12.DataSetName = "ITPMDataSet12";
            this.iTPMDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTPMDataSet11
            // 
            this.iTPMDataSet11.DataSetName = "ITPMDataSet11";
            this.iTPMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.iTPMDataSet11;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // sessionTableAdapter1
            // 
            this.sessionTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SessionID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(442, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(122, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(442, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "GroupID";
            // 
            // numericNon
            // 
            this.numericNon.Location = new System.Drawing.Point(230, 293);
            this.numericNon.Name = "numericNon";
            this.numericNon.Size = new System.Drawing.Size(164, 22);
            this.numericNon.TabIndex = 6;
            // 
            // cmbNotag
            // 
            this.cmbNotag.FormattingEnabled = true;
            this.cmbNotag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.cmbNotag.Location = new System.Drawing.Point(230, 365);
            this.cmbNotag.Name = "cmbNotag";
            this.cmbNotag.Size = new System.Drawing.Size(164, 24);
            this.cmbNotag.TabIndex = 7;
            // 
            // cmbSubN
            // 
            this.cmbSubN.FormattingEnabled = true;
            this.cmbSubN.Items.AddRange(new object[] {
            "ITPM",
            "Mobile Application Devalopment",
            "Object Oriented ProgramminG",
            "Introduction To Programming"});
            this.cmbSubN.Location = new System.Drawing.Point(530, 295);
            this.cmbSubN.Name = "cmbSubN";
            this.cmbSubN.Size = new System.Drawing.Size(164, 24);
            this.cmbSubN.TabIndex = 8;
            // 
            // cmbNgroup
            // 
            this.cmbNgroup.FormattingEnabled = true;
            this.cmbNgroup.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.cmbNgroup.Location = new System.Drawing.Point(530, 359);
            this.cmbNgroup.Name = "cmbNgroup";
            this.cmbNgroup.Size = new System.Drawing.Size(164, 24);
            this.cmbNgroup.TabIndex = 9;
            // 
            // btnNsave
            // 
            this.btnNsave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNsave.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNsave.ForeColor = System.Drawing.Color.White;
            this.btnNsave.Location = new System.Drawing.Point(154, 412);
            this.btnNsave.Name = "btnNsave";
            this.btnNsave.Size = new System.Drawing.Size(255, 38);
            this.btnNsave.TabIndex = 10;
            this.btnNsave.Text = "ADD NON-OVERLAPPING";
            this.btnNsave.UseVisualStyleBackColor = false;
            this.btnNsave.Click += new System.EventHandler(this.btnNsave_Click);
            // 
            // btnNclear
            // 
            this.btnNclear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNclear.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNclear.ForeColor = System.Drawing.Color.White;
            this.btnNclear.Location = new System.Drawing.Point(480, 412);
            this.btnNclear.Name = "btnNclear";
            this.btnNclear.Size = new System.Drawing.Size(227, 38);
            this.btnNclear.TabIndex = 11;
            this.btnNclear.Text = "CLEAR";
            this.btnNclear.UseVisualStyleBackColor = false;
            this.btnNclear.Click += new System.EventHandler(this.btnNclear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonoverlapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1040, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNclear);
            this.Controls.Add(this.btnNsave);
            this.Controls.Add(this.cmbNgroup);
            this.Controls.Add(this.cmbSubN);
            this.Controls.Add(this.cmbNotag);
            this.Controls.Add(this.numericNon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "nonoverlapping";
            this.Load += new System.EventHandler(this.nonoverlapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ITPMDataSet11 iTPMDataSet11;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private ITPMDataSet11TableAdapters.SessionTableAdapter sessionTableAdapter;
        private ITPMDataSet12 iTPMDataSet12;
        private System.Windows.Forms.BindingSource sessionBindingSource1;
        private ITPMDataSet12TableAdapters.SessionTableAdapter sessionTableAdapter1;
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
        private System.Windows.Forms.NumericUpDown numericNon;
        private System.Windows.Forms.ComboBox cmbNotag;
        private System.Windows.Forms.ComboBox cmbSubN;
        private System.Windows.Forms.ComboBox cmbNgroup;
        private System.Windows.Forms.Button btnNsave;
        private System.Windows.Forms.Button btnNclear;
        private System.Windows.Forms.Button button1;
    }
}