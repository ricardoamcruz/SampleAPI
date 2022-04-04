using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithFloat
    {
        public float FloatProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatRequired
    {
        [Required]
        public float FloatPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatIList
    {
        public IList<float> FloatIList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatArray
    {
        public float[] FloatArrayProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatDictionary
    {
        public Dictionary<string, float> FloatDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatDictionaryArrays
    {
        public Dictionary<string, float[][]> FloatArraysDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatDictionaryRequired
    {
        [Required]
        public Dictionary<string, float> FloatDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatIListRequired
    {
        [Required]
        public IList<float> FloatIListRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatNullable
    {
        public float? FloatNullableProp { get; set; }
    }
}