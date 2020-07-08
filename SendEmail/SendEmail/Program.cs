using System;
using System.Net.Mail;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.mailchannels.net");
                client.UseDefaultCredentials = false;
                client.Port = 25;
                client.Credentials = new System.Net.NetworkCredential("okhosting", "he71DZffPLwhCpcrAfelM5Xb");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rey.varela.97@hotmail.com");
                mail.To.Add("jesusvalm97@hotmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail";

                Console.WriteLine("Send mail....");
                client.Send(mail);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
