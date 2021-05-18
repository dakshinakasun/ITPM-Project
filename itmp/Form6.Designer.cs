
namespace itmp
{
    partial class AlloRoom
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
            this.lblRoomforSession = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblLecture = new System.Windows.Forms.Label();
            this.lblsession = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSessionsAll = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbLecture = new System.Windows.Forms.ComboBox();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.ComBoxSelectSessions = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.dataGrdAllocateRooms = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdAllocateRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomforSession
            // 
            this.lblRoomforSession.AutoSize = true;
            this.lblRoomforSession.Font = new System.Drawing.Font("Segoe UI", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomforSession.Location = new System.Drawing.Point(196, -4);
            this.lblRoomforSession.Name = "lblRoomforSession";
            this.lblRoomforSession.Size = new System.Drawing.Size(804, 77);
            this.lblRoomforSession.TabIndex = 0;
            this.lblRoomforSession.Text = "Allocate Rooms For Sessions";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(9, 190);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(165, 32);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Select Subject";
            // 
            // lblLecture
            // 
            this.lblLecture.AutoSize = true;
            this.lblLecture.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture.Location = new System.Drawing.Point(9, 337);
            this.lblLecture.Name = "lblLecture";
            this.lblLecture.Size = new System.Drawing.Size(164, 32);
            this.lblLecture.TabIndex = 3;
            this.lblLecture.Text = "Select Lecture";
            // 
            // lblsession
            // 
            this.lblsession.AutoSize = true;
            this.lblsession.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsession.Location = new System.Drawing.Point(7, 413);
            this.lblsession.Name = "lblsession";
            this.lblsession.Size = new System.Drawing.Size(166, 32);
            this.lblsession.TabIndex = 5;
            this.lblsession.Text = "Select Session";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(657, 111);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(122, 32);
            this.lblTag.TabIndex = 7;
            this.lblTag.Text = "Select Tag";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(12, 259);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(152, 32);
            this.lblGroup.TabIndex = 9;
            this.lblGroup.Text = "Select Group";
            // 
            // lblSessionsAll
            // 
            this.lblSessionsAll.AutoSize = true;
            this.lblSessionsAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionsAll.Location = new System.Drawing.Point(7, 492);
            this.lblSessionsAll.Name = "lblSessionsAll";
            this.lblSessionsAll.Size = new System.Drawing.Size(176, 32);
            this.lblSessionsAll.TabIndex = 11;
            this.lblSessionsAll.Text = "Select Sessions";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(648, 193);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(148, 32);
            this.lblRoom.TabIndex = 12;
            this.lblRoom.Text = "Select Room";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(9, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 63);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(418, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 63);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbSubject
            // 
            this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Introduction to Programming",
            "Introduction to Computer Systems",
            "Mathematics for Computing",
            "Communication Skills"});
            this.cbSubject.Location = new System.Drawing.Point(189, 195);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(383, 33);
            this.cbSubject.TabIndex = 16;
            // 
            // cbLecture
            // 
            this.cbLecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLecture.FormattingEnabled = true;
            this.cbLecture.Items.AddRange(new object[] {
            "Ms. Nadeeka Perera",
            "Ms. Dinusha Ekanayake",
            "Mr. Lakmal Weerasinghe",
            "Ms. Duleeka Thilini",
            "Mr. Dileepa Fernando"});
            this.cbLecture.Location = new System.Drawing.Point(189, 339);
            this.cbLecture.Name = "cbLecture";
            this.cbLecture.Size = new System.Drawing.Size(383, 33);
            this.cbLecture.TabIndex = 17;
            // 
            // cbSession
            // 
            this.cbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Items.AddRange(new object[] {
            "Lecture and Tute",
            "Lab"});
            this.cbSession.Location = new System.Drawing.Point(189, 415);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(383, 33);
            this.cbSession.TabIndex = 18;
            // 
            // cbTag
            // 
            this.cbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Items.AddRange(new object[] {
            "Lecture",
            "Tute ",
            "Lab"});
            this.cbTag.Location = new System.Drawing.Point(813, 113);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(345, 33);
            this.cbTag.TabIndex = 19;
            // 
            // cbGroup
            // 
            this.cbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "Y1S1.IT1",
            "Y1S1.IT2",
            "Y1S1.IT.3",
            "Y1S1.IT.4",
            "Y1S1.IT5"});
            this.cbGroup.Location = new System.Drawing.Point(189, 261);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(383, 33);
            this.cbGroup.TabIndex = 20;
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Items.AddRange(new object[] {
            "IMLab",
            "A401",
            "A501",
            "A502",
            "A503",
            "A402"});
            this.cbRoom.Location = new System.Drawing.Point(813, 195);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(345, 33);
            this.cbRoom.TabIndex = 21;
            // 
            // ComBoxSelectSessions
            // 
            this.ComBoxSelectSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSelectSessions.FormattingEnabled = true;
            this.ComBoxSelectSessions.Items.AddRange(new object[] {
            "ICS - Mr.Lakmal Weerasinghe - Lecture and tute",
            "MC - Ms. Nadeeka Perera - Lecture",
            "IP - Ms. Duleeka Thilini - Lecture and tute",
            "CS - Ms. Dinusha Ekanayake - Lecture"});
            this.ComBoxSelectSessions.Location = new System.Drawing.Point(189, 494);
            this.ComBoxSelectSessions.Name = "ComBoxSelectSessions";
            this.ComBoxSelectSessions.Size = new System.Drawing.Size(383, 33);
            this.ComBoxSelectSessions.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(15, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(189, 116);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(383, 30);
            this.txtBoxID.TabIndex = 24;
            // 
            // dataGrdAllocateRooms
            // 
            this.dataGrdAllocateRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdAllocateRooms.Location = new System.Drawing.Point(589, 248);
            this.dataGrdAllocateRooms.Name = "dataGrdAllocateRooms";
            this.dataGrdAllocateRooms.RowHeadersWidth = 51;
            this.dataGrdAllocateRooms.RowTemplate.Height = 24;
            this.dataGrdAllocateRooms.Size = new System.Drawing.Size(924, 406);
            this.dataGrdAllocateRooms.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(209, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 63);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // AlloRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 666);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGrdAllocateRooms);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ComBoxSelectSessions);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.cbSession);
            this.Controls.Add(this.cbLecture);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblSessionsAll);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblsession);
            this.Controls.Add(this.lblLecture);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblRoomforSession);
            this.Name = "AlloRoom";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.AllocateRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdAllocateRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomforSession;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblLecture;
        private System.Windows.Forms.Label lblsession;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblSessionsAll;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbLecture;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox ComBoxSelectSessions;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.DataGridView dataGrdAllocateRooms;
        private System.Windows.Forms.Button btnDelete;
    }
}