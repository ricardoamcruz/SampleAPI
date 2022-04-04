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
    public class ResponseBodyValidatorController : ControllerBase
    {
        #region Status Codes

        [HttpPost("WithCode200")]
        [ProducesResponseType(200)]
        public IActionResult PostWithCode200() =>
            StatusCode(200);

        [HttpPost("WithCode201")]
        [ProducesResponseType(201)]
        public IActionResult PostWithCode201() =>
            StatusCode(201);

        [HttpPost("WithCode204")]
        [ProducesResponseType(204)]
        public IActionResult PostWithCode204() =>
            StatusCode(204);

        [HttpPost("WithCode301")]
        [ProducesResponseType(301)]
        public IActionResult PostWithCode301() =>
            StatusCode(301);

        [HttpPost("WithCode304")]
        [ProducesResponseType(304)]
        public IActionResult PostWithCode304() =>
            StatusCode(304);

        [HttpPost("WithCode400")]
        [ProducesResponseType(400)]
        public IActionResult PostWithCode400() =>
            StatusCode(400);

        [HttpPost("WithCode401")]
        [ProducesResponseType(401)]
        public IActionResult PostWithCode401() =>
            StatusCode(401);

        [HttpPost("WithCode403")]
        [ProducesResponseType(403)]
        public IActionResult PostWithCode403() =>
            StatusCode(403);

        [HttpPost("WithCode404")]
        [ProducesResponseType(404)]
        public IActionResult PostWithCode404() =>
            StatusCode(404);

        [HttpPost("WithCode405")]
        [ProducesResponseType(405)]
        public IActionResult PostWithCode405() =>
            StatusCode(405);

        [HttpPost("WithCode410")]
        [ProducesResponseType(410)]
        public IActionResult PostWithCode410() =>
            StatusCode(410);

        [HttpPost("WithCode500")]
        [ProducesResponseType(500)]
        public IActionResult PostWithCode500() =>
            StatusCode(500);

        [HttpPost("WithCode503")]
        [ProducesResponseType(503)]
        public IActionResult PostWithCode503() =>
            StatusCode(503);

        [HttpPost("WithCode200And503")]
        [ProducesResponseType(200)]
        [ProducesResponseType(503)]
        public IActionResult PostWithCode200And503() =>
            StatusCode(503);

        #endregion Status Codes

        #region Primitives

        [HttpPost("WithInt")]
        [ProducesResponseType(200, Type = typeof(int))]
        public IActionResult PostWithInt() => StatusCode(200);

        [HttpPost("WithLong")]
        [ProducesResponseType(200, Type = typeof(long))]
        public IActionResult PostWithLong() => StatusCode(200);

        [HttpPost("WithDouble")]
        [ProducesResponseType(200, Type = typeof(double))]
        public IActionResult PostWithDouble() => StatusCode(200);

        [HttpPost("WithFloat")]
        [ProducesResponseType(200, Type = typeof(float))]
        public IActionResult PostWithFloat() => StatusCode(200);

        [HttpPost("WithString")]
        [ProducesResponseType(200, Type = typeof(string))]
        public IActionResult PostWithString() => StatusCode(200);

        [HttpPost("WithDateTime")]
        [ProducesResponseType(200, Type = typeof(DateTime))]
        public IActionResult PostWithDateTime() => StatusCode(200);

        [HttpPost("WithBool")]
        [ProducesResponseType(200, Type = typeof(bool))]
        public IActionResult PostWithBool() => StatusCode(200);

        #endregion Primitives

        #region Object type Arrays and Collections

        [HttpPost("WithArrayOfBoolCollection")]
        [ProducesResponseType(200, Type = typeof(Collection<Collection<bool>>))]
        public IActionResult PostWithArrayOfBoolCollection() => StatusCode(200);

        [HttpPost("WithIEnumerableOfStringArray")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<IEnumerable<string>>))]
        public IActionResult PostWithIEnumerableOfStringArray() => StatusCode(200);

        [HttpPost("WithCollectionOfDoubleList")]
        [ProducesResponseType(200, Type = typeof(Collection<List<double>>))]
        public IActionResult PostWithCollectionOfDoubleList() => StatusCode(200);

        [HttpPost("WithListOfIEnumerableInt")]
        [ProducesResponseType(200, Type = typeof(List<IEnumerable<int>>))]
        public IActionResult PostWithListOfIEnumerableInt() => StatusCode(200);

        [HttpPost("WithIListOfICollectionOfLong")]
        [ProducesResponseType(200, Type = typeof(IList<ICollection<long>>))]
        public IActionResult PostWithIListOfICollectionOfLong() => StatusCode(200);

        [HttpPost("WithICollectionOfIListOfDateTime")]
        [ProducesResponseType(200, Type = typeof(ICollection<IList<DateTime>>))]
        public IActionResult PostWithICollectionOfIListOfDateTime() => StatusCode(200);

        #endregion Object type Arrays and Collections

        #region Dictionaries

        [HttpPost("WithDictionariesOfCollectionBool")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Dictionary<int, Collection<bool>>[]>))]
        public IActionResult PostWithDictionariesOfCollectionBool() => StatusCode(200);

        [HttpPost("WithDictionariesOfCollectionInt")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Dictionary<int, Collection<int>>[]>))]
        public IActionResult PostWithDictionariesOfCollectionInt() => StatusCode(200);

        [HttpPost("WithDictionaryArraysDictionaryString")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, IEnumerable<Dictionary<int, string>[]>>))]
        public IActionResult PostWithDictionaryArraysDictionaryString() => StatusCode(200);

        [HttpPost("WithDictionaryArraysDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, IEnumerable<Dictionary<int, double>[]>>))]
        public IActionResult PostWithDictionaryArraysDictionaryDouble() => StatusCode(200);

        [HttpPost("WithDictionariesOfArraysDouble")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Dictionary<int, Collection<List<double>>>>))]
        public IActionResult PostWithDictionariesOfArraysDouble() => StatusCode(200);

        [HttpPost("WithDictionariesOfArraysString")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Dictionary<int, Collection<List<string>>>>))]
        public IActionResult PostWithDictionariesOfArraysString() => StatusCode(200);

        [HttpPost("WithArraysDictionariesInt")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<List<Dictionary<int, Dictionary<int, int>>>>))]
        public IActionResult PostWithArraysDictionariesInt() => StatusCode(200);

        [HttpPost("WithArraysDictionariesBool")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<List<Dictionary<int, Dictionary<int, bool>>>>))]
        public IActionResult PostWithArraysDictionariesBool() => StatusCode(200);

        [HttpPost("WithReferenceDictionariesBool")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Collection<Dictionary<int, WithBoolDictionariesArraysReference[]>>>))]
        public IActionResult PostWithReferenceDictionariesBool() => StatusCode(200);

        [HttpPost("WithReferenceDictionariesInt")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Collection<Dictionary<int, WithIntArraysDictionariesReference>[]>>))]
        public IActionResult PostWithReferenceDictionariesInt() => StatusCode(200);

        [HttpPost("WithReferenceRequiredDictionariesBool")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Collection<Dictionary<int, WithBoolDictionariesArraysReferenceRequired[]>>>))]
        public IActionResult PostWithReferenceRequiredDictionariesBool() => StatusCode(200);

        [HttpPost("WithReferenceRequiredDictionariesInt")]
        [ProducesResponseType(200, Type = typeof(Dictionary<int, Collection<Dictionary<int, WithIntArraysDictionariesReferenceRequired>[]>>))]
        public IActionResult PostWithReferenceRequiredDictionariesInt() => StatusCode(200);

        #endregion Dictionaries

        #region References with Primitives

        [HttpPost("WithReferenceInt")]
        [ProducesResponseType(200, Type = typeof(WithInt))]
        public IActionResult PostWithReferenceInt() => StatusCode(200);

        [HttpPost("WithReferenceIntTwoProps")]
        [ProducesResponseType(200, Type = typeof(WithIntTwoProperties))]
        public IActionResult PostWithReferenceIntTwoProps() => StatusCode(200);

        [HttpPost("WithReferenceLong")]
        [ProducesResponseType(200, Type = typeof(WithLong))]
        public IActionResult PostWithReferenceLong() => StatusCode(200);

        [HttpPost("WithReferenceDouble")]
        [ProducesResponseType(200, Type = typeof(WithDouble))]
        public IActionResult PostWithReferenceDouble() => StatusCode(200);

        [HttpPost("WithReferenceFloat")]
        [ProducesResponseType(200, Type = typeof(WithFloat))]
        public IActionResult PostWithReferenceFloat() => StatusCode(200);

        [HttpPost("WithReferenceString")]
        [ProducesResponseType(200, Type = typeof(WithString))]
        public IActionResult PostWithReferenceString() => StatusCode(200);

        [HttpPost("WithReferenceDateTime")]
        [ProducesResponseType(200, Type = typeof(WithDateTime))]
        public IActionResult PostWithReferenceDateTime() => StatusCode(200);

        [HttpPost("WithReferenceBool")]
        [ProducesResponseType(200, Type = typeof(WithBool))]
        public IActionResult PostWithReferenceBool() => StatusCode(200);

        [HttpPost("WithIntNullable")]
        [ProducesResponseType(200, Type = typeof(WithIntNullable))]
        public IActionResult PostWithIntNullable() => StatusCode(200);

        [HttpPost("WithLongNullable")]
        [ProducesResponseType(200, Type = typeof(WithLongNullable))]
        public IActionResult PostWithLongNullable() => StatusCode(200);

        [HttpPost("WithDoubleNullable")]
        [ProducesResponseType(200, Type = typeof(WithDoubleNullable))]
        public IActionResult PostWithDoubleNullable() => StatusCode(200);

        [HttpPost("WithFloatNullable")]
        [ProducesResponseType(200, Type = typeof(WithFloatNullable))]
        public IActionResult PostWithFloatNullable() => StatusCode(200);

        [HttpPost("WithDateTimeNullable")]
        [ProducesResponseType(200, Type = typeof(WithDateTimeNullable))]
        public IActionResult PostWithDateTimeNullable() => StatusCode(200);

        [HttpPost("WithBoolNullable")]
        [ProducesResponseType(200, Type = typeof(WithBoolNullable))]
        public IActionResult PostWithBoolNullable() => StatusCode(200);

        [HttpPost("WithIntRequired")]
        [ProducesResponseType(200, Type = typeof(WithIntRequired))]
        public IActionResult PostWithIntRequired() => StatusCode(200);

        [HttpPost("WithLongRequired")]
        [ProducesResponseType(200, Type = typeof(WithLongRequired))]
        public IActionResult PostWithLongRequired() => StatusCode(200);

        [HttpPost("WithDoubleRequired")]
        [ProducesResponseType(200, Type = typeof(WithDoubleRequired))]
        public IActionResult PostWithDoubleRequired() => StatusCode(200);

        [HttpPost("WithFloatRequired")]
        [ProducesResponseType(200, Type = typeof(WithFloatRequired))]
        public IActionResult PostWithFloatRequired() => StatusCode(200);

        [HttpPost("WithStringRequired")]
        [ProducesResponseType(200, Type = typeof(WithStringRequired))]
        public IActionResult PostWithStringRequired() => StatusCode(200);

        [HttpPost("WithDateTimeRequired")]
        [ProducesResponseType(200, Type = typeof(WithDateTimeRequired))]
        public IActionResult PostWithDateTimeRequired() => StatusCode(200);

        [HttpPost("WithBoolRequired")]
        [ProducesResponseType(200, Type = typeof(WithBoolRequired))]
        public IActionResult PostWithBoolRequired() => StatusCode(200);

        #endregion References with Primitives

        #region With Reference

        [HttpPost("WithStringArray")]
        [ProducesResponseType(200, Type = typeof(WithStringArray))]
        public IActionResult PostWithStringArray() =>
            StatusCode(200);

        [HttpPost("WithReferenceDictionaryNameProp")]
        [ProducesResponseType(200, Type = typeof(ReferenceWithName))]
        public IActionResult PostWithReferenceDictionaryNameProp(ReferenceWithName responseParam)
        {
            return new OkObjectResult($"Received response header parameter: {responseParam}");
        }

        [HttpPost("WithArraysOfIntArrays")]
        [ProducesResponseType(200, Type = typeof(List<List<WithIntArrays>>))]
        public IActionResult PostWithArraysOfIntArrays() => StatusCode(200);

        [HttpPost("WithArraysOfStringArrays")]
        [ProducesResponseType(200, Type = typeof(List<List<WithStringArrays>>))]
        public IActionResult PostWithArraysOfStringArrays() => StatusCode(200);

        [HttpPost("WithArraysOfDoubleArrays")]
        [ProducesResponseType(200, Type = typeof(List<List<WithDoubleArrays>>))]
        public IActionResult PostWithArraysOfDoubleArrays() => StatusCode(200);

        [HttpPost("WithArraysOfBoolArrays")]
        [ProducesResponseType(200, Type = typeof(List<List<WithBoolArrays>>))]
        public IActionResult PostWithArraysOfBoolArrays() => StatusCode(200);

        [HttpPost("WithArraysOfIntArraysRequired")]
        [ProducesResponseType(200, Type = typeof(List<List<WithIntArraysRequired>>))]
        public IActionResult PostWithArraysOfIntArraysRequired() => StatusCode(200);

        [HttpPost("WithArraysOfStringArraysRequired")]
        [ProducesResponseType(200, Type = typeof(List<List<WithStringArraysRequired>>))]
        public IActionResult PostWithArraysOfStringArraysRequired() => StatusCode(200);

        [HttpPost("WithArraysOfDoubleArraysRequired")]
        [ProducesResponseType(200, Type = typeof(List<List<WithDoubleArraysRequired>>))]
        public IActionResult PostWithArraysOfDoubleArraysRequired() => StatusCode(200);

        [HttpPost("WithArraysOfBoolArraysRequired")]
        [ProducesResponseType(200, Type = typeof(List<List<WithBoolArraysRequired>>))]
        public IActionResult PostWithArraysOfBoolArraysRequired() => StatusCode(200);

        #endregion With Reference
    }
}