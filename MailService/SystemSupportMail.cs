using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recover_Password.MailService
{
    internal class SystemSupportMail: MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "your_support_email";
            password = "your_password";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
