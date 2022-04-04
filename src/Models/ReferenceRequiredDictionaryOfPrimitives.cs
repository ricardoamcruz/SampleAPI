using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    #region Dictionary of Array

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArrayRequired
    {
        [Required]
        public Dictionary<string, int[]> IntDictionaryArrayRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryIEnumerableRequired
    {
        [Required]
        public Dictionary<string, IEnumerable<double>> DoubleDictionaryIEnumerableRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryIEnumerable
    {
        public Dictionary<string, IEnumerable<double>> DoubleDictionaryIEnumerable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryCollectionRequired
    {
        [Required]
        public Dictionary<string, Collection<string>> StringDictionaryCollectionRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryCollection
    {
        public Dictionary<string, Collection<string>> StringDictionaryCollection { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryListRequired
    {
        [Required]
        public Dictionary<string, List<bool>> BoolDictionaryListRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryList
    {
        public Dictionary<string, List<bool>> BoolDictionaryList { get; set; }
    }

    #endregion Dictionary of Array

    #region Array of Dictionary

    [ExcludeFromCodeCoverage]
    public class WithIntArrayDictionaryRequired
    {
        [Required]
        public Dictionary<string, int>[] IntArrayDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableDictionaryRequired
    {
        [Required]
        public IEnumerable<Dictionary<string, double>> DoubleIEnumerableDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollectionDictionaryRequired
    {
        [Required]
        public Collection<Dictionary<string, string>> StringCollectionDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollectionDictionary
    {
        public Collection<Dictionary<string, string>> StringCollectionDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListDictionaryRequired
    {
        [Required]
        public List<Dictionary<string, bool>> BoolListDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListDictionary
    {
        public List<Dictionary<string, bool>> BoolListDictionary { get; set; }
    }

    #endregion Array of Dictionary

    #region Dictionary of Multiple Arrays

    [ExcludeFromCodeCoverage]
    public class WithIntDictionaryArraysRequired
    {
        [Required]
        public Dictionary<string, int[][]> IntDictionaryArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryIEnumerablesRequired
    {
        [Required]
        public Dictionary<string, IEnumerable<IEnumerable<double>>> DoubleDictionaryIEnumerablesRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryCollectionsRequired
    {
        [Required]
        public Dictionary<string, Collection<Collection<string>>> StringDictionaryCollectionsRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolDictionaryListsRequired
    {
        [Required]
        public Dictionary<string, List<List<bool>>> BoolDictionaryListsRequired { get; set; }
    }

    #endregion Dictionary of Multiple Arrays

    #region Multiple Arrays of Dictionary

    [ExcludeFromCodeCoverage]
    public class WithIntArraysDictionaryRequired
    {
        [Required]
        public Dictionary<string, int>[][] IntArraysDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArraysIEnumerablesRequired
    {
        [Required]
        public IEnumerable<IEnumerable<Dictionary<string, double>>> DoubleArraysIEnumerablesRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollectionsDictionaryRequired
    {
        [Required]
        public Collection<Collection<Dictionary<string, string>>> StringCollectionsDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolListsDictionaryRequired
    {
        [Required]
        public List<List<Dictionary<string, bool>>> BoolListsDictionaryRequired { get; set; }
    }

    #endregion Multiple Arrays of Dictionary
}