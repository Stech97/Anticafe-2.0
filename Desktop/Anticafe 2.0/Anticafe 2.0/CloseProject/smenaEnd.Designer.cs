namespace Антикафе_2._0
{
    partial class smenaEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smenaEnd));
            this.LND = new System.Windows.Forms.Label();
            this.ND = new System.Windows.Forms.Label();
            this.LZ = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.Lrashod = new System.Windows.Forms.Label();
            this.Rashod = new System.Windows.Forms.TextBox();
            this.LItog = new System.Windows.Forms.Label();
            this.Itog = new System.Windows.Forms.Label();
            this.EndSmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LND
            // 
            this.LND.AutoSize = true;
            this.LND.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LND.Location = new System.Drawing.Point(15, 15);
            this.LND.Name = "LND";
            this.LND.Size = new System.Drawing.Size(215, 41);
            this.LND.TabIndex = 3;
            this.LND.Text = "Начало дня:";
            // 
            // ND
            // 
            this.ND.AutoSize = true;
            this.ND.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ND.Location = new System.Drawing.Point(220, 15);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(36, 41);
            this.ND.TabIndex = 4;
            this.ND.Text = "0";
            // 
            // LZ
            // 
            this.LZ.AutoSize = true;
            this.LZ.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LZ.Location = new System.Drawing.Point(15, 60);
            this.LZ.Name = "LZ";
            this.LZ.Size = new System.Drawing.Size(171, 41);
            this.LZ.TabIndex = 5;
            this.LZ.Text = "Z-отчёт:";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Z.Location = new System.Drawing.Point(175, 60);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(36, 41);
            this.Z.TabIndex = 6;
            this.Z.Text = "0";
            // 
            // Lrashod
            // 
            this.Lrashod.AutoSize = true;
            this.Lrashod.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lrashod.Location = new System.Drawing.Point(15, 105);
            this.Lrashod.Name = "Lrashod";
            this.Lrashod.Size = new System.Drawing.Size(163, 41);
            this.Lrashod.TabIndex = 7;
            this.Lrashod.Text = "Расходы:";
            // 
            // Rashod
            // 
            this.Rashod.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rashod.Location = new System.Drawing.Point(175, 105);
            this.Rashod.MaxLength = 10;
            this.Rashod.Name = "Rashod";
            this.Rashod.Size = new System.Drawing.Size(245, 49);
            this.Rashod.TabIndex = 1;
            this.Rashod.TextChanged += new System.EventHandler(this.Rashod_TextChanged);
            // 
            // LItog
            // 
            this.LItog.AutoSize = true;
            this.LItog.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LItog.Location = new System.Drawing.Point(15, 200);
            this.LItog.Name = "LItog";
            this.LItog.Size = new System.Drawing.Size(134, 41);
            this.LItog.TabIndex = 11;
            this.LItog.Text = "Итого:";
            // 
            // Itog
            // 
            this.Itog.AutoSize = true;
            this.Itog.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Itog.Location = new System.Drawing.Point(140, 200);
            this.Itog.Name = "Itog";
            this.Itog.Size = new System.Drawing.Size(27, 41);
            this.Itog.TabIndex = 12;
            this.Itog.Text = " ";
            // 
            // EndSmena
            // 
            this.EndSmena.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EndSmena.Location = new System.Drawing.Point(70, 300);
            this.EndSmena.Name = "EndSmena";
            this.EndSmena.Size = new System.Drawing.Size(450, 69);
            this.EndSmena.TabIndex = 13;
            this.EndSmena.Text = "Я молодец! Я закончил смену!";
            this.EndSmena.UseVisualStyleBackColor = true;
            this.EndSmena.Click += new System.EventHandler(this.EndSmena_Click);
            // 
            // smenaEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.EndSmena);
            this.Controls.Add(this.Itog);
            this.Controls.Add(this.LItog);
            this.Controls.Add(this.Rashod);
            this.Controls.Add(this.Lrashod);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.LZ);
            this.Controls.Add(this.ND);
            this.Controls.Add(this.LND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "smenaEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конец смены";
            this.Load += new System.EventHandler(this.smenaEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LND;
        private System.Windows.Forms.Label ND;
        private System.Windows.Forms.Label LZ;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label Lrashod;
        private System.Windows.Forms.TextBox Rashod;
        private System.Windows.Forms.Label LItog;
        private System.Windows.Forms.Label Itog;
        private System.Windows.Forms.Button EndSmena;
    }
}