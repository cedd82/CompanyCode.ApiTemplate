using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public class AppSecrets
    {
        public string SwaggerBasicAuthUserName { get; set; }
        public string SwaggerBasicAuthPassword { get; set; }
        public string JwtSymmetricKey { get; set; }
        public bool SwaggerBasicAuthIsEnabled { get; set; }
        public string IngresDatabaseConnection { get; set; }
        public string PostgresConnection { get; set; }
    }
}
