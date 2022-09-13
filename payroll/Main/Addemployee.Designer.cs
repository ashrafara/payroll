namespace payroll.Main
{
    partial class Addemployee
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
            this.txtemployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtemployeeInsuranceNumber = new System.Windows.Forms.TextBox();
            this.txtemployeeNationalNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtemployeeBankNumber = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemployementName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbDegreee = new System.Windows.Forms.ComboBox();
            this.txtbouns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbounsAssign = new System.Windows.Forms.TextBox();
            this.txtdegreAssign = new System.Windows.Forms.TextBox();
            this.coDepartement = new System.Windows.Forms.ComboBox();
            this.coDivision = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.coBank = new System.Windows.Forms.ComboBox();
            this.coBankBranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtemployeeName
            // 
            this.txtemployeeName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeName.Location = new System.Drawing.Point(138, 45);
            this.txtemployeeName.Name = "txtemployeeName";
            this.txtemployeeName.Size = new System.Drawing.Size(246, 26);
            this.txtemployeeName.TabIndex = 1;
            this.txtemployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployeeName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الموظف";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(417, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "الرقم الضماني";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(752, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "الرقم الوطني";
            // 
            // txtemployeeInsuranceNumber
            // 
            this.txtemployeeInsuranceNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeInsuranceNumber.Location = new System.Drawing.Point(510, 44);
            this.txtemployeeInsuranceNumber.Name = "txtemployeeInsuranceNumber";
            this.txtemployeeInsuranceNumber.Size = new System.Drawing.Size(229, 26);
            this.txtemployeeInsuranceNumber.TabIndex = 2;
            this.txtemployeeInsuranceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemployeeInsuranceNumber.TextChanged += new System.EventHandler(this.txtemployeeInsuranceNumber_TextChanged);
            this.txtemployeeInsuranceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployeeInsuranceNumber_KeyPress);
            // 
            // txtemployeeNationalNumber
            // 
            this.txtemployeeNationalNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeNationalNumber.Location = new System.Drawing.Point(841, 44);
            this.txtemployeeNationalNumber.Name = "txtemployeeNationalNumber";
            this.txtemployeeNationalNumber.Size = new System.Drawing.Size(235, 26);
            this.txtemployeeNationalNumber.TabIndex = 3;
            this.txtemployeeNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemployeeNationalNumber.TextChanged += new System.EventHandler(this.txtemployeeNationalNumber_TextChanged);
            this.txtemployeeNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployeeNationalNumber_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(458, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 18);
            this.label20.TabIndex = 8;
            this.label20.Text = "القسم ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(758, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 18);
            this.label23.TabIndex = 9;
            this.label23.Text = "اسم الوظيفة";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(38, 163);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 18);
            this.label25.TabIndex = 10;
            this.label25.Text = "الدرجة الوظيفية";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(754, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 18);
            this.label21.TabIndex = 11;
            this.label21.Text = "رقم الحساب ";
            // 
            // txtemployeeBankNumber
            // 
            this.txtemployeeBankNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeBankNumber.Location = new System.Drawing.Point(841, 85);
            this.txtemployeeBankNumber.Name = "txtemployeeBankNumber";
            this.txtemployeeBankNumber.Size = new System.Drawing.Size(235, 26);
            this.txtemployeeBankNumber.TabIndex = 5;
            this.txtemployeeBankNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemployeeBankNumber.TextChanged += new System.EventHandler(this.txtemployeeBankNumber_TextChanged);
            this.txtemployeeBankNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployeeBankNumber_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(58, 131);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 18);
            this.label29.TabIndex = 14;
            this.label29.Text = "اسم الادارة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "العلاوة السنوية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "نوع التوظيف";
            // 
            // txtemployementName
            // 
            this.txtemployementName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployementName.Location = new System.Drawing.Point(844, 125);
            this.txtemployementName.Name = "txtemployementName";
            this.txtemployementName.Size = new System.Drawing.Size(233, 26);
            this.txtemployementName.TabIndex = 8;
            this.txtemployementName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemployementName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployementName_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1001, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(920, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "اضافة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbDegreee
            // 
            this.cbDegreee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDegreee.FormattingEnabled = true;
            this.cbDegreee.Location = new System.Drawing.Point(139, 163);
            this.cbDegreee.Name = "cbDegreee";
            this.cbDegreee.Size = new System.Drawing.Size(245, 26);
            this.cbDegreee.TabIndex = 9;
            // 
            // txtbouns
            // 
            this.txtbouns.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbouns.Location = new System.Drawing.Point(512, 163);
            this.txtbouns.Name = "txtbouns";
            this.txtbouns.Size = new System.Drawing.Size(227, 26);
            this.txtbouns.TabIndex = 10;
            this.txtbouns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbouns.TextChanged += new System.EventHandler(this.txtbouns_TextChanged);
            this.txtbouns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbouns_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "الجنسية";
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(138, 203);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(246, 26);
            this.txtNationality.TabIndex = 12;
            this.txtNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationality_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "تاريخ المباشرة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "تعيين",
            "عقد ",
            "ندب",
            "موفد"});
            this.comboBox1.Location = new System.Drawing.Point(843, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 26);
            this.comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "حالة المرتب";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "مفعل",
            "موقوف"});
            this.comboBox2.Location = new System.Drawing.Point(844, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 26);
            this.comboBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "الدرجة المنتدب اليها";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "العلاوة المنتدب اليها";
            // 
            // txtbounsAssign
            // 
            this.txtbounsAssign.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbounsAssign.Location = new System.Drawing.Point(512, 251);
            this.txtbounsAssign.Name = "txtbounsAssign";
            this.txtbounsAssign.Size = new System.Drawing.Size(227, 26);
            this.txtbounsAssign.TabIndex = 16;
            this.txtbounsAssign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbounsAssign.TextChanged += new System.EventHandler(this.txtbouns_TextChanged);
            this.txtbounsAssign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbounsAssign_KeyPress);
            // 
            // txtdegreAssign
            // 
            this.txtdegreAssign.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdegreAssign.Location = new System.Drawing.Point(138, 251);
            this.txtdegreAssign.Name = "txtdegreAssign";
            this.txtdegreAssign.Size = new System.Drawing.Size(246, 26);
            this.txtdegreAssign.TabIndex = 15;
            this.txtdegreAssign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdegreAssign.TextChanged += new System.EventHandler(this.txtbouns_TextChanged);
            this.txtdegreAssign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdegreAssign_KeyPress);
            // 
            // coDepartement
            // 
            this.coDepartement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coDepartement.FormattingEnabled = true;
            this.coDepartement.Items.AddRange(new object[] {
            "مدير عام المركز",
            "مكتب المدير العام",
            "مكتب المراجعة الداخلية",
            "مكتب الشؤون القانونية",
            "مكتب التفتيش الفني",
            "إدارة الشؤون الادارية والمالية",
            "إدارة الدراسات والتخطيط",
            "إدارة التوثيق والارشيف",
            "إدارة نظم المعلومات",
            "إدارة الشئون الفنية والشبكات",
            "لا يوجد"});
            this.coDepartement.Location = new System.Drawing.Point(140, 121);
            this.coDepartement.Name = "coDepartement";
            this.coDepartement.Size = new System.Drawing.Size(244, 26);
            this.coDepartement.TabIndex = 6;
            // 
            // coDivision
            // 
            this.coDivision.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coDivision.FormattingEnabled = true;
            this.coDivision.Items.AddRange(new object[] {
            "قسم الشئون الادارية والعلاقات",
            "الموارد البشرية",
            "قسم الدراسات والاحصاء ",
            "قسم التخطيط",
            "قسم التقارير وخدمات المستفيدين",
            "قسم الاعلام والترجمة",
            "الارشيف الالكتروني",
            "ادخال وتدقيق البيانات ",
            "الارشيف الورقي",
            "قسم قواعد البيانات",
            "قسم الخدمات الالكترونية",
            "قسم البرمجة",
            "الصيانة والدعم الفني واسترجاع البيانات",
            "قسم الشبكات والاتصالات",
            "قسمة السلامة المعلوماتية",
            "قسم الشئون المالية",
            "لا يوجد"});
            this.coDivision.Location = new System.Drawing.Point(510, 125);
            this.coDivision.Name = "coDivision";
            this.coDivision.Size = new System.Drawing.Size(226, 26);
            this.coDivision.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "المصرف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "الفرع";
            // 
            // coBank
            // 
            this.coBank.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBank.FormattingEnabled = true;
            this.coBank.Location = new System.Drawing.Point(138, 84);
            this.coBank.Name = "coBank";
            this.coBank.Size = new System.Drawing.Size(244, 26);
            this.coBank.TabIndex = 4;
            this.coBank.SelectedIndexChanged += new System.EventHandler(this.coBank_SelectedIndexChanged);
            // 
            // coBankBranch
            // 
            this.coBankBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBankBranch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBankBranch.FormattingEnabled = true;
            this.coBankBranch.Location = new System.Drawing.Point(510, 83);
            this.coBankBranch.Name = "coBankBranch";
            this.coBankBranch.Size = new System.Drawing.Size(229, 26);
            this.coBankBranch.TabIndex = 69;
            // 
            // Addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 308);
            this.Controls.Add(this.coBankBranch);
            this.Controls.Add(this.coBank);
            this.Controls.Add(this.coDivision);
            this.Controls.Add(this.coDepartement);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtdegreAssign);
            this.Controls.Add(this.txtbounsAssign);
            this.Controls.Add(this.txtbouns);
            this.Controls.Add(this.cbDegreee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemployementName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtemployeeBankNumber);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtemployeeInsuranceNumber);
            this.Controls.Add(this.txtemployeeNationalNumber);
            this.Controls.Add(this.txtemployeeName);
            this.Controls.Add(this.label1);
            this.Name = "Addemployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة موظف";
            this.Load += new System.EventHandler(this.Addemployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtemployeeInsuranceNumber;
        private System.Windows.Forms.TextBox txtemployeeNationalNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtemployeeBankNumber;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemployementName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbDegreee;
        private System.Windows.Forms.TextBox txtbouns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbounsAssign;
        private System.Windows.Forms.TextBox txtdegreAssign;
        private System.Windows.Forms.ComboBox coDepartement;
        private System.Windows.Forms.ComboBox coDivision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox coBank;
        private System.Windows.Forms.ComboBox coBankBranch;
    }
}