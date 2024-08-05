using System;
using System.Windows.Forms;

namespace Cashier
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_button_Click(object sender, EventArgs e)
        {

            if (txt_id.Text == "Admin" && txt_pass.Text == "Admin")
            {
                new Home().Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("The Username or Password is wrong, Please try again");
                txt_id.Clear();
                txt_pass.Clear();
                txt_id.Focus();
            }
        }

        private void Clear_lbl_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_pass.Clear();
            txt_id.Focus();
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
