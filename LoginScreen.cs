using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckOut
{
    public partial class LoginScreen : Form
    {
        AdminScreen adminScreen = new AdminScreen();
        CustomerScreen customerScreen = new CustomerScreen();

        public LoginScreen()
        {
            InitializeComponent();
            adminScreen.RefToLoginScreen = this;
            customerScreen.RefToLoginScreen = this;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminScreen.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerScreen.Show();
        }
    }
}
