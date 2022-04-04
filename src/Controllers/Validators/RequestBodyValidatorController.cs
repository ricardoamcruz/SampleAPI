using SampleAPI.Models;
using SampleAPI.Models.ReferencesNegativesScenarios.PositiveClasses;
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
    public class RequestBodyValidatorController : ControllerBase
    {
        #region Reference With Primitive

        [HttpPost("WithBasicModelTrue")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBasicModelTrue([FromBody] ReferenceTypeClassTrue refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithBasicModelFalse")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBasicModelFalse([FromBody] ReferenceTypeClassTrue refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithModelParamsQuantity")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithModelParamsQuantity([FromBody] DummyBodyQuantity refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithModelParamsQuantityNotEqual")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithModelParamsQuantityNotEqual([FromBody] DummyBodyQuantity refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithModelParamsNameNotEqual")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithModelParamsNameNotEqual([FromBody] DummyBodyNameNotEqual refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithReferenceInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceInt([FromBody] WithInt refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithReferenceDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDouble([FromBody] WithDouble referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceLong([FromBody] WithLong refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam}");
        }

        [HttpPost("WithReferenceFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceFloat([FromBody] WithFloat referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceString([FromBody] WithString referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDateTime([FromBody] WithDateTime referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceBoolean([FromBody] WithBool referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceIntArray([FromBody] WithIntArray referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithReferenceDateTimeCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDateTimeCollection([FromBody] Collection<WithDateTime> referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        #endregion Reference With Primitive

        #region Array Properties

        [HttpPost("WithArrayLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayLongBody([FromBody] long[] refBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {refBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysIntBody([FromBody] List<List<int>> arrayArrayIntBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayIntBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysDouble([FromBody] List<List<double>> arrayArrayDoubleBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayDoubleBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysString([FromBody] List<List<string>> arrayArrayStringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayStringBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysLongBody([FromBody] List<List<long>> arrayArrayIntBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayIntBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysFloatBody([FromBody] List<List<float>> arrayArrayFloatBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayFloatBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysDateTimeBody([FromBody] List<List<DateTime>> arrayArrayDateTimeBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayDateTimeBodyParam[0]}");
        }

        [HttpPost("WithListsAsArraysBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListsAsArraysBooleanBody([FromBody] List<List<bool>> arrayArrayBooleanBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayArrayBooleanBodyParam[0]}");
        }

        [HttpPost("WithReferenceBoolList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceBoolList([FromBody] List<WithBool> referencePrimitive)
        {
            return new OkObjectResult($"Received body parameter: {referencePrimitive}");
        }

        [HttpPost("WithIEnumerableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIEnumerableDoubleBody([FromBody] IEnumerable<double> enumerableDoubleBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {enumerableDoubleBodyParam}");
        }

        [HttpPost("WithIEnumerableOfDoubleIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIEnumerableOfDoubleIEnumerableBody([FromBody] IEnumerable<IEnumerable<double>> enumerableOfDoubleEnumerableBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {enumerableOfDoubleEnumerableBodyParam}");
        }

        [HttpPost("WithIEnumerableOfFloatIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIEnumerableOfFloatIEnumerableBody([FromBody] IEnumerable<IEnumerable<float>> enumerableOfDoubleEnumerableBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {enumerableOfDoubleEnumerableBodyParam}");
        }

        [HttpPost("WithIEnumerableFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIEnumerableFloatBody([FromBody] IEnumerable<float> enumerableFloatBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {enumerableFloatBodyParam}");
        }

        [HttpPost("WithCollectionString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionStringBody([FromBody] Collection<string> collectionStringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {collectionStringBodyParam}");
        }

        [HttpPost("WithCollectionDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionDateTimeBody([FromBody] Collection<DateTime> collectionDateTimeBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {collectionDateTimeBodyParam}");
        }

        [HttpPost("WithCollectionOfStringCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionOfStringCollectionBody([FromBody] Collection<Collection<string>> collectionOfStringCollectionBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {collectionOfStringCollectionBodyParam}");
        }

        [HttpPost("WithCollectionOfDateTimeCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionOfDateTimeCollectionBody([FromBody] Collection<Collection<DateTime>> collectionOfDateTimeCollectionBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {collectionOfDateTimeCollectionBodyParam}");
        }

        [HttpPost("WithListString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListStringBody([FromBody] List<string> listStringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listStringBodyParam}");
        }

        [HttpPost("WithListBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListBooleanBody([FromBody] List<bool> listBooleanBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listBooleanBodyParam}");
        }

        [HttpPost("WithListOfStringList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListOfStringListBody([FromBody] List<List<string>> listOfStringListBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listOfStringListBodyParam}");
        }

        [HttpPost("WithListOfBooleanList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListOfBooleanListBody([FromBody] List<List<bool>> listOfBooleanListBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listOfBooleanListBodyParam}");
        }

        [HttpPost("WithIListInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIListIntBody([FromBody] IList<int> listIntBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {listIntBodyParam}");
        }

        [HttpPost("WithICollectionString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithICollectionString([FromBody] ICollection<string> collectionStringBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {collectionStringBodyParam}");
        }

        [HttpPost("WithArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDoubleBody([FromBody] double[] arrayDoubleBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayDoubleBodyParam[0]}");
        }

        [HttpPost("WithArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayFloatBody([FromBody] float[] arrayFloatBodyParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayFloatBodyParam[0]}");
        }

        [HttpPost("WithArrayOfStringDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfStringDictionary([FromBody] Dictionary<string, string>[] arrayStringDictionaryParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayStringDictionaryParam}");
        }

        [HttpPost("WithDictionaryOfArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryOfArrayBool([FromBody] Dictionary<string, bool[]> dictionaryArrayBoolParam)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayBoolParam}");
        }

        [HttpPost("WithArrayOfBoolDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfBoolDictionary([FromBody] Dictionary<string, bool>[] arrayBoolDictionaryParam)
        {
            return new OkObjectResult($"Received body parameter: {arrayBoolDictionaryParam}");
        }

        [HttpPost("WithIntReferenceArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIntReferenceArray([FromBody] WithIntReferenceArray Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDoubleIEnumerableReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDoubleIEnumerableReference([FromBody] WithDoubleIEnumerableReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDateTimeCollectionReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDateTimeCollectionReference([FromBody] WithDateTimeCollectionReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithBoolListReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBoolListReference([FromBody] WithBoolListReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        #endregion Array Properties

        #region Reference With Array Properties

        [HttpPost("WithReferenceContainsListOfList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceContainsListOfList([FromBody] WithStringLists referenceListOfList)
        {
            return new OkObjectResult($"Received body parameter: {referenceListOfList}");
        }

        [HttpPost("WithReferenceContainingAnIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceContainingAnIntArray([FromBody] WithIntArray referenceWithIntArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceWithIntArray}");
        }

        [HttpPost("WithReferenceArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArray([FromBody] WithInt[] referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceArrayArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayArray([FromBody] List<List<WithInt>> referenceArrayArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArrayArray}");
        }

        [HttpPost("WithEnumerableReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithEnumerableReference([FromBody] IEnumerable<WithDouble> enumerableReference)
        {
            return new OkObjectResult($"Received body parameter: {enumerableReference}");
        }

        [HttpPost("WithReferenceIEnumerableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceIEnumerableDouble([FromBody] WithDoubleIEnumerable enumerableReference)
        {
            return new OkObjectResult($"Received body parameter: {enumerableReference}");
        }

        [HttpPost("WithCollectionReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithCollectionReference([FromBody] ICollection<WithString> collectionReference)
        {
            return new OkObjectResult($"Received body parameter: {collectionReference}");
        }

        [HttpPost("WithReferenceICollectionString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceICollectionString([FromBody] WithStringICollection collectionReference)
        {
            return new OkObjectResult($"Received body parameter: {collectionReference}");
        }

        [HttpPost("WithListReferenceBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithListReferenceBool([FromBody] List<WithBool> listReference)
        {
            return new OkObjectResult($"Received body parameter: {listReference}");
        }

        [HttpPost("WithReferenceListBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceListBool([FromBody] WithBoolList listReference)
        {
            return new OkObjectResult($"Received body parameter: {listReference}");
        }

        [HttpPost("WithReferenceLongJsonInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceLongJsonInt([FromBody] ReferenceWithTypeLongJsonInt referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeLongArrayJsonInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostReferenceWithTypeLongArrayJsonInt([FromBody] ReferenceWithTypeLongArrayJsonInt referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeFloatJsonDoubleArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithTypeFloatJsonDoubleArray([FromBody] ReferenceWithTypeFloatJsonArrayDouble referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeDateTimeCollectionJsonArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostReferenceWithTypeDateTimeCollectionJsonArrayString([FromBody] ReferenceWithTypeDateTimeCollectionJsonArrayString referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeDateTimeJsonWithArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostReferenceWithTypeDateTimeJsonWithArrayString([FromBody] ReferenceWithTypeDateTimeJsonWithArrayString referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeStringListJsonArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostReferenceWithTypeStringListJsonArrayBool([FromBody] ReferenceWithTypeStringListJsonArrayBool referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        [HttpPost("WithReferenceWithTypeStringJsonWithArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult ReferenceWithTypeStringJsonWithArrayBool([FromBody] ReferenceWithTypeStringJsonWithArrayBool referenceArray)
        {
            return new OkObjectResult($"Received body parameter: {referenceArray}");
        }

        #endregion Reference With Array Properties

        #region Dictionary Properties

        [HttpPost("WithDictionaryBody")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryBody([FromBody] Dictionary<object, Dictionary<object, DummyBody>> dictionaryParam)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParam}");
        }

        [HttpPost("WithDictionaryInt32")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryInt32Body([FromBody] Dictionary<string, int> dictionaryIntBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryIntBody}");
        }

        [HttpPost("WithArrayOfDictionaryInt32")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfDictionaryInt32Body([FromBody] Dictionary<string, int>[] arrayOfDictionaryIntBody)
        {
            return new OkObjectResult($"Received body parameter: {arrayOfDictionaryIntBody}");
        }

        [HttpPost("WithDictionaryInt64")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryInt64Body([FromBody] Dictionary<string, long> dictionaryLongBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryLongBody}");
        }

        [HttpPost("WithArrayOfDictionaryInt64")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfDictionaryInt64Body([FromBody] Dictionary<string, long>[] arrayDictionaryLongBody)
        {
            return new OkObjectResult($"Received body parameter: {arrayDictionaryLongBody}");
        }

        [HttpPost("WithDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryDoubleBody([FromBody] Dictionary<string, double> dictionaryDoubleBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryDoubleBody}");
        }

        [HttpPost("WithDictionaryFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryFloatBody([FromBody] Dictionary<string, float> dictionaryFloatBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryFloatBody}");
        }

        [HttpPost("WithDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryStringBody([FromBody] Dictionary<string, string> dictionaryStringBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryStringBody}");
        }

        [HttpPost("WithDictionaryDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryDateTimeBody([FromBody] Dictionary<string, DateTime> dictionaryDateTimeBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryDateTimeBody}");
        }

        [HttpPost("WithDictionaryArrayDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayDateTimeBody([FromBody] Dictionary<string, DateTime[]> dictionaryArrayDateTimeBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayDateTimeBody}");
        }

        [HttpPost("WithDictionaryBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryBoolBody([FromBody] Dictionary<string, bool> dictionaryBoolBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryBoolBody}");
        }

        [HttpPost("WithDictionaryArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayStringBody([FromBody] Dictionary<string, string[]> dictionaryArrayStringBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayStringBody}");
        }

        [HttpPost("WithDictionaryArrayInteger")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayIntegerBody([FromBody] Dictionary<string, int[]> dictionaryArrayIntBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayIntBody}");
        }

        [HttpPost("WithDictionaryArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayFloatBody([FromBody] Dictionary<string, float[]> dictionaryArrayFloatBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayFloatBody}");
        }

        [HttpPost("WithDictionaryArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayDoubleBody([FromBody] Dictionary<string, double[]> dictionaryArrayDoubleBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayDoubleBody}");
        }

        [HttpPost("WithDictionaryArrayReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayReferenceBody([FromBody] Dictionary<string, List<WithBool>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayIntBody([FromBody] Dictionary<string, List<List<int>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayLongBody([FromBody] Dictionary<string, List<List<long>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayDoubleBody([FromBody] Dictionary<string, List<List<double>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayFloatBody([FromBody] Dictionary<string, List<List<float>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayStringBody([FromBody] Dictionary<string, List<List<string>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayBoolBody([FromBody] Dictionary<string, List<List<bool>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArrayArrayDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayArrayDateTimeBody([FromBody] Dictionary<string, List<List<DateTime>>> dictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryParameter}");
        }

        [HttpPost("WithDictionaryArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayBody([FromBody] Dictionary<string, int[]> dictionaryArrayBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayBody}");
        }

        [HttpPost("WithArrayOfDictionaryFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfDictionaryFloatBody([FromBody] Dictionary<string, float>[] arrayOfDictionaryFloat)
        {
            return new OkObjectResult($"Received body parameter: {arrayOfDictionaryFloat}");
        }

        [HttpPost("WithArrayOfDictionaryDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfDictionaryDateTime([FromBody] Dictionary<string, DateTime>[] arrayOfDictionaryDateTime)
        {
            return new OkObjectResult($"Received body parameter: {arrayOfDictionaryDateTime}");
        }

        [HttpPost("WithArrayOfDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayOfDictionaryString([FromBody] Dictionary<string, string>[] arrayDictionaryString)
        {
            return new OkObjectResult($"Received body parameter: {arrayDictionaryString}");
        }

        [HttpPost("WithDictionaryIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryIEnumerableBody([FromBody] Dictionary<string, IEnumerable<double>> dictionaryArrayBody)
        {
            return new OkObjectResult($"Received body parameter: {dictionaryArrayBody}");
        }

        [HttpPost("WithIEnumerableOfDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIEnumerableOfDictionaryBody([FromBody] IEnumerable<Dictionary<string, double>> ienumerableDictionary)
        {
            return new OkObjectResult($"Received body parameter: {ienumerableDictionary}");
        }

        [HttpPost("WithReferenceDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryInt([FromBody] Dictionary<string, WithInt> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryLong([FromBody] Dictionary<string, WithLong> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryIntArray([FromBody] Dictionary<string, WithIntArray> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryLongArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryLongArray([FromBody] Dictionary<string, WithLongArray> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryFloatArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryFloatArray([FromBody] Dictionary<string, WithFloatArray> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayInt([FromBody] Dictionary<string, List<List<WithInt>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayInt([FromBody] WithIntDictionary[] referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceArrayLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayLong([FromBody] WithLongDictionary[] referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayFloat([FromBody] WithFloatDictionary[] referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryFloat([FromBody] WithFloatDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayLong([FromBody] Dictionary<string, List<List<WithLong>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayDouble([FromBody] Dictionary<string, IEnumerable<IEnumerable<WithDouble>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayFloat([FromBody] Dictionary<string, IEnumerable<IEnumerable<WithFloat>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayString([FromBody] Dictionary<string, Collection<Collection<WithString>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayDateTime([FromBody] Dictionary<string, List<List<WithDateTime>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryWithArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryWithArrayBool([FromBody] Dictionary<string, List<List<WithBool>>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        #region Recursive Dictionary

        [HttpPost("WithDictionaryWithDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithDictionaryString([FromBody] Dictionary<string, Dictionary<string, string>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithDictionaryWithDictionaryDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithDictionaryDateTime([FromBody] Dictionary<string, Dictionary<string, DateTime>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithDictionaryWithDictionaryReferenceString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithDictionaryReferenceString([FromBody] Dictionary<string, Dictionary<string, WithString>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithDictionaryWithDictionaryReferenceDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithDictionaryReferenceDateTime([FromBody] Dictionary<string, Dictionary<string, WithDateTime>> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryString([FromBody] WithStringDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaries")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaries([FromBody] ReferenceWithMultipleDictionaries referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryNameProp")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryNameProp([FromBody] ReferenceWithName referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithDictionaryWithReferenceDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithReferenceDictionaryString([FromBody] Dictionary<string, WithStringDictionary> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithDictionaryWithReferenceDictionaryDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryWithReferenceDictionaryDateTime([FromBody] Dictionary<string, WithDateTimeDictionary> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        #endregion Recursive Dictionary

        #endregion Dictionary Properties

        #region Reference With Dictionary Properties

        [HttpPost("WithReferenceWithDictionaryArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayInt([FromBody] WithIntDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryInt([FromBody] WithIntDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryReferenceInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryReferenceInt([FromBody] WithIntDictionaryReference referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryLong([FromBody] WithLongDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayLong([FromBody] WithLongDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceEnumWithDoubleDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceEnumWithDoubleDictionary([FromBody] IEnumerable<WithDoubleDictionary> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryDouble([FromBody] WithDoubleDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDoubleDictionaryEnum")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDoubleDictionaryEnum([FromBody] Dictionary<string, WithDoubleEnumerable> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayDouble([FromBody] WithDoubleDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayFloat([FromBody] WithFloatDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayString([FromBody] WithStringDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayBool([FromBody] WithBoolDictionaryArrays referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryArrayDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryArrayDateTime([FromBody] WithDateTimeArraysDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithCollectionOfStringDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithCollectionOfStringDictionary([FromBody] Collection<WithStringDictionaryArrays> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryOfCollectionOfString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryOfCollectionOfString([FromBody] Dictionary<string, WithStringICollection> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithListOfBoolDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithListOfBoolDictionary([FromBody] List<WithBoolDictionaryArrays> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryOfBoolList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryOfBoolList([FromBody] Dictionary<string, WithBoolList> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceArrayOfDateTimeDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayOfDateTimeDictionary([FromBody] Dictionary<string, WithDateTimeArraysDictionary>[] referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceWithDictionaryOfDateTimeArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceWithDictionaryOfDateTimeArray([FromBody] Dictionary<string, WithDateTimeArray> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceArrayOfStringDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayOfDictionaryOfString([FromBody] Dictionary<string, WithString>[] referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryOfStringArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryOfStringArray([FromBody] Dictionary<string, WithStringArray> referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        [HttpPost("WithReferenceDictionaryDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryDateTime([FromBody] WithDateTimeDictionary referenceDictionaryParameter)
        {
            return new OkObjectResult($"Received body parameter: {referenceDictionaryParameter}");
        }

        #region Dictionaries with arrays

        [HttpPost("WithDictionaryArrayWithIntReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithIntReference([FromBody] WithIntDictionaryArrayReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithIntReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithIntReference([FromBody] WithIntArrayDictionaryReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithDoubleReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithDoubleReference([FromBody] WithDoubleDictionaryArrayReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithDoubleReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithDoubleReference([FromBody] WithDoubleArrayDictionaryReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithDateTimeReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithDateTimeReference([FromBody] WithDateTimeDictionaryArrayReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithDateTimeReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithDateTimeReference([FromBody] WithDateTimeArrayDictionaryReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithBoolReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithBoolReference([FromBody] WithBoolDictionaryArrayReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithBoolReference")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithBoolReference([FromBody] WithBoolArrayDictionaryReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        #endregion Dictionaries with arrays

        #endregion Reference With Dictionary Properties

        #region Reference With Required Fields

        [HttpPost("WithRequiredSubReferenceAndFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRequiredSubReferenceAndFloat([FromBody] ReferenceWithRequiredSubReferenceAndFloat requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredInt32")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredInt([FromBody] WithIntRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredInt64")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredLong([FromBody] WithLongRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDouble([FromBody] WithDoubleRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredFloat([FromBody] WithFloatRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredString([FromBody] WithStringRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDateTime([FromBody] WithDateTimeRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredBoolean([FromBody] WithBoolRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredArray([FromBody] WithIntArrayRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredIEnumerable([FromBody] WithDoubleIEnumerableRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceIEnumerable([FromBody] WithDoubleEnumerable nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredCollection([FromBody] WithStringCollectionRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceCollection([FromBody] WithStringCollection nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredList([FromBody] WithBoolListRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredICollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredICollection([FromBody] WithLongICollectionRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceICollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceICollection([FromBody] WithLongICollection nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredIList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredIList([FromBody] WithFloatIListRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceIList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceIList([FromBody] WithFloatIList nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredNestedArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredNestedArray([FromBody] WithIntArraysRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredNestedIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredNestedIEnumerable([FromBody] WithDoubleIEnumerablesRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredNestedCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredNestedCollection([FromBody] WithStringCollectionsRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithRefRequiredNestedList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredNestedList([FromBody] WithBoolListsRequired requiredParameter)
            => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceNestedArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedArray([FromBody] WithIntArrays nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceNestedIEnumerable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedIEnumerable([FromBody] WithDoubleIEnumerables nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceNestedCollection")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedCollection([FromBody] WithStringCollections nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceNestedList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedList([FromBody] WithBoolLists nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredIntDictionary([FromBody] WithIntDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredLongDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredLongDictionary([FromBody] WithLongDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredDoubleDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDoubleDictionary([FromBody] WithDoubleDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredFloatDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredFloatDictionary([FromBody] WithFloatDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredStringDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredStringDictionary([FromBody] WithStringDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredDateTimeDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDateTimeDictionary([FromBody] WithDateTimeDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithRefRequiredBoolDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredBoolDictionary([FromBody] WithBoolDictionaryRequired RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredDictionaryArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDictionaryArrayInt([FromBody] Dictionary<string, WithIntDictionaryArrayRequired[]> RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredDictionaryArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDictionaryArrayDouble([FromBody] Dictionary<string, WithDoubleDictionaryIEnumerableRequired[]> RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredDictionaryArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDictionaryArrayString([FromBody] Dictionary<string, WithStringDictionaryCollectionRequired[]> RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredDictionaryArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredDictionaryArrayBool([FromBody] Dictionary<string, WithBoolDictionaryListRequired[]> RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredArrayDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredArrayDictionaryInt([FromBody] Dictionary<string, WithIntArrayDictionaryRequired>[] RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredArrayDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredArrayDictionaryDouble([FromBody] Dictionary<string, WithDoubleIEnumerableDictionaryRequired>[] RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredArrayDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredArrayDictionaryString([FromBody] Dictionary<string, WithStringCollectionDictionaryRequired>[] RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceRequiredArrayDictionaryBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredArrayDictionaryBool([FromBody] Dictionary<string, WithBoolListDictionaryRequired>[] RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceDictionaryArrayInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArrayInt([FromBody] Dictionary<string, WithIntDictionaryArray[]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceDictionaryArrayDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArrayDouble([FromBody] Dictionary<string, WithDoubleDictionaryArray[]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceDictionaryArrayString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArrayString([FromBody] Dictionary<string, WithStringDictionaryArray[]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceDictionaryArrayBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArrayBool([FromBody] Dictionary<string, WithBoolDictionaryArray[]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArrayDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayDictionaryInt([FromBody] Dictionary<string, WithIntDictionaryArray>[] nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArrayDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayDictionaryDouble([FromBody] Dictionary<string, WithDoubleDictionaryArray>[] nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArrayDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayDictionaryString([FromBody] Dictionary<string, WithStringDictionaryArray>[] nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArrayDictionaryBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArrayDictionaryBool([FromBody] Dictionary<string, WithBoolDictionaryArray>[] nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #region Arrays of Dictionary

        [HttpPost("WithReferenceArraysDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArraysDictionaryInt([FromBody] List<List<Dictionary<string, WithIntArraysDictionary>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArraysDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArraysDictionaryDouble([FromBody] List<List<Dictionary<string, WithDoubleArraysDictionary>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArraysDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArraysDictionaryString([FromBody] List<List<Dictionary<string, WithStringArraysDictionary>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceArraysDictionaryBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceArraysDictionaryBool([FromBody] List<List<Dictionary<string, WithBoolArraysDictionary>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #endregion Arrays of Dictionary

        #region Dictionary of Arrays

        [HttpPost("DictRefWithIntDictionaryArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostDictRefWithIntDictionaryArrays([FromBody] Dictionary<string, List<List<WithIntDictionaryArrays>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("DictRefWithDoubleDictionaryArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostDictRefWithDoubleDictionaryArrays([FromBody] Dictionary<string, List<List<WithDoubleDictionaryArrays>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("DictRefWithStringDictionaryArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostDictRefWithStringDictionaryArrays([FromBody] Dictionary<string, List<List<WithStringDictionaryArrays>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("DictRefWithBoolDictionaryArrays")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostDictRefWithBoolDictionaryArrays([FromBody] Dictionary<string, List<List<WithBoolDictionaryArrays>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #endregion Dictionary of Arrays

        #region Dictionary of Arrays - Required

        [HttpPost("WithReferenceDictionaryArraysInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArraysInt([FromBody] Dictionary<string, List<List<WithIntDictionaryArraysRequired>>> RequiredParameter)
            => new OkObjectResult($"Received body parameter: {RequiredParameter}");

        [HttpPost("WithReferenceDictionaryArraysDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArraysDouble([FromBody] Dictionary<string, List<List<WithDoubleDictionaryIEnumerablesRequired>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceDictionaryArraysString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArraysString([FromBody] Dictionary<string, WithStringDictionaryCollectionsRequired[][]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithReferenceDictionaryArraysBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceDictionaryArraysBool([FromBody] Dictionary<string, WithBoolDictionaryListsRequired[][]> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #endregion Dictionary of Arrays - Required

        #region Arrays of Dictionary - Required

        [HttpPost("WithRefRequiredArraysDictionaryInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRefRequiredArraysDictionaryInt([FromBody] List<List<Dictionary<string, WithIntArraysDictionaryRequired>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredArraysDictionaryDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRefRequiredArraysDictionaryDouble([FromBody] IEnumerable<IEnumerable<Dictionary<string, WithDoubleArraysIEnumerablesRequired>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredArraysDictionaryString")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRefRequiredArraysDictionaryString([FromBody] Collection<Collection<Dictionary<string, WithStringCollectionsDictionaryRequired>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        [HttpPost("WithRefRequiredArraysDictionaryBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithRefRequiredArraysDictionaryBool([FromBody] List<List<Dictionary<string, WithBoolListsDictionaryRequired>>> nonRequiredParameter)
            => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #endregion Arrays of Dictionary - Required

        [HttpPost("WithRefRequiredNestedDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceRequiredNestedDictionary([FromBody] ReferenceWithRequiredNestedDictionary requiredParameter)
           => new OkObjectResult($"Received body parameter: {requiredParameter}");

        [HttpPost("WithReferenceNestedDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedDictionary([FromBody] ReferenceWithNestedDictionary nonRequiredParameter)
           => new OkObjectResult($"Received body parameter: {nonRequiredParameter}");

        #endregion Reference With Required Fields

        #region Reference With Nullable Properties

        [HttpPost("WithReferenceNullableInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableInt([FromBody] WithIntNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableFloat")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableFloat([FromBody] WithFloatNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableLong")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableLong([FromBody] WithLongNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableDouble([FromBody] WithDoubleNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableDateTime([FromBody] WithDateTimeNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableBool")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableBool([FromBody] WithBoolNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithIntReferenceArrayNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithIntReferenceArrayNullable([FromBody] WithIntReferenceArrayNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableIntArray")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableIntArray([FromBody] WithIntArrayNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDoubleIEnumerableReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDoubleIEnumerableReferenceNullable([FromBody] WithDoubleIEnumerableReferenceNullable Parameter)

         => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDateTimeCollectionReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDateTimeCollectionReferenceNullable([FromBody] WithDateTimeCollectionReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableIntList")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableIntList([FromBody] WithIntListNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNullableIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNullableIntDictionary([FromBody] WithIntDictionaryReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithBoolListReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithBoolListReferenceNullable([FromBody] WithBoolListReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNestedIntDictionary")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedIntDictionary([FromBody] WithIntNestedDictionary Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithReferenceNestedIntDictionaryNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithReferenceNestedIntDictionaryNullable([FromBody] WithIntNestedDictionaryNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassArraysWithNullableInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassArraysWithNullableInt([FromBody] WithIntArraysReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassArraysInt")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassArraysInt([FromBody] WithIntArraysReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassIEnumerablesWithNullableDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassIEnumerablesWithNullableDouble([FromBody] WithDoubleIEnumerablesReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassIEnumerablesDouble")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassIEnumerablesDouble([FromBody] WithDoubleIEnumerablesReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassCollectionsWithNullableDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassCollectionsWithNullableDateTime([FromBody] WithDateTimeCollectionsReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassCollectionsDateTime")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassCollectionsDateTime([FromBody] WithDateTimeCollectionsReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassListsWithNullableBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassListsWithNullableBoolean([FromBody] WithBoolListsReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithClassListsBoolean")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithClassListsBoolean([FromBody] WithBoolListsReference Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        #region Dictionaries with arrays

        [HttpPost("WithDictionaryArrayWithIntReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithIntReferenceNullable([FromBody] WithIntDictionaryArrayReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithIntReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithIntReferenceNullable([FromBody] WithIntArrayDictionaryReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithDoubleReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithDoubleReferenceNullable([FromBody] WithDoubleDictionaryArrayReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithDoubleReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithDoubleReferenceNullable([FromBody] WithDoubleArrayDictionaryReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithDateTimeReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithDateTimeReferenceNullable([FromBody] WithDateTimeDictionaryArrayReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithDateTimeReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithDateTimeReferenceNullable([FromBody] WithDateTimeArrayDictionaryReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithDictionaryArrayWithBoolReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithDictionaryArrayWithBoolReferenceNullable([FromBody] WithBoolDictionaryArrayReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        [HttpPost("WithArrayDictionaryWithBoolReferenceNullable")]
        [ProducesResponseType(200, Type = typeof(IActionResult))]
        public IActionResult PostWithArrayDictionaryWithBoolReferenceNullable([FromBody] WithBoolArrayDictionaryReferenceNullable Parameter)
            => new OkObjectResult($"Received body parameter: {Parameter}");

        #endregion Dictionaries with arrays

        #endregion Reference With Nullable Properties
    }
}