using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace Orbit.Serverless
{
    public static class DevicePromotionFunctions
    {
        [OpenApiOperation(operationId: nameof(CreateNewDevicePromotion), Visibility = OpenApiVisibilityType.Important)]
        [OpenApiRequestBody("application/json", typeof(DevicePromotion))]
        [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(DevicePromotion[]))]
        [FunctionName(nameof(CreateNewDevicePromotion))]
        public static IActionResult CreateNewDevicePromotion(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            // get the payload
            var payload = JsonConvert.DeserializeObject<DevicePromotion>(new StreamReader(req.Body).ReadToEnd());

            // return the result
            return new OkObjectResult(payload);
        }
    }
}

