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
    public class RoutesController
    {
        [HttpGet("WithString/{stringRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringRoute([FromRoute] string stringRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {stringRouteParam}");
        }

        [HttpGet("WithInt/{intRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntRoute([FromRoute] int intRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {intRouteParam}");
        }

        [HttpGet("WithDouble/{doubleRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDoubleRoute([FromRoute] double doubleRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {doubleRouteParam}");
        }

        [HttpGet("WithBoolean/{booleanRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithBooleanRoute([FromRoute] bool booleanRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {booleanRouteParam}");
        }

        [HttpGet("WithDatetime/{datetimeRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDatetimeRoute([FromRoute] DateTime datetimeRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {datetimeRouteParam}");
        }

        [HttpGet("WithFloat/{floatRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatRoute([FromRoute] float floatRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {floatRouteParam}");
        }

        [HttpGet("WithLong/{longRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongRoute([FromRoute] long longRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {longRouteParam}");
        }

        [HttpGet("WithArrayInt/{arrayIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayIntRoute([FromRoute] int[] arrayIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {arrayIntRouteParam[0]}");
        }

        [HttpGet("WithArrayString/{arrayStringRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayStringRoute([FromRoute] string[] arrayStringRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {arrayStringRouteParam[0]}");
        }

        [HttpGet("WithDictionaryInt/{dictionaryIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryIntRoute([FromRoute] Dictionary<int, int> dictionaryIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {dictionaryIntRouteParam}");
        }

        [HttpGet("WithDictionaryModel/{dictionaryModelRouteParam}")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithDictionaryModelRoute([FromRoute] Dictionary<DummyBody, DummyBody> dictionaryModelRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {dictionaryModelRouteParam}");
        }

        [HttpGet("WithCollectionInt/{collectionIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithCollectionIntRoute([FromRoute] Collection<int> collectionIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {collectionIntRouteParam}");
        }

        [HttpGet("WithEnumerableInt/{enumerableIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEnumerableIntRoute([FromRoute] IEnumerable<int> enumerableIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {enumerableIntRouteParam}");
        }

        [HttpGet("WithDictionaryInIntDictionary/{dictionaryIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryInIntDictionaryRoute([FromRoute] Dictionary<Dictionary<int, int>, int> dictionaryIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {dictionaryIntRouteParam}");
        }

        [HttpGet("WithListInIntList/{listIntRouteParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithListInListIntRoute([FromRoute] List<List<int>> listIntRouteParam)
        {
            return new OkObjectResult($"Received route parameter: {listIntRouteParam}");
        }
    }
}