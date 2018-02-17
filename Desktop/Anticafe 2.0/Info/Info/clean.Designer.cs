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
            this.TaskData = new System.Data.DataSet();
            this.TASK = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).BeginInit();
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
            // TaskData
            // 
            this.TaskData.DataSetName = "NewDataSet";
            // 
            // TASK
            // 
            this.TASK.FormattingEnabled = true;
            this.TASK.Location = new System.Drawing.Point(12, 64);
            this.TASK.Name = "TASK";
            this.TASK.Size = new System.Drawing.Size(704, 433);
            this.TASK.TabIndex = 11;
            // 
            // clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(728, 513);
            this.Controls.Add(this.TASK);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.LDayOfWeek);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задания";
            this.Load += new System.EventHandler(this.clean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LDayOfWeek;
        private System.Windows.Forms.Label DayOfWeek;
        private System.Data.DataSet TaskData;
        private System.Windows.Forms.CheckedListBox TASK;
    }
}