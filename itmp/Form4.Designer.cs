
namespace itmp
{
    partial class Form4
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
            this.lblManageLocation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxML = new System.Windows.Forms.TextBox();
            this.btnUpdateML = new System.Windows.Forms.Button();
            this.btnDeleteML = new System.Windows.Forms.Button();
            this.btnClearML = new System.Windows.Forms.Button();
            this.lblBuildingNameML = new System.Windows.Forms.Label();
            this.txtBoxBuildingNamML = new System.Windows.Forms.TextBox();
            this.txtBoxRomNameML = new System.Windows.Forms.TextBox();
            this.lblRoomNameML = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCapacityML = new System.Windows.Forms.Label();
            this.txtBoxLocIDML = new System.Windows.Forms.TextBox();
            this.lblLocaIDML = new System.Windows.Forms.Label();
            this.cmbRoomTypeML = new System.Windows.Forms.ComboBox();
            this.numUpDownML = new System.Windows.Forms.NumericUpDown();
            this.btnML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownML)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageLocation
            // 
            this.lblManageLocation.AutoSize = true;
            this.lblManageLocation.Font = new System.Drawing.Font("Segoe UI", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageLocation.Location = new System.Drawing.Point(277, 25);
            this.lblManageLocation.Name = "lblManageLocation";
            this.lblManageLocation.Size = new System.Drawing.Size(498, 77);
            this.lblManageLocation.TabIndex = 0;
            this.lblManageLocation.Text = "Manage Location";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 351);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(827, 74);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 28);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtBoxML
            // 
            this.txtBoxML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxML.Location = new System.Drawing.Point(922, 76);
            this.txtBoxML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxML.Multiline = true;
            this.txtBoxML.Name = "txtBoxML";
            this.txtBoxML.Size = new System.Drawing.Size(291, 43);
            this.txtBoxML.TabIndex = 3;
            this.txtBoxML.TextChanged += new System.EventHandler(this.txtBoxML_TextChanged);
            // 
            // btnUpdateML
            // 
            this.btnUpdateML.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateML.FlatAppearance.BorderSize = 0;
            this.btnUpdateML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdateML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateML.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateML.ForeColor = System.Drawing.Color.White;
            this.btnUpdateML.Location = new System.Drawing.Point(1011, 183);
            this.btnUpdateML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateML.Name = "btnUpdateML";
            this.btnUpdateML.Size = new System.Drawing.Size(181, 70);
            this.btnUpdateML.TabIndex = 4;
            this.btnUpdateML.Text = "Update";
            this.btnUpdateML.UseVisualStyleBackColor = false;
            this.btnUpdateML.Click += new System.EventHandler(this.btnUpdateML_Click);
            // 
            // btnDeleteML
            // 
            this.btnDeleteML.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteML.FlatAppearance.BorderSize = 0;
            this.btnDeleteML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteML.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteML.ForeColor = System.Drawing.Color.White;
            this.btnDeleteML.Location = new System.Drawing.Point(1011, 298);
            this.btnDeleteML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteML.Name = "btnDeleteML";
            this.btnDeleteML.Size = new System.Drawing.Size(181, 76);
            this.btnDeleteML.TabIndex = 5;
            this.btnDeleteML.Text = "Delete";
            this.btnDeleteML.UseVisualStyleBackColor = false;
            this.btnDeleteML.Click += new System.EventHandler(this.btnDeleteML_Click);
            // 
            // btnClearML
            // 
            this.btnClearML.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearML.FlatAppearance.BorderSize = 0;
            this.btnClearML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearML.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearML.ForeColor = System.Drawing.Color.White;
            this.btnClearML.Location = new System.Drawing.Point(1011, 417);
            this.btnClearML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearML.Name = "btnClearML";
            this.btnClearML.Size = new System.Drawing.Size(181, 71);
            this.btnClearML.TabIndex = 6;
            this.btnClearML.Text = "Clear";
            this.btnClearML.UseVisualStyleBackColor = false;
            this.btnClearML.Click += new System.EventHandler(this.btnClearML_Click);
            // 
            // lblBuildingNameML
            // 
            this.lblBuildingNameML.AutoSize = true;
            this.lblBuildingNameML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingNameML.Location = new System.Drawing.Point(120, 573);
            this.lblBuildingNameML.Name = "lblBuildingNameML";
            this.lblBuildingNameML.Size = new System.Drawing.Size(141, 28);
            this.lblBuildingNameML.TabIndex = 7;
            this.lblBuildingNameML.Text = "Building Name";
            // 
            // txtBoxBuildingNamML
            // 
            this.txtBoxBuildingNamML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuildingNamML.Location = new System.Drawing.Point(303, 573);
            this.txtBoxBuildingNamML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuildingNamML.Multiline = true;
            this.txtBoxBuildingNamML.Name = "txtBoxBuildingNamML";
            this.txtBoxBuildingNamML.Size = new System.Drawing.Size(304, 46);
            this.txtBoxBuildingNamML.TabIndex = 8;
            // 
            // txtBoxRomNameML
            // 
            this.txtBoxRomNameML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRomNameML.Location = new System.Drawing.Point(303, 652);
            this.txtBoxRomNameML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRomNameML.Multiline = true;
            this.txtBoxRomNameML.Name = "txtBoxRomNameML";
            this.txtBoxRomNameML.Size = new System.Drawing.Size(304, 47);
            this.txtBoxRomNameML.TabIndex = 10;
            // 
            // lblRoomNameML
            // 
            this.lblRoomNameML.AutoSize = true;
            this.lblRoomNameML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNameML.Location = new System.Drawing.Point(120, 652);
            this.lblRoomNameML.Name = "lblRoomNameML";
            this.lblRoomNameML.Size = new System.Drawing.Size(122, 28);
            this.lblRoomNameML.TabIndex = 9;
            this.lblRoomNameML.Text = "Room Name";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(701, 532);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(111, 28);
            this.lblRoomType.TabIndex = 13;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblCapacityML
            // 
            this.lblCapacityML.AutoSize = true;
            this.lblCapacityML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityML.Location = new System.Drawing.Point(701, 602);
            this.lblCapacityML.Name = "lblCapacityML";
            this.lblCapacityML.Size = new System.Drawing.Size(88, 28);
            this.lblCapacityML.TabIndex = 16;
            this.lblCapacityML.Text = "Capacity";
            // 
            // txtBoxLocIDML
            // 
            this.txtBoxLocIDML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocIDML.Location = new System.Drawing.Point(303, 496);
            this.txtBoxLocIDML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLocIDML.Multiline = true;
            this.txtBoxLocIDML.Name = "txtBoxLocIDML";
            this.txtBoxLocIDML.Size = new System.Drawing.Size(304, 47);
            this.txtBoxLocIDML.TabIndex = 19;
            // 
            // lblLocaIDML
            // 
            this.lblLocaIDML.AutoSize = true;
            this.lblLocaIDML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocaIDML.Location = new System.Drawing.Point(120, 496);
            this.lblLocaIDML.Name = "lblLocaIDML";
            this.lblLocaIDML.Size = new System.Drawing.Size(110, 28);
            this.lblLocaIDML.TabIndex = 18;
            this.lblLocaIDML.Text = "Location ID";
            // 
            // cmbRoomTypeML
            // 
            this.cmbRoomTypeML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomTypeML.FormattingEnabled = true;
            this.cmbRoomTypeML.Items.AddRange(new object[] {
            "Labotarie",
            "Lecture Hall"});
            this.cmbRoomTypeML.Location = new System.Drawing.Point(884, 532);
            this.cmbRoomTypeML.Name = "cmbRoomTypeML";
            this.cmbRoomTypeML.Size = new System.Drawing.Size(304, 33);
            this.cmbRoomTypeML.TabIndex = 20;
            // 
            // numUpDownML
            // 
            this.numUpDownML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownML.Location = new System.Drawing.Point(884, 607);
            this.numUpDownML.Name = "numUpDownML";
            this.numUpDownML.Size = new System.Drawing.Size(120, 30);
            this.numUpDownML.TabIndex = 21;
            // 
            // btnML
            // 
            this.btnML.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnML.Location = new System.Drawing.Point(38, 41);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(134, 46);
            this.btnML.TabIndex = 22;
            this.btnML.Text = "back";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.btnML_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1265, 731);
            this.Controls.Add(this.btnML);
            this.Controls.Add(this.numUpDownML);
            this.Controls.Add(this.cmbRoomTypeML);
            this.Controls.Add(this.txtBoxLocIDML);
            this.Controls.Add(this.lblLocaIDML);
            this.Controls.Add(this.lblCapacityML);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtBoxRomNameML);
            this.Controls.Add(this.lblRoomNameML);
            this.Controls.Add(this.txtBoxBuildingNamML);
            this.Controls.Add(this.lblBuildingNameML);
            this.Controls.Add(this.btnClearML);
            this.Controls.Add(this.btnDeleteML);
            this.Controls.Add(this.btnUpdateML);
            this.Controls.Add(this.txtBoxML);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblManageLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageLocation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxML;
        private System.Windows.Forms.Button btnUpdateML;
        private System.Windows.Forms.Button btnDeleteML;
        private System.Windows.Forms.Button btnClearML;
        private System.Windows.Forms.Label lblBuildingNameML;
        private System.Windows.Forms.TextBox txtBoxBuildingNamML;
        private System.Windows.Forms.TextBox txtBoxRomNameML;
        private System.Windows.Forms.Label lblRoomNameML;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCapacityML;
        private System.Windows.Forms.TextBox txtBoxLocIDML;
        private System.Windows.Forms.Label lblLocaIDML;
        private System.Windows.Forms.ComboBox cmbRoomTypeML;
        private System.Windows.Forms.NumericUpDown numUpDownML;
        private System.Windows.Forms.Button btnML;
    }
}