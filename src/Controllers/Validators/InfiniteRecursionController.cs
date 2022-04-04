using SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Controllers.Validators
{
    [ApiController]
    [Route("[controller]")]
    [ExcludeFromCodeCoverage]
    public class InfiniteRecursionController : Controller
    {
        #region Parameters Test Cases

        [HttpGet("GetWithInfiniteRecursionParameters")]
        [ProducesResponseType(200, Type = typeof(WithInfiniteRerefenceAndIntProp))]
        public IActionResult GetWithInfiniteRecursionParameters([FromQuery] WithInfiniteRerefenceAndIntProp nonRequiredParameter)
            => new OkObjectResult($"Received route parameter(s): {nonRequiredParameter}");

        [HttpGet("GetWithInfiniteRecursionParametersComplex")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithInfiniteRecursionParametersComplex([FromRoute] ParentReferenceWithInfiniteRecursionInsideTheProperties nonRequiredParameter)
            => new OkObjectResult($"Received route parameter(s): {nonRequiredParameter}");

        [HttpGet("GetWithInfiniteRecursionParametersAndSomeProp")]
        [ProducesResponseType(200, Type = typeof(ParentClass))]
        public IActionResult GetWithInfiniteRecursionParametersAndSomeProp([FromQuery] ParentClass nonRequiredParameter)
            => new OkObjectResult($"Received route parameter(s): {nonRequiredParameter}");

        [HttpGet("WithListModelTest")]
        [ProducesResponseType(200, Type = typeof(ParentClass))]
        public IActionResult WithListModelTest([FromQuery] ParentClass listModelQueryParam) =>
            new OkObjectResult($"Received query parameter: {listModelQueryParam}");

        #endregion Parameters Test Cases

        [HttpPost("PostWithInfiniteRecursion")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithInfiniteRecursion([FromBody] WithInfiniteRerefence nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("PostWithInfiniteRecursionChildWithReferenceOfParent")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithInfiniteRecursionChildWithReferenceOfParent([FromBody] ParentReferenceWithInfiniteRecursionInsideTheProperties nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("PostWithInfiniteRecursionParentChildren")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithInfiniteRecursionParentChildren([FromBody] ParentClass nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("PostWithPropertiesAndInfiniteRecursion")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithPropertiesAndInfiniteRecursion([FromBody] ParentWithProperties Parameter)
               => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("PostWithPropertiesAndChildInfiniteRecursion")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithPropertiesAndChildInfiniteRecursion([FromBody] ParentWithChildInfiniteRecursion Parameter)
               => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("PostWithParentAndChildToParentInfiniteRecursion")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithParentAndChildToParentInfiniteRecursion([FromBody] ParentWithChildToParentInfiniteRecursion Parameter)
               => new OkObjectResult($"Received body parameter: {Parameter}");
    }
}