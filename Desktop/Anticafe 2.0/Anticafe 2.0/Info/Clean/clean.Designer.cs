namespace Антикафе_2._0.Info.Clean
{
    partial class clean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clean));
            this.Mon = new System.Windows.Forms.Button();
            this.Tue = new System.Windows.Forms.Button();
            this.Wen = new System.Windows.Forms.Button();
            this.The = new System.Windows.Forms.Button();
            this.Fri = new System.Windows.Forms.Button();
            this.Sat = new System.Windows.Forms.Button();
            this.Sun = new System.Windows.Forms.Button();
            this.ДDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.LDayOfWeek = new System.Windows.Forms.Label();
            this.DayOfWeek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mon
            // 
            this.Mon.Location = new System.Drawing.Point(20, 20);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(150, 60);
            this.Mon.TabIndex = 0;
            this.Mon.Text = "Понедельник";
            this.Mon.UseVisualStyleBackColor = true;
            this.Mon.Click += new System.EventHandler(this.Mon_Click);
            // 
            // Tue
            // 
            this.Tue.Location = new System.Drawing.Point(20, 100);
            this.Tue.Name = "Tue";
            this.Tue.Size = new System.Drawing.Size(150, 60);
            this.Tue.TabIndex = 1;
            this.Tue.Text = "Вторник";
            this.Tue.UseVisualStyleBackColor = true;
            this.Tue.Click += new System.EventHandler(this.Tue_Click);
            // 
            // Wen
            // 
            this.Wen.Location = new System.Drawing.Point(20, 180);
            this.Wen.Name = "Wen";
            this.Wen.Size = new System.Drawing.Size(150, 60);
            this.Wen.TabIndex = 2;
            this.Wen.Text = "Среда";
            this.Wen.UseVisualStyleBackColor = true;
            this.Wen.Click += new System.EventHandler(this.Wen_Click);
            // 
            // The
            // 
            this.The.Location = new System.Drawing.Point(20, 260);
            this.The.Name = "The";
            this.The.Size = new System.Drawing.Size(150, 60);
            this.The.TabIndex = 3;
            this.The.Text = "Четверг";
            this.The.UseVisualStyleBackColor = true;
            this.The.Click += new System.EventHandler(this.The_Click);
            // 
            // Fri
            // 
            this.Fri.Location = new System.Drawing.Point(20, 340);
            this.Fri.Name = "Fri";
            this.Fri.Size = new System.Drawing.Size(150, 60);
            this.Fri.TabIndex = 4;
            this.Fri.Text = "Пятница";
            this.Fri.UseVisualStyleBackColor = true;
            this.Fri.Click += new System.EventHandler(this.Fri_Click);
            // 
            // Sat
            // 
            this.Sat.Location = new System.Drawing.Point(20, 420);
            this.Sat.Name = "Sat";
            this.Sat.Size = new System.Drawing.Size(150, 60);
            this.Sat.TabIndex = 5;
            this.Sat.Text = "Суббота";
            this.Sat.UseVisualStyleBackColor = true;
            this.Sat.Click += new System.EventHandler(this.Sat_Click);
            // 
            // Sun
            // 
            this.Sun.Location = new System.Drawing.Point(20, 500);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(150, 60);
            this.Sun.TabIndex = 6;
            this.Sun.Text = "Воскресенье";
            this.Sun.UseVisualStyleBackColor = true;
            this.Sun.Click += new System.EventHandler(this.Sun_Click);
            // 
            // ДDate
            // 
            this.ДDate.AutoSize = true;
            this.ДDate.Location = new System.Drawing.Point(230, 20);
            this.ДDate.Name = "ДDate";
            this.ДDate.Size = new System.Drawing.Size(91, 24);
            this.ДDate.TabIndex = 7;
            this.ДDate.Text = "Сегодня:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(230, 80);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 24);
            this.Date.TabIndex = 8;
            // 
            // LDayOfWeek
            // 
            this.LDayOfWeek.AutoSize = true;
            this.LDayOfWeek.Location = new System.Drawing.Point(230, 140);
            this.LDayOfWeek.Name = "LDayOfWeek";
            this.LDayOfWeek.Size = new System.Drawing.Size(128, 24);
            this.LDayOfWeek.TabIndex = 9;
            this.LDayOfWeek.Text = "День недели:";
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(230, 200);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(0, 24);
            this.DayOfWeek.TabIndex = 10;
            // 
            // clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(392, 586);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.LDayOfWeek);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ДDate);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.Sat);
            this.Controls.Add(this.Fri);
            this.Controls.Add(this.The);
            this.Controls.Add(this.Wen);
            this.Controls.Add(this.Tue);
            this.Controls.Add(this.Mon);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clean";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чистота и Уют";
            this.Load += new System.EventHandler(this.clean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mon;
        private System.Windows.Forms.Button Tue;
        private System.Windows.Forms.Button Wen;
        private System.Windows.Forms.Button The;
        private System.Windows.Forms.Button Fri;
        private System.Windows.Forms.Button Sat;
        private System.Windows.Forms.Button Sun;
        private System.Windows.Forms.Label ДDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label LDayOfWeek;
        private System.Windows.Forms.Label DayOfWeek;

    }
}