
namespace itmp
{
    partial class Form2
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
            this.lblAddLocation = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.txtBoxBuildingName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lablRoom = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.numUpDowCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnClearLocation = new System.Windows.Forms.Button();
            this.btnForw2 = new System.Windows.Forms.Button();
            this.txtBoxLocationID = new System.Windows.Forms.TextBox();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddLocation
            // 
            this.lblAddLocation.AutoSize = true;
            this.lblAddLocation.Font = new System.Drawing.Font("Segoe UI", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLocation.Location = new System.Drawing.Point(316, 25);
            this.lblAddLocation.Name = "lblAddLocation";
            this.lblAddLocation.Size = new System.Drawing.Size(390, 77);
            this.lblAddLocation.TabIndex = 0;
            this.lblAddLocation.Text = "Add Location";
            this.lblAddLocation.Click += new System.EventHandler(this.lblAddLocation_Click);
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingName.Location = new System.Drawing.Point(129, 226);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(141, 28);
            this.lblBuildingName.TabIndex = 1;
            this.lblBuildingName.Text = "Building Name";
            this.lblBuildingName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxBuildingName
            // 
            this.txtBoxBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuildingName.Location = new System.Drawing.Point(393, 223);
            this.txtBoxBuildingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuildingName.Multiline = true;
            this.txtBoxBuildingName.Name = "txtBoxBuildingName";
            this.txtBoxBuildingName.Size = new System.Drawing.Size(489, 54);
            this.txtBoxBuildingName.TabIndex = 2;
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(393, 297);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom.Multiline = true;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(489, 54);
            this.txtRoom.TabIndex = 4;
            // 
            // lablRoom
            // 
            this.lablRoom.AutoSize = true;
            this.lablRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablRoom.Location = new System.Drawing.Point(129, 300);
            this.lablRoom.Name = "lablRoom";
            this.lablRoom.Size = new System.Drawing.Size(63, 28);
            this.lablRoom.TabIndex = 3;
            this.lablRoom.Text = "Room";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(129, 474);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(88, 28);
            this.lblCapacity.TabIndex = 5;
            this.lblCapacity.Text = "Capacity";
            this.lblCapacity.Click += new System.EventHandler(this.lblCapacity_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(129, 386);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(111, 28);
            this.lblRoomType.TabIndex = 6;
            this.lblRoomType.Text = "Room Type";
            // 
            // numUpDowCapacity
            // 
            this.numUpDowCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDowCapacity.Location = new System.Drawing.Point(393, 474);
            this.numUpDowCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDowCapacity.Name = "numUpDowCapacity";
            this.numUpDowCapacity.Size = new System.Drawing.Size(120, 34);
            this.numUpDowCapacity.TabIndex = 9;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLocation.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.ForeColor = System.Drawing.Color.White;
            this.btnSaveLocation.Location = new System.Drawing.Point(393, 564);
            this.btnSaveLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(151, 65);
            this.btnSaveLocation.TabIndex = 10;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = false;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnClearLocation
            // 
            this.btnClearLocation.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLocation.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLocation.ForeColor = System.Drawing.Color.White;
            this.btnClearLocation.Location = new System.Drawing.Point(738, 564);
            this.btnClearLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLocation.Name = "btnClearLocation";
            this.btnClearLocation.Size = new System.Drawing.Size(144, 65);
            this.btnClearLocation.TabIndex = 11;
            this.btnClearLocation.Text = "Clear";
            this.btnClearLocation.UseVisualStyleBackColor = false;
            this.btnClearLocation.Click += new System.EventHandler(this.btnClearLocation_Click);
            // 
            // btnForw2
            // 
            this.btnForw2.Location = new System.Drawing.Point(97, 55);
            this.btnForw2.Margin = new System.Windows.Forms.Padding(4);
            this.btnForw2.Name = "btnForw2";
            this.btnForw2.Size = new System.Drawing.Size(100, 28);
            this.btnForw2.TabIndex = 12;
            this.btnForw2.Text = "Forward";
            this.btnForw2.UseVisualStyleBackColor = true;
            this.btnForw2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxLocationID
            // 
            this.txtBoxLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocationID.Location = new System.Drawing.Point(393, 139);
            this.txtBoxLocationID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLocationID.Multiline = true;
            this.txtBoxLocationID.Name = "txtBoxLocationID";
            this.txtBoxLocationID.ReadOnly = true;
            this.txtBoxLocationID.Size = new System.Drawing.Size(489, 54);
            this.txtBoxLocationID.TabIndex = 14;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.Location = new System.Drawing.Point(129, 142);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(110, 28);
            this.lblLocationID.TabIndex = 13;
            this.lblLocationID.Text = "Location ID";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Laboratory",
            "Lecture Hall"});
            this.cmbRoomType.Location = new System.Drawing.Point(393, 388);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(489, 33);
            this.cmbRoomType.TabIndex = 15;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1104, 690);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtBoxLocationID);
            this.Controls.Add(this.lblLocationID);
            this.Controls.Add(this.btnForw2);
            this.Controls.Add(this.btnClearLocation);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.numUpDowCapacity);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lablRoom);
            this.Controls.Add(this.txtBoxBuildingName);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.lblAddLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddLocation;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.TextBox txtBoxBuildingName;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lablRoom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.NumericUpDown numUpDowCapacity;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnClearLocation;
        private System.Windows.Forms.Button btnForw2;
        private System.Windows.Forms.TextBox txtBoxLocationID;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}