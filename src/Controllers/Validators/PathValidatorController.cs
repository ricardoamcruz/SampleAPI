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
    public class PathValidatorController
    {
        #region Same Name and Different operation

        [HttpGet("SameNameWithDoubleParameter/{parameter:double}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetRouteWithDoubleParameter(double parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpPost("SameNameWithDoubleParameter/{parameter:double}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostRouteWithDoubleParameter(double parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        #endregion Same Name and Different operation

        #region Primitive Parameters

        [HttpGet("Inexistent/WithIntParameter/{parameter:int}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult InexistentInSwaggerWithInt(int parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("Inexistent/WithLongParameter")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult InexistentInSwaggerWithLong([FromRoute] long parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("Inexistent")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult InexistentInSwaggerWithDouble([FromRoute] double parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithThreeParameters/{intParam:int}/{stringParam}/{booleanParam:bool}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithThreeParameters(int intParam, string stringParam, bool booleanParam)
        {
            return new OkObjectResult($"Received route parameter(s): {intParam}, {stringParam} and {booleanParam}");
        }

        [HttpGet("WithIntParameter/{parameter:int}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithIntParameter(int parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithLongParameter/{parameter:long}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithLongParameter(long parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithDoubleParameter/{parameter:double}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithDoubleParameter(double parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithFloatParameter/{parameter:float}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithFloatParameter(float parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithStringParameter/{parameter}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithStringParameter(string parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithDateTimeParameter/{parameter:DateTime}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithDateTimeParameter(DateTime parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        [HttpGet("WithBoolParameter/{parameter:bool}")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult RouteWithBoolParameter(bool parameter)
        {
            return new OkObjectResult($"Received route parameter(s): {parameter}");
        }

        #endregion Primitive Parameters

        #region Reference Parameters

        [HttpGet("WithIntReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntReference([FromRoute] WithInt intReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {intReferenceParam}");
        }

        [HttpGet("WithLongReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult WithLongReference([FromRoute] WithLong longReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {longReferenceParam}");
        }

        [HttpGet("WithDoubleReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDoubleReference([FromRoute] WithDouble doubleReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {doubleReferenceParam}");
        }

        [HttpGet("WithFloatReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatReference([FromRoute] WithFloat floatReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {floatReferenceParam}");
        }

        [HttpGet("WithStringReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringReference([FromRoute] WithString stringReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {stringReferenceParam}");
        }

        [HttpGet("WithDateTimeReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDateTimeReference([FromRoute] WithDateTime dateTimeReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {dateTimeReferenceParam}");
        }

        [HttpGet("WithBoolReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithBoolReference([FromRoute] WithBool boolReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {boolReferenceParam}");
        }

        [HttpGet("WithMultipleParameters")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithMultipleParameters([FromRoute] DummyInnerClass referenceParam)
        {
            return new OkObjectResult($"Received route parameter: {referenceParam}");
        }

        #endregion Reference Parameters

        #region Arrays and Collections Parameters

        [HttpGet("WithIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntArray([FromRoute] int[] intArrayParam)
        {
            return new OkObjectResult($"Received route parameter: {intArrayParam}");
        }

        [HttpGet("WithLongArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongArray([FromRoute] long[] longArrayParam)
        {
            return new OkObjectResult($"Received route parameter: {longArrayParam}");
        }

        [HttpGet("WithFloatArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatArray([FromRoute] float[] floatArrayParam)
        {
            return new OkObjectResult($"Received route parameter: {floatArrayParam}");
        }

        [HttpGet("WithDoubleArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDoubleArray([FromRoute] double[] doubleArrayParam)
        {
            return new OkObjectResult($"Received route parameter: {doubleArrayParam}");
        }

        [HttpGet("WithDateTimeArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWitDateTimeArray([FromRoute] DateTime[] dateTimeParam)
        {
            return new OkObjectResult($"Received route parameter: {dateTimeParam}");
        }

        [HttpGet("WithStringArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithStringArray([FromRoute] string[] stringArray)
        {
            return new OkObjectResult($"Received route parameter: {stringArray}");
        }

        [HttpGet("WithBoolArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithBoolArray([FromRoute] bool[] boolArray)
        {
            return new OkObjectResult($"Received route parameter: {boolArray}");
        }

        [HttpGet("WithIntArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntArrays([FromRoute] List<List<int>> intArraysParam)
        {
            return new OkObjectResult($"Received route parameter: {intArraysParam}");
        }

        [HttpGet("WithLongArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongArrays([FromRoute] List<List<long>> longArraysParam)
        {
            return new OkObjectResult($"Received route parameter: {longArraysParam}");
        }

        [HttpGet("WithFloatArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatArrays([FromRoute] List<List<float>> floatArraysParam)
        {
            return new OkObjectResult($"Received route parameter: {floatArraysParam}");
        }

        [HttpGet("WithDateTimeArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDateTimeArrays([FromRoute] List<List<DateTime>> dateTimeArraysParam)
        {
            return new OkObjectResult($"Received route parameter: {dateTimeArraysParam}");
        }

        [HttpGet("WithIntArrayReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntArrayReference([FromRoute] WithIntArray[] intArrayReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {intArrayReferenceParam}");
        }

        [HttpGet("WithFloatArrayReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithFloatArrayReference([FromRoute] WithFloatArray[] floatReferenceArrayParam)
        {
            return new OkObjectResult($"Received route parameter: {floatReferenceArrayParam}");
        }

        [HttpGet("WithLongArrayReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongArrayReference([FromRoute] WithLongArray[] longArrayReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {longArrayReferenceParam}");
        }

        [HttpGet("WithDateTimeArrayReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDateTimeArrayReference([FromRoute] WithDateTimeArray[] dateTimeArrayReferenceParam)
        {
            return new OkObjectResult($"Received route parameter: {dateTimeArrayReferenceParam}");
        }

        [HttpGet("WithDoubleIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithDoubleIEnumerable([FromRoute] IEnumerable<double> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithStringCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithStringCollection([FromRoute] Collection<string> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithBoolList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithBoolList([FromRoute] List<bool> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithLongICollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithLongICollection([FromRoute] ICollection<long> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDateTimeIList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithDateTimeIList([FromRoute] IList<DateTime> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithIEnumerableOfDoubleIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithIEnumerableOfDoubleIEnumerable([FromRoute] IEnumerable<IEnumerable<double>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithCollectionOfStringCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithCollectionOfStringCollection([FromRoute] Collection<Collection<string>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithListOfBooleanList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithListOfBooleanList([FromRoute] List<List<bool>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithIEnumerableReferenceDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithIEnumerableReferenceDouble([FromRoute] IEnumerable<WithDoubleIEnumerable> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithCollectionReferenceString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithCollectionReferenceString([FromRoute] Collection<WithStringCollection> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("GetWithListReferenceBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithListReferenceBool([FromRoute] List<WithBoolList> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        #region Collections of Dictionaries

        [HttpGet("WithIEnumerableDictionaryOfIEnumerableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithIEnumerableDictionaryOfIEnumerableDouble([FromRoute] IEnumerable<Dictionary<string, IEnumerable<double>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithIEnumerableDictionaryOfIEnumerableFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithIEnumerableDictionaryOfIEnumerableFloat([FromRoute] IEnumerable<Dictionary<string, IEnumerable<float>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithCollectionDictionaryOfCollectionString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithCollectionDictionaryOfCollectionString([FromRoute] Collection<Dictionary<string, Collection<string>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithCollectionDictionaryOfCollectionDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithCollectionDictionaryOfCollectionDateTime([FromRoute] Collection<Dictionary<string, Collection<DateTime>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithListDictionaryOfListBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithListDictionaryOfListBool([FromRoute] List<Dictionary<string, List<bool>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithListDictionaryOfListFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithListDictionaryOfListFloat([FromRoute] List<Dictionary<string, List<float>>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        #endregion Collections of Dictionaries

        #endregion Arrays and Collections Parameters

        #region Dictionaries

        [HttpGet("WithIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntDictionary([FromRoute] Dictionary<string, int> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithLongDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongDictionary([FromRoute] Dictionary<string, long> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithIntDictionaryReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithIntDictionaryReference([FromRoute] Dictionary<string, WithIntDictionary> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithLongDictionaryReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithLongDictionaryReference([FromRoute] Dictionary<string, WithLongDictionary> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithArrayOfDictionaryOfIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayOfDictionaryOfIntArray([FromRoute] Dictionary<string, int[]>[] parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryOfIntArray([FromRoute] Dictionary<string, int[]> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithArrayOfDictionaryOflongArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithArrayOfDictionaryOflongArray([FromRoute] Dictionary<string, long[]>[] parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfIEnumerableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithDictionaryOfIEnumerableDouble([FromRoute] Dictionary<string, IEnumerable<double>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfCollectionString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithDictionaryOfCollectionString([FromRoute] Dictionary<string, Collection<string>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfListBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public ActionResult GetWithDictionaryOfListBool([FromRoute] Dictionary<string, List<bool>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfDictionaryOfInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryOfDictionaryOfInt([FromRoute] Dictionary<string, Dictionary<string, int>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        [HttpGet("WithDictionaryOfDictionaryOfLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult GetWithDictionaryOfDictionaryOfLong([FromRoute] Dictionary<string, Dictionary<string, long>> parameter)
        {
            return new OkObjectResult($"Received route parameter: {parameter}");
        }

        #endregion Dictionaries
    }
}