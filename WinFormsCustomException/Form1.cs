using Customexception;
using System.ComponentModel.DataAnnotations;

namespace WinFormsCustomException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginInformation loginInformation = new LoginInformation();
            UserValidation validation = new UserValidation();
            try
            {
                loginInformation.Username = txtUsername.Text;
                loginInformation.Password = txtPassword.Text;
                string result = validation.ValidateLoginData(loginInformation);

                lblResult.Text = result;
                txtUsername.Text = ""; txtPassword.Text = "";
            }
            catch (UserNameExeption ex) { lblResult.Text = ex.Message; }
            catch (PasswordExeption ex) { lblResult.Text = ex.Message; }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
