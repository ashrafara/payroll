namespace payroll.Main
{
    partial class AddDegree
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
            this.txtbounsCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdegreecost = new System.Windows.Forms.TextBox();
            this.txtdegreeNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbounsCost
            // 
            this.txtbounsCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbounsCost.Location = new System.Drawing.Point(192, 177);
            this.txtbounsCost.Name = "txtbounsCost";
            this.txtbounsCost.Size = new System.Drawing.Size(91, 26);
            this.txtbounsCost.TabIndex = 3;
            this.txtbounsCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbounsCost.TextChanged += new System.EventHandler(this.txtbounsCost_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "قيمة العلاوة السنوية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "القيمة المالية";
            // 
            // btnExist
            // 
            this.btnExist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(297, 252);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(62, 30);
            this.btnExist.TabIndex = 5;
            this.btnExist.Text = "الخروج";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(229, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "الدرجات الوظيفية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "اسم الدرجة الوظيفية";
            // 
            // txtdegreecost
            // 
            this.txtdegreecost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdegreecost.Location = new System.Drawing.Point(191, 124);
            this.txtdegreecost.Name = "txtdegreecost";
            this.txtdegreecost.Size = new System.Drawing.Size(92, 26);
            this.txtdegreecost.TabIndex = 2;
            this.txtdegreecost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdegreecost.TextChanged += new System.EventHandler(this.txtdegreecost_TextChanged);
            // 
            // txtdegreeNo
            // 
            this.txtdegreeNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdegreeNo.Location = new System.Drawing.Point(191, 71);
            this.txtdegreeNo.Name = "txtdegreeNo";
            this.txtdegreeNo.Size = new System.Drawing.Size(92, 26);
            this.txtdegreeNo.TabIndex = 1;
            this.txtdegreeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdegreeNo.TextChanged += new System.EventHandler(this.txtdegreeNo_TextChanged);
            // 
            // AddDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.txtbounsCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdegreecost);
            this.Controls.Add(this.txtdegreeNo);
            this.Name = "AddDegree";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدرجات الوظيفية";
            this.Load += new System.EventHandler(this.AddDegree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbounsCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdegreecost;
        private System.Windows.Forms.TextBox txtdegreeNo;
    }
}