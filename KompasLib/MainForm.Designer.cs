namespace KompasLib
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PushToKompas = new System.Windows.Forms.Button();
            this.HeightDoor = new System.Windows.Forms.ComboBox();
            this.WidthDoor = new System.Windows.Forms.ComboBox();
            this.ThicknessDoor = new System.Windows.Forms.ComboBox();
            this.DoorHandle = new System.Windows.Forms.ComboBox();
            this.DoorPeephole = new System.Windows.Forms.ComboBox();
            this.HDoor = new System.Windows.Forms.Label();
            this.WDoor = new System.Windows.Forms.Label();
            this.TDoor = new System.Windows.Forms.Label();
            this.HHandle = new System.Windows.Forms.Label();
            this.HPeephole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PushToKompas
            // 
            this.PushToKompas.Location = new System.Drawing.Point(76, 161);
            this.PushToKompas.Name = "PushToKompas";
            this.PushToKompas.Size = new System.Drawing.Size(121, 31);
            this.PushToKompas.TabIndex = 1;
            this.PushToKompas.Text = "Построить модель";
            this.PushToKompas.UseVisualStyleBackColor = true;
            this.PushToKompas.Click += new System.EventHandler(this.PushToKompas_Click);
            // 
            // HeightDoor
            // 
            this.HeightDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeightDoor.FormattingEnabled = true;
            this.HeightDoor.Items.AddRange(new object[] {
            "1900",
            "1950",
            "2000",
            "2050",
            "2100",
            "2150",
            "2200"});
            this.HeightDoor.Location = new System.Drawing.Point(146, 12);
            this.HeightDoor.Name = "HeightDoor";
            this.HeightDoor.Size = new System.Drawing.Size(121, 21);
            this.HeightDoor.TabIndex = 2;
            this.HeightDoor.SelectedIndexChanged += new System.EventHandler(this.HeightDoor_SelectedIndexChanged);
            this.HeightDoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightDoor_KeyPress);
            // 
            // WidthDoor
            // 
            this.WidthDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WidthDoor.FormattingEnabled = true;
            this.WidthDoor.Items.AddRange(new object[] {
            "800",
            "825",
            "850",
            "875",
            "900"});
            this.WidthDoor.Location = new System.Drawing.Point(146, 39);
            this.WidthDoor.Name = "WidthDoor";
            this.WidthDoor.Size = new System.Drawing.Size(121, 21);
            this.WidthDoor.TabIndex = 3;
            this.WidthDoor.SelectedIndexChanged += new System.EventHandler(this.WidthDoor_SelectedIndexChanged);
            this.WidthDoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthDoor_KeyPress);
            // 
            // ThicknessDoor
            // 
            this.ThicknessDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThicknessDoor.FormattingEnabled = true;
            this.ThicknessDoor.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.ThicknessDoor.Location = new System.Drawing.Point(146, 66);
            this.ThicknessDoor.Name = "ThicknessDoor";
            this.ThicknessDoor.Size = new System.Drawing.Size(121, 21);
            this.ThicknessDoor.TabIndex = 4;
            this.ThicknessDoor.SelectedIndexChanged += new System.EventHandler(this.ThicknessDoor_SelectedIndexChanged);
            this.ThicknessDoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThicknessDoor_KeyPress);
            // 
            // DoorHandle
            // 
            this.DoorHandle.AutoCompleteCustomSource.AddRange(new string[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.DoorHandle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoorHandle.FormattingEnabled = true;
            this.DoorHandle.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.DoorHandle.Location = new System.Drawing.Point(146, 93);
            this.DoorHandle.Name = "DoorHandle";
            this.DoorHandle.Size = new System.Drawing.Size(121, 21);
            this.DoorHandle.TabIndex = 5;
            this.DoorHandle.SelectedIndexChanged += new System.EventHandler(this.DoorHandle_SelectedIndexChanged);
            this.DoorHandle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoorHandle_KeyPress);
            // 
            // DoorPeephole
            // 
            this.DoorPeephole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoorPeephole.FormattingEnabled = true;
            this.DoorPeephole.Items.AddRange(new object[] {
            "900",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600"});
            this.DoorPeephole.Location = new System.Drawing.Point(146, 120);
            this.DoorPeephole.Name = "DoorPeephole";
            this.DoorPeephole.Size = new System.Drawing.Size(121, 21);
            this.DoorPeephole.TabIndex = 6;
            this.DoorPeephole.SelectedIndexChanged += new System.EventHandler(this.DoorPeephole_SelectedIndexChanged);
            this.DoorPeephole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoorPeephole_KeyPress);
            // 
            // HDoor
            // 
            this.HDoor.AutoSize = true;
            this.HDoor.Location = new System.Drawing.Point(11, 20);
            this.HDoor.Name = "HDoor";
            this.HDoor.Size = new System.Drawing.Size(78, 13);
            this.HDoor.TabIndex = 7;
            this.HDoor.Text = "Высота двери";
            // 
            // WDoor
            // 
            this.WDoor.AutoSize = true;
            this.WDoor.Location = new System.Drawing.Point(10, 47);
            this.WDoor.Name = "WDoor";
            this.WDoor.Size = new System.Drawing.Size(79, 13);
            this.WDoor.TabIndex = 8;
            this.WDoor.Text = "Ширина двери";
            // 
            // TDoor
            // 
            this.TDoor.AutoSize = true;
            this.TDoor.Location = new System.Drawing.Point(10, 74);
            this.TDoor.Name = "TDoor";
            this.TDoor.Size = new System.Drawing.Size(86, 13);
            this.TDoor.TabIndex = 9;
            this.TDoor.Text = "Толщина двери";
            // 
            // HHandle
            // 
            this.HHandle.AutoSize = true;
            this.HHandle.Location = new System.Drawing.Point(10, 101);
            this.HHandle.Name = "HHandle";
            this.HHandle.Size = new System.Drawing.Size(121, 13);
            this.HHandle.TabIndex = 10;
            this.HHandle.Text = "Высота дверной ручки";
            // 
            // HPeephole
            // 
            this.HPeephole.AutoSize = true;
            this.HPeephole.Location = new System.Drawing.Point(10, 128);
            this.HPeephole.Name = "HPeephole";
            this.HPeephole.Size = new System.Drawing.Size(133, 13);
            this.HPeephole.TabIndex = 11;
            this.HPeephole.Text = "Высота дверного глазка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 313);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 120);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 337);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HPeephole);
            this.Controls.Add(this.HHandle);
            this.Controls.Add(this.TDoor);
            this.Controls.Add(this.WDoor);
            this.Controls.Add(this.HDoor);
            this.Controls.Add(this.DoorPeephole);
            this.Controls.Add(this.DoorHandle);
            this.Controls.Add(this.ThicknessDoor);
            this.Controls.Add(this.WidthDoor);
            this.Controls.Add(this.HeightDoor);
            this.Controls.Add(this.PushToKompas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 380);
            this.MinimumSize = new System.Drawing.Size(550, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бибилиотека \"Входная дверь\" для КОМПАС-3D v17";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PushToKompas;
        private System.Windows.Forms.ComboBox HeightDoor;
        private System.Windows.Forms.ComboBox WidthDoor;
        private System.Windows.Forms.ComboBox ThicknessDoor;
        private System.Windows.Forms.ComboBox DoorHandle;
        private System.Windows.Forms.ComboBox DoorPeephole;
        private System.Windows.Forms.Label HDoor;
        private System.Windows.Forms.Label WDoor;
        private System.Windows.Forms.Label TDoor;
        private System.Windows.Forms.Label HHandle;
        private System.Windows.Forms.Label HPeephole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

