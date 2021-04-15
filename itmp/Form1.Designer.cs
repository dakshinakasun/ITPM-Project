
namespace itmp
{
    partial class formAddBuilding
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblbuildingID = new System.Windows.Forms.Label();
            this.txtBoxBuildingId = new System.Windows.Forms.TextBox();
            this.txtBoxBuildingName = new System.Windows.Forms.TextBox();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.lblNumofRooms = new System.Windows.Forms.Label();
            this.numUpDowNoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnForwdLocation = new System.Windows.Forms.Button();
            this.btnChartLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowNoOfRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Building";
            // 
            // lblbuildingID
            // 
            this.lblbuildingID.AutoSize = true;
            this.lblbuildingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuildingID.Location = new System.Drawing.Point(115, 137);
            this.lblbuildingID.Name = "lblbuildingID";
            this.lblbuildingID.Size = new System.Drawing.Size(107, 28);
            this.lblbuildingID.TabIndex = 1;
            this.lblbuildingID.Text = "Building ID";
            // 
            // txtBoxBuildingId
            // 
            this.txtBoxBuildingId.BackColor = System.Drawing.Color.White;
            this.txtBoxBuildingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuildingId.Location = new System.Drawing.Point(352, 132);
            this.txtBoxBuildingId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuildingId.Multiline = true;
            this.txtBoxBuildingId.Name = "txtBoxBuildingId";
            this.txtBoxBuildingId.ReadOnly = true;
            this.txtBoxBuildingId.Size = new System.Drawing.Size(503, 59);
            this.txtBoxBuildingId.TabIndex = 2;
            this.txtBoxBuildingId.TextChanged += new System.EventHandler(this.txtBoxBuildingId_TextChanged);
            // 
            // txtBoxBuildingName
            // 
            this.txtBoxBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuildingName.Location = new System.Drawing.Point(352, 228);
            this.txtBoxBuildingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuildingName.Multiline = true;
            this.txtBoxBuildingName.Name = "txtBoxBuildingName";
            this.txtBoxBuildingName.Size = new System.Drawing.Size(503, 56);
            this.txtBoxBuildingName.TabIndex = 4;
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingName.Location = new System.Drawing.Point(115, 234);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(141, 28);
            this.lblBuildingName.TabIndex = 3;
            this.lblBuildingName.Text = "Building Name";
            this.lblBuildingName.Click += new System.EventHandler(this.lblBuildingName_Click);
            // 
            // lblNumofRooms
            // 
            this.lblNumofRooms.AutoSize = true;
            this.lblNumofRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofRooms.Location = new System.Drawing.Point(115, 345);
            this.lblNumofRooms.Name = "lblNumofRooms";
            this.lblNumofRooms.Size = new System.Drawing.Size(171, 28);
            this.lblNumofRooms.TabIndex = 5;
            this.lblNumofRooms.Text = "Number of Rooms";
            this.lblNumofRooms.Click += new System.EventHandler(this.label2_Click);
            // 
            // numUpDowNoOfRooms
            // 
            this.numUpDowNoOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDowNoOfRooms.Location = new System.Drawing.Point(355, 340);
            this.numUpDowNoOfRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDowNoOfRooms.Name = "numUpDowNoOfRooms";
            this.numUpDowNoOfRooms.Size = new System.Drawing.Size(93, 34);
            this.numUpDowNoOfRooms.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(352, 475);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 65);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(721, 475);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 65);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(933, 80);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(122, 53);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnForwdLocation
            // 
            this.btnForwdLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwdLocation.Location = new System.Drawing.Point(933, 171);
            this.btnForwdLocation.Name = "btnForwdLocation";
            this.btnForwdLocation.Size = new System.Drawing.Size(122, 60);
            this.btnForwdLocation.TabIndex = 11;
            this.btnForwdLocation.Text = "Forwd Location";
            this.btnForwdLocation.UseVisualStyleBackColor = true;
            this.btnForwdLocation.Click += new System.EventHandler(this.btnForwdLocation_Click);
            // 
            // btnChartLoad
            // 
            this.btnChartLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChartLoad.Location = new System.Drawing.Point(933, 270);
            this.btnChartLoad.Name = "btnChartLoad";
            this.btnChartLoad.Size = new System.Drawing.Size(122, 66);
            this.btnChartLoad.TabIndex = 12;
            this.btnChartLoad.Text = "Chart generate";
            this.btnChartLoad.UseVisualStyleBackColor = true;
            this.btnChartLoad.Click += new System.EventHandler(this.btnChartLoad_Click);
            // 
            // formAddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1129, 692);
            this.Controls.Add(this.btnChartLoad);
            this.Controls.Add(this.btnForwdLocation);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numUpDowNoOfRooms);
            this.Controls.Add(this.lblNumofRooms);
            this.Controls.Add(this.txtBoxBuildingName);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.txtBoxBuildingId);
            this.Controls.Add(this.lblbuildingID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAddBuilding";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formAddBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowNoOfRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbuildingID;
        private System.Windows.Forms.TextBox txtBoxBuildingId;
        private System.Windows.Forms.TextBox txtBoxBuildingName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label lblNumofRooms;
        private System.Windows.Forms.NumericUpDown numUpDowNoOfRooms;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnForwdLocation;
        private System.Windows.Forms.Button btnChartLoad;
    }
}

