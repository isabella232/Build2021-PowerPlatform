using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orbit.Serverless
{
    public class OpenAPIConfiguration : IOpenApiConfigurationOptions
    {
        public OpenApiInfo Info { get; set; } = new OpenApiInfo()
        {
            Version = "1.0.0",
            Title = "Orbit Serverless APIs",
            Description = "Functions used manage the device promotions",
            Contact = new OpenApiContact()
            {
                Name = "Orbit Support",
                Email = "orbit-support@contoso.com"
            }
        };

        public List<OpenApiServer> Servers
        {
            get
            {
                return (new OpenApiServer[] { new OpenApiServer { Url =
                    Environment.GetEnvironmentVariable("WEBSITE_HOSTNAME")
                }}).ToList();
            }
            set => throw new NotImplementedException();
        }

        public OpenApiVersionType OpenApiVersion { get => OpenApiVersionType.V2; set => throw new NotImplementedException(); }
    }
}
