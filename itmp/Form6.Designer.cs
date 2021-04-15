
namespace itmp
{
    partial class Form6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(758, 527);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Load";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.vS1DataGridViewTextBoxColumn,
            this.vS2DataGridViewTextBoxColumn,
            this.vS3DataGridViewTextBoxColumn,
            this.vS4DataGridViewTextBoxColumn,
            this.vS5DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.registerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 289);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(860, 214);
            this.dataGridView.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 36);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(860, 235);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(23, 527);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(174, 23);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "VS-Registed Lecturer";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(219, 527);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(176, 23);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "VS-Registed Students";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(423, 527);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(145, 23);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "VS-Registed Labs";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(23, 575);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(172, 23);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "VS-Registed Subjects";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "VS-Registed Rooms";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // vS1DataGridViewTextBoxColumn
            // 
            this.vS1DataGridViewTextBoxColumn.DataPropertyName = "VS1";
            this.vS1DataGridViewTextBoxColumn.HeaderText = "VS1";
            this.vS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vS1DataGridViewTextBoxColumn.Name = "vS1DataGridViewTextBoxColumn";
            this.vS1DataGridViewTextBoxColumn.Width = 125;
            // 
            // vS2DataGridViewTextBoxColumn
            // 
            this.vS2DataGridViewTextBoxColumn.DataPropertyName = "VS2";
            this.vS2DataGridViewTextBoxColumn.HeaderText = "VS2";
            this.vS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vS2DataGridViewTextBoxColumn.Name = "vS2DataGridViewTextBoxColumn";
            this.vS2DataGridViewTextBoxColumn.Width = 125;
            // 
            // vS3DataGridViewTextBoxColumn
            // 
            this.vS3DataGridViewTextBoxColumn.DataPropertyName = "VS3";
            this.vS3DataGridViewTextBoxColumn.HeaderText = "VS3";
            this.vS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vS3DataGridViewTextBoxColumn.Name = "vS3DataGridViewTextBoxColumn";
            this.vS3DataGridViewTextBoxColumn.Width = 125;
            // 
            // vS4DataGridViewTextBoxColumn
            // 
            this.vS4DataGridViewTextBoxColumn.DataPropertyName = "VS4";
            this.vS4DataGridViewTextBoxColumn.HeaderText = "VS4";
            this.vS4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vS4DataGridViewTextBoxColumn.Name = "vS4DataGridViewTextBoxColumn";
            this.vS4DataGridViewTextBoxColumn.Width = 125;
            // 
            // vS5DataGridViewTextBoxColumn
            // 
            this.vS5DataGridViewTextBoxColumn.DataPropertyName = "VS5";
            this.vS5DataGridViewTextBoxColumn.HeaderText = "VS5";
            this.vS5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vS5DataGridViewTextBoxColumn.Name = "vS5DataGridViewTextBoxColumn";
            this.vS5DataGridViewTextBoxColumn.Width = 125;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataSource = typeof(itmp.Register);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visulization Statistic";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS5DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource registerBindingSource;
    }
}