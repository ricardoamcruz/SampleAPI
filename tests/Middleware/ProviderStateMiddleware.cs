using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Newtonsoft.Json;
using SampleAPI.Controllers;

namespace tests.Middleware
{
    public class ProviderStateMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDictionary<string, Action> _providerStates;
        private readonly ResponsesController _responsesController;
        private IActionResult _statusCode;

        public ProviderStateMiddleware(RequestDelegate next)
        {
            _next = next;
            _responsesController = new ResponsesController();
            _providerStates = new Dictionary<string, Action>
            {
                {
                    "/Responses/WithStatusCode200",
                    Code200
                },
                {
                    "/Responses/WithTestStatus false",
                    TestFalse
                }
            };
        }

        private void Code200()
        {
            //_statusCode = _responsesController.GetWithCode200();
        }

        private void TestFalse()
        {
            //_statusCode = _responsesController.GetWithTestStatus(false);
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value == "/provider-states")
            {
                this.HandleProviderStatesRequest(context);
                await context.Response.WriteAsync(String.Empty);
            }
            else
            {
                await this._next(context);
            }
        }

        private void HandleProviderStatesRequest(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.OK;

            if (context.Request.Method.ToUpper() == HttpMethod.Post.ToString().ToUpper() &&
                context.Request.Body != null)
            {
                string jsonRequestBody = String.Empty;
                using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8))
                {
                    jsonRequestBody = reader.ReadToEnd();
                }

                var providerState = JsonConvert.DeserializeObject<ProviderState>(jsonRequestBody);

                //A null or empty provider state key must be handled
                if (providerState != null && !String.IsNullOrEmpty(providerState.State))
                {
                    _providerStates[providerState.State].Invoke();
                }
            }
        }
    }
}