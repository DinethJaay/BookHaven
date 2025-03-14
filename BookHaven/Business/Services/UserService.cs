using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace BookHaven.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserManageRepository _userRepo;

        public UserService(IUserManageRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void AddUser(UserModel user)
        {
            user.RegistrationNumber = GenerateRegistrationNumber();
            string generatedPassword = GeneratePassword();
            user.Password = HashPassword(generatedPassword);
            user.IsDeleted = false;
            user.CreatedAt = DateTime.Now;

            _userRepo.AddUser(user);

            // Send email with generated password
            SendEmail(user.Email, generatedPassword);
        }

        public List<KeyValuePair<int, string>> GetUserRoles()
        {
            return _userRepo.GetUserRoles();
        }

        private string GenerateRegistrationNumber()
        {
            return "REG" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        private string GeneratePassword()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SendEmail(string recipientEmail, string generatedPassword)
        {
            try
            {
                string senderEmail = "dinethjayanga37@gmail.com"; // Change to your email
                string senderPassword = "aeljetiqkxabowfr"; // Change to your email password
                string smtpServer = "smtp.gmail.com"; // Change to your SMTP server
                int smtpPort = 587; // Change to the correct SMTP port

                string emailBody = $@"
        <html>
        <head>
            <style>
                body {{ font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px; }}
                .container {{ max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px; 
                             box-shadow: 0 4px 8px rgba(0,0,0,0.1); text-align: center; }}
                .header {{ background: #4CAF50; color: white; padding: 15px; font-size: 22px; 
                           border-radius: 10px 10px 0 0; }}
                .content {{ padding: 20px; font-size: 16px; color: #333; }}
                .password-box {{ background: #eee; padding: 10px; font-size: 18px; font-weight: bold; 
                                border-radius: 5px; display: inline-block; margin-top: 10px; }}
                .footer {{ margin-top: 20px; text-align: center; font-size: 14px; color: #777; }}
                .button {{ display: inline-block; padding: 12px 20px; background-color: #4CAF50; color: white;
                           text-decoration: none; border-radius: 5px; font-weight: bold; margin-top: 15px; }}
                .button:hover {{ background-color: #45a049; }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>🎉 Welcome to BookHaven! 📚</div>
                <div class='content'>
                    <p>Dear User,</p>
                    <p>Your account has been created successfully. Below is your login password:</p>
                    <div class='password-box'>{generatedPassword}</div>
                    <p>Please change your password after logging in for security reasons.</p>
                    <a class='button' href='#'>Login Now</a>
                </div>
                <div class='footer'>
                    <p>Best Regards,</p>
                    <p><strong>BookHaven Team</strong></p>
                    <p>&copy; 2025 BookHaven. All Rights Reserved.</p>
                </div>
            </div>
        </body>
        </html>";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "📌 Your BookHaven Account Password";
                    mail.Body = emailBody;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }


        public List<UserModel> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }
        public void UpdateUser(UserModel user)
        {
            _userRepo.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            try
            {
                _userRepo.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
            }
        }

    }
}
