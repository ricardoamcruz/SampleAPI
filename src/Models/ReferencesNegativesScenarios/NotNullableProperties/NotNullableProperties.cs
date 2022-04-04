using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NotNullableProperties
{
    #region Long Properties

    [ExcludeFromCodeCoverage]
    public class WithLong
    {
        public long? LongProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongNullable
    {
        public long LongNullableProp { get; set; }
    }

    #endregion Long Properties

    #region Float Properties

    [ExcludeFromCodeCoverage]
    public class WithFloat
    {
        public float? FloatProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatNullable
    {
        public float FloatNullableProp { get; set; }
    }

    #endregion Float Properties

    #region Bool Properties

    [ExcludeFromCodeCoverage]
    public class WithBool
    {
        public bool? BoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListReference
    {
        public List<WithBool> BoolList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolNullable
    {
        public bool BoolNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryArrayReference
    {
        public Dictionary<string, List<WithBool>> BoolDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArrayDictionaryReference
    {
        public List<Dictionary<string, WithBool>> BoolArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryArrayReferenceNullable
    {
        public Dictionary<string, List<WithBoolNullable>> BoolDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArrayDictionaryReferenceNullable
    {
        public List<Dictionary<string, WithBoolNullable>> BoolArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListReferenceNullable
    {
        public List<WithBoolNullable> BoolListNullable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListsReferenceNullable
    {
        public List<List<WithBoolNullable>> BoolListsNullable { get; set; }
    }

    #endregion Bool Properties

    #region DateTime Properties

    [ExcludeFromCodeCoverage]
    public class WithDateTime
    {
        public DateTime? DateTimeProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeCollectionReference
    {
        public Collection<WithDateTime> DateTimeCollection { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeNullable
    {
        public DateTime DateTimeNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeDictionaryArrayReference
    {
        public Dictionary<string, List<WithDateTime>> DateTimeDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeArrayDictionaryReference
    {
        public List<Dictionary<string, WithDateTime>> DateTimeArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeDictionaryArrayReferenceNullable
    {
        public Dictionary<string, List<WithDateTimeNullable>> DateTimeDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeArrayDictionaryReferenceNullable
    {
        public List<Dictionary<string, WithDateTimeNullable>> DateTimeArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeCollectionReferenceNullable
    {
        public Collection<WithDateTimeNullable> DateTimeCollectionNullable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeCollectionsReferenceNullable
    {
        public Collection<Collection<WithDateTimeNullable>> DateTimeCollectionsNullable { get; set; }
    }

    #endregion DateTime Properties

    #region Double Properties

    [ExcludeFromCodeCoverage]
    public class WithDouble
    {
        public double? DoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableReference
    {
        public IEnumerable<WithDouble> DoubleIEnumerable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleNullable
    {
        public double DoubleNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArrayReference
    {
        public Dictionary<string, IEnumerable<WithDouble>> DoubleDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrayDictionaryReference
    {
        public IEnumerable<Dictionary<string, WithDouble>> DoubleArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArrayReferenceNullable
    {
        public Dictionary<string, IEnumerable<WithDoubleNullable>> DoubleDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrayDictionaryReferenceNullable
    {
        public IEnumerable<Dictionary<string, WithDoubleNullable>> DoubleArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableReferenceNullable
    {
        public IEnumerable<WithDoubleNullable> DoubleIEnumerableNullable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerablesReferenceNullable
    {
        public IEnumerable<IEnumerable<WithDoubleNullable>> DoubleIEnumerablesNullable { get; set; }
    }

    #endregion Double Properties

    #region Int Properties

    [ExcludeFromCodeCoverage]
    public class WithInt
    {
        public int? IntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntReferenceArray
    {
        public WithInt[] IntReferenceArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntNullable
    {
        public int IntNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryReference
    {
        public Dictionary<string, WithInt> IntDictionaryReference { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryReferenceNullable
    {
        public Dictionary<string, WithIntNullable> IntNullableDictionaryReference { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntNestedDictionary
    {
        public Dictionary<string, Dictionary<string, WithInt>> IntNestedDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntNestedDictionaryNullable
    {
        public Dictionary<string, Dictionary<string, WithIntNullable>> IntNestedDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArrayReference
    {
        public Dictionary<string, WithInt[]> IntDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrayDictionaryReference
    {
        public Dictionary<string, WithInt>[] IntArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArrayReferenceNullable
    {
        public Dictionary<string, WithIntNullable[]> IntDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrayDictionaryReferenceNullable
    {
        public Dictionary<string, WithIntNullable>[] IntArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntReferenceArrayNullable
    {
        public WithIntNullable[] IntReferenceArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysReferenceNullable
    {
        public WithIntNullable[][] IntNullableArraysProp { get; set; }
    }

    #endregion Int Properties
}