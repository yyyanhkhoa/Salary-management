

using Salary_management.Controller.Infrastructure.Repositories;

namespace Salary_management
{   
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            checkLogin(usernameTextBox.Text, passwordTextBox.Text);            
           
        }

        // Kiem tra login
        private void checkLogin(string username , string password)
        {
			var authRepo = new RepositoryAuth();
            if (!authRepo.CheckUserExist(username, password))
				MessageBox.Show("Incorrect Information");
            
			else
            {
                Management mng = new Management();
                this.Hide();
                mng.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}