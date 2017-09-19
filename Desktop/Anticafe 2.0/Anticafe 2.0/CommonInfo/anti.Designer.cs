namespace Anticafe_2._0
{
    partial class anti
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anti));
            this.Table = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Флаер = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Время_прихода = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_ухода = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_в_минутах = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сумма = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif = new System.Windows.Forms.Button();
            this.CHE = new System.Windows.Forms.Button();
            this.SmenaEnd = new System.Windows.Forms.Button();
            this.GuestOut = new System.Windows.Forms.Button();
            this.NewGuest = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.TimeOnForm = new System.Windows.Forms.Timer(this.components);
            this.WhoWork = new System.Windows.Forms.Label();
            this.trey = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.NullValue = null;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Tax,
            this.Флаер,
            this.Время_прихода,
            this.Время_ухода,
            this.Время_в_минутах,
            this.Сумма});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle4;
            this.Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Table.GridColor = System.Drawing.Color.SandyBrown;
            this.Table.Location = new System.Drawing.Point(27, 117);
            this.Table.Margin = new System.Windows.Forms.Padding(1);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersWidth = 10;
            this.Table.Size = new System.Drawing.Size(903, 634);
            this.Table.TabIndex = 7;
            this.Table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellDoubleClick);
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.MaxInputLength = 10;
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            this.Имя.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Тип подсчёта";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 150;
            // 
            // Флаер
            // 
            this.Флаер.HeaderText = "Флаер";
            this.Флаер.Name = "Флаер";
            this.Флаер.ReadOnly = true;
            this.Флаер.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Флаер.Width = 65;
            // 
            // Время_прихода
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Время_прихода.DefaultCellStyle = dataGridViewCellStyle3;
            this.Время_прихода.HeaderText = "Время прихода";
            this.Время_прихода.MaxInputLength = 8;
            this.Время_прихода.Name = "Время_прихода";
            this.Время_прихода.ReadOnly = true;
            this.Время_прихода.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Время_прихода.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Время_прихода.Width = 85;
            // 
            // Время_ухода
            // 
            this.Время_ухода.HeaderText = "Время ухода";
            this.Время_ухода.MaxInputLength = 8;
            this.Время_ухода.Name = "Время_ухода";
            this.Время_ухода.ReadOnly = true;
            this.Время_ухода.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Время_ухода.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Время_ухода.Width = 75;
            // 
            // Время_в_минутах
            // 
            this.Время_в_минутах.HeaderText = "Время в минутах";
            this.Время_в_минутах.MaxInputLength = 4;
            this.Время_в_минутах.Name = "Время_в_минутах";
            this.Время_в_минутах.ReadOnly = true;
            this.Время_в_минутах.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Время_в_минутах.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Время_в_минутах.Width = 95;
            // 
            // Сумма
            // 
            this.Сумма.HeaderText = "Сумма к оплате";
            this.Сумма.MaxInputLength = 6;
            this.Сумма.Name = "Сумма";
            this.Сумма.ReadOnly = true;
            this.Сумма.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Сумма.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Сумма.Width = 95;
            // 
            // Tarif
            // 
            this.Tarif.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Tarif.Location = new System.Drawing.Point(954, 117);
            this.Tarif.Margin = new System.Windows.Forms.Padding(4);
            this.Tarif.Name = "Tarif";
            this.Tarif.Size = new System.Drawing.Size(247, 117);
            this.Tarif.TabIndex = 1;
            this.Tarif.Text = "Тарифы";
            this.Tarif.UseVisualStyleBackColor = true;
            this.Tarif.Click += new System.EventHandler(this.Tarif_Click);
            // 
            // CHE
            // 
            this.CHE.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CHE.Location = new System.Drawing.Point(954, 634);
            this.CHE.Margin = new System.Windows.Forms.Padding(4);
            this.CHE.Name = "CHE";
            this.CHE.Size = new System.Drawing.Size(247, 117);
            this.CHE.TabIndex = 5;
            this.CHE.Text = "Чистота и Уют";
            this.CHE.UseVisualStyleBackColor = true;
            this.CHE.Click += new System.EventHandler(this.CHE_Click);
            // 
            // SmenaEnd
            // 
            this.SmenaEnd.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SmenaEnd.Location = new System.Drawing.Point(954, 505);
            this.SmenaEnd.Margin = new System.Windows.Forms.Padding(4);
            this.SmenaEnd.Name = "SmenaEnd";
            this.SmenaEnd.Size = new System.Drawing.Size(247, 117);
            this.SmenaEnd.TabIndex = 4;
            this.SmenaEnd.Text = "Конец смены";
            this.SmenaEnd.UseVisualStyleBackColor = true;
            this.SmenaEnd.Click += new System.EventHandler(this.SmenaEnd_Click);
            // 
            // GuestOut
            // 
            this.GuestOut.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GuestOut.Location = new System.Drawing.Point(954, 375);
            this.GuestOut.Margin = new System.Windows.Forms.Padding(4);
            this.GuestOut.Name = "GuestOut";
            this.GuestOut.Size = new System.Drawing.Size(247, 117);
            this.GuestOut.TabIndex = 3;
            this.GuestOut.Text = "Гость уходит";
            this.GuestOut.UseVisualStyleBackColor = true;
            this.GuestOut.Click += new System.EventHandler(this.GuestOut_Click);
            // 
            // NewGuest
            // 
            this.NewGuest.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NewGuest.Location = new System.Drawing.Point(954, 246);
            this.NewGuest.Margin = new System.Windows.Forms.Padding(4);
            this.NewGuest.Name = "NewGuest";
            this.NewGuest.Size = new System.Drawing.Size(247, 117);
            this.NewGuest.TabIndex = 2;
            this.NewGuest.Text = "Новый гость";
            this.NewGuest.UseVisualStyleBackColor = true;
            this.NewGuest.Click += new System.EventHandler(this.NewGuest_Click);
            // 
            // Time
            // 
            this.Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Enabled = false;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(907, 18);
            this.Time.Margin = new System.Windows.Forms.Padding(4);
            this.Time.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.Time.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(245, 37);
            this.Time.TabIndex = 15;
            this.Time.TabStop = false;
            // 
            // TimeOnForm
            // 
            this.TimeOnForm.Tick += new System.EventHandler(this.TimeOnForm_Tick);
            // 
            // WhoWork
            // 
            this.WhoWork.AutoSize = true;
            this.WhoWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.WhoWork.Location = new System.Drawing.Point(400, 18);
            this.WhoWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhoWork.Name = "WhoWork";
            this.WhoWork.Size = new System.Drawing.Size(0, 42);
            this.WhoWork.TabIndex = 16;
            // 
            // trey
            // 
            this.trey.Icon = ((System.Drawing.Icon)(resources.GetObject("trey.Icon")));
            this.trey.Text = "Сметка антикафе\"Время терпит\"";
            this.trey.Visible = true;
            this.trey.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trey_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сейчас на смене: ";
            // 
            // anti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1227, 766);
            this.Controls.Add(this.WhoWork);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Tarif);
            this.Controls.Add(this.CHE);
            this.Controls.Add(this.SmenaEnd);
            this.Controls.Add(this.GuestOut);
            this.Controls.Add(this.NewGuest);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "anti";
            this.Text = "Антикафе 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anti_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anti_FormClosed);
            this.Load += new System.EventHandler(this.anti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Tarif;
        private System.Windows.Forms.Button CHE;
        private System.Windows.Forms.Button SmenaEnd;
        private System.Windows.Forms.Button GuestOut;
        private System.Windows.Forms.Button NewGuest;
        private System.Windows.Forms.Timer TimeOnForm;
        private System.Windows.Forms.Label WhoWork;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.NotifyIcon trey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Флаер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_прихода;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_ухода;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_в_минутах;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сумма;
    }
}