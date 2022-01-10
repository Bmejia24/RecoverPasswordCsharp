namespace Recover_Password
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSendReset_Click(object sender, EventArgs e)
        {
            var result = recoverPassword(txtEnterEmail.Text);
            lbInfo.Text = result;
        }

        public string recoverPassword(string userRequesting)
        {
            var userName = "Your_UserName";
            var accountPassword = "Your_Password";
            var userMail = "your_e-mail";

            if (userMail == userRequesting)
            {
                var mailService = new MailService.SystemSupportMail();
                mailService.sendMail(
                  subject: "SYSTEM: Password recovery request",
                  body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                  "your current password is: " + accountPassword +
                  "\nHowever, we ask that you change your password inmediately once you enter the system.",
                  recipientMail: userMail
                  );
                return "We have sent your password to your email.";
            }
            else
            {
                return "Sorry, you don't have an account with that email.";
            }
        }
    }
}