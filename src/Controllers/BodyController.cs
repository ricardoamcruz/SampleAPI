using SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class BodyController
    {
        [HttpPost("WithString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithStringBody([FromBody] string stringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {stringBodyParam}");
        }

        [HttpPost("WithInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIntBody([FromBody] int intBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {intBodyParam}");
        }

        [HttpPost("WithDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDoubleBody([FromBody] double doubleBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {doubleBodyParam}");
        }

        [HttpPost("WithBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBooleanBody([FromBody] bool booleanBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {booleanBodyParam}");
        }

        [HttpPost("WithDatetime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDatetimeBody([FromBody] DateTime datetimeBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {datetimeBodyParam}");
        }

        [HttpPost("WithFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithFloatBody([FromBody] float floatBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {floatBodyParam}");
        }

        [HttpPost("WithLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithLongBody([FromBody] long longBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {longBodyParam}");
        }

        [HttpPost("WithModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithModelBody([FromBody] DummyBody modelBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {modelBodyParam}");
        }

        [HttpPost("WithArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayIntBody([FromBody] int[] arrayIntBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayIntBodyParam[0]}");
        }

        [HttpPost("WithArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDoubleBody([FromBody] double[] arrayDoubleBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayDoubleBodyParam[0]}");
        }

        [HttpPost("WithArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayStringBody([FromBody] string[] arrayStringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayStringBodyParam[0]}");
        }

        [HttpPost("WithArrayModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithArrayModelBody([FromBody] DummyBody[] arrayModelBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayModelBodyParam}");
        }

        [HttpPost("WithArrayBoolean")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithArrayBoolean([FromBody] bool[] arrayBooleanParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayBooleanParam}");
        }

        [HttpPost("WithListModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithListModelBody([FromBody] List<DummyBody> listModelBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listModelBodyParam}");
        }

        [HttpPost("WithoutParam")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithoutParam()
        {
            return new OkObjectResult("No parameter received!");
        }

        [HttpPost("WithDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryStringBody([FromBody] Dictionary<string, string> dictionaryStringBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryStringBody}");
        }

        [HttpPost("WithCollectionModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithCollectionModelBody([FromBody] Collection<DummyBody> collectionModelBody)
        {
            return new OkObjectResult($"Received body parameter: {collectionModelBody}");
        }

        [HttpPost("WithCollectionInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionIntBody([FromBody] Collection<int> collectionIntBody)
        {
            return new OkObjectResult($"Received body parameter: {collectionIntBody}");
        }

        [HttpPost("WithEnumerableModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult PostWithEnumerableModelBody([FromBody] IEnumerable<DummyBody> enumerableModelBody)
        {
            return new OkObjectResult($"Received body parameter: {enumerableModelBody}");
        }

        [HttpPost("WithEnumerableInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithEnumerableIntBody([FromBody] IEnumerable<int> enumerableIntBody)
        {
            return new OkObjectResult($"Received body parameter: {enumerableIntBody}");
        }

        [HttpPost("WithListInIntList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithListInListIntBody([FromBody] List<List<int>> listIntBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listIntBodyParam}");
        }
    }
}