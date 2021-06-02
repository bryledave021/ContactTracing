using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtBx_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBx_Username.Text == "admin1234" && txtBx_Pass.Text == "123456789")
            {
                this.Hide();
                ViewCT CT = new ViewCT();
                CT.Show();
            }
            else {
                MessageBox.Show("You Entered a wrong username or password!");
                txtBx_Username.Clear();
                txtBx_Pass.Clear();
                    }
        }
    }
}
