
namespace itmp
{
    partial class Form7
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
            this.lblManageSessionRooms = new System.Windows.Forms.Label();
            this.lblSessionMS = new System.Windows.Forms.Label();
            this.lblRoomsMS = new System.Windows.Forms.Label();
            this.lblSessionsMS = new System.Windows.Forms.Label();
            this.btnSaveMS = new System.Windows.Forms.Button();
            this.btnClearMS = new System.Windows.Forms.Button();
            this.txtBoxSessionMS = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxIDMS = new System.Windows.Forms.TextBox();
            this.btnClickView = new System.Windows.Forms.Button();
            this.comBoxSessionMS = new System.Windows.Forms.ComboBox();
            this.comBoxRoomsMS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblManageSessionRooms
            // 
            this.lblManageSessionRooms.AutoSize = true;
            this.lblManageSessionRooms.Font = new System.Drawing.Font("Segoe UI", 34.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSessionRooms.Location = new System.Drawing.Point(211, 18);
            this.lblManageSessionRooms.Name = "lblManageSessionRooms";
            this.lblManageSessionRooms.Size = new System.Drawing.Size(617, 77);
            this.lblManageSessionRooms.TabIndex = 0;
            this.lblManageSessionRooms.Text = "Manage Session Rooms";
            // 
            // lblSessionMS
            // 
            this.lblSessionMS.AutoSize = true;
            this.lblSessionMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionMS.Location = new System.Drawing.Point(43, 217);
            this.lblSessionMS.Name = "lblSessionMS";
            this.lblSessionMS.Size = new System.Drawing.Size(102, 25);
            this.lblSessionMS.TabIndex = 1;
            this.lblSessionMS.Text = "SessionID";
            // 
            // lblRoomsMS
            // 
            this.lblRoomsMS.AutoSize = true;
            this.lblRoomsMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsMS.Location = new System.Drawing.Point(43, 306);
            this.lblRoomsMS.Name = "lblRoomsMS";
            this.lblRoomsMS.Size = new System.Drawing.Size(133, 25);
            this.lblRoomsMS.TabIndex = 3;
            this.lblRoomsMS.Text = "Select Rooms";
            this.lblRoomsMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSessionsMS
            // 
            this.lblSessionsMS.AutoSize = true;
            this.lblSessionsMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionsMS.Location = new System.Drawing.Point(43, 400);
            this.lblSessionsMS.Name = "lblSessionsMS";
            this.lblSessionsMS.Size = new System.Drawing.Size(175, 25);
            this.lblSessionsMS.TabIndex = 5;
            this.lblSessionsMS.Text = "Selected Sessions";
            this.lblSessionsMS.Visible = false;
            // 
            // btnSaveMS
            // 
            this.btnSaveMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveMS.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMS.ForeColor = System.Drawing.Color.White;
            this.btnSaveMS.Location = new System.Drawing.Point(912, 294);
            this.btnSaveMS.Name = "btnSaveMS";
            this.btnSaveMS.Size = new System.Drawing.Size(176, 63);
            this.btnSaveMS.TabIndex = 7;
            this.btnSaveMS.Text = "Save";
            this.btnSaveMS.UseVisualStyleBackColor = false;
            this.btnSaveMS.Click += new System.EventHandler(this.btnSaveMS_Click);
            // 
            // btnClearMS
            // 
            this.btnClearMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearMS.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMS.ForeColor = System.Drawing.Color.White;
            this.btnClearMS.Location = new System.Drawing.Point(912, 469);
            this.btnClearMS.Name = "btnClearMS";
            this.btnClearMS.Size = new System.Drawing.Size(176, 57);
            this.btnClearMS.TabIndex = 8;
            this.btnClearMS.Text = "Clear";
            this.btnClearMS.UseVisualStyleBackColor = false;
            this.btnClearMS.Click += new System.EventHandler(this.btnClearMS_Click);
            // 
            // txtBoxSessionMS
            // 
            this.txtBoxSessionMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSessionMS.Location = new System.Drawing.Point(224, 392);
            this.txtBoxSessionMS.Multiline = true;
            this.txtBoxSessionMS.Name = "txtBoxSessionMS";
            this.txtBoxSessionMS.Size = new System.Drawing.Size(562, 279);
            this.txtBoxSessionMS.TabIndex = 11;
            this.txtBoxSessionMS.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(57, 143);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            // 
            // txtBoxIDMS
            // 
            this.txtBoxIDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIDMS.Location = new System.Drawing.Point(224, 143);
            this.txtBoxIDMS.Name = "txtBoxIDMS";
            this.txtBoxIDMS.Size = new System.Drawing.Size(562, 30);
            this.txtBoxIDMS.TabIndex = 16;
            // 
            // btnClickView
            // 
            this.btnClickView.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClickView.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickView.ForeColor = System.Drawing.Color.White;
            this.btnClickView.Location = new System.Drawing.Point(912, 143);
            this.btnClickView.Name = "btnClickView";
            this.btnClickView.Size = new System.Drawing.Size(176, 62);
            this.btnClickView.TabIndex = 17;
            this.btnClickView.Text = "View Session";
            this.btnClickView.UseVisualStyleBackColor = false;
            this.btnClickView.Click += new System.EventHandler(this.btnClickView_Click);
            // 
            // comBoxSessionMS
            // 
            this.comBoxSessionMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxSessionMS.FormattingEnabled = true;
            this.comBoxSessionMS.Location = new System.Drawing.Point(224, 217);
            this.comBoxSessionMS.Name = "comBoxSessionMS";
            this.comBoxSessionMS.Size = new System.Drawing.Size(562, 33);
            this.comBoxSessionMS.TabIndex = 18;
            this.comBoxSessionMS.SelectedIndexChanged += new System.EventHandler(this.comBoxSessionMS_SelectedIndexChanged);
            // 
            // comBoxRoomsMS
            // 
            this.comBoxRoomsMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxRoomsMS.FormattingEnabled = true;
            this.comBoxRoomsMS.Location = new System.Drawing.Point(224, 306);
            this.comBoxRoomsMS.Name = "comBoxRoomsMS";
            this.comBoxRoomsMS.Size = new System.Drawing.Size(562, 33);
            this.comBoxRoomsMS.TabIndex = 19;
            this.comBoxRoomsMS.SelectedIndexChanged += new System.EventHandler(this.comBoxRoomsMS_SelectedIndexChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1155, 688);
            this.Controls.Add(this.comBoxRoomsMS);
            this.Controls.Add(this.comBoxSessionMS);
            this.Controls.Add(this.btnClickView);
            this.Controls.Add(this.txtBoxIDMS);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBoxSessionMS);
            this.Controls.Add(this.btnClearMS);
            this.Controls.Add(this.btnSaveMS);
            this.Controls.Add(this.lblSessionsMS);
            this.Controls.Add(this.lblRoomsMS);
            this.Controls.Add(this.lblSessionMS);
            this.Controls.Add(this.lblManageSessionRooms);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageSessionRooms;
        private System.Windows.Forms.Label lblSessionMS;
        private System.Windows.Forms.Label lblRoomsMS;
        private System.Windows.Forms.Label lblSessionsMS;
        private System.Windows.Forms.Button btnSaveMS;
        private System.Windows.Forms.Button btnClearMS;
        private System.Windows.Forms.TextBox txtBoxSessionMS;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBoxIDMS;
        private System.Windows.Forms.Button btnClickView;
        private System.Windows.Forms.ComboBox comBoxSessionMS;
        private System.Windows.Forms.ComboBox comBoxRoomsMS;
    }
}