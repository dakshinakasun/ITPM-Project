
namespace itmp
{
    partial class Form8
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
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.lblSessions = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSession
            // 
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Location = new System.Drawing.Point(12, 163);
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.RowHeadersWidth = 51;
            this.dataGridSession.RowTemplate.Height = 24;
            this.dataGridSession.Size = new System.Drawing.Size(1271, 350);
            this.dataGridSession.TabIndex = 0;
            this.dataGridSession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSession_CellContentClick);
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Font = new System.Drawing.Font("Segoe UI", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessions.Location = new System.Drawing.Point(542, 13);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(250, 77);
            this.lblSessions.TabIndex = 3;
            this.lblSessions.Text = "Sessions";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(245, 571);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(175, 62);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1351, 676);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lblSessions);
            this.Controls.Add(this.dataGridSession);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.Button btnAddRoom;
    }
}