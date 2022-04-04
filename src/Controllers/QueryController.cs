using SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class QueryController
    {
        [HttpGet("WithRequiredString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRequiredStringQuery([FromQuery][Required] string stringQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {stringQueryParam}");
        }

        [HttpGet("WithString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringQuery([FromQuery] string stringQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {stringQueryParam}");
        }

        [HttpGet("WithInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntQuery([FromQuery] int intQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {intQueryParam}");
        }

        [HttpGet("WithDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDoubleQuery([FromQuery] double doubleQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {doubleQueryParam}");
        }

        [HttpGet("WithBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithBooleanQuery([FromQuery] bool booleanQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {booleanQueryParam}");
        }

        [HttpGet("WithDatetime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDatetimeQuery([FromQuery] DateTime datetimeQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {datetimeQueryParam}");
        }

        [HttpGet("WithFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatQuery([FromQuery] float floatQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {floatQueryParam}");
        }

        [HttpGet("WithLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongQuery([FromQuery] long longQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {longQueryParam}");
        }

        [HttpGet("WithModel")]
        [ProducesResponseType(200, Type = typeof(DummyQuery))]
        public IActionResult GetWithModelQuery([FromQuery] DummyQuery modelQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {modelQueryParam}");
        }

        // Parameters Test Cases
        [HttpGet("WithDummyBody")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithDummyBody([FromQuery] DummyBody modelQueryParam) =>
            new OkObjectResult($"Received query parameter: {modelQueryParam}");

        [HttpGet("WithArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayIntQuery([FromQuery] int[] arrayIntQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {arrayIntQueryParam[0]}");
        }

        [HttpGet("WithArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayStringQuery([FromQuery] string[] arrayStringQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {arrayStringQueryParam[0]}");
        }

        [HttpGet("WithArrayModel")]
        [ProducesResponseType(200, Type = typeof(DummyQuery))]
        public IActionResult GetWithArrayModelQuery([FromQuery] DummyQuery[] arrayModelQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {arrayModelQueryParam}");
        }

        [HttpGet("WithListModel")]
        [ProducesResponseType(200, Type = typeof(DummyQuery))]
        public IActionResult GetWithListModelQuery([FromQuery] List<DummyQuery> listModelQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {listModelQueryParam}");
        }

        [HttpGet("WithoutParam")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithoutParam()
        {
            return new OkObjectResult("No parameter received!");
        }

        [HttpGet("WithCollectionModel")]
        [ProducesResponseType(200, Type = typeof(DummyQuery))]
        public IActionResult GetWithCollectionModelQuery([FromQuery] Collection<DummyQuery> collectionModelQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {collectionModelQueryParam}");
        }

        [HttpGet("WithCollectionInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithCollectionIntQuery([FromQuery] Collection<int> collectionIntQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {collectionIntQueryParam}");
        }

        [HttpGet("WithEnumerableModel")]
        [ProducesResponseType(200, Type = typeof(DummyQuery))]
        public IActionResult GetWithEnumerableModelQuery([FromQuery] IEnumerable<DummyQuery> enumerableModelQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {enumerableModelQueryParam}");
        }

        [HttpGet("WithEnumerableInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEnumerableIntQuery([FromQuery] IEnumerable<int> enumerableIntQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {enumerableIntQueryParam}");
        }

        [HttpGet("WithListInIntList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithListInListIntQuery([FromQuery] List<List<int>> listIntQueryParam)
        {
            return new OkObjectResult($"Received query parameter: {listIntQueryParam}");
        }
    }
}