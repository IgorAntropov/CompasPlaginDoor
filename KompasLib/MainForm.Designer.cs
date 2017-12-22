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
            this.pushToKompas = new System.Windows.Forms.Button();
            this.doorHeight = new System.Windows.Forms.ComboBox();
            this.doorWidth = new System.Windows.Forms.ComboBox();
            this.doorThickness = new System.Windows.Forms.ComboBox();
            this.doorHandle = new System.Windows.Forms.ComboBox();
            this.doorPeephole = new System.Windows.Forms.ComboBox();
            this.doorH = new System.Windows.Forms.Label();
            this.doorW = new System.Windows.Forms.Label();
            this.doorT = new System.Windows.Forms.Label();
            this.doorHa = new System.Windows.Forms.Label();
            this.doorP = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openAnimalDoor = new System.Windows.Forms.RadioButton();
            this.closeAnimalDoor = new System.Windows.Forms.RadioButton();
            this.checkAnimal = new System.Windows.Forms.CheckBox();
            this.demoVariable = new System.Windows.Forms.Button();
            this.test100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pushToKompas
            // 
            this.pushToKompas.Location = new System.Drawing.Point(88, 268);
            this.pushToKompas.Margin = new System.Windows.Forms.Padding(4);
            this.pushToKompas.Name = "pushToKompas";
            this.pushToKompas.Size = new System.Drawing.Size(161, 38);
            this.pushToKompas.TabIndex = 1;
            this.pushToKompas.Text = "Построить модель";
            this.pushToKompas.UseVisualStyleBackColor = true;
            this.pushToKompas.Click += new System.EventHandler(this.pushToKompas_Click);
            // 
            // doorHeight
            // 
            this.doorHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorHeight.FormattingEnabled = true;
            this.doorHeight.Items.AddRange(new object[] {
            "1900",
            "1950",
            "2000",
            "2050",
            "2100",
            "2150",
            "2200"});
            this.doorHeight.Location = new System.Drawing.Point(191, 13);
            this.doorHeight.Margin = new System.Windows.Forms.Padding(4);
            this.doorHeight.Name = "doorHeight";
            this.doorHeight.Size = new System.Drawing.Size(160, 24);
            this.doorHeight.TabIndex = 2;
            this.doorHeight.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load_1);
            // 
            // doorWidth
            // 
            this.doorWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorWidth.FormattingEnabled = true;
            this.doorWidth.Items.AddRange(new object[] {
            "800",
            "825",
            "850",
            "875",
            "900"});
            this.doorWidth.Location = new System.Drawing.Point(191, 47);
            this.doorWidth.Margin = new System.Windows.Forms.Padding(4);
            this.doorWidth.Name = "doorWidth";
            this.doorWidth.Size = new System.Drawing.Size(160, 24);
            this.doorWidth.TabIndex = 3;
            this.doorWidth.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load_1);
            // 
            // doorThickness
            // 
            this.doorThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorThickness.FormattingEnabled = true;
            this.doorThickness.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.doorThickness.Location = new System.Drawing.Point(191, 80);
            this.doorThickness.Margin = new System.Windows.Forms.Padding(4);
            this.doorThickness.Name = "doorThickness";
            this.doorThickness.Size = new System.Drawing.Size(160, 24);
            this.doorThickness.TabIndex = 4;
            this.doorThickness.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load_1);
            // 
            // doorHandle
            // 
            this.doorHandle.AutoCompleteCustomSource.AddRange(new string[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.doorHandle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorHandle.FormattingEnabled = true;
            this.doorHandle.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900"});
            this.doorHandle.Location = new System.Drawing.Point(191, 113);
            this.doorHandle.Margin = new System.Windows.Forms.Padding(4);
            this.doorHandle.Name = "doorHandle";
            this.doorHandle.Size = new System.Drawing.Size(160, 24);
            this.doorHandle.TabIndex = 5;
            this.doorHandle.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load_1);
            // 
            // doorPeephole
            // 
            this.doorPeephole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorPeephole.FormattingEnabled = true;
            this.doorPeephole.Items.AddRange(new object[] {
            "900",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600"});
            this.doorPeephole.Location = new System.Drawing.Point(191, 146);
            this.doorPeephole.Margin = new System.Windows.Forms.Padding(4);
            this.doorPeephole.Name = "doorPeephole";
            this.doorPeephole.Size = new System.Drawing.Size(160, 24);
            this.doorPeephole.TabIndex = 6;
            this.doorPeephole.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load_1);
            // 
            // doorH
            // 
            this.doorH.AutoSize = true;
            this.doorH.Location = new System.Drawing.Point(11, 23);
            this.doorH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doorH.Name = "doorH";
            this.doorH.Size = new System.Drawing.Size(100, 17);
            this.doorH.TabIndex = 7;
            this.doorH.Text = "Высота двери";
            // 
            // doorW
            // 
            this.doorW.AutoSize = true;
            this.doorW.Location = new System.Drawing.Point(9, 56);
            this.doorW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doorW.Name = "doorW";
            this.doorW.Size = new System.Drawing.Size(102, 17);
            this.doorW.TabIndex = 8;
            this.doorW.Text = "Ширина двери";
            // 
            // doorT
            // 
            this.doorT.AutoSize = true;
            this.doorT.Location = new System.Drawing.Point(9, 90);
            this.doorT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doorT.Name = "doorT";
            this.doorT.Size = new System.Drawing.Size(111, 17);
            this.doorT.TabIndex = 9;
            this.doorT.Text = "Толщина двери";
            // 
            // doorHa
            // 
            this.doorHa.AutoSize = true;
            this.doorHa.Location = new System.Drawing.Point(9, 123);
            this.doorHa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doorHa.Name = "doorHa";
            this.doorHa.Size = new System.Drawing.Size(158, 17);
            this.doorHa.TabIndex = 10;
            this.doorHa.Text = "Высота дверной ручки";
            // 
            // doorP
            // 
            this.doorP.AutoSize = true;
            this.doorP.Location = new System.Drawing.Point(9, 156);
            this.doorP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doorP.Name = "doorP";
            this.doorP.Size = new System.Drawing.Size(168, 17);
            this.doorP.TabIndex = 11;
            this.doorP.Text = "Высота дверного глазка";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::KompasLib.Properties.Resources._1;
            this.pictureBox.Location = new System.Drawing.Point(390, 23);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(244, 313);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // openAnimalDoor
            // 
            this.openAnimalDoor.AutoSize = true;
            this.openAnimalDoor.Location = new System.Drawing.Point(191, 189);
            this.openAnimalDoor.Margin = new System.Windows.Forms.Padding(4);
            this.openAnimalDoor.Name = "openAnimalDoor";
            this.openAnimalDoor.Size = new System.Drawing.Size(141, 21);
            this.openAnimalDoor.TabIndex = 14;
            this.openAnimalDoor.TabStop = true;
            this.openAnimalDoor.Text = "В открытом виде";
            this.openAnimalDoor.UseVisualStyleBackColor = true;
            // 
            // closeAnimalDoor
            // 
            this.closeAnimalDoor.AutoSize = true;
            this.closeAnimalDoor.Location = new System.Drawing.Point(191, 218);
            this.closeAnimalDoor.Margin = new System.Windows.Forms.Padding(4);
            this.closeAnimalDoor.Name = "closeAnimalDoor";
            this.closeAnimalDoor.Size = new System.Drawing.Size(141, 21);
            this.closeAnimalDoor.TabIndex = 15;
            this.closeAnimalDoor.TabStop = true;
            this.closeAnimalDoor.Text = "В закрытом виде";
            this.closeAnimalDoor.UseVisualStyleBackColor = true;
            // 
            // checkAnimal
            // 
            this.checkAnimal.AutoSize = true;
            this.checkAnimal.Location = new System.Drawing.Point(13, 191);
            this.checkAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.checkAnimal.Name = "checkAnimal";
            this.checkAnimal.Size = new System.Drawing.Size(151, 21);
            this.checkAnimal.TabIndex = 16;
            this.checkAnimal.Text = "Собачья заслонка";
            this.checkAnimal.UseVisualStyleBackColor = true;
            this.checkAnimal.CheckedChanged += new System.EventHandler(this.checkAnimal_CheckedChanged);
            // 
            // demoVariable
            // 
            this.demoVariable.Location = new System.Drawing.Point(14, 314);
            this.demoVariable.Margin = new System.Windows.Forms.Padding(4);
            this.demoVariable.Name = "demoVariable";
            this.demoVariable.Size = new System.Drawing.Size(150, 33);
            this.demoVariable.TabIndex = 17;
            this.demoVariable.Text = "Demo";
            this.demoVariable.UseVisualStyleBackColor = true;
            this.demoVariable.Click += new System.EventHandler(this.demoVariable_Click_1);
            // 
            // test100
            // 
            this.test100.Location = new System.Drawing.Point(175, 314);
            this.test100.Margin = new System.Windows.Forms.Padding(4);
            this.test100.Name = "test100";
            this.test100.Size = new System.Drawing.Size(162, 33);
            this.test100.TabIndex = 18;
            this.test100.Text = "Нагрузочный тест";
            this.test100.UseVisualStyleBackColor = true;
            this.test100.Click += new System.EventHandler(this.test100_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 357);
            this.Controls.Add(this.test100);
            this.Controls.Add(this.demoVariable);
            this.Controls.Add(this.checkAnimal);
            this.Controls.Add(this.closeAnimalDoor);
            this.Controls.Add(this.openAnimalDoor);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.doorP);
            this.Controls.Add(this.doorHa);
            this.Controls.Add(this.doorT);
            this.Controls.Add(this.doorW);
            this.Controls.Add(this.doorH);
            this.Controls.Add(this.doorPeephole);
            this.Controls.Add(this.doorHandle);
            this.Controls.Add(this.doorThickness);
            this.Controls.Add(this.doorWidth);
            this.Controls.Add(this.doorHeight);
            this.Controls.Add(this.pushToKompas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(726, 456);
            this.MinimumSize = new System.Drawing.Size(680, 408);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бибилиотека \"Входная дверь\" для КОМПАС-3D v17";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushToKompas;
        private System.Windows.Forms.ComboBox doorHeight;
        private System.Windows.Forms.ComboBox doorWidth;
        private System.Windows.Forms.ComboBox doorThickness;
        private System.Windows.Forms.ComboBox doorHandle;
        private System.Windows.Forms.ComboBox doorPeephole;
        private System.Windows.Forms.Label doorH;
        private System.Windows.Forms.Label doorW;
        private System.Windows.Forms.Label doorT;
        private System.Windows.Forms.Label doorHa;
        private System.Windows.Forms.Label doorP;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.RadioButton openAnimalDoor;
        public System.Windows.Forms.RadioButton closeAnimalDoor;
        public System.Windows.Forms.CheckBox checkAnimal;
        private System.Windows.Forms.Button demoVariable;
        private System.Windows.Forms.Button test100;
    }
}

