using System.Net.Mail;

namespace CompanyCode.ApiTemplate.Common.Models
{
    public class EmailDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public Attachment Attachment { get; set; } = null;
    }
}