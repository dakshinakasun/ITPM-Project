
namespace itmp
{
    partial class Form10
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
            this.lblVS = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vS5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temptureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temptureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(835, 575);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(132, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Load";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.vS1DataGridViewTextBoxColumn,
            this.vS2DataGridViewTextBoxColumn,
            this.vS3DataGridViewTextBoxColumn,
            this.vS4DataGridViewTextBoxColumn,
            this.vS5DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.temptureBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 313);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(955, 242);
            this.dataGridView.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 76);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(955, 231);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(269, 6);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(490, 67);
            this.lblVS.TabIndex = 3;
            this.lblVS.Text = "Visualization Statistic";
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Location = new System.Drawing.Point(973, 91);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(165, 17);
            this.lblLecturer.TabIndex = 4;
            this.lblLecturer.Text = "VS1-Registered Lecturer";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(973, 133);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "VS2-Registered Student";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(973, 182);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(159, 17);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "VS3-Registered Subject";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(973, 226);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(156, 17);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "VS4-Registered Rooms";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(973, 272);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(143, 17);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "VS5-Registered Labs";
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
            // temptureBindingSource
            // 
            this.temptureBindingSource.DataSource = typeof(itmp.Tempture);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1147, 643);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temptureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vS5DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource temptureBindingSource;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
    }
}