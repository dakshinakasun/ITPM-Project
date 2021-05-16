
namespace ITPM_Project
{
    partial class AddSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSession));
            this.panelHeadding = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblAddSubject = new System.Windows.Forms.Label();
            this.panelAddSession = new System.Windows.Forms.Panel();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelHeadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelAddSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeadding
            // 
            this.panelHeadding.BackColor = System.Drawing.Color.Azure;
            this.panelHeadding.Controls.Add(this.pictureBoxClose);
            this.panelHeadding.Controls.Add(this.lblAddSubject);
            this.panelHeadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadding.Location = new System.Drawing.Point(0, 0);
            this.panelHeadding.Name = "panelHeadding";
            this.panelHeadding.Size = new System.Drawing.Size(907, 100);
            this.panelHeadding.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(887, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 80;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblAddSubject
            // 
            this.lblAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddSubject.AutoSize = true;
            this.lblAddSubject.Font = new System.Drawing.Font("Segoe UI Black", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSubject.Location = new System.Drawing.Point(322, 9);
            this.lblAddSubject.Name = "lblAddSubject";
            this.lblAddSubject.Size = new System.Drawing.Size(370, 76);
            this.lblAddSubject.TabIndex = 1;
            this.lblAddSubject.Text = "Add Session";
            // 
            // panelAddSession
            // 
            this.panelAddSession.BackColor = System.Drawing.Color.Azure;
            this.panelAddSession.Controls.Add(this.comboBoxSelectDuration);
            this.panelAddSession.Controls.Add(this.lblSelectDuration);
            this.panelAddSession.Controls.Add(this.comboBoxSelectSubGroup);
            this.panelAddSession.Controls.Add(this.lblSelectSubGroup);
            this.panelAddSession.Controls.Add(this.comboBoxSelectTag);
            this.panelAddSession.Controls.Add(this.lblSelectTag);
            this.panelAddSession.Controls.Add(this.comboBoxSelectSubject);
            this.panelAddSession.Controls.Add(this.lblSelectSubject);
            this.panelAddSession.Controls.Add(this.comboBoxSelectGroup);
            this.panelAddSession.Controls.Add(this.lblSelectGroup);
            this.panelAddSession.Controls.Add(this.textBoxNoOfStudents);
            this.panelAddSession.Controls.Add(this.lblNoOfStudents);
            this.panelAddSession.Controls.Add(this.comboBoxLecturer2);
            this.panelAddSession.Controls.Add(this.lblLecture2);
            this.panelAddSession.Controls.Add(this.comboBoxLecture1);
            this.panelAddSession.Controls.Add(this.lblLecture1);
            this.panelAddSession.Controls.Add(this.btnClear);
            this.panelAddSession.Controls.Add(this.btnAdd);
            this.panelAddSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSession.Location = new System.Drawing.Point(0, 100);
            this.panelAddSession.Name = "panelAddSession";
            this.panelAddSession.Size = new System.Drawing.Size(907, 458);
            this.panelAddSession.TabIndex = 4;
            // 
            // comboBoxSelectDuration
            // 
            this.comboBoxSelectDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectDuration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectDuration.FormattingEnabled = true;
            this.comboBoxSelectDuration.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours"});
            this.comboBoxSelectDuration.Location = new System.Drawing.Point(587, 171);
            this.comboBoxSelectDuration.Name = "comboBoxSelectDuration";
            this.comboBoxSelectDuration.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectDuration.TabIndex = 81;
            this.comboBoxSelectDuration.Tag = "";
            // 
            // lblSelectDuration
            // 
            this.lblSelectDuration.AutoSize = true;
            this.lblSelectDuration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDuration.Location = new System.Drawing.Point(444, 174);
            this.lblSelectDuration.Name = "lblSelectDuration";
            this.lblSelectDuration.Size = new System.Drawing.Size(121, 23);
            this.lblSelectDuration.TabIndex = 80;
            this.lblSelectDuration.Text = "Select Duration";
            // 
            // comboBoxSelectSubGroup
            // 
            this.comboBoxSelectSubGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSubGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectSubGroup.FormattingEnabled = true;
            this.comboBoxSelectSubGroup.Location = new System.Drawing.Point(587, 131);
            this.comboBoxSelectSubGroup.Name = "comboBoxSelectSubGroup";
            this.comboBoxSelectSubGroup.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectSubGroup.TabIndex = 79;
            this.comboBoxSelectSubGroup.Tag = "";
            // 
            // lblSelectSubGroup
            // 
            this.lblSelectSubGroup.AutoSize = true;
            this.lblSelectSubGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubGroup.Location = new System.Drawing.Point(444, 134);
            this.lblSelectSubGroup.Name = "lblSelectSubGroup";
            this.lblSelectSubGroup.Size = new System.Drawing.Size(132, 23);
            this.lblSelectSubGroup.TabIndex = 78;
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
            this.comboBoxSelectTag.Location = new System.Drawing.Point(587, 47);
            this.comboBoxSelectTag.Name = "comboBoxSelectTag";
            this.comboBoxSelectTag.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectTag.TabIndex = 77;
            this.comboBoxSelectTag.Tag = "";
            // 
            // lblSelectTag
            // 
            this.lblSelectTag.AutoSize = true;
            this.lblSelectTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTag.Location = new System.Drawing.Point(444, 50);
            this.lblSelectTag.Name = "lblSelectTag";
            this.lblSelectTag.Size = new System.Drawing.Size(83, 23);
            this.lblSelectTag.TabIndex = 76;
            this.lblSelectTag.Text = "Select Tag";
            // 
            // comboBoxSelectSubject
            // 
            this.comboBoxSelectSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectSubject.FormattingEnabled = true;
            this.comboBoxSelectSubject.Location = new System.Drawing.Point(188, 171);
            this.comboBoxSelectSubject.Name = "comboBoxSelectSubject";
            this.comboBoxSelectSubject.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectSubject.TabIndex = 75;
            this.comboBoxSelectSubject.Tag = "";
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(45, 174);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(107, 23);
            this.lblSelectSubject.TabIndex = 74;
            this.lblSelectSubject.Text = "Select Subject";
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(188, 131);
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(192, 31);
            this.comboBoxSelectGroup.TabIndex = 73;
            this.comboBoxSelectGroup.Tag = "";
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(45, 134);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(101, 23);
            this.lblSelectGroup.TabIndex = 72;
            this.lblSelectGroup.Text = "Select Group";
            // 
            // textBoxNoOfStudents
            // 
            this.textBoxNoOfStudents.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNoOfStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNoOfStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOfStudents.Location = new System.Drawing.Point(188, 217);
            this.textBoxNoOfStudents.Name = "textBoxNoOfStudents";
            this.textBoxNoOfStudents.Size = new System.Drawing.Size(192, 30);
            this.textBoxNoOfStudents.TabIndex = 71;
            // 
            // lblNoOfStudents
            // 
            this.lblNoOfStudents.AutoSize = true;
            this.lblNoOfStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfStudents.Location = new System.Drawing.Point(45, 219);
            this.lblNoOfStudents.Name = "lblNoOfStudents";
            this.lblNoOfStudents.Size = new System.Drawing.Size(123, 23);
            this.lblNoOfStudents.TabIndex = 70;
            this.lblNoOfStudents.Text = "No Of Students";
            // 
            // comboBoxLecturer2
            // 
            this.comboBoxLecturer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLecturer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLecturer2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer2.FormattingEnabled = true;
            this.comboBoxLecturer2.Location = new System.Drawing.Point(188, 89);
            this.comboBoxLecturer2.Name = "comboBoxLecturer2";
            this.comboBoxLecturer2.Size = new System.Drawing.Size(192, 31);
            this.comboBoxLecturer2.TabIndex = 69;
            this.comboBoxLecturer2.Tag = "";
            // 
            // lblLecture2
            // 
            this.lblLecture2.AutoSize = true;
            this.lblLecture2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture2.Location = new System.Drawing.Point(45, 92);
            this.lblLecture2.Name = "lblLecture2";
            this.lblLecture2.Size = new System.Drawing.Size(128, 23);
            this.lblLecture2.TabIndex = 68;
            this.lblLecture2.Text = "Select Lecturer 2";
            // 
            // comboBoxLecture1
            // 
            this.comboBoxLecture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLecture1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLecture1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecture1.FormattingEnabled = true;
            this.comboBoxLecture1.Location = new System.Drawing.Point(188, 47);
            this.comboBoxLecture1.Name = "comboBoxLecture1";
            this.comboBoxLecture1.Size = new System.Drawing.Size(192, 31);
            this.comboBoxLecture1.TabIndex = 65;
            this.comboBoxLecture1.Tag = "";
            // 
            // lblLecture1
            // 
            this.lblLecture1.AutoSize = true;
            this.lblLecture1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture1.Location = new System.Drawing.Point(45, 50);
            this.lblLecture1.Name = "lblLecture1";
            this.lblLecture1.Size = new System.Drawing.Size(128, 23);
            this.lblLecture1.TabIndex = 64;
            this.lblLecture1.Text = "Select Lecturer 1";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(640, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 50);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(495, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 50);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 558);
            this.Controls.Add(this.panelAddSession);
            this.Controls.Add(this.panelHeadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSession";
            this.Text = "AddSession";
            this.panelHeadding.ResumeLayout(false);
            this.panelHeadding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelAddSession.ResumeLayout(false);
            this.panelAddSession.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeadding;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblAddSubject;
        private System.Windows.Forms.Panel panelAddSession;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
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