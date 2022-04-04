using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithRequiredNestedDictionary
    {
        [Required]
        public Dictionary<string, Dictionary<string, string>> RequiredNestedDictionaryProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithNestedDictionary
    {
        public Dictionary<string, Dictionary<string, string>> NestedDictionaryProp { get; set; }
    }
}