
namespace Time_Table_Management
{
    partial class NonReservable
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.subDrop = new System.Windows.Forms.ComboBox();
            this.roomDrop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dateTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeToPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select a Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select the Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select a Room";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(162, 31);
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 19;
            // 
            // subDrop
            // 
            this.subDrop.FormattingEnabled = true;
            this.subDrop.Items.AddRange(new object[] {
            "Computer Networks",
            "Database Systems",
            "Information Computer Systems",
            "Network Management Systems",
            "Introduction To Programming",
            "Mathematics For Computing",
            "Programming Application Frameworks"});
            this.subDrop.Location = new System.Drawing.Point(198, 274);
            this.subDrop.Name = "subDrop";
            this.subDrop.Size = new System.Drawing.Size(166, 36);
            this.subDrop.TabIndex = 20;
            // 
            // roomDrop
            // 
            this.roomDrop.FormattingEnabled = true;
            this.roomDrop.Items.AddRange(new object[] {
            "N3A - LAB",
            "A506",
            "B406",
            "N3E LAB",
            "13-E",
            "B302"});
            this.roomDrop.Location = new System.Drawing.Point(198, 346);
            this.roomDrop.Name = "roomDrop";
            this.roomDrop.Size = new System.Drawing.Size(166, 36);
            this.roomDrop.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 61);
            this.label2.TabIndex = 53;
            this.label2.Text = "NON RESERVABLE TIMES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 460);
            this.tabControl1.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.roomDrop);
            this.tabPage1.Controls.Add(this.submitBtn);
            this.tabPage1.Controls.Add(this.subDrop);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimeFromPicker);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dateTimeToPicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Times Rooms Are Not Availabe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.BorderSize = 5;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(684, 304);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(144, 56);
            this.clearBtn.TabIndex = 50;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitBtn.FlatAppearance.BorderSize = 5;
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(520, 304);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(144, 56);
            this.submitBtn.TabIndex = 49;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dateTimeFromPicker
            // 
            this.dateTimeFromPicker.CustomFormat = "hh:mm";
            this.dateTimeFromPicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFromPicker.Location = new System.Drawing.Point(646, 36);
            this.dateTimeFromPicker.Name = "dateTimeFromPicker";
            this.dateTimeFromPicker.ShowUpDown = true;
            this.dateTimeFromPicker.Size = new System.Drawing.Size(182, 30);
            this.dateTimeFromPicker.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "Time To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(501, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "Time From";
            // 
            // dateTimeToPicker
            // 
            this.dateTimeToPicker.CustomFormat = "hh:mm";
            this.dateTimeToPicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeToPicker.Location = new System.Drawing.Point(646, 92);
            this.dateTimeToPicker.Name = "dateTimeToPicker";
            this.dateTimeToPicker.ShowUpDown = true;
            this.dateTimeToPicker.Size = new System.Drawing.Size(182, 30);
            this.dateTimeToPicker.TabIndex = 45;
            this.dateTimeToPicker.Value = new System.DateTime(2021, 3, 10, 2, 12, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.idTxt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Not Available Times";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(568, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 56);
            this.button4.TabIndex = 46;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(114, 372);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(142, 30);
            this.idTxt.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 28);
            this.label10.TabIndex = 44;
            this.label10.Text = "Select Id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(695, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 43;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(27, 14);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(810, 330);
            this.dgv.TabIndex = 22;
            // 
            // NonReservable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "NonReservable";
            this.Text = "Room Cannot be Reserved Form";
            this.Load += new System.EventHandler(this.NonReservable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar datePicker;
        private System.Windows.Forms.ComboBox subDrop;
        private System.Windows.Forms.ComboBox roomDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DateTimePicker dateTimeFromPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeToPicker;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
    }
}