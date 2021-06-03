using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class ViewCT : Form
    {
        public ViewCT()
        {
            InitializeComponent();
        }

        private void ViewCT_Load(object sender, EventArgs e)
        {
            string CTPath = @"ContactTracing.txt";
            string CTShow = File.ReadAllText(CTPath);
            CTViewer.Text = CTShow;
            }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactTracingForm CT = new ContactTracingForm();
            CT.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

