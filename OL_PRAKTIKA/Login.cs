using System;
using System.Windows.Forms;

namespace OL_PRAKTIKA
{
    public partial class Login : Form
    {
        SQL _SQL = new SQL();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_SQL.userExists(tUsername.Text, tPassword.Text))
            {
                if (_SQL.getUserRole(tUsername.Text, tPassword.Text) == 1)
                {
                    int groupId = _SQL.getGroupOfStudent(tUsername.Text, tPassword.Text);
                    int userId = _SQL.getUserIdByCredentials(tUsername.Text, tPassword.Text);

                    new panelStudent(groupId, userId).Show();
                }

                if (_SQL.getUserRole(tUsername.Text, tPassword.Text) == 2)
                {
                    int userId = _SQL.getUserIdByCredentials(tUsername.Text, tPassword.Text);

                    new panelLecturer(userId).Show();
                }

                if (_SQL.getUserRole(tUsername.Text, tPassword.Text) == 3)
                    new panelAdmin().Show();

                Hide();
            }
            else
                MessageBox.Show("Toks vartotojas neegzistuoja.");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
