#  Recover Password

------------

This Is A Small Example With Which We Can Recover A Password From A Form In C#.

------------

With this code we can obtain the data from our BD

```csharp
public string recoverPassword(string userRequesting)
        {
            using (var connection = connectionBD())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from teacher where email=@mail";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(5);
                        string userMail = reader.GetString(8);
                        string accountPassword = reader.GetString(6);

                        var mailService = new SystemSupportMail();
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
                        return "Sorry, you don't have an account with that email.";
                }
            }
        }
```

------------

From this code block we can configure your email with which will be our support email

```csharp
public SystemSupportMail()
        {
            senderMail = "your_support_email";
            password = "your_password";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
```
Here we can find more information about names and settings of the outgoing mail server (SMTP): [Enter here](https://support.microsoft.com/es-es/topic/c%C3%B3mo-configurar-una-cuenta-de-correo-electr%C3%B3nico-de-internet-en-outlook-2013-o-2016-3d900107-3c86-a326-6b8c-f214d10a6017 "Enter here")
