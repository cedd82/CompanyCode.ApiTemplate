using System.Net.Mail;

using CompanyCode.ApiTemplate.Common.Models;

namespace CompanyCode.ApiTemplate.Common.Email
{
    public interface IEmailService
    {
        void Send(string toEmailAddresses, string subject, string body, Attachment attachment = null);
        Result SendEmail(string toEmailAddresses, string subject, string body, Attachment attachment = null);
        void SendErrorEmail(EmailDto emailDto);
        void SendErrorEmail(string subject, string body, Attachment attachment = null);
    }
}