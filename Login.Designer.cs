
namespace Contact_Tracing
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_Username = new System.Windows.Forms.TextBox();
            this.txtBx_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtBx_Username
            // 
            this.txtBx_Username.Location = new System.Drawing.Point(81, 46);
            this.txtBx_Username.Name = "txtBx_Username";
            this.txtBx_Username.Size = new System.Drawing.Size(100, 23);
            this.txtBx_Username.TabIndex = 2;
            // 
            // txtBx_Pass
            // 
            this.txtBx_Pass.Location = new System.Drawing.Point(81, 75);
            this.txtBx_Pass.MaxLength = 14;
            this.txtBx_Pass.Name = "txtBx_Pass";
            this.txtBx_Pass.PasswordChar = '*';
            this.txtBx_Pass.Size = new System.Drawing.Size(100, 23);
            this.txtBx_Pass.TabIndex = 3;
            this.txtBx_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_Pass_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(90, 119);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 167);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBx_Pass);
            this.Controls.Add(this.txtBx_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_Username;
        private System.Windows.Forms.TextBox txtBx_Pass;
        private System.Windows.Forms.Button btn_Login;
    }
}