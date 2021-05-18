
namespace itmp
{
    partial class Form9
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
            this.dataGridVi = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(775, 551);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(141, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Load";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridVi
            // 
            this.dataGridVi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVi.AutoGenerateColumns = false;
            this.dataGridVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.vS1DataGridViewTextBoxColumn,
            this.vS2DataGridViewTextBoxColumn,
            this.vS3DataGridViewTextBoxColumn,
            this.vS4DataGridViewTextBoxColumn,
            this.vS5DataGridViewTextBoxColumn});
            this.dataGridVi.DataSource = this.tempBindingSource2;
            this.dataGridVi.Location = new System.Drawing.Point(24, 313);
            this.dataGridVi.Name = "dataGridVi";
            this.dataGridVi.RowHeadersWidth = 51;
            this.dataGridVi.RowTemplate.Height = 24;
            this.dataGridVi.Size = new System.Drawing.Size(912, 216);
            this.dataGridVi.TabIndex = 1;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(24, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(892, 266);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // tempBindingSource1
            // 
            this.tempBindingSource1.DataSource = typeof(itmp.Temp);
            // 
            // tempBindingSource
            // 
            this.tempBindingSource.DataSource = typeof(itmp.Temp);
            // 
            // form9BindingSource
            // 
            this.form9BindingSource.DataSource = typeof(itmp.Form9);
            // 
            // tempBindingSource2
            // 
            this.tempBindingSource2.DataSource = typeof(itmp.Temp);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
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
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 609);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridVi);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridVi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.BindingSource form9BindingSource;
        private System.Windows.Forms.BindingSource tempBindingSource;
        private System.Windows.Forms.BindingSource tempBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS5DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tempBindingSource2;
    }
}