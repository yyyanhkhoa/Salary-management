
using checkLogin
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
            if (checkLogin.check()
            if (((usernameTextBox.Text != "admin") || (passwordTextBox.Text != "admin"))) MessageBox.Show("Incorrect Information");
            else
            {
                Management mng = new Management();
                this.Hide();
                mng.Show();
            }
        }
    }
}