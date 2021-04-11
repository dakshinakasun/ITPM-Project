
namespace ITPM_Project
{
    partial class ManageLecturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLecturers));
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.lblCenter = new System.Windows.Forms.Label();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.textBoxLectureID = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeadingManageLecturers = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(57, 123);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 23);
            this.labelTitle.TabIndex = 51;
            this.labelTitle.Text = "Title";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Prof",
            "Dr"});
            this.comboBoxTitle.Location = new System.Drawing.Point(162, 120);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(192, 31);
            this.comboBoxTitle.TabIndex = 52;
            this.comboBoxTitle.Tag = "";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(58, 237);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(58, 23);
            this.lblFaculty.TabIndex = 53;
            this.lblFaculty.Text = "Factlty";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities and Science"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(163, 234);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(191, 31);
            this.comboBoxFaculty.TabIndex = 54;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(417, 123);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(99, 23);
            this.lblDepartment.TabIndex = 55;
            this.lblDepartment.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(522, 120);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(191, 31);
            this.comboBoxDepartment.TabIndex = 56;
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.Location = new System.Drawing.Point(417, 161);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(59, 23);
            this.lblCenter.TabIndex = 57;
            this.lblCenter.Text = "Center";
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCenter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCenter.FormattingEnabled = true;
            this.comboBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.comboBoxCenter.Location = new System.Drawing.Point(522, 158);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(191, 31);
            this.comboBoxCenter.TabIndex = 58;
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(417, 198);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(69, 23);
            this.lblBuilding.TabIndex = 59;
            this.lblBuilding.Text = "Building";
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuilding.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Engineering Building",
            "Business Building",
            "D-Block"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(522, 195);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(191, 31);
            this.comboBoxBuilding.TabIndex = 60;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(417, 237);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 23);
            this.lblLevel.TabIndex = 61;
            this.lblLevel.Text = "Level";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.comboBoxLevel.Location = new System.Drawing.Point(522, 234);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(191, 31);
            this.comboBoxLevel.TabIndex = 62;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(57, 161);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 23);
            this.lblFirstName.TabIndex = 63;
            this.lblFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(162, 158);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(192, 30);
            this.textBoxFirstName.TabIndex = 64;
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerID.Location = new System.Drawing.Point(58, 86);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(90, 23);
            this.lblLecturerID.TabIndex = 65;
            this.lblLecturerID.Text = "Lecturer ID";
            // 
            // textBoxLectureID
            // 
            this.textBoxLectureID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLectureID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLectureID.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxLectureID.Enabled = false;
            this.textBoxLectureID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLectureID.Location = new System.Drawing.Point(163, 83);
            this.textBoxLectureID.Name = "textBoxLectureID";
            this.textBoxLectureID.ReadOnly = true;
            this.textBoxLectureID.Size = new System.Drawing.Size(191, 30);
            this.textBoxLectureID.TabIndex = 66;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(416, 86);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 23);
            this.lblRank.TabIndex = 67;
            this.lblRank.Text = "Rank";
            // 
            // textBoxRank
            // 
            this.textBoxRank.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRank.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxRank.Enabled = false;
            this.textBoxRank.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRank.Location = new System.Drawing.Point(521, 83);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.ReadOnly = true;
            this.textBoxRank.Size = new System.Drawing.Size(191, 30);
            this.textBoxRank.TabIndex = 68;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(58, 198);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 23);
            this.lblLastName.TabIndex = 69;
            this.lblLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(163, 195);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(191, 30);
            this.textBoxLastName.TabIndex = 70;
            // 
            // bntUpdate
            // 
            this.bntUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntUpdate.FlatAppearance.BorderSize = 0;
            this.bntUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpdate.ForeColor = System.Drawing.Color.White;
            this.bntUpdate.Location = new System.Drawing.Point(740, 97);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(139, 50);
            this.bntUpdate.TabIndex = 71;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = false;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click_1);
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
            this.btnDelete.Location = new System.Drawing.Point(740, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 45);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.bntClear.Location = new System.Drawing.Point(740, 204);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(139, 45);
            this.bntClear.TabIndex = 73;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(57, 293);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 23);
            this.lblSearch.TabIndex = 74;
            this.lblSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(120, 290);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(550, 30);
            this.textBoxSearch.TabIndex = 75;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLecturers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(61, 326);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 51;
            this.dataGridViewLecturers.RowTemplate.Height = 24;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(818, 221);
            this.dataGridViewLecturers.TabIndex = 76;
            this.dataGridViewLecturers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLecturers_RowHeaderMouseClick_1);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(713, 290);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(166, 30);
            this.textBoxId.TabIndex = 77;
            this.textBoxId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.dataGridViewLecturers);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.bntClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.bntUpdate);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.textBoxRank);
            this.panel2.Controls.Add(this.lblRank);
            this.panel2.Controls.Add(this.textBoxLectureID);
            this.panel2.Controls.Add(this.lblLecturerID);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Controls.Add(this.comboBoxLevel);
            this.panel2.Controls.Add(this.lblLevel);
            this.panel2.Controls.Add(this.comboBoxBuilding);
            this.panel2.Controls.Add(this.lblBuilding);
            this.panel2.Controls.Add(this.comboBoxCenter);
            this.panel2.Controls.Add(this.lblCenter);
            this.panel2.Controls.Add(this.comboBoxDepartment);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.comboBoxFaculty);
            this.panel2.Controls.Add(this.lblFaculty);
            this.panel2.Controls.Add(this.comboBoxTitle);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 605);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.labelHeadingManageLecturers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 80);
            this.panel1.TabIndex = 78;
            // 
            // labelHeadingManageLecturers
            // 
            this.labelHeadingManageLecturers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeadingManageLecturers.AutoSize = true;
            this.labelHeadingManageLecturers.Font = new System.Drawing.Font("Segoe UI Black", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadingManageLecturers.Location = new System.Drawing.Point(243, 4);
            this.labelHeadingManageLecturers.Name = "labelHeadingManageLecturers";
            this.labelHeadingManageLecturers.Size = new System.Drawing.Size(536, 76);
            this.labelHeadingManageLecturers.TabIndex = 3;
            this.labelHeadingManageLecturers.Text = "Manage Lecturers";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(888, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 80;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // ManageLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(925, 605);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(925, 605);
            this.Name = "ManageLecturers";
            this.Text = "ManageLecturers";
            this.Load += new System.EventHandler(this.ManageLecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.TextBox textBoxLectureID;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeadingManageLecturers;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}