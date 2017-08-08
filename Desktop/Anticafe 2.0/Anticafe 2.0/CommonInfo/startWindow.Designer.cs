namespace Антикафе_2._0
{
    partial class Start
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.NDLabel = new System.Windows.Forms.Label();
            this.SmenaLabel = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.Button();
            this.ND = new System.Windows.Forms.TextBox();
            this.Smena = new System.Windows.Forms.TextBox();
            this.MerFal = new System.Windows.Forms.RadioButton();
            this.MerTru = new System.Windows.Forms.RadioButton();
            this.MerStartLabel = new System.Windows.Forms.Label();
            this.HourMerStart = new System.Windows.Forms.ComboBox();
            this.MinMerStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LTimeStart = new System.Windows.Forms.Label();
            this.TimeStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NDLabel
            // 
            this.NDLabel.AutoSize = true;
            this.NDLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDLabel.Location = new System.Drawing.Point(27, 25);
            this.NDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NDLabel.Name = "NDLabel";
            this.NDLabel.Size = new System.Drawing.Size(417, 52);
            this.NDLabel.TabIndex = 2;
            this.NDLabel.Text = "Сумма в кошельке:";
            // 
            // SmenaLabel
            // 
            this.SmenaLabel.AutoSize = true;
            this.SmenaLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SmenaLabel.Location = new System.Drawing.Point(27, 159);
            this.SmenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SmenaLabel.Name = "SmenaLabel";
            this.SmenaLabel.Size = new System.Drawing.Size(233, 52);
            this.SmenaLabel.TabIndex = 4;
            this.SmenaLabel.Text = "На смене:";
            // 
            // work
            // 
            this.work.Font = new System.Drawing.Font("Times New Roman", 27.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.work.Location = new System.Drawing.Point(110, 565);
            this.work.Margin = new System.Windows.Forms.Padding(4);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(401, 80);
            this.work.TabIndex = 5;
            this.work.Text = "Начать смену!";
            this.work.UseVisualStyleBackColor = true;
            this.work.Click += new System.EventHandler(this.work_Click);
            // 
            // ND
            // 
            this.ND.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ND.Location = new System.Drawing.Point(465, 25);
            this.ND.Margin = new System.Windows.Forms.Padding(4);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(193, 61);
            this.ND.TabIndex = 1;
            this.ND.TextChanged += new System.EventHandler(this.new_day_TextChanged);
            // 
            // Smena
            // 
            this.Smena.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Smena.Location = new System.Drawing.Point(281, 159);
            this.Smena.Margin = new System.Windows.Forms.Padding(4);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(377, 61);
            this.Smena.TabIndex = 6;
            this.Smena.TextChanged += new System.EventHandler(this.smena_TextChanged);
            // 
            // MerFal
            // 
            this.MerFal.AutoSize = true;
            this.MerFal.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MerFal.Location = new System.Drawing.Point(30, 239);
            this.MerFal.Margin = new System.Windows.Forms.Padding(4);
            this.MerFal.Name = "MerFal";
            this.MerFal.Size = new System.Drawing.Size(450, 56);
            this.MerFal.TabIndex = 7;
            this.MerFal.TabStop = true;
            this.MerFal.Text = "Нет мероприятия ";
            this.MerFal.UseVisualStyleBackColor = true;
            this.MerFal.CheckedChanged += new System.EventHandler(this.MerFal_CheckedChanged);
            // 
            // MerTru
            // 
            this.MerTru.AutoSize = true;
            this.MerTru.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MerTru.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MerTru.Location = new System.Drawing.Point(30, 312);
            this.MerTru.Margin = new System.Windows.Forms.Padding(4);
            this.MerTru.Name = "MerTru";
            this.MerTru.Size = new System.Drawing.Size(454, 57);
            this.MerTru.TabIndex = 8;
            this.MerTru.TabStop = true;
            this.MerTru.Text = "Есть мероприятие";
            this.MerTru.UseVisualStyleBackColor = true;
            this.MerTru.CheckedChanged += new System.EventHandler(this.MerTru_CheckedChanged);
            // 
            // MerStartLabel
            // 
            this.MerStartLabel.AutoSize = true;
            this.MerStartLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MerStartLabel.Location = new System.Drawing.Point(30, 386);
            this.MerStartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MerStartLabel.Name = "MerStartLabel";
            this.MerStartLabel.Size = new System.Drawing.Size(571, 52);
            this.MerStartLabel.TabIndex = 9;
            this.MerStartLabel.Text = "мероприятие начнется в:";
            // 
            // HourMerStart
            // 
            this.HourMerStart.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HourMerStart.FormattingEnabled = true;
            this.HourMerStart.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.HourMerStart.Location = new System.Drawing.Point(110, 460);
            this.HourMerStart.Margin = new System.Windows.Forms.Padding(4);
            this.HourMerStart.Name = "HourMerStart";
            this.HourMerStart.Size = new System.Drawing.Size(172, 60);
            this.HourMerStart.TabIndex = 10;
            this.HourMerStart.SelectedIndexChanged += new System.EventHandler(this.HourMerStart_SelectedIndexChanged);
            // 
            // MinMerStart
            // 
            this.MinMerStart.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MinMerStart.FormattingEnabled = true;
            this.MinMerStart.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.MinMerStart.Location = new System.Drawing.Point(339, 460);
            this.MinMerStart.Margin = new System.Windows.Forms.Padding(4);
            this.MinMerStart.Name = "MinMerStart";
            this.MinMerStart.Size = new System.Drawing.Size(172, 60);
            this.MinMerStart.TabIndex = 11;
            this.MinMerStart.SelectedIndexChanged += new System.EventHandler(this.MinMerSatrt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(290, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // LTimeStart
            // 
            this.LTimeStart.AutoSize = true;
            this.LTimeStart.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LTimeStart.Location = new System.Drawing.Point(27, 94);
            this.LTimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTimeStart.Name = "LTimeStart";
            this.LTimeStart.Size = new System.Drawing.Size(473, 52);
            this.LTimeStart.TabIndex = 13;
            this.LTimeStart.Text = "Время начала смены:";
            // 
            // TimeStart
            // 
            this.TimeStart.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TimeStart.Location = new System.Drawing.Point(518, 94);
            this.TimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            this.TimeStart.Size = new System.Drawing.Size(140, 61);
            this.TimeStart.TabIndex = 14;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(678, 699);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.LTimeStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinMerStart);
            this.Controls.Add(this.HourMerStart);
            this.Controls.Add(this.MerStartLabel);
            this.Controls.Add(this.MerTru);
            this.Controls.Add(this.MerFal);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.ND);
            this.Controls.Add(this.work);
            this.Controls.Add(this.SmenaLabel);
            this.Controls.Add(this.NDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Text = "Антикафе приветствует тебя на работе и желает хорошой смены)";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label NDLabel;
        private System.Windows.Forms.Label SmenaLabel;
        private System.Windows.Forms.Button work;
        private System.Windows.Forms.TextBox ND;
        private System.Windows.Forms.TextBox Smena;
        private System.Windows.Forms.RadioButton MerFal;
        private System.Windows.Forms.RadioButton MerTru;
        private System.Windows.Forms.Label MerStartLabel;
        private System.Windows.Forms.ComboBox HourMerStart;
        private System.Windows.Forms.ComboBox MinMerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTimeStart;
        private System.Windows.Forms.TextBox TimeStart;
    }
}

