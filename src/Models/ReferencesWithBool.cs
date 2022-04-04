using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithBool
    {
        public bool BoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolRequired
    {
        [Required]
        public bool BoolPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolList
    {
        public List<bool> BoolList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArrays
    {
        public bool[][] BoolArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolLists
    {
        public List<List<bool>> BoolLists { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryArray
    {
        public Dictionary<string, bool[]> BoolDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryArrays
    {
        public Dictionary<string, bool[][]> BoolDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArraysRequired
    {
        [Required]
        public bool[][] BoolArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArrayDictionary
    {
        public Dictionary<string, bool>[] BoolArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArraysDictionary
    {
        public Dictionary<string, bool>[][] BoolArraysDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryRequired
    {
        [Required]
        public Dictionary<string, bool> BoolDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionariesArraysReference
    {
        public Dictionary<string, Dictionary<string, List<List<bool>>>> BoolDictionariesArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionariesArraysReferenceRequired
    {
        [Required]
        public Dictionary<string, Dictionary<string, List<List<bool>>>> BoolDictionariesArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListRequired
    {
        [Required]
        public List<bool> BoolListRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListsRequired
    {
        [Required]
        public List<List<bool>> BoolListsRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArraysDictionariesReference
    {
        public List<List<Dictionary<string, Dictionary<string, bool>>>> BoolArraysDictionaries { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListReference
    {
        public List<WithBool> BoolList { get; set; }
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
    public class WithBoolNullable
    {
        public bool? BoolNullableProp { get; set; }
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

    [ExcludeFromCodeCoverage]
    public class WithBoolListsReference
    {
        public List<List<WithBool>> BoolList { get; set; }
    }
}