
namespace StudentAndTagProject
{
    partial class session
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet = new StudentAndTagProject.ITPMDataSet();
            this.btncon = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaddSession = new System.Windows.Forms.Button();
            this.sessionTableAdapter = new StudentAndTagProject.ITPMDataSetTableAdapters.SessionTableAdapter();
            this.sessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet1 = new StudentAndTagProject.ITPMDataSet1();
            this.sessionTableAdapter1 = new StudentAndTagProject.ITPMDataSet1TableAdapters.SessionTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concecutiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet5 = new StudentAndTagProject.ITPMDataSet5();
            this.sessionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iTPMDataSet3 = new StudentAndTagProject.ITPMDataSet3();
            this.sessionTableAdapter2 = new StudentAndTagProject.ITPMDataSet3TableAdapters.SessionTableAdapter();
            this.concecutiveTableAdapter = new StudentAndTagProject.ITPMDataSet5TableAdapters.concecutiveTableAdapter();
            this.iTPMDataSet7 = new StudentAndTagProject.ITPMDataSet7();
            this.concecutiveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.concecutiveTableAdapter1 = new StudentAndTagProject.ITPMDataSet7TableAdapters.concecutiveTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sessions And Not Available Times Allocation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.iTPMDataSet;
            // 
            // iTPMDataSet
            // 
            this.iTPMDataSet.DataSetName = "ITPMDataSet";
            this.iTPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncon
            // 
            this.btncon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.Location = new System.Drawing.Point(28, 113);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(160, 47);
            this.btncon.TabIndex = 2;
            this.btncon.Text = "Consecutive";
            this.btncon.UseVisualStyleBackColor = true;
            // 
            // btnpara
            // 
            this.btnpara.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpara.Location = new System.Drawing.Point(185, 113);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(160, 47);
            this.btnpara.TabIndex = 3;
            this.btnpara.Text = "Parallel";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Non overlapping ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnaddSession
            // 
            this.btnaddSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddSession.Location = new System.Drawing.Point(322, 396);
            this.btnaddSession.Name = "btnaddSession";
            this.btnaddSession.Size = new System.Drawing.Size(175, 48);
            this.btnaddSession.TabIndex = 5;
            this.btnaddSession.Text = "ADD SESSION";
            this.btnaddSession.UseVisualStyleBackColor = true;
            this.btnaddSession.Click += new System.EventHandler(this.btnaddSession_Click);
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // sessionBindingSource1
            // 
            this.sessionBindingSource1.DataMember = "Session";
            this.sessionBindingSource1.DataSource = this.iTPMDataSet1;
            // 
            // iTPMDataSet1
            // 
            this.iTPMDataSet1.DataSetName = "ITPMDataSet1";
            this.iTPMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTableAdapter1
            // 
            this.sessionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagDataGridViewTextBoxColumn,
            this.studentSubGroupDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.concecutiveBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentSubGroupDataGridViewTextBoxColumn
            // 
            this.studentSubGroupDataGridViewTextBoxColumn.DataPropertyName = "StudentSubGroup";
            this.studentSubGroupDataGridViewTextBoxColumn.HeaderText = "StudentSubGroup";
            this.studentSubGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSubGroupDataGridViewTextBoxColumn.Name = "studentSubGroupDataGridViewTextBoxColumn";
            this.studentSubGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // concecutiveBindingSource
            // 
            this.concecutiveBindingSource.DataMember = "concecutive";
            this.concecutiveBindingSource.DataSource = this.iTPMDataSet5;
            // 
            // iTPMDataSet5
            // 
            this.iTPMDataSet5.DataSetName = "ITPMDataSet5";
            this.iTPMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource2
            // 
            this.sessionBindingSource2.DataMember = "Session";
            this.sessionBindingSource2.DataSource = this.iTPMDataSet3;
            // 
            // iTPMDataSet3
            // 
            this.iTPMDataSet3.DataSetName = "ITPMDataSet3";
            this.iTPMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTableAdapter2
            // 
            this.sessionTableAdapter2.ClearBeforeFill = true;
            // 
            // concecutiveTableAdapter
            // 
            this.concecutiveTableAdapter.ClearBeforeFill = true;
            // 
            // iTPMDataSet7
            // 
            this.iTPMDataSet7.DataSetName = "ITPMDataSet7";
            this.iTPMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concecutiveBindingSource1
            // 
            this.concecutiveBindingSource1.DataMember = "concecutive";
            this.concecutiveBindingSource1.DataSource = this.iTPMDataSet7;
            // 
            // concecutiveTableAdapter1
            // 
            this.concecutiveTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(912, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaddSession);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.label1);
            this.Name = "session";
            this.Text = "session";
            this.Load += new System.EventHandler(this.session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnaddSession;
        private ITPMDataSet iTPMDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private ITPMDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private ITPMDataSet1 iTPMDataSet1;
        private System.Windows.Forms.BindingSource sessionBindingSource1;
        private ITPMDataSet1TableAdapters.SessionTableAdapter sessionTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ITPMDataSet3 iTPMDataSet3;
        private System.Windows.Forms.BindingSource sessionBindingSource2;
        private ITPMDataSet3TableAdapters.SessionTableAdapter sessionTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private ITPMDataSet5 iTPMDataSet5;
        private System.Windows.Forms.BindingSource concecutiveBindingSource;
        private ITPMDataSet5TableAdapters.concecutiveTableAdapter concecutiveTableAdapter;
        private ITPMDataSet7 iTPMDataSet7;
        private System.Windows.Forms.BindingSource concecutiveBindingSource1;
        private ITPMDataSet7TableAdapters.concecutiveTableAdapter concecutiveTableAdapter1;
        private System.Windows.Forms.Button button2;
    }
}