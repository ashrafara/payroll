namespace payroll.Main
{
    partial class AnnualBounsDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnualBounsDate));
            this.allowanceLogDate = new System.Windows.Forms.DateTimePicker();
            this.cbemployeeId = new System.Windows.Forms.ComboBox();
            this.txtallowanceLogNotes = new System.Windows.Forms.TextBox();
            this.cbemployementDegreeId = new System.Windows.Forms.ComboBox();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBouns = new System.Windows.Forms.ComboBox();
            this.txtbouns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allowanceLogDate
            // 
            this.allowanceLogDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowanceLogDate.Location = new System.Drawing.Point(152, 183);
            this.allowanceLogDate.Name = "allowanceLogDate";
            this.allowanceLogDate.Size = new System.Drawing.Size(251, 24);
            this.allowanceLogDate.TabIndex = 73;
            // 
            // cbemployeeId
            // 
            this.cbemployeeId.DisplayMember = "employeeId";
            this.cbemployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbemployeeId.FormattingEnabled = true;
            this.cbemployeeId.Location = new System.Drawing.Point(152, 69);
            this.cbemployeeId.Name = "cbemployeeId";
            this.cbemployeeId.Size = new System.Drawing.Size(252, 28);
            this.cbemployeeId.TabIndex = 72;
            this.cbemployeeId.ValueMember = "employeeId";
            this.cbemployeeId.SelectedIndexChanged += new System.EventHandler(this.cbemployeeId_SelectedIndexChanged);
            // 
            // txtallowanceLogNotes
            // 
            this.txtallowanceLogNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallowanceLogNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtallowanceLogNotes.Location = new System.Drawing.Point(151, 221);
            this.txtallowanceLogNotes.Name = "txtallowanceLogNotes";
            this.txtallowanceLogNotes.Size = new System.Drawing.Size(252, 27);
            this.txtallowanceLogNotes.TabIndex = 71;
            this.txtallowanceLogNotes.TextChanged += new System.EventHandler(this.txtallowanceLogNotes_TextChanged);
            // 
            // cbemployementDegreeId
            // 
            this.cbemployementDegreeId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbemployementDegreeId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbemployementDegreeId.FormattingEnabled = true;
            this.cbemployementDegreeId.Location = new System.Drawing.Point(151, 106);
            this.cbemployementDegreeId.Name = "cbemployementDegreeId";
            this.cbemployementDegreeId.Size = new System.Drawing.Size(252, 27);
            this.cbemployementDegreeId.TabIndex = 69;
            this.cbemployementDegreeId.SelectedIndexChanged += new System.EventHandler(this.cbemployementDegreeId_SelectedIndexChanged);
            // 
            // btnExist
            // 
            this.btnExist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(352, 278);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 35);
            this.btnExist.TabIndex = 68;
            this.btnExist.Text = "الخروج";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(271, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "تواريخ استحقاق العلاوات السنوية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "ملاحظات العلاوة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "تاريخ العلاوة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "العلاوة السنوية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "الدرجة الوظيفية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "اسم الموظف";
            // 
            // cbBouns
            // 
            this.cbBouns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBouns.FormattingEnabled = true;
            this.cbBouns.Location = new System.Drawing.Point(28, 291);
            this.cbBouns.Name = "cbBouns";
            this.cbBouns.Size = new System.Drawing.Size(121, 28);
            this.cbBouns.TabIndex = 74;
            // 
            // txtbouns
            // 
            this.txtbouns.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbouns.Location = new System.Drawing.Point(151, 143);
            this.txtbouns.Name = "txtbouns";
            this.txtbouns.Size = new System.Drawing.Size(251, 27);
            this.txtbouns.TabIndex = 75;
            // 
            // AnnualBounsDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 340);
            this.Controls.Add(this.txtbouns);
            this.Controls.Add(this.cbBouns);
            this.Controls.Add(this.allowanceLogDate);
            this.Controls.Add(this.cbemployeeId);
            this.Controls.Add(this.txtallowanceLogNotes);
            this.Controls.Add(this.cbemployementDegreeId);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnnualBounsDate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العلاوة السنوية";
            this.Load += new System.EventHandler(this.AnnualBounsDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker allowanceLogDate;
        private System.Windows.Forms.ComboBox cbemployeeId;
        private System.Windows.Forms.TextBox txtallowanceLogNotes;
        private System.Windows.Forms.ComboBox cbemployementDegreeId;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBouns;
        private System.Windows.Forms.TextBox txtbouns;
    }
}