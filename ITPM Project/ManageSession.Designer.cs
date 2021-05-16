
namespace ITPM_Project
{
    partial class ManageSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSession));
            this.panelHeadding = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelHeadingManageSession = new System.Windows.Forms.Label();
            this.panelManageSession = new System.Windows.Forms.Panel();
            this.comboBoxSelectDuration = new System.Windows.Forms.ComboBox();
            this.lblSelectDuration = new System.Windows.Forms.Label();
            this.comboBoxSelectSubGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectSubGroup = new System.Windows.Forms.Label();
            this.comboBoxSelectTag = new System.Windows.Forms.ComboBox();
            this.lblSelectTag = new System.Windows.Forms.Label();
            this.comboBoxSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.textBoxNoOfStudents = new System.Windows.Forms.TextBox();
            this.lblNoOfStudents = new System.Windows.Forms.Label();
            this.comboBoxLecturer2 = new System.Windows.Forms.ComboBox();
            this.lblLecture2 = new System.Windows.Forms.Label();
            this.comboBoxLecture1 = new System.Windows.Forms.ComboBox();
            this.lblLecture1 = new System.Windows.Forms.Label();
            this.textSessionID = new System.Windows.Forms.TextBox();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.panelHeadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelManageSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeadding
            // 
            this.panelHeadding.BackColor = System.Drawing.Color.Azure;
            this.panelHeadding.Controls.Add(this.pictureBoxClose);
            this.panelHeadding.Controls.Add(this.labelHeadingManageSession);
            this.panelHeadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadding.Location = new System.Drawing.Point(0, 0);
            this.panelHeadding.Name = "panelHeadding";
            this.panelHeadding.Size = new System.Drawing.Size(925, 80);
            this.panelHeadding.TabIndex = 3;
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
            // labelHeadingManageSession
            // 
            this.labelHeadingManageSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeadingManageSession.AutoSize = true;
            this.labelHeadingManageSession.Font = new System.Drawing.Font("Segoe UI Black", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadingManageSession.Location = new System.Drawing.Point(257, 4);
            this.labelHeadingManageSession.Name = "labelHeadingManageSession";
            this.labelHeadingManageSession.Size = new System.Drawing.Size(486, 76);
            this.labelHeadingManageSession.TabIndex = 1;
            this.labelHeadingManageSession.Text = "Manage Session";
            // 
            // panelManageSession
            // 
            this.panelManageSession.AutoScroll = true;
            this.panelManageSession.BackColor = System.Drawing.Color.Azure;
            this.panelManageSession.Controls.Add(this.comboBoxSelectDuration);
            this.panelManageSession.Controls.Add(this.lblSelectDuration);
            this.panelManageSession.Controls.Add(this.comboBoxSelectSubGroup);
            this.panelManageSession.Controls.Add(this.lblSelectSubGroup);
            this.panelManageSession.Controls.Add(this.comboBoxSelectTag);
            this.panelManageSession.Controls.Add(this.lblSelectTag);
            this.panelManageSession.Controls.Add(this.comboBoxSelectSubject);
            this.panelManageSession.Controls.Add(this.lblSelectSubject);
            this.panelManageSession.Controls.Add(this.comboBoxSelectGroup);
            this.panelManageSession.Controls.Add(this.lblSelectGroup);
            this.panelManageSession.Controls.Add(this.textBoxNoOfStudents);
            this.panelManageSession.Controls.Add(this.lblNoOfStudents);
            this.panelManageSession.Controls.Add(this.comboBoxLecturer2);
            this.panelManageSession.Controls.Add(this.lblLecture2);
            this.panelManageSession.Controls.Add(this.comboBoxLecture1);
            this.panelManageSession.Controls.Add(this.lblLecture1);
            this.panelManageSession.Controls.Add(this.textSessionID);
            this.panelManageSession.Controls.Add(this.dataGridViewSessions);
            this.panelManageSession.Controls.Add(this.textBoxSearch);
            this.panelManageSession.Controls.Add(this.lblSearch);
            this.panelManageSession.Controls.Add(this.bntClear);
            this.panelManageSession.Controls.Add(this.btnDelete);
            this.panelManageSession.Controls.Add(this.bntUpdate);
            this.panelManageSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageSession.Location = new System.Drawing.Point(0, 80);
            this.panelManageSession.Name = "panelManageSession";
            this.panelManageSession.Size = new System.Drawing.Size(925, 529);
            this.panelManageSession.TabIndex = 4;
            // 
            // comboBoxSelectDuration
            // 
            this.comboBoxSelectDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectDuration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectDuration.FormattingEnabled = true;
            this.comboBoxSelectDuration.Items.AddRange(new object[] {
            "1 Houre",
            "2 Hours",
            "3 Hours"});
            this.comboBoxSelectDuration.Location = new System.Drawing.Point(535, 121);
            this.comboBoxSelectDuration.Name = "comboBoxSelectDuration";
            this.comboBoxSelectDuration.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectDuration.TabIndex = 100;
            this.comboBoxSelectDuration.Tag = "";
            // 
            // lblSelectDuration
            // 
            this.lblSelectDuration.AutoSize = true;
            this.lblSelectDuration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDuration.Location = new System.Drawing.Point(392, 124);
            this.lblSelectDuration.Name = "lblSelectDuration";
            this.lblSelectDuration.Size = new System.Drawing.Size(121, 23);
            this.lblSelectDuration.TabIndex = 99;
            this.lblSelectDuration.Text = "Select Duration";
            // 
            // comboBoxSelectSubGroup
            // 
            this.comboBoxSelectSubGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSubGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectSubGroup.FormattingEnabled = true;
            this.comboBoxSelectSubGroup.Location = new System.Drawing.Point(535, 84);
            this.comboBoxSelectSubGroup.Name = "comboBoxSelectSubGroup";
            this.comboBoxSelectSubGroup.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectSubGroup.TabIndex = 98;
            this.comboBoxSelectSubGroup.Tag = "";
            // 
            // lblSelectSubGroup
            // 
            this.lblSelectSubGroup.AutoSize = true;
            this.lblSelectSubGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubGroup.Location = new System.Drawing.Point(392, 87);
            this.lblSelectSubGroup.Name = "lblSelectSubGroup";
            this.lblSelectSubGroup.Size = new System.Drawing.Size(132, 23);
            this.lblSelectSubGroup.TabIndex = 97;
            this.lblSelectSubGroup.Text = "Select Sub Group";
            // 
            // comboBoxSelectTag
            // 
            this.comboBoxSelectTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectTag.FormattingEnabled = true;
            this.comboBoxSelectTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.comboBoxSelectTag.Location = new System.Drawing.Point(535, 0);
            this.comboBoxSelectTag.Name = "comboBoxSelectTag";
            this.comboBoxSelectTag.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectTag.TabIndex = 96;
            this.comboBoxSelectTag.Tag = "";
            // 
            // lblSelectTag
            // 
            this.lblSelectTag.AutoSize = true;
            this.lblSelectTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTag.Location = new System.Drawing.Point(392, 3);
            this.lblSelectTag.Name = "lblSelectTag";
            this.lblSelectTag.Size = new System.Drawing.Size(83, 23);
            this.lblSelectTag.TabIndex = 95;
            this.lblSelectTag.Text = "Select Tag";
            // 
            // comboBoxSelectSubject
            // 
            this.comboBoxSelectSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectSubject.FormattingEnabled = true;
            this.comboBoxSelectSubject.Location = new System.Drawing.Point(173, 111);
            this.comboBoxSelectSubject.Name = "comboBoxSelectSubject";
            this.comboBoxSelectSubject.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectSubject.TabIndex = 94;
            this.comboBoxSelectSubject.Tag = "";
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(30, 114);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(107, 23);
            this.lblSelectSubject.TabIndex = 93;
            this.lblSelectSubject.Text = "Select Subject";
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(173, 74);
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectGroup.TabIndex = 92;
            this.comboBoxSelectGroup.Tag = "";
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(30, 77);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(101, 23);
            this.lblSelectGroup.TabIndex = 91;
            this.lblSelectGroup.Text = "Select Group";
            // 
            // textBoxNoOfStudents
            // 
            this.textBoxNoOfStudents.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNoOfStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNoOfStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOfStudents.Location = new System.Drawing.Point(173, 148);
            this.textBoxNoOfStudents.Name = "textBoxNoOfStudents";
            this.textBoxNoOfStudents.Size = new System.Drawing.Size(192, 30);
            this.textBoxNoOfStudents.TabIndex = 90;
            // 
            // lblNoOfStudents
            // 
            this.lblNoOfStudents.AutoSize = true;
            this.lblNoOfStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfStudents.Location = new System.Drawing.Point(30, 150);
            this.lblNoOfStudents.Name = "lblNoOfStudents";
            this.lblNoOfStudents.Size = new System.Drawing.Size(123, 23);
            this.lblNoOfStudents.TabIndex = 89;
            this.lblNoOfStudents.Text = "No Of Students";
            // 
            // comboBoxLecturer2
            // 
            this.comboBoxLecturer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLecturer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLecturer2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer2.FormattingEnabled = true;
            this.comboBoxLecturer2.Location = new System.Drawing.Point(173, 37);
            this.comboBoxLecturer2.Name = "comboBoxLecturer2";
            this.comboBoxLecturer2.Size = new System.Drawing.Size(192, 31);
            this.comboBoxLecturer2.TabIndex = 88;
            this.comboBoxLecturer2.Tag = "";
            // 
            // lblLecture2
            // 
            this.lblLecture2.AutoSize = true;
            this.lblLecture2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture2.Location = new System.Drawing.Point(30, 40);
            this.lblLecture2.Name = "lblLecture2";
            this.lblLecture2.Size = new System.Drawing.Size(128, 23);
            this.lblLecture2.TabIndex = 87;
            this.lblLecture2.Text = "Select Lecturer 2";
            // 
            // comboBoxLecture1
            // 
            this.comboBoxLecture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLecture1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLecture1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecture1.FormattingEnabled = true;
            this.comboBoxLecture1.Location = new System.Drawing.Point(173, 0);
            this.comboBoxLecture1.Name = "comboBoxLecture1";
            this.comboBoxLecture1.Size = new System.Drawing.Size(192, 31);
            this.comboBoxLecture1.TabIndex = 86;
            this.comboBoxLecture1.Tag = "";
            // 
            // lblLecture1
            // 
            this.lblLecture1.AutoSize = true;
            this.lblLecture1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture1.Location = new System.Drawing.Point(30, 3);
            this.lblLecture1.Name = "lblLecture1";
            this.lblLecture1.Size = new System.Drawing.Size(128, 23);
            this.lblLecture1.TabIndex = 85;
            this.lblLecture1.Text = "Select Lecturer 1";
            // 
            // textSessionID
            // 
            this.textSessionID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSessionID.Location = new System.Drawing.Point(662, 186);
            this.textSessionID.Name = "textSessionID";
            this.textSessionID.ReadOnly = true;
            this.textSessionID.Size = new System.Drawing.Size(237, 30);
            this.textSessionID.TabIndex = 84;
            this.textSessionID.Visible = false;
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSessions.Location = new System.Drawing.Point(34, 225);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.RowHeadersWidth = 51;
            this.dataGridViewSessions.RowTemplate.Height = 24;
            this.dataGridViewSessions.Size = new System.Drawing.Size(865, 245);
            this.dataGridViewSessions.TabIndex = 83;
            this.dataGridViewSessions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSessions_RowHeaderMouseClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(93, 187);
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
            // ManageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 609);
            this.Controls.Add(this.panelManageSession);
            this.Controls.Add(this.panelHeadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSession";
            this.Text = "ManageSession";
            this.Load += new System.EventHandler(this.ManageSession_Load);
            this.panelHeadding.ResumeLayout(false);
            this.panelHeadding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelManageSession.ResumeLayout(false);
            this.panelManageSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeadding;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelHeadingManageSession;
        private System.Windows.Forms.Panel panelManageSession;
        private System.Windows.Forms.TextBox textSessionID;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.ComboBox comboBoxSelectDuration;
        private System.Windows.Forms.Label lblSelectDuration;
        private System.Windows.Forms.ComboBox comboBoxSelectSubGroup;
        private System.Windows.Forms.Label lblSelectSubGroup;
        private System.Windows.Forms.ComboBox comboBoxSelectTag;
        private System.Windows.Forms.Label lblSelectTag;
        private System.Windows.Forms.ComboBox comboBoxSelectSubject;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.ComboBox comboBoxSelectGroup;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.TextBox textBoxNoOfStudents;
        private System.Windows.Forms.Label lblNoOfStudents;
        private System.Windows.Forms.ComboBox comboBoxLecturer2;
        private System.Windows.Forms.Label lblLecture2;
        private System.Windows.Forms.ComboBox comboBoxLecture1;
        private System.Windows.Forms.Label lblLecture1;
    }
}