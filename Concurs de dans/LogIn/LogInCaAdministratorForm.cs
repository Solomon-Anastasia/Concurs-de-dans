using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.LogIn
{
    public partial class LogInCaAdministratorForm : Form
    {
        public LogInCaAdministratorForm()
        {
            InitializeComponent();
        }

        // Metoda ce intoarce la meniul de logare
        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new LogInForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce deschide formularul principal din numele administratorului
        private void logInButton_Click(object sender, EventArgs e)
        {
            List<string> users = DataAccess.GetAdministratorLogIn(usernameTextBox.Text, passwordTextBox.Text);
            if (users.Count > 0) {
                DataAccess.WhoLogin(usernameTextBox.Text);

                this.Hide(); // Ascundem formularul curent

                // Cream o variabila de tip form
                var Form = new ConcursDeDansForm();

                // Inchidem formularul curent, deschizand formularul de salutare
                Form.Closed += (s, args) => this.Close();
                Form.Show();
            } else {
                MessageBox.Show("Username sau parola introdusa gresit!", "Introducere gresita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda ce afiseaza / ascunde parola, atunci cand este apasat butonul
        private void seePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*') {
                passwordTextBox.PasswordChar = '\0';
            } else {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}