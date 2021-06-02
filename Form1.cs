using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbBox_Q2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbBox_Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbBox_Q1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbBox_Q2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtbx_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txtbx_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbx_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space);

        }

        private void txtbx_MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space);
        }

        private void txtbx_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space);
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            StreamWriter ContactTracing;
            ContactTracing = File.AppendText("ContactTracing.txt");
            ContactTracing.WriteLine("Name: " + txtbx_FName.Text+ " " + txtbx_MName.Text + " " + txtbx_LName.Text);
            ContactTracing.WriteLine("Birth Date: " + txtbx_BDate.Text);
            ContactTracing.WriteLine("Age: " + txtbx_Age.Text + " years old");
            ContactTracing.WriteLine("Gender: " + CmbBox_Gender.Text);
            ContactTracing.WriteLine("Phone No.: " + txtbx_ContactNo.Text);
            ContactTracing.WriteLine("E-Mail: " + txtbx_Email.Text);
            ContactTracing.WriteLine("Home Address:" + txtbx_Address.Text);
            ContactTracing.WriteLine(lbl_Q1.Text + " " + CmbBox_Q1.Text);
            ContactTracing.WriteLine(lbl_Q2.Text + " " + CmbBox_Q2.Text);
            ContactTracing.WriteLine("|---------------------------------------------|");
            ContactTracing.WriteLine();
            ContactTracing.Close();
            MessageBox.Show("Your Response has been submitted. Thank you!");
            txtbx_Address.Clear();
            txtbx_Age.Clear();
            txtbx_BDate.Clear();
            txtbx_ContactNo.Clear();
            txtbx_Email.Clear();
            txtbx_FName.Clear();
            txtbx_LName.Clear();
            txtbx_MName.Clear();
            CmbBox_Gender.Text= "";
            CmbBox_Q1.Text = "";
            CmbBox_Q2.Text = "";




        }
    }
}
