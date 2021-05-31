
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
            this.Radbtn_Male_Gndr = new System.Windows.Forms.RadioButton();
            this.Radbtn_Female_Gndr = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Radbtn_No_Q1 = new System.Windows.Forms.RadioButton();
            this.Radbtn_Yes_Q1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Radbtn_No_Q2 = new System.Windows.Forms.RadioButton();
            this.Radbtn_Yes_Q2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_ContactNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbx_FName
            // 
            this.txtbx_FName.Location = new System.Drawing.Point(12, 48);
            this.txtbx_FName.Name = "txtbx_FName";
            this.txtbx_FName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_FName.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle Name:";
            // 
            // txtbx_MName
            // 
            this.txtbx_MName.Location = new System.Drawing.Point(12, 100);
            this.txtbx_MName.Name = "txtbx_MName";
            this.txtbx_MName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_MName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            // 
            // txtbx_LName
            // 
            this.txtbx_LName.Location = new System.Drawing.Point(12, 152);
            this.txtbx_LName.Name = "txtbx_LName";
            this.txtbx_LName.Size = new System.Drawing.Size(113, 23);
            this.txtbx_LName.TabIndex = 4;
            // 
            // txtbx_Age
            // 
            this.txtbx_Age.Location = new System.Drawing.Point(175, 48);
            this.txtbx_Age.Name = "txtbx_Age";
            this.txtbx_Age.Size = new System.Drawing.Size(51, 23);
            this.txtbx_Age.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birth Date:";
            // 
            // txtbx_BDate
            // 
            this.txtbx_BDate.Location = new System.Drawing.Point(175, 100);
            this.txtbx_BDate.Name = "txtbx_BDate";
            this.txtbx_BDate.Size = new System.Drawing.Size(123, 23);
            this.txtbx_BDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender:";
            // 
            // Radbtn_Male_Gndr
            // 
            this.Radbtn_Male_Gndr.AutoSize = true;
            this.Radbtn_Male_Gndr.Location = new System.Drawing.Point(178, 152);
            this.Radbtn_Male_Gndr.Name = "Radbtn_Male_Gndr";
            this.Radbtn_Male_Gndr.Size = new System.Drawing.Size(51, 19);
            this.Radbtn_Male_Gndr.TabIndex = 12;
            this.Radbtn_Male_Gndr.TabStop = true;
            this.Radbtn_Male_Gndr.Text = "Male";
            this.Radbtn_Male_Gndr.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Female_Gndr
            // 
            this.Radbtn_Female_Gndr.AutoSize = true;
            this.Radbtn_Female_Gndr.Location = new System.Drawing.Point(235, 152);
            this.Radbtn_Female_Gndr.Name = "Radbtn_Female_Gndr";
            this.Radbtn_Female_Gndr.Size = new System.Drawing.Size(63, 19);
            this.Radbtn_Female_Gndr.TabIndex = 13;
            this.Radbtn_Female_Gndr.TabStop = true;
            this.Radbtn_Female_Gndr.Text = "Female";
            this.Radbtn_Female_Gndr.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // txtbx_Address
            // 
            this.txtbx_Address.Location = new System.Drawing.Point(12, 205);
            this.txtbx_Address.Name = "txtbx_Address";
            this.txtbx_Address.Size = new System.Drawing.Size(286, 23);
            this.txtbx_Address.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Do you have a fever, cough, or cold in the past 14 days?";
            // 
            // Radbtn_No_Q1
            // 
            this.Radbtn_No_Q1.AutoSize = true;
            this.Radbtn_No_Q1.Location = new System.Drawing.Point(69, 315);
            this.Radbtn_No_Q1.Name = "Radbtn_No_Q1";
            this.Radbtn_No_Q1.Size = new System.Drawing.Size(41, 19);
            this.Radbtn_No_Q1.TabIndex = 18;
            this.Radbtn_No_Q1.TabStop = true;
            this.Radbtn_No_Q1.Text = "No";
            this.Radbtn_No_Q1.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Yes_Q1
            // 
            this.Radbtn_Yes_Q1.AutoSize = true;
            this.Radbtn_Yes_Q1.Location = new System.Drawing.Point(12, 315);
            this.Radbtn_Yes_Q1.Name = "Radbtn_Yes_Q1";
            this.Radbtn_Yes_Q1.Size = new System.Drawing.Size(42, 19);
            this.Radbtn_Yes_Q1.TabIndex = 17;
            this.Radbtn_Yes_Q1.TabStop = true;
            this.Radbtn_Yes_Q1.Text = "Yes";
            this.Radbtn_Yes_Q1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Are you diagnosed with CoVid-19 in the past?";
            // 
            // Radbtn_No_Q2
            // 
            this.Radbtn_No_Q2.AutoSize = true;
            this.Radbtn_No_Q2.Location = new System.Drawing.Point(69, 375);
            this.Radbtn_No_Q2.Name = "Radbtn_No_Q2";
            this.Radbtn_No_Q2.Size = new System.Drawing.Size(41, 19);
            this.Radbtn_No_Q2.TabIndex = 21;
            this.Radbtn_No_Q2.TabStop = true;
            this.Radbtn_No_Q2.Text = "No";
            this.Radbtn_No_Q2.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Yes_Q2
            // 
            this.Radbtn_Yes_Q2.AutoSize = true;
            this.Radbtn_Yes_Q2.Location = new System.Drawing.Point(12, 375);
            this.Radbtn_Yes_Q2.Name = "Radbtn_Yes_Q2";
            this.Radbtn_Yes_Q2.Size = new System.Drawing.Size(42, 19);
            this.Radbtn_Yes_Q2.TabIndex = 20;
            this.Radbtn_Yes_Q2.TabStop = true;
            this.Radbtn_Yes_Q2.Text = "Yes";
            this.Radbtn_Yes_Q2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Contact No.:";
            // 
            // txtbx_ContactNo
            // 
            this.txtbx_ContactNo.Location = new System.Drawing.Point(12, 259);
            this.txtbx_ContactNo.Name = "txtbx_ContactNo";
            this.txtbx_ContactNo.Size = new System.Drawing.Size(98, 23);
            this.txtbx_ContactNo.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Email:";
            // 
            // txtbx_Email
            // 
            this.txtbx_Email.Location = new System.Drawing.Point(125, 259);
            this.txtbx_Email.Name = "txtbx_Email";
            this.txtbx_Email.Size = new System.Drawing.Size(173, 23);
            this.txtbx_Email.TabIndex = 24;
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 398);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbx_Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_ContactNo);
            this.Controls.Add(this.Radbtn_No_Q2);
            this.Controls.Add(this.Radbtn_Yes_Q2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Radbtn_No_Q1);
            this.Controls.Add(this.Radbtn_Yes_Q1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_Address);
            this.Controls.Add(this.Radbtn_Female_Gndr);
            this.Controls.Add(this.Radbtn_Male_Gndr);
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
            this.Text = "Covid Contact Tracing";
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
        private System.Windows.Forms.RadioButton Radbtn_Male_Gndr;
        private System.Windows.Forms.RadioButton Radbtn_Female_Gndr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Radbtn_No_Q1;
        private System.Windows.Forms.RadioButton Radbtn_Yes_Q1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Radbtn_No_Q2;
        private System.Windows.Forms.RadioButton Radbtn_Yes_Q2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_ContactNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_Email;
    }
}

