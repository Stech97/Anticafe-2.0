namespace CloseProject
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
            this.SumPrazdnik = new System.Windows.Forms.TextBox();
            this.LSumPrazdnik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LND
            // 
            this.LND.AutoSize = true;
            this.LND.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LND.Location = new System.Drawing.Point(20, 18);
            this.LND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LND.Name = "LND";
            this.LND.Size = new System.Drawing.Size(269, 52);
            this.LND.TabIndex = 3;
            this.LND.Text = "Начало дня:";
            // 
            // ND
            // 
            this.ND.AutoSize = true;
            this.ND.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ND.Location = new System.Drawing.Point(293, 18);
            this.ND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(46, 52);
            this.ND.TabIndex = 4;
            this.ND.Text = "0";
            // 
            // LZ
            // 
            this.LZ.AutoSize = true;
            this.LZ.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LZ.Location = new System.Drawing.Point(20, 74);
            this.LZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LZ.Name = "LZ";
            this.LZ.Size = new System.Drawing.Size(217, 52);
            this.LZ.TabIndex = 5;
            this.LZ.Text = "Z-отчёт:";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Z.Location = new System.Drawing.Point(233, 74);
            this.Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(46, 52);
            this.Z.TabIndex = 6;
            this.Z.Text = "0";
            // 
            // Lrashod
            // 
            this.Lrashod.AutoSize = true;
            this.Lrashod.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lrashod.Location = new System.Drawing.Point(20, 199);
            this.Lrashod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lrashod.Name = "Lrashod";
            this.Lrashod.Size = new System.Drawing.Size(202, 52);
            this.Lrashod.TabIndex = 7;
            this.Lrashod.Text = "Расходы:";
            // 
            // Rashod
            // 
            this.Rashod.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rashod.Location = new System.Drawing.Point(233, 199);
            this.Rashod.Margin = new System.Windows.Forms.Padding(4);
            this.Rashod.MaxLength = 10;
            this.Rashod.Name = "Rashod";
            this.Rashod.Size = new System.Drawing.Size(325, 59);
            this.Rashod.TabIndex = 1;
            this.Rashod.TextChanged += new System.EventHandler(this.Rashod_TextChanged);
            // 
            // LItog
            // 
            this.LItog.AutoSize = true;
            this.LItog.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LItog.Location = new System.Drawing.Point(20, 269);
            this.LItog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LItog.Name = "LItog";
            this.LItog.Size = new System.Drawing.Size(170, 52);
            this.LItog.TabIndex = 11;
            this.LItog.Text = "Итого:";
            // 
            // Itog
            // 
            this.Itog.AutoSize = true;
            this.Itog.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Itog.Location = new System.Drawing.Point(203, 269);
            this.Itog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Itog.Name = "Itog";
            this.Itog.Size = new System.Drawing.Size(57, 52);
            this.Itog.TabIndex = 12;
            this.Itog.Text = " 0";
            // 
            // EndSmena
            // 
            this.EndSmena.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EndSmena.Location = new System.Drawing.Point(93, 369);
            this.EndSmena.Margin = new System.Windows.Forms.Padding(4);
            this.EndSmena.Name = "EndSmena";
            this.EndSmena.Size = new System.Drawing.Size(600, 85);
            this.EndSmena.TabIndex = 13;
            this.EndSmena.Text = "Я молодец! Я закончил смену!";
            this.EndSmena.UseVisualStyleBackColor = true;
            this.EndSmena.Click += new System.EventHandler(this.EndSmena_Click);
            // 
            // SumPrazdnik
            // 
            this.SumPrazdnik.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SumPrazdnik.Location = new System.Drawing.Point(452, 135);
            this.SumPrazdnik.Margin = new System.Windows.Forms.Padding(4);
            this.SumPrazdnik.MaxLength = 10;
            this.SumPrazdnik.Name = "SumPrazdnik";
            this.SumPrazdnik.Size = new System.Drawing.Size(325, 59);
            this.SumPrazdnik.TabIndex = 14;
            this.SumPrazdnik.TextChanged += new System.EventHandler(this.SumPrazdnik_TextChanged);
            // 
            // LSumPrazdnik
            // 
            this.LSumPrazdnik.AutoSize = true;
            this.LSumPrazdnik.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LSumPrazdnik.Location = new System.Drawing.Point(20, 136);
            this.LSumPrazdnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSumPrazdnik.Name = "LSumPrazdnik";
            this.LSumPrazdnik.Size = new System.Drawing.Size(418, 52);
            this.LSumPrazdnik.TabIndex = 15;
            this.LSumPrazdnik.Text = "Предоплата по ДР:";
            // 
            // smenaEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.SumPrazdnik);
            this.Controls.Add(this.LSumPrazdnik);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox SumPrazdnik;
        private System.Windows.Forms.Label LSumPrazdnik;
    }
}