using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public class EmailSettings
    {
        public string ErrorEmailRecipients { get; set; }
        public string FromEmail { get; set; }
        public bool SendErrorEmail { get; set; }
        public string SmtpServer { get; set; }
    }
}
