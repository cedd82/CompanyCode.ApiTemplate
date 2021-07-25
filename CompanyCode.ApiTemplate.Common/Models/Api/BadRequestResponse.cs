using System;
using System.Collections.Generic;

namespace CompanyCode.ApiTemplate.Common.Models.Api
{
    public class BadRequestResponse
    {
        public List<ModelErrorDto> Errors { get; set; }
        public static int Code => 400;
        public static string Name => "BadRequest";
        public static DateTime TimeStamp => DateTime.Now;
    }
}