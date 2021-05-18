
namespace itmp
{
    partial class Form3
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
            this.lblManageBuildings = new System.Windows.Forms.Label();
            this.dataGdManageBuil = new System.Windows.Forms.DataGridView();
            this.btnUpdateMB = new System.Windows.Forms.Button();
            this.btnDeleteMB = new System.Windows.Forms.Button();
            this.btnClearMB = new System.Windows.Forms.Button();
            this.lblBuildingNameMB = new System.Windows.Forms.Label();
            this.txtBuildingNameMB = new System.Windows.Forms.TextBox();
            this.NoOfRoomsMB = new System.Windows.Forms.Label();
            this.numUpDownoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.btnForw3 = new System.Windows.Forms.Button();
            this.txtBuildingIDMB = new System.Windows.Forms.TextBox();
            this.lblBuildingIDMB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdManageBuil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownoOfRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageBuildings
            // 
            this.lblManageBuildings.AutoSize = true;
            this.lblManageBuildings.Font = new System.Drawing.Font("Segoe UI", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBuildings.Location = new System.Drawing.Point(307, 22);
            this.lblManageBuildings.Name = "lblManageBuildings";
            this.lblManageBuildings.Size = new System.Drawing.Size(521, 77);
            this.lblManageBuildings.TabIndex = 0;
            this.lblManageBuildings.Text = "Manage Buildings";
            // 
            // dataGdManageBuil
            // 
            this.dataGdManageBuil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdManageBuil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGdManageBuil.Location = new System.Drawing.Point(85, 138);
            this.dataGdManageBuil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGdManageBuil.Name = "dataGdManageBuil";
            this.dataGdManageBuil.RowHeadersWidth = 51;
            this.dataGdManageBuil.RowTemplate.Height = 24;
            this.dataGdManageBuil.Size = new System.Drawing.Size(925, 405);
            this.dataGdManageBuil.TabIndex = 1;
            this.dataGdManageBuil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGdManageBuil_CellContentClick);
            this.dataGdManageBuil.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGdManageBuil_RowHeaderMouseClick);
            // 
            // btnUpdateMB
            // 
            this.btnUpdateMB.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMB.FlatAppearance.BorderSize = 0;
            this.btnUpdateMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMB.Location = new System.Drawing.Point(1100, 155);
            this.btnUpdateMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMB.Name = "btnUpdateMB";
            this.btnUpdateMB.Size = new System.Drawing.Size(152, 71);
            this.btnUpdateMB.TabIndex = 2;
            this.btnUpdateMB.Text = "Update";
            this.btnUpdateMB.UseVisualStyleBackColor = false;
            this.btnUpdateMB.Click += new System.EventHandler(this.btnUpdateMB_Click);
            // 
            // btnDeleteMB
            // 
            this.btnDeleteMB.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMB.FlatAppearance.BorderSize = 0;
            this.btnDeleteMB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMB.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMB.Location = new System.Drawing.Point(1100, 294);
            this.btnDeleteMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMB.Name = "btnDeleteMB";
            this.btnDeleteMB.Size = new System.Drawing.Size(152, 71);
            this.btnDeleteMB.TabIndex = 3;
            this.btnDeleteMB.Text = "Delete";
            this.btnDeleteMB.UseVisualStyleBackColor = false;
            this.btnDeleteMB.Click += new System.EventHandler(this.btnDeleteMB_Click);
            // 
            // btnClearMB
            // 
            this.btnClearMB.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMB.FlatAppearance.BorderSize = 0;
            this.btnClearMB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMB.ForeColor = System.Drawing.Color.White;
            this.btnClearMB.Location = new System.Drawing.Point(1100, 434);
            this.btnClearMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearMB.Name = "btnClearMB";
            this.btnClearMB.Size = new System.Drawing.Size(152, 66);
            this.btnClearMB.TabIndex = 4;
            this.btnClearMB.Text = "Clear";
            this.btnClearMB.UseVisualStyleBackColor = false;
            this.btnClearMB.Click += new System.EventHandler(this.btnClearMB_Click);
            // 
            // lblBuildingNameMB
            // 
            this.lblBuildingNameMB.AutoSize = true;
            this.lblBuildingNameMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingNameMB.Location = new System.Drawing.Point(218, 666);
            this.lblBuildingNameMB.Name = "lblBuildingNameMB";
            this.lblBuildingNameMB.Size = new System.Drawing.Size(141, 28);
            this.lblBuildingNameMB.TabIndex = 5;
            this.lblBuildingNameMB.Text = "Building Name";
            this.lblBuildingNameMB.Click += new System.EventHandler(this.lblBuildingNameMB_Click);
            // 
            // txtBuildingNameMB
            // 
            this.txtBuildingNameMB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBuildingNameMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingNameMB.Location = new System.Drawing.Point(412, 660);
            this.txtBuildingNameMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuildingNameMB.Multiline = true;
            this.txtBuildingNameMB.Name = "txtBuildingNameMB";
            this.txtBuildingNameMB.Size = new System.Drawing.Size(333, 51);
            this.txtBuildingNameMB.TabIndex = 6;
            // 
            // NoOfRoomsMB
            // 
            this.NoOfRoomsMB.AutoSize = true;
            this.NoOfRoomsMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfRoomsMB.Location = new System.Drawing.Point(839, 582);
            this.NoOfRoomsMB.Name = "NoOfRoomsMB";
            this.NoOfRoomsMB.Size = new System.Drawing.Size(171, 28);
            this.NoOfRoomsMB.TabIndex = 7;
            this.NoOfRoomsMB.Text = "Number of Rooms";
            // 
            // numUpDownoOfRooms
            // 
            this.numUpDownoOfRooms.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numUpDownoOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownoOfRooms.Location = new System.Drawing.Point(1052, 583);
            this.numUpDownoOfRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownoOfRooms.Name = "numUpDownoOfRooms";
            this.numUpDownoOfRooms.Size = new System.Drawing.Size(123, 38);
            this.numUpDownoOfRooms.TabIndex = 8;
            this.numUpDownoOfRooms.ValueChanged += new System.EventHandler(this.numUpDownoOfRooms_ValueChanged);
            // 
            // btnForw3
            // 
            this.btnForw3.Location = new System.Drawing.Point(113, 49);
            this.btnForw3.Margin = new System.Windows.Forms.Padding(4);
            this.btnForw3.Name = "btnForw3";
            this.btnForw3.Size = new System.Drawing.Size(100, 28);
            this.btnForw3.TabIndex = 9;
            this.btnForw3.Text = "Forward";
            this.btnForw3.UseVisualStyleBackColor = true;
            this.btnForw3.Click += new System.EventHandler(this.btnForw3_Click);
            // 
            // txtBuildingIDMB
            // 
            this.txtBuildingIDMB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBuildingIDMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingIDMB.Location = new System.Drawing.Point(413, 593);
            this.txtBuildingIDMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuildingIDMB.Multiline = true;
            this.txtBuildingIDMB.Name = "txtBuildingIDMB";
            this.txtBuildingIDMB.Size = new System.Drawing.Size(333, 51);
            this.txtBuildingIDMB.TabIndex = 11;
            // 
            // lblBuildingIDMB
            // 
            this.lblBuildingIDMB.AutoSize = true;
            this.lblBuildingIDMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingIDMB.Location = new System.Drawing.Point(218, 593);
            this.lblBuildingIDMB.Name = "lblBuildingIDMB";
            this.lblBuildingIDMB.Size = new System.Drawing.Size(101, 28);
            this.lblBuildingIDMB.TabIndex = 10;
            this.lblBuildingIDMB.Text = "BuildingID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1315, 769);
            this.Controls.Add(this.txtBuildingIDMB);
            this.Controls.Add(this.lblBuildingIDMB);
            this.Controls.Add(this.btnForw3);
            this.Controls.Add(this.numUpDownoOfRooms);
            this.Controls.Add(this.NoOfRoomsMB);
            this.Controls.Add(this.txtBuildingNameMB);
            this.Controls.Add(this.lblBuildingNameMB);
            this.Controls.Add(this.btnClearMB);
            this.Controls.Add(this.btnDeleteMB);
            this.Controls.Add(this.btnUpdateMB);
            this.Controls.Add(this.dataGdManageBuil);
            this.Controls.Add(this.lblManageBuildings);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdManageBuil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownoOfRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageBuildings;
        private System.Windows.Forms.DataGridView dataGdManageBuil;
        private System.Windows.Forms.Button btnUpdateMB;
        private System.Windows.Forms.Button btnDeleteMB;
        private System.Windows.Forms.Button btnClearMB;
        private System.Windows.Forms.Label lblBuildingNameMB;
        private System.Windows.Forms.TextBox txtBuildingNameMB;
        private System.Windows.Forms.Label NoOfRoomsMB;
        private System.Windows.Forms.NumericUpDown numUpDownoOfRooms;
        private System.Windows.Forms.Button btnForw3;
        private System.Windows.Forms.TextBox txtBuildingIDMB;
        private System.Windows.Forms.Label lblBuildingIDMB;
    }
}