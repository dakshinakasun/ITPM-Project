
namespace Time_Table_Management
{
    partial class TimeSlots
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeToPicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tsdgv = new System.Windows.Forms.DataGridView();
            this.radioButtononehour = new System.Windows.Forms.RadioButton();
            this.radioButton30min = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tsdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(912, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD / MANAGE TIME SLOTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimeFromPicker
            // 
            this.dateTimeFromPicker.CustomFormat = "hh:mm";
            this.dateTimeFromPicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFromPicker.Location = new System.Drawing.Point(232, 438);
            this.dateTimeFromPicker.Name = "dateTimeFromPicker";
            this.dateTimeFromPicker.ShowUpDown = true;
            this.dateTimeFromPicker.Size = new System.Drawing.Size(181, 30);
            this.dateTimeFromPicker.TabIndex = 23;
            // 
            // dateTimeToPicker
            // 
            this.dateTimeToPicker.CustomFormat = "hh:mm";
            this.dateTimeToPicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeToPicker.Location = new System.Drawing.Point(232, 480);
            this.dateTimeToPicker.Name = "dateTimeToPicker";
            this.dateTimeToPicker.ShowUpDown = true;
            this.dateTimeToPicker.Size = new System.Drawing.Size(181, 30);
            this.dateTimeToPicker.TabIndex = 24;
            this.dateTimeToPicker.Value = new System.DateTime(2021, 3, 10, 2, 12, 0, 0);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(661, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 60);
            this.button3.TabIndex = 32;
            this.button3.Text = "Remove Slot";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Starting Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ending Time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(474, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 60);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add Slot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tsdgv
            // 
            this.tsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tsdgv.BackgroundColor = System.Drawing.Color.White;
            this.tsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tsdgv.Location = new System.Drawing.Point(69, 101);
            this.tsdgv.Name = "tsdgv";
            this.tsdgv.RowHeadersWidth = 51;
            this.tsdgv.RowTemplate.Height = 24;
            this.tsdgv.Size = new System.Drawing.Size(773, 220);
            this.tsdgv.TabIndex = 41;
            this.tsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tsdgv_CellContentClick);
            // 
            // radioButtononehour
            // 
            this.radioButtononehour.AutoSize = true;
            this.radioButtononehour.Checked = true;
            this.radioButtononehour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtononehour.Location = new System.Drawing.Point(16, 29);
            this.radioButtononehour.Name = "radioButtononehour";
            this.radioButtononehour.Size = new System.Drawing.Size(156, 32);
            this.radioButtononehour.TabIndex = 42;
            this.radioButtononehour.TabStop = true;
            this.radioButtononehour.Text = "One Hour Slot";
            this.radioButtononehour.UseVisualStyleBackColor = true;
            // 
            // radioButton30min
            // 
            this.radioButton30min.AutoSize = true;
            this.radioButton30min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton30min.Location = new System.Drawing.Point(240, 28);
            this.radioButton30min.Name = "radioButton30min";
            this.radioButton30min.Size = new System.Drawing.Size(158, 32);
            this.radioButton30min.TabIndex = 43;
            this.radioButton30min.TabStop = true;
            this.radioButton30min.Text = "30 Minute Slot";
            this.radioButton30min.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton30min);
            this.groupBox1.Controls.Add(this.radioButtononehour);
            this.groupBox1.Font = new System.Drawing.Font("Lovelo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 75);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtext.Location = new System.Drawing.Point(661, 367);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(181, 30);
            this.idtext.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 28);
            this.label10.TabIndex = 45;
            this.label10.Text = "Enter Slot Id";
            // 
            // TimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tsdgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimeToPicker);
            this.Controls.Add(this.dateTimeFromPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimeSlots";
            this.Text = "Manage Time Slots";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tsdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFromPicker;
        private System.Windows.Forms.DateTimePicker dateTimeToPicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tsdgv;
        private System.Windows.Forms.RadioButton radioButtononehour;
        private System.Windows.Forms.RadioButton radioButton30min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Label label10;
    }
}