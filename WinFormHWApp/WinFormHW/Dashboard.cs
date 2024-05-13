using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void SayHi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || (string.IsNullOrWhiteSpace(lastNameTextBox.Text)))
            {
                MessageBox.Show("You forgot to enter your First or Last Name.",
                    "Empty First or Last Name field", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}");
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
            }

            firstNameTextBox.Focus();
        }
    }
}
