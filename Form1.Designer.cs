
namespace Contact_Tracing
{
    partial class ContactTracingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_MName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_LName = new System.Windows.Forms.TextBox();
            this.txtbx_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_BDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_Address = new System.Windows.Forms.TextBox();
            this.lbl_Q1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_ContactNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_Email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbBox_Q1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbBox_Q2 = new System.Windows.Forms.ComboBox();
            this.lbl_Q2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbBox_Gender = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbBox_Q3 = new System.Windows.Forms.ComboBox();
            this.lbl_Q3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_FName
            // 
            this.txtbx_FName.Location = new System.Drawing.Point(12, 48);
            this.txtbx_FName.Name = "txtbx_FName";
            this.txtbx_FName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_FName.TabIndex = 0;
            this.txtbx_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_FName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle Name:";
            // 
            // txtbx_MName
            // 
            this.txtbx_MName.Location = new System.Drawing.Point(140, 48);
            this.txtbx_MName.Name = "txtbx_MName";
            this.txtbx_MName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_MName.TabIndex = 2;
            this.txtbx_MName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_MName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            // 
            // txtbx_LName
            // 
            this.txtbx_LName.Location = new System.Drawing.Point(269, 48);
            this.txtbx_LName.Name = "txtbx_LName";
            this.txtbx_LName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_LName.TabIndex = 4;
            this.txtbx_LName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_LName_KeyPress);
            // 
            // txtbx_Age
            // 
            this.txtbx_Age.Location = new System.Drawing.Point(140, 100);
            this.txtbx_Age.MaxLength = 2;
            this.txtbx_Age.Name = "txtbx_Age";
            this.txtbx_Age.Size = new System.Drawing.Size(51, 23);
            this.txtbx_Age.TabIndex = 6;
            this.txtbx_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Age_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birth Date:";
            // 
            // txtbx_BDate
            // 
            this.txtbx_BDate.Location = new System.Drawing.Point(12, 100);
            this.txtbx_BDate.Name = "txtbx_BDate";
            this.txtbx_BDate.Size = new System.Drawing.Size(113, 23);
            this.txtbx_BDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // txtbx_Address
            // 
            this.txtbx_Address.Location = new System.Drawing.Point(14, 206);
            this.txtbx_Address.Name = "txtbx_Address";
            this.txtbx_Address.Size = new System.Drawing.Size(252, 23);
            this.txtbx_Address.TabIndex = 14;
            // 
            // lbl_Q1
            // 
            this.lbl_Q1.AutoSize = true;
            this.lbl_Q1.Location = new System.Drawing.Point(6, 19);
            this.lbl_Q1.Name = "lbl_Q1";
            this.lbl_Q1.Size = new System.Drawing.Size(299, 15);
            this.lbl_Q1.TabIndex = 16;
            this.lbl_Q1.Text = "Do you have a fever, cough, or cold in the past 14 days?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Phone No.:";
            // 
            // txtbx_ContactNo
            // 
            this.txtbx_ContactNo.Location = new System.Drawing.Point(200, 100);
            this.txtbx_ContactNo.MaxLength = 11;
            this.txtbx_ContactNo.Name = "txtbx_ContactNo";
            this.txtbx_ContactNo.Size = new System.Drawing.Size(98, 23);
            this.txtbx_ContactNo.TabIndex = 22;
            this.txtbx_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_ContactNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Email:";
            // 
            // txtbx_Email
            // 
            this.txtbx_Email.Location = new System.Drawing.Point(140, 152);
            this.txtbx_Email.Name = "txtbx_Email";
            this.txtbx_Email.Size = new System.Drawing.Size(126, 23);
            this.txtbx_Email.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.CmbBox_Q1);
            this.groupBox1.Controls.Add(this.lbl_Q1);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 70);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // CmbBox_Q1
            // 
            this.CmbBox_Q1.FormattingEnabled = true;
            this.CmbBox_Q1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBox_Q1.Location = new System.Drawing.Point(6, 37);
            this.CmbBox_Q1.Name = "CmbBox_Q1";
            this.CmbBox_Q1.Size = new System.Drawing.Size(76, 23);
            this.CmbBox_Q1.TabIndex = 29;
            this.CmbBox_Q1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBox_Q1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbBox_Q2);
            this.groupBox2.Controls.Add(this.lbl_Q2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 70);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // CmbBox_Q2
            // 
            this.CmbBox_Q2.FormattingEnabled = true;
            this.CmbBox_Q2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBox_Q2.Location = new System.Drawing.Point(6, 37);
            this.CmbBox_Q2.Name = "CmbBox_Q2";
            this.CmbBox_Q2.Size = new System.Drawing.Size(76, 23);
            this.CmbBox_Q2.TabIndex = 30;
            this.CmbBox_Q2.SelectedIndexChanged += new System.EventHandler(this.CmbBox_Q2_SelectedIndexChanged);
            this.CmbBox_Q2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBox_Q2_KeyPress);
            // 
            // lbl_Q2
            // 
            this.lbl_Q2.AutoSize = true;
            this.lbl_Q2.Location = new System.Drawing.Point(12, 19);
            this.lbl_Q2.Name = "lbl_Q2";
            this.lbl_Q2.Size = new System.Drawing.Size(247, 15);
            this.lbl_Q2.TabIndex = 22;
            this.lbl_Q2.Text = "Are you diagnosed with CoVid-19 in the past?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 16;
            // 
            // CmbBox_Gender
            // 
            this.CmbBox_Gender.FormattingEnabled = true;
            this.CmbBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbBox_Gender.Location = new System.Drawing.Point(14, 152);
            this.CmbBox_Gender.Name = "CmbBox_Gender";
            this.CmbBox_Gender.Size = new System.Drawing.Size(111, 23);
            this.CmbBox_Gender.TabIndex = 28;
            this.CmbBox_Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBox_Gender_KeyPress);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(80, 487);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 29;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(161, 487);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 30;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbBox_Q3);
            this.groupBox3.Controls.Add(this.lbl_Q3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 85);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // CmbBox_Q3
            // 
            this.CmbBox_Q3.FormattingEnabled = true;
            this.CmbBox_Q3.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBox_Q3.Location = new System.Drawing.Point(6, 52);
            this.CmbBox_Q3.Name = "CmbBox_Q3";
            this.CmbBox_Q3.Size = new System.Drawing.Size(76, 23);
            this.CmbBox_Q3.TabIndex = 30;
            this.CmbBox_Q3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBox_Q3_KeyPress);
            // 
            // lbl_Q3
            // 
            this.lbl_Q3.AutoSize = true;
            this.lbl_Q3.Location = new System.Drawing.Point(12, 19);
            this.lbl_Q3.Name = "lbl_Q3";
            this.lbl_Q3.Size = new System.Drawing.Size(276, 30);
            this.lbl_Q3.TabIndex = 22;
            this.lbl_Q3.Text = "Have you travelled outside the country/NCR in the \r\npast 14 days?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 16;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(242, 487);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 32;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.CmbBox_Gender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbx_Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_ContactNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_BDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_LName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_MName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_FName);
            this.Name = "ContactTracingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid Contact Tracing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_MName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_LName;
        private System.Windows.Forms.TextBox txtbx_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_BDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_Address;
        private System.Windows.Forms.Label lbl_Q1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_ContactNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Q2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbBox_Q1;
        private System.Windows.Forms.ComboBox CmbBox_Q2;
        private System.Windows.Forms.ComboBox CmbBox_Gender;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbBox_Q3;
        private System.Windows.Forms.Label lbl_Q3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Exit;
    }
}

