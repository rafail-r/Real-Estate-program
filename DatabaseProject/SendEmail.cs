using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using System.Threading;

namespace DatabaseProject
{
    class SendEmail
    {
        List<String> emails = null;
        internal SendEmail(List<String> ems)
        {
            emails = ems;
        }

        internal void sendEmail(String subject, String body, String c_name)
        {
            BackgroundWorker bw = new BackgroundWorker();

            // this allows our worker to report progress during work
            //bw.WorkerReportsProgress = true;

            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // do some simple processing for 10 seconds
                foreach (String em in emails)
                {
                    try
                    {
                        var fromAddress = new MailAddress("neosastir@gmail.com", "Omilos Neos Astir Vouliagmenis");
                        var toAddress = new MailAddress(em, c_name);
                        const string fromPassword = "neosastirproject";
                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Data);
                    }
                }

            });
            bw.RunWorkerAsync();
        }
    }
}
