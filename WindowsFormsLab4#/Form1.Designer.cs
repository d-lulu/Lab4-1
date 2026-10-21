namespace WindowsFormsLab4_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxHuman = new System.Windows.Forms.GroupBox();
            this.buttonHuman_Clear = new System.Windows.Forms.Button();
            this.buttonHuman_Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.buttonCar_Clear = new System.Windows.Forms.Button();
            this.buttonCar_Add = new System.Windows.Forms.Button();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxBuilding = new System.Windows.Forms.GroupBox();
            this.buttonBuilding_Clear = new System.Windows.Forms.Button();
            this.buttonBuilding_Add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxHuman.SuspendLayout();
            this.groupBoxCar.SuspendLayout();
            this.groupBoxBuilding.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHuman
            // 
            this.groupBoxHuman.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxHuman.Controls.Add(this.buttonHuman_Clear);
            this.groupBoxHuman.Controls.Add(this.buttonHuman_Add);
            this.groupBoxHuman.Controls.Add(this.label7);
            this.groupBoxHuman.Controls.Add(this.label6);
            this.groupBoxHuman.Controls.Add(this.label3);
            this.groupBoxHuman.Controls.Add(this.comboBox1);
            this.groupBoxHuman.Controls.Add(this.textBoxHight);
            this.groupBoxHuman.Controls.Add(this.textBoxWeight);
            this.groupBoxHuman.Controls.Add(this.textBoxAge);
            this.groupBoxHuman.Controls.Add(this.textBoxName);
            this.groupBoxHuman.Controls.Add(this.label5);
            this.groupBoxHuman.Controls.Add(this.label4);
            this.groupBoxHuman.Controls.Add(this.label2);
            this.groupBoxHuman.Controls.Add(this.label1);
            this.groupBoxHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxHuman.Location = new System.Drawing.Point(12, 117);
            this.groupBoxHuman.Name = "groupBoxHuman";
            this.groupBoxHuman.Size = new System.Drawing.Size(849, 240);
            this.groupBoxHuman.TabIndex = 0;
            this.groupBoxHuman.TabStop = false;
            this.groupBoxHuman.Text = "Человек";
            // 
            // buttonHuman_Clear
            // 
            this.buttonHuman_Clear.Location = new System.Drawing.Point(462, 176);
            this.buttonHuman_Clear.Name = "buttonHuman_Clear";
            this.buttonHuman_Clear.Size = new System.Drawing.Size(348, 49);
            this.buttonHuman_Clear.TabIndex = 19;
            this.buttonHuman_Clear.Text = "Очистить";
            this.buttonHuman_Clear.UseVisualStyleBackColor = true;
            this.buttonHuman_Clear.Click += new System.EventHandler(this.buttonHuman_Clear_Click);
            // 
            // buttonHuman_Add
            // 
            this.buttonHuman_Add.Location = new System.Drawing.Point(32, 176);
            this.buttonHuman_Add.Name = "buttonHuman_Add";
            this.buttonHuman_Add.Size = new System.Drawing.Size(350, 49);
            this.buttonHuman_Add.TabIndex = 19;
            this.buttonHuman_Add.Text = "Добавить";
            this.buttonHuman_Add.UseVisualStyleBackColor = true;
            this.buttonHuman_Add.Click += new System.EventHandler(this.buttonHuman_Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(508, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "кг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(508, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "см";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(331, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рост:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "женский",
            "мужской"});
            this.comboBox1.Location = new System.Drawing.Point(665, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // textBoxHight
            // 
            this.textBoxHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxHight.Location = new System.Drawing.Point(400, 51);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(102, 30);
            this.textBoxHight.TabIndex = 8;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxWeight.Location = new System.Drawing.Point(400, 113);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(102, 30);
            this.textBoxWeight.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAge.Location = new System.Drawing.Point(130, 113);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(174, 30);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(95, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 30);
            this.textBoxName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(594, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(331, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(29, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxCar.Controls.Add(this.buttonCar_Clear);
            this.groupBoxCar.Controls.Add(this.buttonCar_Add);
            this.groupBoxCar.Controls.Add(this.textBoxEngine);
            this.groupBoxCar.Controls.Add(this.textBoxNumber);
            this.groupBoxCar.Controls.Add(this.textBoxYear);
            this.groupBoxCar.Controls.Add(this.textBoxBrand);
            this.groupBoxCar.Controls.Add(this.label12);
            this.groupBoxCar.Controls.Add(this.label11);
            this.groupBoxCar.Controls.Add(this.label10);
            this.groupBoxCar.Controls.Add(this.label9);
            this.groupBoxCar.Controls.Add(this.label8);
            this.groupBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxCar.Location = new System.Drawing.Point(12, 363);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(849, 210);
            this.groupBoxCar.TabIndex = 1;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Машина";
            // 
            // buttonCar_Clear
            // 
            this.buttonCar_Clear.Location = new System.Drawing.Point(462, 155);
            this.buttonCar_Clear.Name = "buttonCar_Clear";
            this.buttonCar_Clear.Size = new System.Drawing.Size(348, 49);
            this.buttonCar_Clear.TabIndex = 18;
            this.buttonCar_Clear.Text = "Очистить";
            this.buttonCar_Clear.UseVisualStyleBackColor = true;
            this.buttonCar_Clear.Click += new System.EventHandler(this.buttonCar_Clear_Click);
            // 
            // buttonCar_Add
            // 
            this.buttonCar_Add.Location = new System.Drawing.Point(34, 155);
            this.buttonCar_Add.Name = "buttonCar_Add";
            this.buttonCar_Add.Size = new System.Drawing.Size(348, 49);
            this.buttonCar_Add.TabIndex = 12;
            this.buttonCar_Add.Text = "Добавить";
            this.buttonCar_Add.UseVisualStyleBackColor = true;
            this.buttonCar_Add.Click += new System.EventHandler(this.buttonCar_Add_Click);
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEngine.Location = new System.Drawing.Point(502, 117);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(90, 30);
            this.textBoxEngine.TabIndex = 17;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNumber.Location = new System.Drawing.Point(116, 112);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 30);
            this.textBoxNumber.TabIndex = 16;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxYear.Location = new System.Drawing.Point(448, 50);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(144, 30);
            this.textBoxYear.TabIndex = 12;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBrand.Location = new System.Drawing.Point(116, 50);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(149, 30);
            this.textBoxBrand.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(598, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "л";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(297, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Объём двигателя:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(29, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Номер:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(297, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Год выпуска:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(29, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Марка:";
            // 
            // groupBoxBuilding
            // 
            this.groupBoxBuilding.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBuilding.Controls.Add(this.buttonBuilding_Clear);
            this.groupBoxBuilding.Controls.Add(this.buttonBuilding_Add);
            this.groupBoxBuilding.Controls.Add(this.label15);
            this.groupBoxBuilding.Controls.Add(this.textBoxArea);
            this.groupBoxBuilding.Controls.Add(this.textBoxAddress);
            this.groupBoxBuilding.Controls.Add(this.label14);
            this.groupBoxBuilding.Controls.Add(this.label13);
            this.groupBoxBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxBuilding.Location = new System.Drawing.Point(12, 584);
            this.groupBoxBuilding.Name = "groupBoxBuilding";
            this.groupBoxBuilding.Size = new System.Drawing.Size(849, 247);
            this.groupBoxBuilding.TabIndex = 1;
            this.groupBoxBuilding.TabStop = false;
            this.groupBoxBuilding.Text = "Административное здание";
            // 
            // buttonBuilding_Clear
            // 
            this.buttonBuilding_Clear.Location = new System.Drawing.Point(462, 176);
            this.buttonBuilding_Clear.Name = "buttonBuilding_Clear";
            this.buttonBuilding_Clear.Size = new System.Drawing.Size(348, 49);
            this.buttonBuilding_Clear.TabIndex = 19;
            this.buttonBuilding_Clear.Text = "Очистить";
            this.buttonBuilding_Clear.UseVisualStyleBackColor = true;
            this.buttonBuilding_Clear.Click += new System.EventHandler(this.buttonBuilding_Clear_Click);
            // 
            // buttonBuilding_Add
            // 
            this.buttonBuilding_Add.Location = new System.Drawing.Point(34, 176);
            this.buttonBuilding_Add.Name = "buttonBuilding_Add";
            this.buttonBuilding_Add.Size = new System.Drawing.Size(348, 49);
            this.buttonBuilding_Add.TabIndex = 19;
            this.buttonBuilding_Add.Text = "Добавить";
            this.buttonBuilding_Add.UseVisualStyleBackColor = true;
            this.buttonBuilding_Add.Click += new System.EventHandler(this.buttonBuilding_Add_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(310, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "м^2";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxArea.Location = new System.Drawing.Point(149, 113);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(155, 30);
            this.textBoxArea.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAddress.Location = new System.Drawing.Point(120, 44);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(704, 30);
            this.textBoxAddress.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(29, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Площадь:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(29, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Адресс:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.buttonShowAll);
            this.groupBox1.Controls.Add(this.buttonClearAll);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(890, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 714);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Массив массивов";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(6, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(851, 555);
            this.listBox1.TabIndex = 0;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(444, 625);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(394, 67);
            this.buttonClearAll.TabIndex = 20;
            this.buttonClearAll.Text = "Очистить";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(22, 625);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(388, 67);
            this.buttonShowAll.TabIndex = 21;
            this.buttonShowAll.Text = "Показать все записи";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(11, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1269, 87);
            this.label16.TabIndex = 20;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBuilding);
            this.Controls.Add(this.groupBoxCar);
            this.Controls.Add(this.groupBoxHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHuman.ResumeLayout(false);
            this.groupBoxHuman.PerformLayout();
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            this.groupBoxBuilding.ResumeLayout(false);
            this.groupBoxBuilding.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHuman;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.GroupBox groupBoxBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonHuman_Clear;
        private System.Windows.Forms.Button buttonHuman_Add;
        private System.Windows.Forms.Button buttonCar_Clear;
        private System.Windows.Forms.Button buttonCar_Add;
        private System.Windows.Forms.Button buttonBuilding_Clear;
        private System.Windows.Forms.Button buttonBuilding_Add;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label16;
    }
}

