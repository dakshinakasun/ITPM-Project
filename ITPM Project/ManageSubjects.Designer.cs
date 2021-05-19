
namespace ITPM_Project
{
    partial class ManageSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubjects));
            this.panelHeadding = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelHeadingManageLecturers = new System.Windows.Forms.Label();
            this.panelManageSubject = new System.Windows.Forms.Panel();
            this.textSubjectID = new System.Windows.Forms.TextBox();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.numericUpDownNoOfLabHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNoOfEvaluHours = new System.Windows.Forms.NumericUpDown();
            this.lblNoOfLabHours = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpNoOfLecHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNoOfTuteHour = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.comboBoxOfferedSemester = new System.Windows.Forms.ComboBox();
            this.lblOfferedSemester = new System.Windows.Forms.Label();
            this.lblNoOfLectureHours = new System.Windows.Forms.Label();
            this.lblNoOfTutorialHours = new System.Windows.Forms.Label();
            this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.comboBoxOfferdYear = new System.Windows.Forms.ComboBox();
            this.lblOfferedYear = new System.Windows.Forms.Label();
            this.panelHeadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelManageSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLabHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfEvaluHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpNoOfLecHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfTuteHour)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeadding
            // 
            this.panelHeadding.BackColor = System.Drawing.Color.Azure;
            this.panelHeadding.Controls.Add(this.pictureBoxClose);
            this.panelHeadding.Controls.Add(this.labelHeadingManageLecturers);
            this.panelHeadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadding.Location = new System.Drawing.Point(0, 0);
            this.panelHeadding.Name = "panelHeadding";
            this.panelHeadding.Size = new System.Drawing.Size(925, 80);
            this.panelHeadding.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(888, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 80;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labelHeadingManageLecturers
            // 
            this.labelHeadingManageLecturers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeadingManageLecturers.AutoSize = true;
            this.labelHeadingManageLecturers.Font = new System.Drawing.Font("Segoe UI Black", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadingManageLecturers.Location = new System.Drawing.Point(257, 4);
            this.labelHeadingManageLecturers.Name = "labelHeadingManageLecturers";
            this.labelHeadingManageLecturers.Size = new System.Drawing.Size(511, 76);
            this.labelHeadingManageLecturers.TabIndex = 1;
            this.labelHeadingManageLecturers.Text = "Manage Subjects";
            // 
            // panelManageSubject
            // 
            this.panelManageSubject.AutoScroll = true;
            this.panelManageSubject.BackColor = System.Drawing.Color.Azure;
            this.panelManageSubject.Controls.Add(this.textSubjectID);
            this.panelManageSubject.Controls.Add(this.dataGridViewSubjects);
            this.panelManageSubject.Controls.Add(this.textBoxSearch);
            this.panelManageSubject.Controls.Add(this.lblSearch);
            this.panelManageSubject.Controls.Add(this.bntClear);
            this.panelManageSubject.Controls.Add(this.btnDelete);
            this.panelManageSubject.Controls.Add(this.bntUpdate);
            this.panelManageSubject.Controls.Add(this.numericUpDownNoOfLabHour);
            this.panelManageSubject.Controls.Add(this.numericUpDownNoOfEvaluHours);
            this.panelManageSubject.Controls.Add(this.lblNoOfLabHours);
            this.panelManageSubject.Controls.Add(this.label4);
            this.panelManageSubject.Controls.Add(this.numericUpNoOfLecHour);
            this.panelManageSubject.Controls.Add(this.numericUpDownNoOfTuteHour);
            this.panelManageSubject.Controls.Add(this.textBoxSubjectName);
            this.panelManageSubject.Controls.Add(this.lblSubjectName);
            this.panelManageSubject.Controls.Add(this.comboBoxOfferedSemester);
            this.panelManageSubject.Controls.Add(this.lblOfferedSemester);
            this.panelManageSubject.Controls.Add(this.lblNoOfLectureHours);
            this.panelManageSubject.Controls.Add(this.lblNoOfTutorialHours);
            this.panelManageSubject.Controls.Add(this.textBoxSubjectCode);
            this.panelManageSubject.Controls.Add(this.lblSubjectCode);
            this.panelManageSubject.Controls.Add(this.comboBoxOfferdYear);
            this.panelManageSubject.Controls.Add(this.lblOfferedYear);
            this.panelManageSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageSubject.Location = new System.Drawing.Point(0, 80);
            this.panelManageSubject.Name = "panelManageSubject";
            this.panelManageSubject.Size = new System.Drawing.Size(925, 525);
            this.panelManageSubject.TabIndex = 3;
            // 
            // textSubjectID
            // 
            this.textSubjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSubjectID.Location = new System.Drawing.Point(662, 186);
            this.textSubjectID.Name = "textSubjectID";
            this.textSubjectID.ReadOnly = true;
            this.textSubjectID.Size = new System.Drawing.Size(237, 30);
            this.textSubjectID.TabIndex = 84;
            this.textSubjectID.Visible = false;
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(34, 225);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersWidth = 51;
            this.dataGridViewSubjects.RowTemplate.Height = 24;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(865, 245);
            this.dataGridViewSubjects.TabIndex = 83;
            this.dataGridViewSubjects.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubjects_RowHeaderMouseClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(93, 186);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(550, 30);
            this.textBoxSearch.TabIndex = 82;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(30, 189);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 23);
            this.lblSearch.TabIndex = 81;
            this.lblSearch.Text = "Search";
            // 
            // bntClear
            // 
            this.bntClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClear.FlatAppearance.BorderSize = 0;
            this.bntClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClear.ForeColor = System.Drawing.Color.White;
            this.bntClear.Location = new System.Drawing.Point(760, 107);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(139, 45);
            this.bntClear.TabIndex = 80;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(760, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 45);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntUpdate.FlatAppearance.BorderSize = 0;
            this.bntUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpdate.ForeColor = System.Drawing.Color.White;
            this.bntUpdate.Location = new System.Drawing.Point(760, 0);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(139, 50);
            this.bntUpdate.TabIndex = 78;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = false;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // numericUpDownNoOfLabHour
            // 
            this.numericUpDownNoOfLabHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfLabHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfLabHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfLabHour.Location = new System.Drawing.Point(614, 86);
            this.numericUpDownNoOfLabHour.Name = "numericUpDownNoOfLabHour";
            this.numericUpDownNoOfLabHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfLabHour.TabIndex = 77;
            this.numericUpDownNoOfLabHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownNoOfEvaluHours
            // 
            this.numericUpDownNoOfEvaluHours.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfEvaluHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfEvaluHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfEvaluHours.Location = new System.Drawing.Point(614, 131);
            this.numericUpDownNoOfEvaluHours.Name = "numericUpDownNoOfEvaluHours";
            this.numericUpDownNoOfEvaluHours.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfEvaluHours.TabIndex = 76;
            this.numericUpDownNoOfEvaluHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoOfLabHours
            // 
            this.lblNoOfLabHours.AutoSize = true;
            this.lblNoOfLabHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfLabHours.Location = new System.Drawing.Point(411, 88);
            this.lblNoOfLabHours.Name = "lblNoOfLabHours";
            this.lblNoOfLabHours.Size = new System.Drawing.Size(134, 23);
            this.lblNoOfLabHours.TabIndex = 75;
            this.lblNoOfLabHours.Text = "No Of Lab Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "No Of Evaluation Hours";
            // 
            // numericUpNoOfLecHour
            // 
            this.numericUpNoOfLecHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpNoOfLecHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpNoOfLecHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpNoOfLecHour.Location = new System.Drawing.Point(614, 0);
            this.numericUpNoOfLecHour.Name = "numericUpNoOfLecHour";
            this.numericUpNoOfLecHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpNoOfLecHour.TabIndex = 73;
            this.numericUpNoOfLecHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownNoOfTuteHour
            // 
            this.numericUpDownNoOfTuteHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfTuteHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfTuteHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfTuteHour.Location = new System.Drawing.Point(614, 42);
            this.numericUpDownNoOfTuteHour.Name = "numericUpDownNoOfTuteHour";
            this.numericUpDownNoOfTuteHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfTuteHour.TabIndex = 72;
            this.numericUpDownNoOfTuteHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubjectName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(173, 86);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(192, 30);
            this.textBoxSubjectName.TabIndex = 71;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(30, 88);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(111, 23);
            this.lblSubjectName.TabIndex = 70;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // comboBoxOfferedSemester
            // 
            this.comboBoxOfferedSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxOfferedSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferedSemester.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOfferedSemester.FormattingEnabled = true;
            this.comboBoxOfferedSemester.Items.AddRange(new object[] {
            "1 st Semester",
            "2 nd Semester"});
            this.comboBoxOfferedSemester.Location = new System.Drawing.Point(173, 42);
            this.comboBoxOfferedSemester.Name = "comboBoxOfferedSemester";
            this.comboBoxOfferedSemester.Size = new System.Drawing.Size(192, 31);
            this.comboBoxOfferedSemester.TabIndex = 69;
            this.comboBoxOfferedSemester.Tag = "";
            // 
            // lblOfferedSemester
            // 
            this.lblOfferedSemester.AutoSize = true;
            this.lblOfferedSemester.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedSemester.Location = new System.Drawing.Point(30, 45);
            this.lblOfferedSemester.Name = "lblOfferedSemester";
            this.lblOfferedSemester.Size = new System.Drawing.Size(135, 23);
            this.lblOfferedSemester.TabIndex = 68;
            this.lblOfferedSemester.Text = "Offered Semester";
            // 
            // lblNoOfLectureHours
            // 
            this.lblNoOfLectureHours.AutoSize = true;
            this.lblNoOfLectureHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfLectureHours.Location = new System.Drawing.Point(411, 3);
            this.lblNoOfLectureHours.Name = "lblNoOfLectureHours";
            this.lblNoOfLectureHours.Size = new System.Drawing.Size(160, 23);
            this.lblNoOfLectureHours.TabIndex = 67;
            this.lblNoOfLectureHours.Text = "No Of Lecture Hours";
            // 
            // lblNoOfTutorialHours
            // 
            this.lblNoOfTutorialHours.AutoSize = true;
            this.lblNoOfTutorialHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfTutorialHours.Location = new System.Drawing.Point(411, 45);
            this.lblNoOfTutorialHours.Name = "lblNoOfTutorialHours";
            this.lblNoOfTutorialHours.Size = new System.Drawing.Size(164, 23);
            this.lblNoOfTutorialHours.TabIndex = 66;
            this.lblNoOfTutorialHours.Text = "No Of Tutorial Hours";
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(173, 130);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(192, 30);
            this.textBoxSubjectCode.TabIndex = 65;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectCode.Location = new System.Drawing.Point(30, 132);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(103, 23);
            this.lblSubjectCode.TabIndex = 64;
            this.lblSubjectCode.Text = "Subject Code";
            // 
            // comboBoxOfferdYear
            // 
            this.comboBoxOfferdYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxOfferdYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferdYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOfferdYear.FormattingEnabled = true;
            this.comboBoxOfferdYear.Items.AddRange(new object[] {
            "1 st Year",
            "2 nd Year",
            "3 rd Year",
            "4 th Year"});
            this.comboBoxOfferdYear.Location = new System.Drawing.Point(173, 0);
            this.comboBoxOfferdYear.Name = "comboBoxOfferdYear";
            this.comboBoxOfferdYear.Size = new System.Drawing.Size(192, 31);
            this.comboBoxOfferdYear.TabIndex = 63;
            this.comboBoxOfferdYear.Tag = "";
            // 
            // lblOfferedYear
            // 
            this.lblOfferedYear.AutoSize = true;
            this.lblOfferedYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedYear.Location = new System.Drawing.Point(30, 3);
            this.lblOfferedYear.Name = "lblOfferedYear";
            this.lblOfferedYear.Size = new System.Drawing.Size(101, 23);
            this.lblOfferedYear.TabIndex = 62;
            this.lblOfferedYear.Text = "Offered Year";
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 605);
            this.Controls.Add(this.panelManageSubject);
            this.Controls.Add(this.panelHeadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(925, 605);
            this.MinimumSize = new System.Drawing.Size(925, 605);
            this.Name = "ManageSubjects";
            this.Text = "ManageSubjects";
            this.Load += new System.EventHandler(this.ManageSubjects_Load);
            this.panelHeadding.ResumeLayout(false);
            this.panelHeadding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelManageSubject.ResumeLayout(false);
            this.panelManageSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLabHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfEvaluHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpNoOfLecHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfTuteHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeadding;
        private System.Windows.Forms.Label labelHeadingManageLecturers;
        private System.Windows.Forms.Panel panelManageSubject;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfLabHour;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfEvaluHours;
        private System.Windows.Forms.Label lblNoOfLabHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpNoOfLecHour;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfTuteHour;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.ComboBox comboBoxOfferedSemester;
        private System.Windows.Forms.Label lblOfferedSemester;
        private System.Windows.Forms.Label lblNoOfLectureHours;
        private System.Windows.Forms.Label lblNoOfTutorialHours;
        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.ComboBox comboBoxOfferdYear;
        private System.Windows.Forms.Label lblOfferedYear;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.TextBox textSubjectID;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}