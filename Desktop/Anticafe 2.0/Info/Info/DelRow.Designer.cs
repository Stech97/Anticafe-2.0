namespace Info
{
    partial class DelRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelRow));
            this.LGuest = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.LPass = new System.Windows.Forms.Label();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.DelGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LGuest
            // 
            this.LGuest.AutoSize = true;
            this.LGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LGuest.Location = new System.Drawing.Point(13, 19);
            this.LGuest.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.LGuest.Name = "LGuest";
            this.LGuest.Size = new System.Drawing.Size(131, 42);
            this.LGuest.TabIndex = 7;
            this.LGuest.Text = "Гость:";
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guest.Location = new System.Drawing.Point(166, 19);
            this.Guest.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(0, 42);
            this.Guest.TabIndex = 8;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPass.Location = new System.Drawing.Point(14, 112);
            this.LPass.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(165, 42);
            this.LPass.TabIndex = 9;
            this.LPass.Text = "Пароль:";
            // 
            // TPassword
            // 
            this.TPassword.Location = new System.Drawing.Point(193, 112);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(334, 49);
            this.TPassword.TabIndex = 10;
            // 
            // DelGuest
            // 
            this.DelGuest.Location = new System.Drawing.Point(134, 220);
            this.DelGuest.Name = "DelGuest";
            this.DelGuest.Size = new System.Drawing.Size(307, 90);
            this.DelGuest.TabIndex = 11;
            this.DelGuest.Text = "Удалить гостя";
            this.DelGuest.UseVisualStyleBackColor = true;
            this.DelGuest.Click += new System.EventHandler(this.DelGuest_Click);
            // 
            // DelRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(552, 333);
            this.Controls.Add(this.DelGuest);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.LGuest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "DelRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление гостя";
            this.Load += new System.EventHandler(this.DelGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LGuest;
        private System.Windows.Forms.Label Guest;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button DelGuest;
    }
}