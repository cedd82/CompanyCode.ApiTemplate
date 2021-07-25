using System;

using CompanyCode.ApiTemplate.Common.Models;

using Microsoft.AspNetCore.Mvc;

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
    }
}