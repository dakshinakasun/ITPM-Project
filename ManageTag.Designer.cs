
namespace StudentAndTagProject
{
    partial class ManageTag
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
            this.panelHedding = new System.Windows.Forms.Panel();
            this.labelManagTags = new System.Windows.Forms.Label();
            this.btnClearManage = new System.Windows.Forms.Button();
            this.btnDeleteManage = new System.Windows.Forms.Button();
            this.btnUpdateManage = new System.Windows.Forms.Button();
            this.dataGridViewManageTag = new System.Windows.Forms.DataGridView();
            this.lblSearchmanage = new System.Windows.Forms.Label();
            this.textBoxSearchManageTag = new System.Windows.Forms.TextBox();
            this.lblRelatedTagManage = new System.Windows.Forms.Label();
            this.comboCodeTag = new System.Windows.Forms.ComboBox();
            this.lblTageCodemanage = new System.Windows.Forms.Label();
            this.comboBoxRelatedTag = new System.Windows.Forms.ComboBox();
            this.lblTagNameManageTage = new System.Windows.Forms.Label();
            this.comboBoxTagNameManage = new System.Windows.Forms.ComboBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.panelHedding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTag)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHedding
            // 
            this.panelHedding.Controls.Add(this.labelManagTags);
            this.panelHedding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHedding.Location = new System.Drawing.Point(0, 0);
            this.panelHedding.Name = "panelHedding";
            this.panelHedding.Size = new System.Drawing.Size(907, 70);
            this.panelHedding.TabIndex = 2;
            // 
            // labelManagTags
            // 
            this.labelManagTags.AutoSize = true;
            this.labelManagTags.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagTags.Location = new System.Drawing.Point(364, 9);
            this.labelManagTags.Name = "labelManagTags";
            this.labelManagTags.Size = new System.Drawing.Size(291, 59);
            this.labelManagTags.TabIndex = 0;
            this.labelManagTags.Text = "Manage Tags";
            // 
            // btnClearManage
            // 
            this.btnClearManage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearManage.FlatAppearance.BorderSize = 0;
            this.btnClearManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearManage.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearManage.ForeColor = System.Drawing.Color.White;
            this.btnClearManage.Location = new System.Drawing.Point(744, 267);
            this.btnClearManage.Name = "btnClearManage";
            this.btnClearManage.Size = new System.Drawing.Size(151, 54);
            this.btnClearManage.TabIndex = 37;
            this.btnClearManage.Text = "Clear";
            this.btnClearManage.UseVisualStyleBackColor = false;
            this.btnClearManage.Click += new System.EventHandler(this.btnClearManage_Click);
            // 
            // btnDeleteManage
            // 
            this.btnDeleteManage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteManage.FlatAppearance.BorderSize = 0;
            this.btnDeleteManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteManage.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteManage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteManage.Location = new System.Drawing.Point(744, 207);
            this.btnDeleteManage.Name = "btnDeleteManage";
            this.btnDeleteManage.Size = new System.Drawing.Size(151, 54);
            this.btnDeleteManage.TabIndex = 36;
            this.btnDeleteManage.Text = "Delete";
            this.btnDeleteManage.UseVisualStyleBackColor = false;
            this.btnDeleteManage.Click += new System.EventHandler(this.btnDeleteManage_Click);
            // 
            // btnUpdateManage
            // 
            this.btnUpdateManage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateManage.FlatAppearance.BorderSize = 0;
            this.btnUpdateManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateManage.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateManage.ForeColor = System.Drawing.Color.White;
            this.btnUpdateManage.Location = new System.Drawing.Point(744, 147);
            this.btnUpdateManage.Name = "btnUpdateManage";
            this.btnUpdateManage.Size = new System.Drawing.Size(151, 54);
            this.btnUpdateManage.TabIndex = 35;
            this.btnUpdateManage.Text = "Update";
            this.btnUpdateManage.UseVisualStyleBackColor = false;
            this.btnUpdateManage.Click += new System.EventHandler(this.btnUpdateManage_Click);
            // 
            // dataGridViewManageTag
            // 
            this.dataGridViewManageTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewManageTag.Location = new System.Drawing.Point(16, 119);
            this.dataGridViewManageTag.Name = "dataGridViewManageTag";
            this.dataGridViewManageTag.RowHeadersWidth = 51;
            this.dataGridViewManageTag.RowTemplate.Height = 24;
            this.dataGridViewManageTag.Size = new System.Drawing.Size(707, 214);
            this.dataGridViewManageTag.TabIndex = 34;
            this.dataGridViewManageTag.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageTag_RowHeaderMouseClick);
            // 
            // lblSearchmanage
            // 
            this.lblSearchmanage.AutoSize = true;
            this.lblSearchmanage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchmanage.Location = new System.Drawing.Point(12, 85);
            this.lblSearchmanage.Name = "lblSearchmanage";
            this.lblSearchmanage.Size = new System.Drawing.Size(57, 23);
            this.lblSearchmanage.TabIndex = 33;
            this.lblSearchmanage.Text = "Search";
            // 
            // textBoxSearchManageTag
            // 
            this.textBoxSearchManageTag.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearchManageTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchManageTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchManageTag.Location = new System.Drawing.Point(75, 83);
            this.textBoxSearchManageTag.Name = "textBoxSearchManageTag";
            this.textBoxSearchManageTag.Size = new System.Drawing.Size(352, 30);
            this.textBoxSearchManageTag.TabIndex = 32;
            this.textBoxSearchManageTag.TextChanged += new System.EventHandler(this.textBoxSearchManageTag_TextChanged);
            // 
            // lblRelatedTagManage
            // 
            this.lblRelatedTagManage.AutoSize = true;
            this.lblRelatedTagManage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatedTagManage.Location = new System.Drawing.Point(385, 360);
            this.lblRelatedTagManage.Name = "lblRelatedTagManage";
            this.lblRelatedTagManage.Size = new System.Drawing.Size(96, 23);
            this.lblRelatedTagManage.TabIndex = 44;
            this.lblRelatedTagManage.Text = "Related Tag";
            // 
            // comboCodeTag
            // 
            this.comboCodeTag.BackColor = System.Drawing.Color.Gainsboro;
            this.comboCodeTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCodeTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCodeTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCodeTag.FormattingEnabled = true;
            this.comboCodeTag.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboCodeTag.Location = new System.Drawing.Point(138, 401);
            this.comboCodeTag.Name = "comboCodeTag";
            this.comboCodeTag.Size = new System.Drawing.Size(211, 31);
            this.comboCodeTag.TabIndex = 43;
            // 
            // lblTageCodemanage
            // 
            this.lblTageCodemanage.AutoSize = true;
            this.lblTageCodemanage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTageCodemanage.Location = new System.Drawing.Point(20, 404);
            this.lblTageCodemanage.Name = "lblTageCodemanage";
            this.lblTageCodemanage.Size = new System.Drawing.Size(79, 23);
            this.lblTageCodemanage.TabIndex = 42;
            this.lblTageCodemanage.Text = "Tag Code";
            // 
            // comboBoxRelatedTag
            // 
            this.comboBoxRelatedTag.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRelatedTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRelatedTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelatedTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRelatedTag.FormattingEnabled = true;
            this.comboBoxRelatedTag.Items.AddRange(new object[] {
            "Lecture",
            "Tute",
            "Lab"});
            this.comboBoxRelatedTag.Location = new System.Drawing.Point(503, 357);
            this.comboBoxRelatedTag.Name = "comboBoxRelatedTag";
            this.comboBoxRelatedTag.Size = new System.Drawing.Size(211, 31);
            this.comboBoxRelatedTag.TabIndex = 41;
            // 
            // lblTagNameManageTage
            // 
            this.lblTagNameManageTage.AutoSize = true;
            this.lblTagNameManageTage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagNameManageTage.Location = new System.Drawing.Point(20, 360);
            this.lblTagNameManageTage.Name = "lblTagNameManageTage";
            this.lblTagNameManageTage.Size = new System.Drawing.Size(87, 23);
            this.lblTagNameManageTage.TabIndex = 40;
            this.lblTagNameManageTage.Text = "Tag Name";
            // 
            // comboBoxTagNameManage
            // 
            this.comboBoxTagNameManage.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTagNameManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTagNameManage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTagNameManage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTagNameManage.FormattingEnabled = true;
            this.comboBoxTagNameManage.Items.AddRange(new object[] {
            "PAF",
            "ITPM",
            "DS",
            "NDM",
            "ESD"});
            this.comboBoxTagNameManage.Location = new System.Drawing.Point(138, 357);
            this.comboBoxTagNameManage.Name = "comboBoxTagNameManage";
            this.comboBoxTagNameManage.Size = new System.Drawing.Size(211, 31);
            this.comboBoxTagNameManage.TabIndex = 39;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(579, 85);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(100, 22);
            this.textBoxid.TabIndex = 45;
            this.textBoxid.Visible = false;
            // 
            // ManageTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(907, 453);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.lblRelatedTagManage);
            this.Controls.Add(this.comboCodeTag);
            this.Controls.Add(this.lblTageCodemanage);
            this.Controls.Add(this.comboBoxRelatedTag);
            this.Controls.Add(this.lblTagNameManageTage);
            this.Controls.Add(this.comboBoxTagNameManage);
            this.Controls.Add(this.btnClearManage);
            this.Controls.Add(this.btnDeleteManage);
            this.Controls.Add(this.btnUpdateManage);
            this.Controls.Add(this.dataGridViewManageTag);
            this.Controls.Add(this.lblSearchmanage);
            this.Controls.Add(this.textBoxSearchManageTag);
            this.Controls.Add(this.panelHedding);
            this.Name = "ManageTag";
            this.Text = "ManageTag";
            this.Load += new System.EventHandler(this.ManageTag_Load_1);
            this.panelHedding.ResumeLayout(false);
            this.panelHedding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHedding;
        private System.Windows.Forms.Label labelManagTags;
        private System.Windows.Forms.Button btnClearManage;
        private System.Windows.Forms.Button btnDeleteManage;
        private System.Windows.Forms.Button btnUpdateManage;
        private System.Windows.Forms.DataGridView dataGridViewManageTag;
        private System.Windows.Forms.Label lblSearchmanage;
        private System.Windows.Forms.TextBox textBoxSearchManageTag;
        private System.Windows.Forms.Label lblRelatedTagManage;
        private System.Windows.Forms.ComboBox comboCodeTag;
        private System.Windows.Forms.Label lblTageCodemanage;
        private System.Windows.Forms.ComboBox comboBoxRelatedTag;
        private System.Windows.Forms.Label lblTagNameManageTage;
        private System.Windows.Forms.ComboBox comboBoxTagNameManage;
        private System.Windows.Forms.TextBox textBoxid;
    }
}