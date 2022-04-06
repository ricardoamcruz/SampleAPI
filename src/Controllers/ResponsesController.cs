using SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class ResponsesController : ControllerBase
    {
        private readonly int[] codes = { 200, 201, 204, 205, 304, 400, 403, 404, 405, 500, 502, 503, 504 };

        [HttpGet("WithStatusCode200")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        [ProducesResponseType(204)]
        public IActionResult GetWithCode200()
        {
            return StatusCode(200);
        }

        [HttpGet("WithStatusCode201")]
        [ProducesResponseType(201, Type = typeof(IActionResult))]
        public IActionResult GetWithCode201()
        {
            return StatusCode(201);
        }

        [HttpGet("WithStatusCode204")]
        [ProducesResponseType(204, Type = typeof(IActionResult))]
        public IActionResult GetWithCode204()
        {
            return StatusCode(204);
        }

        [HttpGet("WithStatusCode205")]
        [ProducesResponseType(205, Type = typeof(IActionResult))]
        public IActionResult GetWithCode205()
        {
            return StatusCode(205);
        }

        [HttpGet("WithStatusCode304")]
        [ProducesResponseType(304, Type = typeof(IActionResult))]
        public IActionResult GetWithCode304()
        {
            return StatusCode(304);
        }

        [HttpGet("WithStatusCode400")]
        [ProducesResponseType(400, Type = typeof(IActionResult))]
        public IActionResult GetWithCode400()
        {
            return StatusCode(400);
        }

        [HttpGet("WithStatusCode403")]
        [ProducesResponseType(403, Type = typeof(IActionResult))]
        public IActionResult GetWithCode403()
        {
            return StatusCode(403);
        }

        [HttpGet("WithStatusCode404")]
        [ProducesResponseType(404, Type = typeof(IActionResult))]
        public IActionResult GetWithCode404()
        {
            return StatusCode(404);
        }

        [HttpGet("WithStatusCode405")]
        [ProducesResponseType(405, Type = typeof(IActionResult))]
        public IActionResult GetWithCode405()
        {
            return StatusCode(405);
        }

        [HttpGet("WithStatusCode500")]
        [ProducesResponseType(500, Type = typeof(IActionResult))]
        public IActionResult GetWithCode500()
        {
            return StatusCode(500);
        }

        [HttpGet("WithStatusCode501")]
        [ProducesResponseType(501, Type = typeof(IActionResult))]
        public IActionResult GetWithCode501()
        {
            return StatusCode(501);
        }

        [HttpGet("WithStatusCode502")]
        [ProducesResponseType(502, Type = typeof(IActionResult))]
        public IActionResult GetWithCode502()
        {
            return StatusCode(502);
        }

        [HttpGet("WithStatusCode503")]
        [ProducesResponseType(503, Type = typeof(IActionResult))]
        public IActionResult GetWithCode503()
        {
            return StatusCode(503);
        }

        [HttpGet("WithStatusCode504")]
        [ProducesResponseType(504, Type = typeof(IActionResult))]
        public IActionResult GetWithCode504()
        {
            return StatusCode(504);
        }

        [HttpGet("WithStatusCodes")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        [ProducesResponseType(201, Type = typeof(IActionResult))]
        [ProducesResponseType(204, Type = typeof(IActionResult))]
        [ProducesResponseType(205, Type = typeof(IActionResult))]
        [ProducesResponseType(304, Type = typeof(IActionResult))]
        [ProducesResponseType(400, Type = typeof(IActionResult))]
        [ProducesResponseType(403, Type = typeof(IActionResult))]
        [ProducesResponseType(404, Type = typeof(IActionResult))]
        [ProducesResponseType(405, Type = typeof(IActionResult))]
        [ProducesResponseType(500, Type = typeof(IActionResult))]
        [ProducesResponseType(501, Type = typeof(IActionResult))]
        [ProducesResponseType(502, Type = typeof(IActionResult))]
        [ProducesResponseType(503, Type = typeof(IActionResult))]
        [ProducesResponseType(504, Type = typeof(IActionResult))]
        public IActionResult GetWithCodes(int codeParam)
        {
            if (codes.Contains(codeParam))
            {
                return StatusCode(codeParam);
            }

            return StatusCode(501);
        }

        [HttpGet("WithResponseInt")]
        [ProducesResponseType(200, Type = typeof(int))]
        public int ResponseWithInt(int intParam)
        {
            return intParam;
        }

        [HttpGet("WithResponseString")]
        [ProducesResponseType(200, Type = typeof(string))]
        public string ResponseWithString(string stringParam)
        {
            return stringParam;
        }

        [HttpGet("WithResponseDateTime")]
        [ProducesResponseType(200, Type = typeof(DateTime))]
        public DateTime ResponseWithDateTime(DateTime dateTimeParam)
        {
            return dateTimeParam;
        }

        [HttpPost("WithResponseModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public DummyBody ResponseWithStringModel(DummyBody modelParam)
        {
            return modelParam;
        }

        [HttpGet("WithResponseArrayInt")]
        [ProducesResponseType(200, Type = typeof(int[]))]
        public int[] ResponseWithArrayInt(int[] arrayIntParam)
        {
            return arrayIntParam;
        }

        [HttpGet("WithResponseArrayString")]
        [ProducesResponseType(200, Type = typeof(string[]))]
        public string[] ResponseWithArrayString([FromHeader] string[] arrayStringParam)
        {
            return arrayStringParam;
        }

        [HttpPost("WithResponseArrayModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody[]))]
        public DummyBody[] ResponseWithArrayModel(DummyBody[] arrayModelParam)
        {
            return arrayModelParam;
        }

        [HttpGet("WithResponseDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult WithResponseDictionaryIntHeader([FromHeader] Dictionary<int, int> dictionaryIntResponseHeaderParam)
        {
            return new OkObjectResult($"Received response header parameter: {dictionaryIntResponseHeaderParam}");
        }

        [HttpGet("WithResponseDictionaryModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult WithResponseDictionaryModelHeader([FromHeader] Dictionary<DummyBody, DummyBody> dictionaryModelResponseHeaderParam)
        {
            return new OkObjectResult($"Received response header parameter: {dictionaryModelResponseHeaderParam}");
        }

        [HttpGet("WithResponseDictionaryInIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryInIntDictionaryHeader([FromHeader] Dictionary<Dictionary<int, int>, int> dictionaryIntResponseHeaderParam)
        {
            return new OkObjectResult($"Received response header parameter: {dictionaryIntResponseHeaderParam}");
        }

        [HttpGet("WithResponseListInIntList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithListInListIntRoute([FromHeader] List<List<int>> listIntResponseHeaderParam)
        {
            return new OkObjectResult($"Received response header parameter: {listIntResponseHeaderParam}");
        }
    }
}