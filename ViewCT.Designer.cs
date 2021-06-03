
namespace Contact_Tracing
{
    partial class ViewCT
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
            this.CTViewer = new System.Windows.Forms.RichTextBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CTViewer
            // 
            this.CTViewer.Location = new System.Drawing.Point(32, 66);
            this.CTViewer.Name = "CTViewer";
            this.CTViewer.Size = new System.Drawing.Size(422, 291);
            this.CTViewer.TabIndex = 0;
            this.CTViewer.Text = "";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(156, 378);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.btn_GoBack.TabIndex = 1;
            this.btn_GoBack.Text = "Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(265, 378);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Tracing Lists:";
            // 
            // ViewCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 406);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.CTViewer);
            this.Name = "ViewCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCT";
            this.Load += new System.EventHandler(this.ViewCT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CTViewer;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
    }
}