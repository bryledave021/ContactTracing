
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
            this.SuspendLayout();
            // 
            // CTViewer
            // 
            this.CTViewer.Location = new System.Drawing.Point(74, 29);
            this.CTViewer.Name = "CTViewer";
            this.CTViewer.Size = new System.Drawing.Size(509, 203);
            this.CTViewer.TabIndex = 0;
            this.CTViewer.Text = "";
            // 
            // ViewCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CTViewer);
            this.Name = "ViewCT";
            this.Text = "ViewCT";
            this.Load += new System.EventHandler(this.ViewCT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CTViewer;
    }
}