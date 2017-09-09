namespace Anticafe_2._0
{
    partial class guestOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guestOut));
            this.flayer = new System.Windows.Forms.CheckBox();
            this.Sum = new System.Windows.Forms.Label();
            this.TimeOutput = new System.Windows.Forms.Label();
            this.TimeInput = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.Ltax = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.outVis = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Label();
            this.GuestIn = new System.Windows.Forms.TextBox();
            this.Minus = new System.Windows.Forms.Label();
            this.LTimeInput = new System.Windows.Forms.Label();
            this.LTimeOutput = new System.Windows.Forms.Label();
            this.Lsum = new System.Windows.Forms.Label();
            this.SumCalc = new System.Windows.Forms.Label();
            this.Antiout = new System.Windows.Forms.Label();
            this.ravno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flayer
            // 
            this.flayer.AutoSize = true;
            this.flayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flayer.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.flayer.Location = new System.Drawing.Point(25, 205);
            this.flayer.Name = "flayer";
            this.flayer.Size = new System.Drawing.Size(204, 50);
            this.flayer.TabIndex = 43;
            this.flayer.Text = "Флаер     ";
            this.flayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flayer.UseVisualStyleBackColor = true;
            this.flayer.CheckedChanged += new System.EventHandler(this.flayer_CheckedChanged);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.ForeColor = System.Drawing.Color.Red;
            this.Sum.Location = new System.Drawing.Point(150, 250);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(0, 46);
            this.Sum.TabIndex = 40;
            // 
            // TimeOutput
            // 
            this.TimeOutput.AutoSize = true;
            this.TimeOutput.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOutput.Location = new System.Drawing.Point(230, 160);
            this.TimeOutput.Name = "TimeOutput";
            this.TimeOutput.Size = new System.Drawing.Size(0, 46);
            this.TimeOutput.TabIndex = 39;
            // 
            // TimeInput
            // 
            this.TimeInput.AutoSize = true;
            this.TimeInput.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeInput.Location = new System.Drawing.Point(265, 115);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(0, 46);
            this.TimeInput.TabIndex = 38;
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tax.FormattingEnabled = true;
            this.tax.Items.AddRange(new object[] {
            "Обычный",
            "Студенческий",
            "Детский"});
            this.tax.Location = new System.Drawing.Point(150, 60);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(221, 54);
            this.tax.TabIndex = 34;
            this.tax.SelectedIndexChanged += new System.EventHandler(this.tax_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(114, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 46);
            this.name.TabIndex = 32;
            // 
            // Ltax
            // 
            this.Ltax.AutoSize = true;
            this.Ltax.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ltax.Location = new System.Drawing.Point(25, 60);
            this.Ltax.Name = "Ltax";
            this.Ltax.Size = new System.Drawing.Size(147, 46);
            this.Ltax.TabIndex = 31;
            this.Ltax.Text = "Тариф:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(24, 14);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(112, 46);
            this.LName.TabIndex = 29;
            this.LName.Text = "Имя:";
            // 
            // outVis
            // 
            this.outVis.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outVis.Location = new System.Drawing.Point(100, 450);
            this.outVis.Name = "outVis";
            this.outVis.Size = new System.Drawing.Size(250, 90);
            this.outVis.TabIndex = 28;
            this.outVis.Text = "Гость ушел :-(";
            this.outVis.UseVisualStyleBackColor = true;
            this.outVis.Click += new System.EventHandler(this.outVis_Click);
            // 
            // Calc
            // 
            this.Calc.AutoSize = true;
            this.Calc.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Calc.Location = new System.Drawing.Point(25, 295);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(394, 46);
            this.Calc.TabIndex = 48;
            this.Calc.Text = "Мини -  калькулятор";
            // 
            // GuestIn
            // 
            this.GuestIn.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GuestIn.Location = new System.Drawing.Point(25, 350);
            this.GuestIn.MaxLength = 4;
            this.GuestIn.Name = "GuestIn";
            this.GuestIn.Size = new System.Drawing.Size(100, 53);
            this.GuestIn.TabIndex = 2;
            this.GuestIn.TextChanged += new System.EventHandler(this.GuestInMoney_TextChanged);
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Minus.Location = new System.Drawing.Point(125, 350);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(33, 46);
            this.Minus.TabIndex = 50;
            this.Minus.Text = "-";
            // 
            // LTimeInput
            // 
            this.LTimeInput.AutoSize = true;
            this.LTimeInput.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTimeInput.Location = new System.Drawing.Point(25, 115);
            this.LTimeInput.Name = "LTimeInput";
            this.LTimeInput.Size = new System.Drawing.Size(307, 46);
            this.LTimeInput.TabIndex = 47;
            this.LTimeInput.Text = "Время прихода: ";
            // 
            // LTimeOutput
            // 
            this.LTimeOutput.AutoSize = true;
            this.LTimeOutput.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTimeOutput.Location = new System.Drawing.Point(25, 160);
            this.LTimeOutput.Name = "LTimeOutput";
            this.LTimeOutput.Size = new System.Drawing.Size(250, 46);
            this.LTimeOutput.TabIndex = 46;
            this.LTimeOutput.Text = "Время ухода:";
            // 
            // Lsum
            // 
            this.Lsum.AutoSize = true;
            this.Lsum.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lsum.Location = new System.Drawing.Point(25, 250);
            this.Lsum.Name = "Lsum";
            this.Lsum.Size = new System.Drawing.Size(151, 46);
            this.Lsum.TabIndex = 51;
            this.Lsum.Text = "Итого:";
            // 
            // SumCalc
            // 
            this.SumCalc.AutoSize = true;
            this.SumCalc.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SumCalc.Location = new System.Drawing.Point(145, 350);
            this.SumCalc.Name = "SumCalc";
            this.SumCalc.Size = new System.Drawing.Size(0, 46);
            this.SumCalc.TabIndex = 52;
            // 
            // Antiout
            // 
            this.Antiout.AutoSize = true;
            this.Antiout.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Antiout.Location = new System.Drawing.Point(235, 350);
            this.Antiout.Name = "Antiout";
            this.Antiout.Size = new System.Drawing.Size(0, 46);
            this.Antiout.TabIndex = 54;
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ravno.Location = new System.Drawing.Point(205, 350);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(43, 46);
            this.ravno.TabIndex = 55;
            this.ravno.Text = "=";
            // 
            // guestOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(434, 566);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.Antiout);
            this.Controls.Add(this.SumCalc);
            this.Controls.Add(this.Lsum);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.GuestIn);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.LTimeInput);
            this.Controls.Add(this.LTimeOutput);
            this.Controls.Add(this.flayer);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.TimeOutput);
            this.Controls.Add(this.TimeInput);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Ltax);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.outVis);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guestOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гость уходит";
            this.Load += new System.EventHandler(this.guestOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox flayer;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label TimeOutput;
        private System.Windows.Forms.Label TimeInput;
        private System.Windows.Forms.ComboBox tax;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Ltax;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button outVis;
        private System.Windows.Forms.Label Calc;
        private System.Windows.Forms.TextBox GuestIn;
        private System.Windows.Forms.Label Minus;
        private System.Windows.Forms.Label LTimeInput;
        private System.Windows.Forms.Label LTimeOutput;
        private System.Windows.Forms.Label Lsum;
        private System.Windows.Forms.Label SumCalc;
        private System.Windows.Forms.Label Antiout;
        private System.Windows.Forms.Label ravno;
    }
}