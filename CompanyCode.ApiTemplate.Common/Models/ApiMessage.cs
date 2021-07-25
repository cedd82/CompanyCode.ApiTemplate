using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CompanyCode.ApiTemplate.Common.Constants;
using CompanyCode.ApiTemplate.Common.Models.Api;

namespace CompanyCode.ApiTemplate.Common.Models
{
    public class ApiMessage
    {
        public string Code { get; }
        public string Message { get; }
        public List<ModelErrorDto> Errors { get; set; }
        public int Level { get; }

        public ApiMessage(string code, string message, int level = CommonConstants.MessageLevel.Error)
        {
            Code    = code;
            Message = message;
            Level   = level;
        }

        public ApiMessage(string message, int level = CommonConstants.MessageLevel.Error)
        {
            Errors = new List<ModelErrorDto>
            {
                new(message)
                {
                    Message = message,
                }
            };
            Level = level;
        }

        public override string ToString()
        {
            return string.Join(",", Errors.Select(x => x.Message));
        }
    }
}
