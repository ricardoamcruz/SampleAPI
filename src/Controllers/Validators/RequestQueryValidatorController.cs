using SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Controllers.Validators
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class RequestQueryValidatorController : Controller
    {
        [HttpPost("WithMultipleParameters")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithMultipleParameters([FromQuery] DummyQuery queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithInt([FromQuery] int intProp)
        {
            return new OkObjectResult($"Received body parameter: {intProp}");
        }

        [HttpPost("WithLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithLong([FromQuery] long longProp)
        {
            return new OkObjectResult($"Received body parameter: {longProp}");
        }

        [HttpPost("WithDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDouble([FromQuery] double doubleProp)
        {
            return new OkObjectResult($"Received body parameter: {doubleProp}");
        }

        [HttpPost("WithFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithFloat([FromQuery] float floatProp)
        {
            return new OkObjectResult($"Received body parameter: {floatProp}");
        }

        [HttpPost("WithString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithString([FromQuery] string stringProp)
        {
            return new OkObjectResult($"Received body parameter: {stringProp}");
        }

        [HttpPost("WithDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDateTime([FromQuery] DateTime dateTimeProp)
        {
            return new OkObjectResult($"Received body parameter: {dateTimeProp}");
        }

        [HttpPost("WithBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBoolean([FromQuery] bool boolProp)
        {
            return new OkObjectResult($"Received body parameter: {boolProp}");
        }

        [HttpPost("WithIntRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIntRequired([FromQuery] WithIntRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithLongRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithLongRequired([FromQuery] WithLongRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithDoubleRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDoubleRequired([FromQuery] WithDoubleRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithFloatRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithFloatRequired([FromQuery] WithFloatRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithStringRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithStringRequired([FromQuery] WithStringRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithDateTimeRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDateTimeRequired([FromQuery] WithDateTimeRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        [HttpPost("WithBooleanRequired")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBooleanRequired([FromQuery] WithBoolRequired queryParameter)
        {
            return new OkObjectResult($"Received body parameter: {queryParameter}");
        }

        #region Brazao

        // Brazao tests

        #endregion Brazao

        #region Jhonata

        // Jhonata tests

        #endregion Jhonata

        #region Ricardo

        [HttpPost("WithArrayReferenceInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayRefInt([FromQuery] WithInt[] MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayRefLong([FromQuery] WithLong[] MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayReferenceDouble([FromQuery] IEnumerable<WithDouble> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayReferenceFloat([FromQuery] IEnumerable<WithFloat> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayReferenceString([FromQuery] Collection<WithString> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayReferenceDateTime([FromQuery] Collection<WithDateTime> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithArrayReferenceBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayReferenceBool([FromQuery] List<WithBool> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithDictionaryReferenceFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryReferenceFloat([FromQuery] Dictionary<string, WithFloat> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithDictionaryReferenceDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryReferenceDouble([FromQuery] Dictionary<string, WithDouble> MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithClassSelfReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassSelfReference([FromQuery] WithSelfReference MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithChildToParentReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithChildToParentReference([FromQuery] WithChildToParentReference MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithChildSelfReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithChildSelfReference([FromQuery] WithChildSelfReference MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithClassSelfReferenceAndInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassSelfReferenceAndInt([FromQuery] WithSelfReferenceAndInt MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithChildToParentReferenceAndInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithChildToParentReferenceAndInt([FromQuery] WithChildToParentReferenceAndInt MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        [HttpPost("WithChildSelfReferenceAndInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithChildSelfReferenceAndInt([FromQuery] WithChildSelfReferenceAndInt MyQueryParam) =>
            new OkObjectResult($"Received body parameter: {MyQueryParam}");

        #endregion Ricardo

        #region Filipe

        // Filipe tests

        #endregion Filipe
    }
}