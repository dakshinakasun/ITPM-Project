
namespace StudentAndTagProject
{
    partial class parallel
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
            this.btnpcon = new System.Windows.Forms.Button();
            this.btnpover = new System.Windows.Forms.Button();
            this.btnppar = new System.Windows.Forms.Button();
            this.iTPMDataSet2 = new StudentAndTagProject.ITPMDataSet2();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new StudentAndTagProject.ITPMDataSet2TableAdapters.SessionTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iTPMDataSet8 = new StudentAndTagProject.ITPMDataSet8();
            this.concecutiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concecutiveTableAdapter = new StudentAndTagProject.ITPMDataSet8TableAdapters.concecutiveTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session And Not Available Times Allocation";
            // 
            // btnpcon
            // 
            this.btnpcon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpcon.Location = new System.Drawing.Point(141, 136);
            this.btnpcon.Name = "btnpcon";
            this.btnpcon.Size = new System.Drawing.Size(160, 47);
            this.btnpcon.TabIndex = 1;
            this.btnpcon.Text = "Consecutive";
            this.btnpcon.UseVisualStyleBackColor = true;
            // 
            // btnpover
            // 
            this.btnpover.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpover.Location = new System.Drawing.Point(452, 136);
            this.btnpover.Name = "btnpover";
            this.btnpover.Size = new System.Drawing.Size(160, 47);
            this.btnpover.TabIndex = 2;
            this.btnpover.Text = "Non overlapping";
            this.btnpover.UseVisualStyleBackColor = true;
            // 
            // btnppar
            // 
            this.btnppar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnppar.Location = new System.Drawing.Point(297, 136);
            this.btnppar.Name = "btnppar";
            this.btnppar.Size = new System.Drawing.Size(160, 47);
            this.btnppar.TabIndex = 3;
            this.btnppar.Text = "Parallel";
            this.btnppar.UseVisualStyleBackColor = true;
            // 
            // iTPMDataSet2
            // 
            this.iTPMDataSet2.DataSetName = "ITPMDataSet2";
            this.iTPMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.iTPMDataSet2;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.studentSubGroupDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.concecutiveBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(141, 215);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(536, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // iTPMDataSet8
            // 
            this.iTPMDataSet8.DataSetName = "ITPMDataSet8";
            this.iTPMDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concecutiveBindingSource
            // 
            this.concecutiveBindingSource.DataMember = "concecutive";
            this.concecutiveBindingSource.DataSource = this.iTPMDataSet8;
            // 
            // concecutiveTableAdapter
            // 
            this.concecutiveTableAdapter.ClearBeforeFill = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 125;
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
            // parallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 607);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnppar);
            this.Controls.Add(this.btnpover);
            this.Controls.Add(this.btnpcon);
            this.Controls.Add(this.label1);
            this.Name = "parallel";
            this.Text = "parallel";
            this.Load += new System.EventHandler(this.parallel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTPMDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concecutiveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpcon;
        private System.Windows.Forms.Button btnpover;
        private System.Windows.Forms.Button btnppar;
        private ITPMDataSet2 iTPMDataSet2;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private ITPMDataSet2TableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ITPMDataSet8 iTPMDataSet8;
        private System.Windows.Forms.BindingSource concecutiveBindingSource;
        private ITPMDataSet8TableAdapters.concecutiveTableAdapter concecutiveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
    }
}