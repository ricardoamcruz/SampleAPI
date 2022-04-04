using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithInt
    {
        public int IntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntTwoProperties
    {
        public int FirstIntProp { get; set; }
        public int SecondIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntRequired
    {
        [Required]
        public int IntPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArray
    {
        public int[] IntArrayProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrays
    {
        public int[][] IntArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionary
    {
        public Dictionary<string, int> IntDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArray
    {
        public Dictionary<string, int[]> IntDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArrays
    {
        public Dictionary<string, int[][]> IntDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrayDictionary
    {
        public Dictionary<string, int>[] IntArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysDictionary
    {
        public Dictionary<string, int>[][] IntArraysDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryRequired
    {
        [Required]
        public Dictionary<string, int> IntDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrayRequired
    {
        [Required]
        public int[] IntArrayRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysRequired
    {
        [Required]
        public int[][] IntArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysDictionariesReference
    {
        public List<List<Dictionary<string, Dictionary<string, int>>>> IntArraysDictionaries { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysDictionariesReferenceRequired
    {
        [Required]
        public List<List<Dictionary<string, Dictionary<string, int>>>> IntArraysDictionaries { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionariesArraysReference
    {
        public Dictionary<string, Dictionary<string, List<List<int>>>> IntDictionariesArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntReferenceArray
    {
        public WithInt[] IntReferenceArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntNestedDictionary
    {
        public Dictionary<string, Dictionary<string, WithInt>> IntNestedDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryReference
    {
        public Dictionary<string, WithInt> IntDictionaryReference { get; set; }
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
    public class WithIntNullable
    {
        public int? IntNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryReferenceNullable
    {
        public Dictionary<string, WithIntNullable> IntNullableDictionaryReference { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntListNullable
    {
        public List<int?> IntNullableList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrayNullable
    {
        public int?[] IntNullableArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntNestedDictionaryNullable
    {
        public Dictionary<string, Dictionary<string, WithIntNullable>> IntNestedDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntReferenceArrayNullable
    {
        public WithIntNullable[] IntReferenceArray { get; set; }
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
    public class WithIntArraysReferenceNullable
    {
        public WithIntNullable[][] IntNullableArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysReference
    {
        public WithInt[][] IntArraysProp { get; set; }
    }
}