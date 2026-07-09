using ClassExampleController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExampleWF
{
    /// <summary>
    /// Login View representation.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginFrm : Form
    {
        private LoginController LoginController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginFrm"/> class.
        /// </summary>
        /// <param name="loginController">The login controller.</param>
        public LoginFrm(LoginController loginController)
        {
            InitializeComponent();
            this.LoginController = loginController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var password = txtPassword.Text;

            var login = LoginController.Login(user, password);

            if (login)
            {
                MessageBox.Show("Login success");
                var examplesFrm = new ExamplesFrm(new ClassExampleController.ExamplesController(new ClassExampleController.Examples()));
                examplesFrm.Show();
            }
            else
            {
                MessageBox.Show("Try again jaja");
            }
        }
    }
}
