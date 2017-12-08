using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppraisalMiddleware;



using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AppraisalMiddleware
{
    using System.Runtime.InteropServices.ComTypes;
    using Amazon.Lambda.APIGatewayEvents;
    using Amazon.Runtime.Internal;
    using Newtonsoft.Json;

    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>

        /// 

        public APIGatewayProxyResponse FunctionHandler(ILambdaContext context)
        {

            GeoLocationRepository georep =new GeoLocationRepository();
            var location = georep.GetGeoLocation();
            var serializer = JsonSerializer.Create();
            
            return new APIGatewayProxyResponse() {StatusCode = 200,Body = JsonConvert.SerializeObject(location)};

        }
    }
}
