using System;

using Microsoft.AspNetCore.Mvc;
using CompanyCode.ApiTemplate.Common.Models;

namespace CompanyCode.ApiTemplate.Api.Controllers
{
    public abstract class ApiControllerBase : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ApiBadRequest(ApiMessage message)
        {
            return BadRequest(new
            {
                Status = new
                {
                    message.Message,
                    message.Level,
                    message.Code,
                    Timestamp = DateTime.Now.ToString("s")
                }
            });
        }
        
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ApiOk()
        {
            return Ok(new
            {
                Data = new { },
                Status = new
                {
                    Timestamp = DateTime.Now.ToString("s")
                }
            });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult ApiOk(object result)
        {
            return Ok(new
            {
                Data = result ?? new { },
                Status = new
                {
                    Timestamp = DateTime.Now.ToString("s")
                }
            });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        protected void SaveToFile<T>(T result, string customFileName = "")  where T: class
        {
        #if !DEBUG
            string serviceResultClassName = result.GetType().Name;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.Indented);
            string dir = @"d:\temp\vlmsCustomerServiceResults";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            
            string fileName = $@"{dir}\{serviceResultClassName}-{customFileName}-{DateTime.Now:yyyMMdd-hhmmss}.json";
            using StreamWriter writer = new StreamWriter(fileName);
            writer.Write(json);
            writer.Flush();
        #endif
        }
    }
}