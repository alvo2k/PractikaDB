namespace PractikaDB
{
    partial class Form_ankete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ankete));
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.groupBoxAnkete = new System.Windows.Forms.GroupBox();
            this.lblCompensation = new System.Windows.Forms.Label();
            this.tbxCompensation = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.dateBday = new System.Windows.Forms.DateTimePicker();
            this.lblBday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tbxWorkplace = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.groupBoxPhisics = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDisease = new System.Windows.Forms.CheckBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.comboBoxHairColor = new System.Windows.Forms.ComboBox();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.btnPsyco = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.imageLoaded = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxAnkete.SuspendLayout();
            this.groupBoxPhisics.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLoaded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(22, 46);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(103, 25);
            this.lblSurname.TabIndex = 100;
            this.lblSurname.Text = "Фамилия";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSurname.Location = new System.Drawing.Point(178, 34);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(326, 26);
            this.tbxSurname.TabIndex = 1;
            // 
            // groupBoxAnkete
            // 
            this.groupBoxAnkete.Controls.Add(this.lblCompensation);
            this.groupBoxAnkete.Controls.Add(this.tbxCompensation);
            this.groupBoxAnkete.Controls.Add(this.lblPosition);
            this.groupBoxAnkete.Controls.Add(this.tbxPosition);
            this.groupBoxAnkete.Controls.Add(this.lblEmail);
            this.groupBoxAnkete.Controls.Add(this.tbxEmail);
            this.groupBoxAnkete.Controls.Add(this.lblPhone);
            this.groupBoxAnkete.Controls.Add(this.tbxPhone);
            this.groupBoxAnkete.Controls.Add(this.dateBday);
            this.groupBoxAnkete.Controls.Add(this.lblBday);
            this.groupBoxAnkete.Controls.Add(this.label2);
            this.groupBoxAnkete.Controls.Add(this.lblMiddleName);
            this.groupBoxAnkete.Controls.Add(this.tbxWorkplace);
            this.groupBoxAnkete.Controls.Add(this.tbxMiddleName);
            this.groupBoxAnkete.Controls.Add(this.lblName);
            this.groupBoxAnkete.Controls.Add(this.tbxName);
            this.groupBoxAnkete.Controls.Add(this.tbxSurname);
            this.groupBoxAnkete.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnkete.Name = "groupBoxAnkete";
            this.groupBoxAnkete.Size = new System.Drawing.Size(514, 371);
            this.groupBoxAnkete.TabIndex = 2;
            this.groupBoxAnkete.TabStop = false;
            this.groupBoxAnkete.Text = "Анкета";
            // 
            // lblCompensation
            // 
            this.lblCompensation.AutoSize = true;
            this.lblCompensation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompensation.Location = new System.Drawing.Point(10, 325);
            this.lblCompensation.Name = "lblCompensation";
            this.lblCompensation.Size = new System.Drawing.Size(73, 25);
            this.lblCompensation.TabIndex = 606;
            this.lblCompensation.Text = "Доход";
            // 
            // tbxCompensation
            // 
            this.tbxCompensation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCompensation.Location = new System.Drawing.Point(178, 325);
            this.tbxCompensation.Name = "tbxCompensation";
            this.tbxCompensation.Size = new System.Drawing.Size(326, 26);
            this.tbxCompensation.TabIndex = 9;
            this.tbxCompensation.Text = "0";
            this.tbxCompensation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCompensation_KeyPress);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(10, 288);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(123, 25);
            this.lblPosition.TabIndex = 604;
            this.lblPosition.Text = "Должность";
            // 
            // tbxPosition
            // 
            this.tbxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPosition.Location = new System.Drawing.Point(178, 288);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(326, 26);
            this.tbxPosition.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(10, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 602;
            this.lblEmail.Text = "E-mail";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxEmail.Location = new System.Drawing.Point(178, 217);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(326, 26);
            this.tbxEmail.TabIndex = 6;
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(10, 182);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 25);
            this.lblPhone.TabIndex = 80;
            this.lblPhone.Text = "Телефон";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPhone.Location = new System.Drawing.Point(178, 182);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(326, 26);
            this.tbxPhone.TabIndex = 5;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // dateBday
            // 
            this.dateBday.CustomFormat = "dd.MM.yyyy";
            this.dateBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBday.Location = new System.Drawing.Point(296, 145);
            this.dateBday.Name = "dateBday";
            this.dateBday.Size = new System.Drawing.Size(210, 26);
            this.dateBday.TabIndex = 4;
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBday.Location = new System.Drawing.Point(10, 145);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(161, 25);
            this.lblBday.TabIndex = 600;
            this.lblBday.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 400;
            this.label2.Text = "Место работы";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMiddleName.Location = new System.Drawing.Point(10, 109);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(104, 25);
            this.lblMiddleName.TabIndex = 400;
            this.lblMiddleName.Text = "Отчество";
            // 
            // tbxWorkplace
            // 
            this.tbxWorkplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWorkplace.Location = new System.Drawing.Point(178, 252);
            this.tbxWorkplace.Name = "tbxWorkplace";
            this.tbxWorkplace.Size = new System.Drawing.Size(326, 26);
            this.tbxWorkplace.TabIndex = 7;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxMiddleName.Location = new System.Drawing.Point(178, 109);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(326, 26);
            this.tbxMiddleName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(10, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 25);
            this.lblName.TabIndex = 200;
            this.lblName.Text = "Имя";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxName.Location = new System.Drawing.Point(178, 72);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(326, 26);
            this.tbxName.TabIndex = 2;
            // 
            // groupBoxPhisics
            // 
            this.groupBoxPhisics.Controls.Add(this.label1);
            this.groupBoxPhisics.Controls.Add(this.checkBoxDisease);
            this.groupBoxPhisics.Controls.Add(this.lblHeight);
            this.groupBoxPhisics.Controls.Add(this.tbxHeight);
            this.groupBoxPhisics.Controls.Add(this.lblWeight);
            this.groupBoxPhisics.Controls.Add(this.comboBoxHairColor);
            this.groupBoxPhisics.Controls.Add(this.tbxWeight);
            this.groupBoxPhisics.Controls.Add(this.lblHairColor);
            this.groupBoxPhisics.Location = new System.Drawing.Point(14, 389);
            this.groupBoxPhisics.Name = "groupBoxPhisics";
            this.groupBoxPhisics.Size = new System.Drawing.Size(514, 185);
            this.groupBoxPhisics.TabIndex = 101;
            this.groupBoxPhisics.TabStop = false;
            this.groupBoxPhisics.Text = "Физические показатели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 612;
            this.label1.Text = "Неизлечимые болезни";
            // 
            // checkBoxDisease
            // 
            this.checkBoxDisease.AutoSize = true;
            this.checkBoxDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDisease.Location = new System.Drawing.Point(432, 148);
            this.checkBoxDisease.Name = "checkBoxDisease";
            this.checkBoxDisease.Size = new System.Drawing.Size(72, 24);
            this.checkBoxDisease.TabIndex = 13;
            this.checkBoxDisease.Text = "Есть";
            this.checkBoxDisease.UseVisualStyleBackColor = true;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(10, 111);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 25);
            this.lblHeight.TabIndex = 610;
            this.lblHeight.Text = "Рост";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxHeight.Location = new System.Drawing.Point(178, 111);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(326, 26);
            this.tbxHeight.TabIndex = 12;
            this.tbxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWeight_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeight.Location = new System.Drawing.Point(10, 75);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(45, 25);
            this.lblWeight.TabIndex = 608;
            this.lblWeight.Text = "Вес";
            // 
            // comboBoxHairColor
            // 
            this.comboBoxHairColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHairColor.FormattingEnabled = true;
            this.comboBoxHairColor.Items.AddRange(new object[] {
            "Блонд",
            "Брюнет",
            "Шатен",
            "Рыжий",
            "Другой"});
            this.comboBoxHairColor.Location = new System.Drawing.Point(178, 35);
            this.comboBoxHairColor.Name = "comboBoxHairColor";
            this.comboBoxHairColor.Size = new System.Drawing.Size(326, 28);
            this.comboBoxHairColor.TabIndex = 10;
            this.comboBoxHairColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxHairColor_KeyPress);
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxWeight.Location = new System.Drawing.Point(178, 75);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(326, 26);
            this.tbxWeight.TabIndex = 11;
            this.tbxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWeight_KeyPress);
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHairColor.Location = new System.Drawing.Point(10, 35);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(118, 25);
            this.lblHairColor.TabIndex = 608;
            this.lblHairColor.Text = "Цвет волос";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(260, 580);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 45);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPhoto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPhoto.Location = new System.Drawing.Point(15, 580);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(194, 45);
            this.btnPhoto.TabIndex = 14;
            this.btnPhoto.Text = "Загрузить фото";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(394, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.btnPsyco);
            this.groupBoxControls.Controls.Add(this.btnAdmin);
            this.groupBoxControls.Location = new System.Drawing.Point(534, 12);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(194, 152);
            this.groupBoxControls.TabIndex = 102;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Панель управления";
            // 
            // btnPsyco
            // 
            this.btnPsyco.BackColor = System.Drawing.Color.LightCoral;
            this.btnPsyco.ForeColor = System.Drawing.Color.White;
            this.btnPsyco.Location = new System.Drawing.Point(6, 89);
            this.btnPsyco.Name = "btnPsyco";
            this.btnPsyco.Size = new System.Drawing.Size(184, 55);
            this.btnPsyco.TabIndex = 18;
            this.btnPsyco.Text = "Психологический тест";
            this.btnPsyco.UseVisualStyleBackColor = false;
            this.btnPsyco.Click += new System.EventHandler(this.btnPsyco_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdmin.Location = new System.Drawing.Point(6, 28);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(184, 55);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "Войти как администратор";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // imageLoaded
            // 
            this.imageLoaded.BackgroundImage = global::PractikaDB.Properties.Resources._checked;
            this.imageLoaded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageLoaded.Location = new System.Drawing.Point(217, 587);
            this.imageLoaded.Name = "imageLoaded";
            this.imageLoaded.Size = new System.Drawing.Size(32, 32);
            this.imageLoaded.TabIndex = 103;
            this.imageLoaded.TabStop = false;
            this.imageLoaded.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(532, 170);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(197, 404);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 104;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // Form_ankete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 642);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.imageLoaded);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxPhisics);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.groupBoxAnkete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ankete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с клиентами";
            this.Load += new System.EventHandler(this.Form_ankete_Load);
            this.groupBoxAnkete.ResumeLayout(false);
            this.groupBoxAnkete.PerformLayout();
            this.groupBoxPhisics.ResumeLayout(false);
            this.groupBoxPhisics.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLoaded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.GroupBox groupBoxAnkete;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWorkplace;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.DateTimePicker dateBday;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblCompensation;
        private System.Windows.Forms.TextBox tbxCompensation;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.GroupBox groupBoxPhisics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDisease;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ComboBox comboBoxHairColor;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button btnPsyco;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox imageLoaded;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

