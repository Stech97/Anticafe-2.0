namespace Anticafe_2._0
{
    partial class StartWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindows));
            this.NDLabel = new System.Windows.Forms.Label();
            this.SmenaLabel = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.Button();
            this.ND = new System.Windows.Forms.TextBox();
            this.Smena = new System.Windows.Forms.TextBox();
            this.MerStartLabel1 = new System.Windows.Forms.Label();
            this.HourMerStart1 = new System.Windows.Forms.ComboBox();
            this.MinMerStart1 = new System.Windows.Forms.ComboBox();
            this.L1 = new System.Windows.Forms.Label();
            this.LTimeStart = new System.Windows.Forms.Label();
            this.startWIndow = new System.Windows.Forms.TextBox();
            this.LMer = new System.Windows.Forms.Label();
            this.colMer = new System.Windows.Forms.NumericUpDown();
            this.LMer1 = new System.Windows.Forms.Label();
            this.LMer2 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.MinMerStart2 = new System.Windows.Forms.ComboBox();
            this.HourMerStart2 = new System.Windows.Forms.ComboBox();
            this.MerStartLabel2 = new System.Windows.Forms.Label();
            this.Mer11 = new System.Windows.Forms.CheckBox();
            this.Mer12 = new System.Windows.Forms.CheckBox();
            this.Mer13 = new System.Windows.Forms.CheckBox();
            this.Mer21 = new System.Windows.Forms.CheckBox();
            this.Mer22 = new System.Windows.Forms.CheckBox();
            this.Mer23 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.colMer)).BeginInit();
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
            this.SmenaLabel.Location = new System.Drawing.Point(27, 189);
            this.SmenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SmenaLabel.Name = "SmenaLabel";
            this.SmenaLabel.Size = new System.Drawing.Size(233, 52);
            this.SmenaLabel.TabIndex = 4;
            this.SmenaLabel.Text = "На смене:";
            // 
            // work
            // 
            this.work.Font = new System.Drawing.Font("Times New Roman", 27.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.work.Location = new System.Drawing.Point(99, 401);
            this.work.Margin = new System.Windows.Forms.Padding(4);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(401, 85);
            this.work.TabIndex = 4;
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
            this.Smena.Location = new System.Drawing.Point(281, 189);
            this.Smena.Margin = new System.Windows.Forms.Padding(4);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(377, 61);
            this.Smena.TabIndex = 2;
            this.Smena.TextChanged += new System.EventHandler(this.smena_TextChanged);
            // 
            // MerStartLabel1
            // 
            this.MerStartLabel1.AutoSize = true;
            this.MerStartLabel1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MerStartLabel1.Location = new System.Drawing.Point(691, 357);
            this.MerStartLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MerStartLabel1.Name = "MerStartLabel1";
            this.MerStartLabel1.Size = new System.Drawing.Size(170, 52);
            this.MerStartLabel1.TabIndex = 9;
            this.MerStartLabel1.Text = "Время:";
            // 
            // HourMerStart1
            // 
            this.HourMerStart1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HourMerStart1.FormattingEnabled = true;
            this.HourMerStart1.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.HourMerStart1.Location = new System.Drawing.Point(696, 426);
            this.HourMerStart1.Margin = new System.Windows.Forms.Padding(4);
            this.HourMerStart1.Name = "HourMerStart1";
            this.HourMerStart1.Size = new System.Drawing.Size(172, 60);
            this.HourMerStart1.TabIndex = 10;
            this.HourMerStart1.SelectedIndexChanged += new System.EventHandler(this.HourMerStart_SelectedIndexChanged);
            // 
            // MinMerStart1
            // 
            this.MinMerStart1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MinMerStart1.FormattingEnabled = true;
            this.MinMerStart1.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.MinMerStart1.Location = new System.Drawing.Point(927, 426);
            this.MinMerStart1.Margin = new System.Windows.Forms.Padding(4);
            this.MinMerStart1.Name = "MinMerStart1";
            this.MinMerStart1.Size = new System.Drawing.Size(172, 60);
            this.MinMerStart1.TabIndex = 11;
            this.MinMerStart1.SelectedIndexChanged += new System.EventHandler(this.MinMerSatrt_SelectedIndexChanged);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.L1.Location = new System.Drawing.Point(880, 429);
            this.L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(39, 52);
            this.L1.TabIndex = 12;
            this.L1.Text = ":";
            // 
            // LTimeStart
            // 
            this.LTimeStart.AutoSize = true;
            this.LTimeStart.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LTimeStart.Location = new System.Drawing.Point(27, 104);
            this.LTimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTimeStart.Name = "LTimeStart";
            this.LTimeStart.Size = new System.Drawing.Size(473, 52);
            this.LTimeStart.TabIndex = 13;
            this.LTimeStart.Text = "Время начала смены:";
            // 
            // startWIndow
            // 
            this.startWIndow.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.startWIndow.Location = new System.Drawing.Point(518, 104);
            this.startWIndow.Margin = new System.Windows.Forms.Padding(4);
            this.startWIndow.Name = "startWIndow";
            this.startWIndow.ReadOnly = true;
            this.startWIndow.Size = new System.Drawing.Size(140, 61);
            this.startWIndow.TabIndex = 14;
            // 
            // LMer
            // 
            this.LMer.AutoSize = true;
            this.LMer.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LMer.Location = new System.Drawing.Point(27, 281);
            this.LMer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMer.Name = "LMer";
            this.LMer.Size = new System.Drawing.Size(333, 52);
            this.LMer.TabIndex = 16;
            this.LMer.Text = "Мероприятие:";
            // 
            // colMer
            // 
            this.colMer.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.colMer.Location = new System.Drawing.Point(538, 279);
            this.colMer.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.colMer.Name = "colMer";
            this.colMer.Size = new System.Drawing.Size(120, 61);
            this.colMer.TabIndex = 17;
            this.colMer.ValueChanged += new System.EventHandler(this.colMer_ValueChanged);
            // 
            // LMer1
            // 
            this.LMer1.AutoSize = true;
            this.LMer1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMer1.Location = new System.Drawing.Point(691, 25);
            this.LMer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMer1.Name = "LMer1";
            this.LMer1.Size = new System.Drawing.Size(369, 52);
            this.LMer1.TabIndex = 18;
            this.LMer1.Text = "Мероприятие 1:";
            // 
            // LMer2
            // 
            this.LMer2.AutoSize = true;
            this.LMer2.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMer2.Location = new System.Drawing.Point(1151, 25);
            this.LMer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMer2.Name = "LMer2";
            this.LMer2.Size = new System.Drawing.Size(369, 52);
            this.LMer2.TabIndex = 24;
            this.LMer2.Text = "Мероприятие 2:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.L2.Location = new System.Drawing.Point(1352, 425);
            this.L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(39, 52);
            this.L2.TabIndex = 23;
            this.L2.Text = ":";
            // 
            // MinMerStart2
            // 
            this.MinMerStart2.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MinMerStart2.FormattingEnabled = true;
            this.MinMerStart2.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.MinMerStart2.Location = new System.Drawing.Point(1401, 425);
            this.MinMerStart2.Margin = new System.Windows.Forms.Padding(4);
            this.MinMerStart2.Name = "MinMerStart2";
            this.MinMerStart2.Size = new System.Drawing.Size(172, 60);
            this.MinMerStart2.TabIndex = 22;
            // 
            // HourMerStart2
            // 
            this.HourMerStart2.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HourMerStart2.FormattingEnabled = true;
            this.HourMerStart2.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.HourMerStart2.Location = new System.Drawing.Point(1170, 425);
            this.HourMerStart2.Margin = new System.Windows.Forms.Padding(4);
            this.HourMerStart2.Name = "HourMerStart2";
            this.HourMerStart2.Size = new System.Drawing.Size(172, 60);
            this.HourMerStart2.TabIndex = 21;
            // 
            // MerStartLabel2
            // 
            this.MerStartLabel2.AutoSize = true;
            this.MerStartLabel2.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MerStartLabel2.Location = new System.Drawing.Point(1170, 357);
            this.MerStartLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MerStartLabel2.Name = "MerStartLabel2";
            this.MerStartLabel2.Size = new System.Drawing.Size(170, 52);
            this.MerStartLabel2.TabIndex = 20;
            this.MerStartLabel2.Text = "Время:";
            // 
            // Mer11
            // 
            this.Mer11.AutoSize = true;
            this.Mer11.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer11.Location = new System.Drawing.Point(696, 109);
            this.Mer11.Name = "Mer11";
            this.Mer11.Size = new System.Drawing.Size(324, 56);
            this.Mer11.TabIndex = 26;
            this.Mer11.Text = "Вечер в анти";
            this.Mer11.UseVisualStyleBackColor = true;
            this.Mer11.CheckedChanged += new System.EventHandler(this.Mer11_CheckedChanged);
            // 
            // Mer12
            // 
            this.Mer12.AutoSize = true;
            this.Mer12.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer12.Location = new System.Drawing.Point(696, 194);
            this.Mer12.Name = "Mer12";
            this.Mer12.Size = new System.Drawing.Size(194, 56);
            this.Mer12.TabIndex = 27;
            this.Mer12.Text = "Мафия";
            this.Mer12.UseVisualStyleBackColor = true;
            this.Mer12.CheckedChanged += new System.EventHandler(this.Mer12_CheckedChanged);
            // 
            // Mer13
            // 
            this.Mer13.AutoSize = true;
            this.Mer13.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer13.Location = new System.Drawing.Point(696, 282);
            this.Mer13.Name = "Mer13";
            this.Mer13.Size = new System.Drawing.Size(248, 56);
            this.Mer13.TabIndex = 28;
            this.Mer13.Text = "Киноночь";
            this.Mer13.UseVisualStyleBackColor = true;
            this.Mer13.CheckedChanged += new System.EventHandler(this.Mer13_CheckedChanged);
            // 
            // Mer21
            // 
            this.Mer21.AutoSize = true;
            this.Mer21.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer21.Location = new System.Drawing.Point(1160, 106);
            this.Mer21.Name = "Mer21";
            this.Mer21.Size = new System.Drawing.Size(324, 56);
            this.Mer21.TabIndex = 29;
            this.Mer21.Text = "Вечер в анти";
            this.Mer21.UseVisualStyleBackColor = true;
            this.Mer21.CheckedChanged += new System.EventHandler(this.Mer21_CheckedChanged);
            // 
            // Mer22
            // 
            this.Mer22.AutoSize = true;
            this.Mer22.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer22.Location = new System.Drawing.Point(1160, 191);
            this.Mer22.Name = "Mer22";
            this.Mer22.Size = new System.Drawing.Size(194, 56);
            this.Mer22.TabIndex = 30;
            this.Mer22.Text = "Мафия";
            this.Mer22.UseVisualStyleBackColor = true;
            this.Mer22.CheckedChanged += new System.EventHandler(this.Mer22_CheckedChanged);
            // 
            // Mer23
            // 
            this.Mer23.AutoSize = true;
            this.Mer23.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mer23.Location = new System.Drawing.Point(1160, 282);
            this.Mer23.Name = "Mer23";
            this.Mer23.Size = new System.Drawing.Size(248, 56);
            this.Mer23.TabIndex = 31;
            this.Mer23.Text = "Киноночь";
            this.Mer23.UseVisualStyleBackColor = true;
            this.Mer23.CheckedChanged += new System.EventHandler(this.Mer23_CheckedChanged);
            // 
            // StartWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1578, 519);
            this.Controls.Add(this.Mer23);
            this.Controls.Add(this.Mer22);
            this.Controls.Add(this.Mer21);
            this.Controls.Add(this.Mer13);
            this.Controls.Add(this.Mer12);
            this.Controls.Add(this.Mer11);
            this.Controls.Add(this.LMer2);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.MinMerStart2);
            this.Controls.Add(this.HourMerStart2);
            this.Controls.Add(this.MerStartLabel2);
            this.Controls.Add(this.LMer1);
            this.Controls.Add(this.colMer);
            this.Controls.Add(this.LMer);
            this.Controls.Add(this.startWIndow);
            this.Controls.Add(this.LTimeStart);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.MinMerStart1);
            this.Controls.Add(this.HourMerStart1);
            this.Controls.Add(this.MerStartLabel1);
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
            this.Name = "StartWindows";
            this.Text = "Антикафе приветствует тебя на работе и желает хорошой смены)";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colMer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label NDLabel;
        private System.Windows.Forms.Label SmenaLabel;
        private System.Windows.Forms.Button work;
        private System.Windows.Forms.TextBox ND;
        private System.Windows.Forms.TextBox Smena;
        private System.Windows.Forms.Label MerStartLabel1;
        private System.Windows.Forms.ComboBox HourMerStart1;
        private System.Windows.Forms.ComboBox MinMerStart1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label LTimeStart;
        private System.Windows.Forms.TextBox startWIndow;
        private System.Windows.Forms.Label LMer;
        private System.Windows.Forms.NumericUpDown colMer;
        private System.Windows.Forms.Label LMer1;
        private System.Windows.Forms.Label LMer2;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.ComboBox MinMerStart2;
        private System.Windows.Forms.ComboBox HourMerStart2;
        private System.Windows.Forms.Label MerStartLabel2;
        private System.Windows.Forms.CheckBox Mer11;
        private System.Windows.Forms.CheckBox Mer12;
        private System.Windows.Forms.CheckBox Mer13;
        private System.Windows.Forms.CheckBox Mer21;
        private System.Windows.Forms.CheckBox Mer22;
        private System.Windows.Forms.CheckBox Mer23;
    }
}

