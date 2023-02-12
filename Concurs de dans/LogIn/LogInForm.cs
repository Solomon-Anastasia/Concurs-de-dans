using System.Windows.Forms;

namespace Concurs_de_dans.LogIn
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        // Metoda ce afiseaza formularul principal, pentru un oaspete
        private void intraCaOaspeteButton_Click(object sender, System.EventArgs e)
        {
            DataAccess.WhoLogin("Guest");

            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new ConcursDeDansForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul de logare a administratorului
        private void intraCaAdministratorButton_Click(object sender, System.EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new LogInCaAdministratorForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
