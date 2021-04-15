
namespace StudentAndTagProject
{
    partial class Form1
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
            this.lblTagName = new System.Windows.Forms.Label();
            this.comboBoxTagName = new System.Windows.Forms.ComboBox();
            this.lblTageCode = new System.Windows.Forms.Label();
            this.comboBoxRelated = new System.Windows.Forms.ComboBox();
            this.lblRelatedTag = new System.Windows.Forms.Label();
            this.comboCode = new System.Windows.Forms.ComboBox();
            this.panelHedding = new System.Windows.Forms.Panel();
            this.labelAddTag = new System.Windows.Forms.Label();
            this.btnClearTag = new System.Windows.Forms.Button();
            this.btnSaveTag = new System.Windows.Forms.Button();
            this.panelHedding.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagName.Location = new System.Drawing.Point(224, 98);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(87, 23);
            this.lblTagName.TabIndex = 23;
            this.lblTagName.Text = "Tag Name";
            // 
            // comboBoxTagName
            // 
            this.comboBoxTagName.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTagName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTagName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTagName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTagName.FormattingEnabled = true;
            this.comboBoxTagName.Items.AddRange(new object[] {
            "PAF",
            "ITPM",
            "DS",
            "NDM",
            "ESD"});
            this.comboBoxTagName.Location = new System.Drawing.Point(394, 95);
            this.comboBoxTagName.Name = "comboBoxTagName";
            this.comboBoxTagName.Size = new System.Drawing.Size(211, 31);
            this.comboBoxTagName.TabIndex = 22;
            // 
            // lblTageCode
            // 
            this.lblTageCode.AutoSize = true;
            this.lblTageCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTageCode.Location = new System.Drawing.Point(224, 178);
            this.lblTageCode.Name = "lblTageCode";
            this.lblTageCode.Size = new System.Drawing.Size(79, 23);
            this.lblTageCode.TabIndex = 25;
            this.lblTageCode.Text = "Tag Code";
            // 
            // comboBoxRelated
            // 
            this.comboBoxRelated.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRelated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRelated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelated.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRelated.FormattingEnabled = true;
            this.comboBoxRelated.Items.AddRange(new object[] {
            "Lecture",
            "Tute",
            "Lab"});
            this.comboBoxRelated.Location = new System.Drawing.Point(394, 262);
            this.comboBoxRelated.Name = "comboBoxRelated";
            this.comboBoxRelated.Size = new System.Drawing.Size(211, 31);
            this.comboBoxRelated.TabIndex = 24;
            this.comboBoxRelated.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblRelatedTag
            // 
            this.lblRelatedTag.AutoSize = true;
            this.lblRelatedTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatedTag.Location = new System.Drawing.Point(224, 270);
            this.lblRelatedTag.Name = "lblRelatedTag";
            this.lblRelatedTag.Size = new System.Drawing.Size(96, 23);
            this.lblRelatedTag.TabIndex = 27;
            this.lblRelatedTag.Text = "Related Tag";
            // 
            // comboCode
            // 
            this.comboCode.BackColor = System.Drawing.Color.Gainsboro;
            this.comboCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCode.FormattingEnabled = true;
            this.comboCode.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboCode.Location = new System.Drawing.Point(394, 175);
            this.comboCode.Name = "comboCode";
            this.comboCode.Size = new System.Drawing.Size(211, 31);
            this.comboCode.TabIndex = 26;
            // 
            // panelHedding
            // 
            this.panelHedding.Controls.Add(this.labelAddTag);
            this.panelHedding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHedding.Location = new System.Drawing.Point(0, 0);
            this.panelHedding.Name = "panelHedding";
            this.panelHedding.Size = new System.Drawing.Size(907, 70);
            this.panelHedding.TabIndex = 28;
            // 
            // labelAddTag
            // 
            this.labelAddTag.AutoSize = true;
            this.labelAddTag.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTag.Location = new System.Drawing.Point(302, 9);
            this.labelAddTag.Name = "labelAddTag";
            this.labelAddTag.Size = new System.Drawing.Size(216, 59);
            this.labelAddTag.TabIndex = 0;
            this.labelAddTag.Text = "ADD TAG";
            // 
            // btnClearTag
            // 
            this.btnClearTag.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTag.FlatAppearance.BorderSize = 0;
            this.btnClearTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTag.ForeColor = System.Drawing.Color.White;
            this.btnClearTag.Location = new System.Drawing.Point(469, 355);
            this.btnClearTag.Name = "btnClearTag";
            this.btnClearTag.Size = new System.Drawing.Size(151, 54);
            this.btnClearTag.TabIndex = 32;
            this.btnClearTag.Text = "Clear";
            this.btnClearTag.UseVisualStyleBackColor = false;
            this.btnClearTag.Click += new System.EventHandler(this.btnClearTag_Click);
            // 
            // btnSaveTag
            // 
            this.btnSaveTag.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTag.FlatAppearance.BorderSize = 0;
            this.btnSaveTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTag.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTag.ForeColor = System.Drawing.Color.White;
            this.btnSaveTag.Location = new System.Drawing.Point(235, 355);
            this.btnSaveTag.Name = "btnSaveTag";
            this.btnSaveTag.Size = new System.Drawing.Size(151, 54);
            this.btnSaveTag.TabIndex = 31;
            this.btnSaveTag.Text = "Save";
            this.btnSaveTag.UseVisualStyleBackColor = false;
            this.btnSaveTag.Click += new System.EventHandler(this.btnSaveTag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(907, 453);
            this.Controls.Add(this.btnClearTag);
            this.Controls.Add(this.btnSaveTag);
            this.Controls.Add(this.panelHedding);
            this.Controls.Add(this.lblRelatedTag);
            this.Controls.Add(this.comboCode);
            this.Controls.Add(this.lblTageCode);
            this.Controls.Add(this.comboBoxRelated);
            this.Controls.Add(this.lblTagName);
            this.Controls.Add(this.comboBoxTagName);
            this.Name = "Form1";
            this.Text = "AddTag";
            this.panelHedding.ResumeLayout(false);
            this.panelHedding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.ComboBox comboBoxTagName;
        private System.Windows.Forms.Label lblTageCode;
        private System.Windows.Forms.ComboBox comboBoxRelated;
        private System.Windows.Forms.Label lblRelatedTag;
        private System.Windows.Forms.ComboBox comboCode;
        private System.Windows.Forms.Panel panelHedding;
        private System.Windows.Forms.Label labelAddTag;
        private System.Windows.Forms.Button btnClearTag;
        private System.Windows.Forms.Button btnSaveTag;
    }
}