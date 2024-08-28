using System;
using System.IO;
using System.Web.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MayBatch1WebApplication1
{
    public partial class GeneratePDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input data
                string empFullName = TextBox1.Text;
                string email = TextBox2.Text;
                string dateOfJoining = TextBox3.Text;

                // Generate offer letter content
                string offerLetterContent = $"Dear {empFullName},\n\nCongratulations! We are pleased to offer you the position with our company. Your date of joining is {dateOfJoining}.\n\nSincerely,\nThe HR Team";

                // Generate PDF
                using (MemoryStream ms = new MemoryStream())
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, ms);
                    document.Open();
                    document.Add(new Paragraph(offerLetterContent));
                    document.Close();

                    // Define file name and directory path
                    string fileName = $"OfferLetter_{empFullName}.pdf";
                    string directoryPath = Server.MapPath("~/OfferLetters/");
                    string filePath = Path.Combine(directoryPath, fileName);

                    // Log directory path for debugging
                    Console.WriteLine(filePath);
                    System.Diagnostics.Debug.WriteLine("Directory Path: " + directoryPath);

                    // Create directory if it doesn't exist
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Save PDF to server
                    File.WriteAllBytes(filePath, ms.ToArray());

                    // Log success message
                    System.Diagnostics.Debug.WriteLine("PDF generated and saved at: " + filePath);

                    // Optional: Provide feedback to the user
                    Response.Write("<script>alert('Offer letter generated successfully.')</script>");
                }
            }
            catch (Exception ex)
            {
                // Log or handle the error
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                Response.Write($"<script>alert('An error occurred: {ex.Message}')</script>");
            }
        }

        //private void SendEmail(string recipientEmail, string attachmentPath, string attachmentFileName)
        //{
        //    using (MailMessage mail = new MailMessage())
        //    {
        //        mail.From = new MailAddress("rajeshnarkar05@gmail.com"); // Update with your email address
        //        mail.To.Add(recipientEmail);
        //        mail.Subject = "Offer Letter";
        //        mail.Body = "Please find the attached offer letter.";

        //        // Attach PDF to email
        //        Attachment attachment = new Attachment(attachmentPath);
        //        attachment.Name = attachmentFileName;
        //        mail.Attachments.Add(attachment);

        //        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com")) // Update with your SMTP server address
        //        {
        //            smtp.Credentials = new NetworkCredential("rajeshnarkar05@gmail.com", "xcbxsohmepzvwhyd"); // Update with your email credentials
        //            smtp.EnableSsl = true;
        //            smtp.Port = 587;
        //            smtp.Send(mail);
        //        }
        //    }
        //}
    }
}
