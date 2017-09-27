namespace Info
{
    partial class clean
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clean));
            this.LDayOfWeek = new System.Windows.Forms.Label();
            this.DayOfWeek = new System.Windows.Forms.Label();
            this.Task1 = new System.Windows.Forms.CheckBox();
            this.Task2 = new System.Windows.Forms.CheckBox();
            this.Task3 = new System.Windows.Forms.CheckBox();
            this.Task4 = new System.Windows.Forms.CheckBox();
            this.Task5 = new System.Windows.Forms.CheckBox();
            this.Task6 = new System.Windows.Forms.CheckBox();
            this.Task7 = new System.Windows.Forms.CheckBox();
            this.Task8 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LDayOfWeek
            // 
            this.LDayOfWeek.AutoSize = true;
            this.LDayOfWeek.Location = new System.Drawing.Point(14, 30);
            this.LDayOfWeek.Name = "LDayOfWeek";
            this.LDayOfWeek.Size = new System.Drawing.Size(166, 31);
            this.LDayOfWeek.TabIndex = 9;
            this.LDayOfWeek.Text = "День недели:";
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(176, 30);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(0, 31);
            this.DayOfWeek.TabIndex = 10;
            // 
            // Task1
            // 
            this.Task1.AutoSize = true;
            this.Task1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Task1.Location = new System.Drawing.Point(14, 85);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(18, 17);
            this.Task1.TabIndex = 11;
            this.Task1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Task1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.UseWaitCursor = true;
            // 
            // Task2
            // 
            this.Task2.AutoSize = true;
            this.Task2.Location = new System.Drawing.Point(14, 160);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(18, 17);
            this.Task2.TabIndex = 12;
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // Task3
            // 
            this.Task3.AutoSize = true;
            this.Task3.Location = new System.Drawing.Point(14, 240);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(18, 17);
            this.Task3.TabIndex = 13;
            this.Task3.UseVisualStyleBackColor = true;
            // 
            // Task4
            // 
            this.Task4.AutoSize = true;
            this.Task4.Location = new System.Drawing.Point(14, 320);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(18, 17);
            this.Task4.TabIndex = 14;
            this.Task4.UseVisualStyleBackColor = true;
            // 
            // Task5
            // 
            this.Task5.AutoSize = true;
            this.Task5.Location = new System.Drawing.Point(14, 400);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(18, 17);
            this.Task5.TabIndex = 15;
            this.Task5.UseVisualStyleBackColor = true;
            // 
            // Task6
            // 
            this.Task6.AutoSize = true;
            this.Task6.Location = new System.Drawing.Point(14, 480);
            this.Task6.Name = "Task6";
            this.Task6.Size = new System.Drawing.Size(18, 17);
            this.Task6.TabIndex = 16;
            this.Task6.UseVisualStyleBackColor = true;
            // 
            // Task7
            // 
            this.Task7.AutoSize = true;
            this.Task7.Location = new System.Drawing.Point(14, 560);
            this.Task7.Name = "Task7";
            this.Task7.Size = new System.Drawing.Size(18, 17);
            this.Task7.TabIndex = 17;
            this.Task7.UseVisualStyleBackColor = true;
            // 
            // Task8
            // 
            this.Task8.AutoSize = true;
            this.Task8.Location = new System.Drawing.Point(14, 640);
            this.Task8.Name = "Task8";
            this.Task8.Size = new System.Drawing.Size(18, 17);
            this.Task8.TabIndex = 18;
            this.Task8.UseVisualStyleBackColor = true;
            // 
            // clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1157, 838);
            this.Controls.Add(this.Task8);
            this.Controls.Add(this.Task7);
            this.Controls.Add(this.Task6);
            this.Controls.Add(this.Task5);
            this.Controls.Add(this.Task4);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.LDayOfWeek);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clean";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.clean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LDayOfWeek;
        private System.Windows.Forms.Label DayOfWeek;
        private System.Windows.Forms.CheckBox Task1;
        private System.Windows.Forms.CheckBox Task2;
        private System.Windows.Forms.CheckBox Task3;
        private System.Windows.Forms.CheckBox Task4;
        private System.Windows.Forms.CheckBox Task5;
        private System.Windows.Forms.CheckBox Task6;
        private System.Windows.Forms.CheckBox Task7;
        private System.Windows.Forms.CheckBox Task8;
    }
}