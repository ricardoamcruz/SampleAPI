using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class ValidationController : ControllerBase
    {
        [HttpPost("WithRegularExpressionBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRegularExpressionBody([FromBody][Required][RegularExpression(".+\\@.+\\..+")] string regularExpressionParam)
        {
            return new OkObjectResult($"Received parameter: {regularExpressionParam}");
        }

        [HttpGet("WithRegularExpressionHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRegularExpressionHeader([FromHeader][Required][RegularExpression(".+\\@.+\\..+")] string regularExpressionParam)
        {
            return new OkObjectResult($"Received parameter: {regularExpressionParam}");
        }

        [HttpGet("WithRegularExpressionQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRegularExpressionQuery([FromQuery][Required][RegularExpression(".+\\@.+\\..+")] string regularExpressionParam)
        {
            return new OkObjectResult($"Received parameter: {regularExpressionParam}");
        }

        [HttpGet("WithRegularExpressionRoute/{regularExpressionParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRegularExpressionRoute([FromRoute][Required][RegularExpression(".+\\@.+\\..+")] string regularExpressionParam)
        {
            return new OkObjectResult($"Received parameter: {regularExpressionParam}");
        }

        [HttpPost("WithStringLengthBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithStringLengthBody([FromBody][Required][StringLength(10, MinimumLength = 5)] string stringLengthParam)
        {
            return new OkObjectResult($"Received parameter: {stringLengthParam}");
        }

        [HttpGet("WithStringLengthHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringLengthHeader([FromHeader][Required][StringLength(10, MinimumLength = 5)] string stringLengthParam)
        {
            return new OkObjectResult($"Received parameter: {stringLengthParam}");
        }

        [HttpGet("WithStringLengthQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringLengthQuery([FromQuery][Required][StringLength(10, MinimumLength = 5)] string stringLengthParam)
        {
            return new OkObjectResult($"Received parameter: {stringLengthParam}");
        }

        [HttpGet("WithStringLengthRoute/{stringLengthParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringLengthRoute([FromRoute][Required][StringLength(10, MinimumLength = 5)] string stringLengthParam)
        {
            return new OkObjectResult($"Received parameter: {stringLengthParam}");
        }

        [HttpPost("WithRangeBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRangeBody([FromBody][Required][Range(5, 10)] int rangeParam)
        {
            return new OkObjectResult($"Received parameter: {rangeParam}");
        }

        [HttpGet("WithRangeHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRangeHeader([FromHeader][Required][Range(5, 10)] int rangeParam)
        {
            return new OkObjectResult($"Received parameter: {rangeParam}");
        }

        [HttpGet("WithRangeQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRangeQuery([FromQuery][Required][Range(5, 10)] int rangeParam)
        {
            return new OkObjectResult($"Received parameter: {rangeParam}");
        }

        [HttpGet("WithRangeRoute/{rangeParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithRangeRoute([FromRoute][Required][Range(5, 10)] int rangeParam)
        {
            return new OkObjectResult($"Received parameter: {rangeParam}");
        }

        [HttpPost("WithMinLengthBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithMinLengthBody([FromBody][Required][MinLength(5)] string minLengthParam)
        {
            return new OkObjectResult($"Received parameter: {minLengthParam}");
        }

        [HttpGet("WithMinLengthHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMinLengthHeader([FromHeader][Required][MinLength(5)] string minLengthParam)
        {
            return new OkObjectResult($"Received parameter: {minLengthParam}");
        }

        [HttpGet("WithMinLengthQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMinLengthQuery([FromQuery][Required][MinLength(5)] string minLengthParam)
        {
            return new OkObjectResult($"Received parameter: {minLengthParam}");
        }

        [HttpGet("WithMinLengthRoute/{minLengthParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMinLengthRoute([FromRoute][Required][MinLength(5)] string minLengthParam)
        {
            return new OkObjectResult($"Received parameter: {minLengthParam}");
        }

        [HttpPost("WithMaxLengthBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithMaxLengthBody([FromBody][Required][MaxLength(10)] string maxLengthParam)
        {
            return new OkObjectResult($"Received parameter: {maxLengthParam}");
        }

        [HttpGet("WithMaxLengthHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMaxLengthHeader([FromHeader][Required][MaxLength(10)] string maxLengthParam)
        {
            return new OkObjectResult($"Received parameter: {maxLengthParam}");
        }

        [HttpGet("WithMaxLengthQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMaxLengthQuery([FromQuery][Required][MaxLength(10)] string maxLengthParam)
        {
            return new OkObjectResult($"Received parameter: {maxLengthParam}");
        }

        [HttpGet("WithMaxLengthRoute/{maxLengthParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMaxLengthRoute([FromRoute][Required][MaxLength(10)] string maxLengthParam)
        {
            return new OkObjectResult($"Received parameter: {maxLengthParam}");
        }

        [HttpGet("WithDataTypeHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDataTypeHeader([FromHeader][Required][DataType(DataType.DateTime)] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithDataTypeQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDataTypeQuery([FromQuery][Required][DataType(DataType.DateTime)] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithDataTypeRoute/{dataTypeParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDataTypeRoute([FromRoute][Required][DataType(DataType.DateTime)] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithDataTypePswdBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDataTypePswdBody([FromHeader][Required][DataType(DataType.Password)] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpPost("WithUrlBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithUrlBody([FromBody][Required][Url] string urlParam)
        {
            return new OkObjectResult($"Received parameter: {urlParam}");
        }

        [HttpGet("WithUrlHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithUrlHeader([FromHeader][Required][Url] string urlParam)
        {
            return new OkObjectResult($"Received parameter: {urlParam}");
        }

        [HttpGet("WithUrlQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithUrlQuery([FromQuery][Required][Url] string urlParam)
        {
            return new OkObjectResult($"Received parameter: {urlParam}");
        }

        [HttpPost("WithEmailAddressBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithEmailAddressBody([FromBody][Required][EmailAddress] string emailParam)
        {
            return new OkObjectResult($"Received parameter: {emailParam}");
        }

        [HttpGet("WithEmailAddressHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEmailAddressHeader([FromHeader][Required][EmailAddress] string emailParam)
        {
            return new OkObjectResult($"Received parameter: {emailParam}");
        }

        [HttpGet("WithEmailAddressQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEmailAddressQuery([FromQuery][Required][EmailAddress] string emailParam)
        {
            return new OkObjectResult($"Received parameter: {emailParam}");
        }

        [HttpGet("WithEmailAddressRoute/{emailParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithEmailAddressRoute([FromRoute][Required][EmailAddress] string emailParam)
        {
            return new OkObjectResult($"Received parameter: {emailParam}");
        }

        [HttpPost("WithFileTypeBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithFileTypeBody([FromBody][Required][FileExtensions] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithFileTypeHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFileTypeHeader([FromHeader][Required][FileExtensions] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithFileTypeQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFileTypeQuery([FromQuery][Required][FileExtensions] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpGet("WithFileTypeRoute/{dataTypeParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFileTypeRoute([FromRoute][Required][FileExtensions] string dataTypeParam)
        {
            return new OkObjectResult($"Received parameter: {dataTypeParam}");
        }

        [HttpPost("WithPhoneBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithPhoneBody([FromBody][Required][Phone] string phoneParam)
        {
            return new OkObjectResult($"Received parameter: {phoneParam}");
        }

        [HttpGet("WithPhoneHeader")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithPhoneHeader([FromHeader][Required][Phone] string phoneParam)
        {
            return new OkObjectResult($"Received parameter: {phoneParam}");
        }

        [HttpGet("WithPhoneQuery")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithPhoneQuery([FromQuery][Required][Phone] string phoneParam)
        {
            return new OkObjectResult($"Received parameter: {phoneParam}");
        }

        [HttpGet("WithPhoneRoute/{phoneParam}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithPhoneRoute([FromRoute][Required][Phone] string phoneParam)
        {
            return new OkObjectResult($"Received parameter: {phoneParam}");
        }
    }
}