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
    public class HeaderController
    {
        [HttpGet("WithString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringHeader([FromHeader][Required] string stringHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {stringHeaderParam}");
        }

        [HttpGet("WithInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntHeader([FromHeader] int intHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {intHeaderParam}");
        }

        [HttpGet("WithDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDoubleHeader([FromHeader] double doubleHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {doubleHeaderParam}");
        }

        [HttpGet("WithBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithBooleanHeader([FromHeader] bool booleanHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {booleanHeaderParam}");
        }

        [HttpGet("WithDatetime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDatetimeHeader([FromHeader] DateTime datetimeHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {datetimeHeaderParam}");
        }

        [HttpGet("WithFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatHeader([FromHeader] float floatHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {floatHeaderParam}");
        }

        [HttpGet("WithLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongHeader([FromHeader] long longHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {longHeaderParam}");
        }

        [HttpGet("WithArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayIntHeader([FromHeader] int[] arrayIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {arrayIntHeaderParam[0]}");
        }

        [HttpGet("WithArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayStringHeader([FromHeader] string[] arrayStringHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {arrayStringHeaderParam[0]}");
        }

        [HttpGet("WithoutParam")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithoutParam()
        {
            return new OkObjectResult("No parameter received!");
        }

        [HttpGet("WithDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryIntHeader([FromHeader] Dictionary<int, int> dictionaryIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {dictionaryIntHeaderParam}");
        }

        [HttpGet("WithDictionaryModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithDictionaryModelHeader([FromHeader] Dictionary<DummyBody, DummyBody> dictionaryModelHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {dictionaryModelHeaderParam}");
        }

        [HttpGet("WithCollectionModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithCollectionModelHeader([FromHeader] Collection<DummyBody> collectionModelHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {collectionModelHeaderParam}");
        }

        [HttpGet("WithCollectionInt")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithCollectionIntHeader([FromHeader] Collection<int> collectionIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {collectionIntHeaderParam}");
        }

        [HttpGet("WithEnumerableModel")]
        [ProducesResponseType(200, Type = typeof(DummyBody))]
        public IActionResult GetWithEnumerableModelHeader([FromHeader] IEnumerable<DummyBody> enumerableModelHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {enumerableModelHeaderParam}");
        }

        [HttpGet("WithEnumerableInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEnumerableIntHeader([FromHeader] IEnumerable<int> enumerableIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {enumerableIntHeaderParam}");
        }

        [HttpGet("WithDictionaryInIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryInIntDictionaryHeader([FromHeader] Dictionary<Dictionary<int, int>, int> dictionaryIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {dictionaryIntHeaderParam}");
        }

        [HttpGet("WithListInIntList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithListInListIntRoute([FromHeader] List<List<int>> listIntHeaderParam)
        {
            return new OkObjectResult($"Received header parameter: {listIntHeaderParam}");
        }
    }
}