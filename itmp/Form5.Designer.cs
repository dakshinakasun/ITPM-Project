
namespace itmp
{
    partial class Form5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lblRegiLec = new System.Windows.Forms.Label();
            this.numUpDowRegiL = new System.Windows.Forms.NumericUpDown();
            this.nuUpDowStudent = new System.Windows.Forms.NumericUpDown();
            this.lblRegiStud = new System.Windows.Forms.Label();
            this.numUpDowSubjects = new System.Windows.Forms.NumericUpDown();
            this.lblRegiSubjects = new System.Windows.Forms.Label();
            this.numUpDownLab = new System.Windows.Forms.NumericUpDown();
            this.lblRegiLab = new System.Windows.Forms.Label();
            this.numUpDowRooms = new System.Windows.Forms.NumericUpDown();
            this.lblRoomsStatics = new System.Windows.Forms.Label();
            this.btnGenerateRepo = new System.Windows.Forms.Button();
            this.chartStatic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblLatestPerInfo = new System.Windows.Forms.Label();
            this.lblLatestLect = new System.Windows.Forms.Label();
            this.txtBoxLatestLect = new System.Windows.Forms.TextBox();
            this.txtBoxlatestGroup = new System.Windows.Forms.TextBox();
            this.lblLatestGroup = new System.Windows.Forms.Label();
            this.txtBoxLatestSub = new System.Windows.Forms.TextBox();
            this.lblLatestSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowRegiL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDowStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Font = new System.Drawing.Font("Segoe UI", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistic.Location = new System.Drawing.Point(162, 9);
            this.lblStatistic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(457, 62);
            this.lblStatistic.TabIndex = 0;
            this.lblStatistic.Text = "Visualizing Statistic";
            // 
            // lblRegiLec
            // 
            this.lblRegiLec.AutoSize = true;
            this.lblRegiLec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiLec.Location = new System.Drawing.Point(51, 120);
            this.lblRegiLec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegiLec.Name = "lblRegiLec";
            this.lblRegiLec.Size = new System.Drawing.Size(148, 21);
            this.lblRegiLec.TabIndex = 1;
            this.lblRegiLec.Text = "Registered Lecturers";
            // 
            // numUpDowRegiL
            // 
            this.numUpDowRegiL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDowRegiL.Location = new System.Drawing.Point(206, 120);
            this.numUpDowRegiL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDowRegiL.Name = "numUpDowRegiL";
            this.numUpDowRegiL.Size = new System.Drawing.Size(90, 26);
            this.numUpDowRegiL.TabIndex = 2;
            // 
            // nuUpDowStudent
            // 
            this.nuUpDowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuUpDowStudent.Location = new System.Drawing.Point(206, 177);
            this.nuUpDowStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nuUpDowStudent.Name = "nuUpDowStudent";
            this.nuUpDowStudent.Size = new System.Drawing.Size(90, 26);
            this.nuUpDowStudent.TabIndex = 4;
            // 
            // lblRegiStud
            // 
            this.lblRegiStud.AutoSize = true;
            this.lblRegiStud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiStud.Location = new System.Drawing.Point(51, 177);
            this.lblRegiStud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegiStud.Name = "lblRegiStud";
            this.lblRegiStud.Size = new System.Drawing.Size(145, 21);
            this.lblRegiStud.TabIndex = 3;
            this.lblRegiStud.Text = "Registered Students";
            // 
            // numUpDowSubjects
            // 
            this.numUpDowSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDowSubjects.Location = new System.Drawing.Point(206, 231);
            this.numUpDowSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDowSubjects.Name = "numUpDowSubjects";
            this.numUpDowSubjects.Size = new System.Drawing.Size(90, 26);
            this.numUpDowSubjects.TabIndex = 6;
            // 
            // lblRegiSubjects
            // 
            this.lblRegiSubjects.AutoSize = true;
            this.lblRegiSubjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiSubjects.Location = new System.Drawing.Point(51, 231);
            this.lblRegiSubjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegiSubjects.Name = "lblRegiSubjects";
            this.lblRegiSubjects.Size = new System.Drawing.Size(142, 21);
            this.lblRegiSubjects.TabIndex = 5;
            this.lblRegiSubjects.Text = "Registered Subjects";
            // 
            // numUpDownLab
            // 
            this.numUpDownLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownLab.Location = new System.Drawing.Point(677, 123);
            this.numUpDownLab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDownLab.Name = "numUpDownLab";
            this.numUpDownLab.Size = new System.Drawing.Size(90, 26);
            this.numUpDownLab.TabIndex = 8;
            // 
            // lblRegiLab
            // 
            this.lblRegiLab.AutoSize = true;
            this.lblRegiLab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiLab.Location = new System.Drawing.Point(477, 124);
            this.lblRegiLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegiLab.Name = "lblRegiLab";
            this.lblRegiLab.Size = new System.Drawing.Size(173, 21);
            this.lblRegiLab.TabIndex = 7;
            this.lblRegiLab.Text = "Registered Laboratories";
            // 
            // numUpDowRooms
            // 
            this.numUpDowRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDowRooms.Location = new System.Drawing.Point(677, 181);
            this.numUpDowRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUpDowRooms.Name = "numUpDowRooms";
            this.numUpDowRooms.Size = new System.Drawing.Size(90, 26);
            this.numUpDowRooms.TabIndex = 10;
            // 
            // lblRoomsStatics
            // 
            this.lblRoomsStatics.AutoSize = true;
            this.lblRoomsStatics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsStatics.Location = new System.Drawing.Point(477, 183);
            this.lblRoomsStatics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomsStatics.Name = "lblRoomsStatics";
            this.lblRoomsStatics.Size = new System.Drawing.Size(133, 21);
            this.lblRoomsStatics.TabIndex = 9;
            this.lblRoomsStatics.Text = "Registered Rooms";
            // 
            // btnGenerateRepo
            // 
            this.btnGenerateRepo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerateRepo.FlatAppearance.BorderSize = 0;
            this.btnGenerateRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRepo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRepo.ForeColor = System.Drawing.Color.White;
            this.btnGenerateRepo.Location = new System.Drawing.Point(661, 51);
            this.btnGenerateRepo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateRepo.Name = "btnGenerateRepo";
            this.btnGenerateRepo.Size = new System.Drawing.Size(162, 50);
            this.btnGenerateRepo.TabIndex = 11;
            this.btnGenerateRepo.Text = "Generate Summary";
            this.btnGenerateRepo.UseVisualStyleBackColor = false;
            this.btnGenerateRepo.Click += new System.EventHandler(this.btnGenerateRepo_Click);
            // 
            // chartStatic
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatic.Legends.Add(legend2);
            this.chartStatic.Location = new System.Drawing.Point(55, 306);
            this.chartStatic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartStatic.Name = "chartStatic";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStatic.Series.Add(series2);
            this.chartStatic.Size = new System.Drawing.Size(225, 244);
            this.chartStatic.TabIndex = 12;
            this.chartStatic.Text = "chart1";
            this.chartStatic.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblLatestPerInfo
            // 
            this.lblLatestPerInfo.AutoSize = true;
            this.lblLatestPerInfo.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestPerInfo.Location = new System.Drawing.Point(588, 316);
            this.lblLatestPerInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatestPerInfo.Name = "lblLatestPerInfo";
            this.lblLatestPerInfo.Size = new System.Drawing.Size(217, 30);
            this.lblLatestPerInfo.TabIndex = 13;
            this.lblLatestPerInfo.Text = "Latest Personal Info";
            // 
            // lblLatestLect
            // 
            this.lblLatestLect.AutoSize = true;
            this.lblLatestLect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestLect.Location = new System.Drawing.Point(525, 376);
            this.lblLatestLect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatestLect.Name = "lblLatestLect";
            this.lblLatestLect.Size = new System.Drawing.Size(100, 19);
            this.lblLatestLect.TabIndex = 14;
            this.lblLatestLect.Text = "Latest Lacturer";
            this.lblLatestLect.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxLatestLect
            // 
            this.txtBoxLatestLect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLatestLect.Location = new System.Drawing.Point(645, 372);
            this.txtBoxLatestLect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxLatestLect.Multiline = true;
            this.txtBoxLatestLect.Name = "txtBoxLatestLect";
            this.txtBoxLatestLect.Size = new System.Drawing.Size(178, 38);
            this.txtBoxLatestLect.TabIndex = 15;
            // 
            // txtBoxlatestGroup
            // 
            this.txtBoxlatestGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxlatestGroup.Location = new System.Drawing.Point(645, 440);
            this.txtBoxlatestGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxlatestGroup.Multiline = true;
            this.txtBoxlatestGroup.Name = "txtBoxlatestGroup";
            this.txtBoxlatestGroup.Size = new System.Drawing.Size(178, 33);
            this.txtBoxlatestGroup.TabIndex = 17;
            // 
            // lblLatestGroup
            // 
            this.lblLatestGroup.AutoSize = true;
            this.lblLatestGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestGroup.Location = new System.Drawing.Point(525, 444);
            this.lblLatestGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatestGroup.Name = "lblLatestGroup";
            this.lblLatestGroup.Size = new System.Drawing.Size(89, 19);
            this.lblLatestGroup.TabIndex = 16;
            this.lblLatestGroup.Text = "Latest Group";
            this.lblLatestGroup.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxLatestSub
            // 
            this.txtBoxLatestSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLatestSub.Location = new System.Drawing.Point(645, 508);
            this.txtBoxLatestSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxLatestSub.Multiline = true;
            this.txtBoxLatestSub.Name = "txtBoxLatestSub";
            this.txtBoxLatestSub.Size = new System.Drawing.Size(178, 36);
            this.txtBoxLatestSub.TabIndex = 19;
            // 
            // lblLatestSubject
            // 
            this.lblLatestSubject.AutoSize = true;
            this.lblLatestSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestSubject.Location = new System.Drawing.Point(525, 508);
            this.lblLatestSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatestSubject.Name = "lblLatestSubject";
            this.lblLatestSubject.Size = new System.Drawing.Size(94, 19);
            this.lblLatestSubject.TabIndex = 18;
            this.lblLatestSubject.Text = "Latest Subject";
            this.lblLatestSubject.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(867, 607);
            this.Controls.Add(this.txtBoxLatestSub);
            this.Controls.Add(this.lblLatestSubject);
            this.Controls.Add(this.txtBoxlatestGroup);
            this.Controls.Add(this.lblLatestGroup);
            this.Controls.Add(this.txtBoxLatestLect);
            this.Controls.Add(this.lblLatestLect);
            this.Controls.Add(this.lblLatestPerInfo);
            this.Controls.Add(this.chartStatic);
            this.Controls.Add(this.btnGenerateRepo);
            this.Controls.Add(this.numUpDowRooms);
            this.Controls.Add(this.lblRoomsStatics);
            this.Controls.Add(this.numUpDownLab);
            this.Controls.Add(this.lblRegiLab);
            this.Controls.Add(this.numUpDowSubjects);
            this.Controls.Add(this.lblRegiSubjects);
            this.Controls.Add(this.nuUpDowStudent);
            this.Controls.Add(this.lblRegiStud);
            this.Controls.Add(this.numUpDowRegiL);
            this.Controls.Add(this.lblRegiLec);
            this.Controls.Add(this.lblStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowRegiL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDowStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDowRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Label lblRegiLec;
        private System.Windows.Forms.NumericUpDown numUpDowRegiL;
        private System.Windows.Forms.NumericUpDown nuUpDowStudent;
        private System.Windows.Forms.Label lblRegiStud;
        private System.Windows.Forms.NumericUpDown numUpDowSubjects;
        private System.Windows.Forms.Label lblRegiSubjects;
        private System.Windows.Forms.NumericUpDown numUpDownLab;
        private System.Windows.Forms.Label lblRegiLab;
        private System.Windows.Forms.NumericUpDown numUpDowRooms;
        private System.Windows.Forms.Label lblRoomsStatics;
        private System.Windows.Forms.Button btnGenerateRepo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatic;
        private System.Windows.Forms.Label lblLatestPerInfo;
        private System.Windows.Forms.Label lblLatestLect;
        private System.Windows.Forms.TextBox txtBoxLatestLect;
        private System.Windows.Forms.TextBox txtBoxlatestGroup;
        private System.Windows.Forms.Label lblLatestGroup;
        private System.Windows.Forms.TextBox txtBoxLatestSub;
        private System.Windows.Forms.Label lblLatestSubject;
    }
}