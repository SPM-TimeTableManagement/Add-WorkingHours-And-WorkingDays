namespace Add_WorkingHours_And_WorkingDays
{
    partial class Form2
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnWeekend = new System.Windows.Forms.Button();
            this.btnWeekday = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnView);
            this.panel.Controls.Add(this.btnEdit);
            this.panel.Controls.Add(this.btnWeekend);
            this.panel.Controls.Add(this.btnWeekday);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1225, 79);
            this.panel.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(864, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(361, 79);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(534, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(367, 79);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnWeekend
            // 
            this.btnWeekend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWeekend.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekend.Location = new System.Drawing.Point(282, 0);
            this.btnWeekend.Name = "btnWeekend";
            this.btnWeekend.Size = new System.Drawing.Size(252, 79);
            this.btnWeekend.TabIndex = 1;
            this.btnWeekend.Text = "WeekEnd";
            this.btnWeekend.UseVisualStyleBackColor = false;
            this.btnWeekend.Click += new System.EventHandler(this.btnWeekend_Click);
            // 
            // btnWeekday
            // 
            this.btnWeekday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWeekday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekday.Location = new System.Drawing.Point(0, 0);
            this.btnWeekday.Name = "btnWeekday";
            this.btnWeekday.Size = new System.Drawing.Size(282, 79);
            this.btnWeekday.TabIndex = 0;
            this.btnWeekday.Text = "WeekDay";
            this.btnWeekday.UseVisualStyleBackColor = false;
            this.btnWeekday.Click += new System.EventHandler(this.btnWeekday_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 797);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 876);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnWeekend;
        private System.Windows.Forms.Button btnWeekday;
        private System.Windows.Forms.Panel panel2;
    }
}