using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailFrom = "idaniiel.testing.16@gmail.com";
            string password = "Micontrasenaes#25";
            string emailTo = "idaniiel@live.com.mx";
            string fileAttachmentPath = @"C:\TextFile.7z";
            int result = -1;

            try
            {
                using (EmailServRef.MailClient client = new EmailServRef.MailClient())
                {
                    List<EmailServRef.FileAttachment> allAttachments = new List<EmailServRef.FileAttachment>();
                    EmailServRef.FileAttachment attachment = new EmailServRef.FileAttachment();
                    attachment.Info = new FileInfo(fileAttachmentPath);
                    attachment.FileContentBase64 = Convert.ToBase64String(File.ReadAllBytes(fileAttachmentPath));
                    allAttachments.Add(attachment);

                    result = client.SendEmail(emailFrom, password, new string[] { emailTo }, null,
                      "Nueva version dll.", "Se actualizo la dll, favor de descargar y actualiza.", false, allAttachments.ToArray());
                    Console.WriteLine("Result: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
