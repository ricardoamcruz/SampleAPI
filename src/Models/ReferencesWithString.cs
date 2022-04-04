using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithString
    {
        public string StringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringRequired
    {
        [Required]
        public string StringPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringICollection
    {
        public ICollection<string> StringICollection { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollection
    {
        public Collection<string> StringCollection { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollections
    {
        public Collection<Collection<string>> StringCollections { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArray
    {
        public string[] StringArrayProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArrays
    {
        public string[][] StringArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArraysRequired
    {
        [Required]
        public string[][] StringArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionary
    {
        public Dictionary<string, string> StringDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryArray
    {
        public Dictionary<string, string[]> StringDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryArrays
    {
        public Dictionary<string, string[][]> StringDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringLists
    {
        public List<List<string>> StringLists { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArrayDictionary
    {
        public Dictionary<string, string>[] StringArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArraysDictionary
    {
        public Dictionary<string, string>[][] StringArraysDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringDictionaryRequired
    {
        [Required]
        public Dictionary<string, string> StringDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollectionRequired
    {
        [Required]
        public Collection<string> StringCollectionRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringCollectionsRequired
    {
        [Required]
        public Collection<Collection<string>> StringCollectionsRequired { get; set; }
    }
}