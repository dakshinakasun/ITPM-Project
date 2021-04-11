
namespace ITPM_Project
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.panelHeadding = new System.Windows.Forms.Panel();
            this.lblAddSubject = new System.Windows.Forms.Label();
            this.panelAddSubject = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUpDownNoOfLabHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNoOfEvaluHours = new System.Windows.Forms.NumericUpDown();
            this.lblNoOfLabHours = new System.Windows.Forms.Label();
            this.lblNoOfEvaluHours = new System.Windows.Forms.Label();
            this.numericUpDownNoOfLectHour = new System.Windows.Forms.NumericUpDown();
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelHeadding.SuspendLayout();
            this.panelAddSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLabHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfEvaluHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLectHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfTuteHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
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
            this.panelHeadding.Size = new System.Drawing.Size(925, 100);
            this.panelHeadding.TabIndex = 2;
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
            this.lblAddSubject.Size = new System.Drawing.Size(368, 76);
            this.lblAddSubject.TabIndex = 1;
            this.lblAddSubject.Text = "Add Subject";
            // 
            // panelAddSubject
            // 
            this.panelAddSubject.BackColor = System.Drawing.Color.Azure;
            this.panelAddSubject.Controls.Add(this.btnClear);
            this.panelAddSubject.Controls.Add(this.btnAdd);
            this.panelAddSubject.Controls.Add(this.numericUpDownNoOfLabHour);
            this.panelAddSubject.Controls.Add(this.numericUpDownNoOfEvaluHours);
            this.panelAddSubject.Controls.Add(this.lblNoOfLabHours);
            this.panelAddSubject.Controls.Add(this.lblNoOfEvaluHours);
            this.panelAddSubject.Controls.Add(this.numericUpDownNoOfLectHour);
            this.panelAddSubject.Controls.Add(this.numericUpDownNoOfTuteHour);
            this.panelAddSubject.Controls.Add(this.textBoxSubjectName);
            this.panelAddSubject.Controls.Add(this.lblSubjectName);
            this.panelAddSubject.Controls.Add(this.comboBoxOfferedSemester);
            this.panelAddSubject.Controls.Add(this.lblOfferedSemester);
            this.panelAddSubject.Controls.Add(this.lblNoOfLectureHours);
            this.panelAddSubject.Controls.Add(this.lblNoOfTutorialHours);
            this.panelAddSubject.Controls.Add(this.textBoxSubjectCode);
            this.panelAddSubject.Controls.Add(this.lblSubjectCode);
            this.panelAddSubject.Controls.Add(this.comboBoxOfferdYear);
            this.panelAddSubject.Controls.Add(this.lblOfferedYear);
            this.panelAddSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSubject.Location = new System.Drawing.Point(0, 100);
            this.panelAddSubject.Name = "panelAddSubject";
            this.panelAddSubject.Size = new System.Drawing.Size(925, 505);
            this.panelAddSubject.TabIndex = 3;
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
            this.btnClear.Location = new System.Drawing.Point(679, 291);
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
            this.btnAdd.Location = new System.Drawing.Point(534, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 50);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericUpDownNoOfLabHour
            // 
            this.numericUpDownNoOfLabHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfLabHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfLabHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfLabHour.Location = new System.Drawing.Point(703, 151);
            this.numericUpDownNoOfLabHour.Name = "numericUpDownNoOfLabHour";
            this.numericUpDownNoOfLabHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfLabHour.TabIndex = 61;
            this.numericUpDownNoOfLabHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownNoOfEvaluHours
            // 
            this.numericUpDownNoOfEvaluHours.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfEvaluHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfEvaluHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfEvaluHours.Location = new System.Drawing.Point(703, 196);
            this.numericUpDownNoOfEvaluHours.Name = "numericUpDownNoOfEvaluHours";
            this.numericUpDownNoOfEvaluHours.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfEvaluHours.TabIndex = 60;
            this.numericUpDownNoOfEvaluHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoOfLabHours
            // 
            this.lblNoOfLabHours.AutoSize = true;
            this.lblNoOfLabHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfLabHours.Location = new System.Drawing.Point(500, 153);
            this.lblNoOfLabHours.Name = "lblNoOfLabHours";
            this.lblNoOfLabHours.Size = new System.Drawing.Size(134, 23);
            this.lblNoOfLabHours.TabIndex = 59;
            this.lblNoOfLabHours.Text = "No Of Lab Hours";
            // 
            // lblNoOfEvaluHours
            // 
            this.lblNoOfEvaluHours.AutoSize = true;
            this.lblNoOfEvaluHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfEvaluHours.Location = new System.Drawing.Point(500, 195);
            this.lblNoOfEvaluHours.Name = "lblNoOfEvaluHours";
            this.lblNoOfEvaluHours.Size = new System.Drawing.Size(184, 23);
            this.lblNoOfEvaluHours.TabIndex = 58;
            this.lblNoOfEvaluHours.Text = "No Of Evaluation Hours";
            // 
            // numericUpDownNoOfLectHour
            // 
            this.numericUpDownNoOfLectHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfLectHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfLectHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfLectHour.InterceptArrowKeys = false;
            this.numericUpDownNoOfLectHour.Location = new System.Drawing.Point(703, 65);
            this.numericUpDownNoOfLectHour.Name = "numericUpDownNoOfLectHour";
            this.numericUpDownNoOfLectHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfLectHour.TabIndex = 57;
            this.numericUpDownNoOfLectHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownNoOfTuteHour
            // 
            this.numericUpDownNoOfTuteHour.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDownNoOfTuteHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownNoOfTuteHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfTuteHour.Location = new System.Drawing.Point(703, 107);
            this.numericUpDownNoOfTuteHour.Name = "numericUpDownNoOfTuteHour";
            this.numericUpDownNoOfTuteHour.Size = new System.Drawing.Size(115, 30);
            this.numericUpDownNoOfTuteHour.TabIndex = 56;
            this.numericUpDownNoOfTuteHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubjectName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(217, 151);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(192, 30);
            this.textBoxSubjectName.TabIndex = 55;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(74, 153);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(111, 23);
            this.lblSubjectName.TabIndex = 54;
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
            this.comboBoxOfferedSemester.Location = new System.Drawing.Point(217, 107);
            this.comboBoxOfferedSemester.Name = "comboBoxOfferedSemester";
            this.comboBoxOfferedSemester.Size = new System.Drawing.Size(192, 31);
            this.comboBoxOfferedSemester.TabIndex = 53;
            this.comboBoxOfferedSemester.Tag = "";
            // 
            // lblOfferedSemester
            // 
            this.lblOfferedSemester.AutoSize = true;
            this.lblOfferedSemester.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedSemester.Location = new System.Drawing.Point(74, 110);
            this.lblOfferedSemester.Name = "lblOfferedSemester";
            this.lblOfferedSemester.Size = new System.Drawing.Size(135, 23);
            this.lblOfferedSemester.TabIndex = 52;
            this.lblOfferedSemester.Text = "Offered Semester";
            // 
            // lblNoOfLectureHours
            // 
            this.lblNoOfLectureHours.AutoSize = true;
            this.lblNoOfLectureHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfLectureHours.Location = new System.Drawing.Point(500, 68);
            this.lblNoOfLectureHours.Name = "lblNoOfLectureHours";
            this.lblNoOfLectureHours.Size = new System.Drawing.Size(160, 23);
            this.lblNoOfLectureHours.TabIndex = 50;
            this.lblNoOfLectureHours.Text = "No Of Lecture Hours";
            // 
            // lblNoOfTutorialHours
            // 
            this.lblNoOfTutorialHours.AutoSize = true;
            this.lblNoOfTutorialHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfTutorialHours.Location = new System.Drawing.Point(500, 110);
            this.lblNoOfTutorialHours.Name = "lblNoOfTutorialHours";
            this.lblNoOfTutorialHours.Size = new System.Drawing.Size(164, 23);
            this.lblNoOfTutorialHours.TabIndex = 48;
            this.lblNoOfTutorialHours.Text = "No Of Tutorial Hours";
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(217, 195);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(192, 30);
            this.textBoxSubjectCode.TabIndex = 47;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectCode.Location = new System.Drawing.Point(74, 197);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(103, 23);
            this.lblSubjectCode.TabIndex = 46;
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
            this.comboBoxOfferdYear.Location = new System.Drawing.Point(217, 65);
            this.comboBoxOfferdYear.Name = "comboBoxOfferdYear";
            this.comboBoxOfferdYear.Size = new System.Drawing.Size(192, 31);
            this.comboBoxOfferdYear.TabIndex = 45;
            this.comboBoxOfferdYear.Tag = "";
            // 
            // lblOfferedYear
            // 
            this.lblOfferedYear.AutoSize = true;
            this.lblOfferedYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedYear.Location = new System.Drawing.Point(74, 68);
            this.lblOfferedYear.Name = "lblOfferedYear";
            this.lblOfferedYear.Size = new System.Drawing.Size(101, 23);
            this.lblOfferedYear.TabIndex = 44;
            this.lblOfferedYear.Text = "Offered Year";
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
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(925, 605);
            this.Controls.Add(this.panelAddSubject);
            this.Controls.Add(this.panelHeadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(925, 605);
            this.MinimumSize = new System.Drawing.Size(925, 605);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.panelHeadding.ResumeLayout(false);
            this.panelHeadding.PerformLayout();
            this.panelAddSubject.ResumeLayout(false);
            this.panelAddSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLabHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfEvaluHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfLectHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfTuteHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeadding;
        private System.Windows.Forms.Label lblAddSubject;
        private System.Windows.Forms.Panel panelAddSubject;
        private System.Windows.Forms.Label lblNoOfLectureHours;
        private System.Windows.Forms.Label lblNoOfTutorialHours;
        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.ComboBox comboBoxOfferdYear;
        private System.Windows.Forms.Label lblOfferedYear;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.ComboBox comboBoxOfferedSemester;
        private System.Windows.Forms.Label lblOfferedSemester;
        private System.Windows.Forms.Label lblNoOfLabHours;
        private System.Windows.Forms.Label lblNoOfEvaluHours;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfLabHour;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfEvaluHours;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfLectHour;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfTuteHour;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}