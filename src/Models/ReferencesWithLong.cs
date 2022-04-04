using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithLong
    {
        public long LongProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongRequired
    {
        [Required]
        public long LongPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongArray
    {
        public long[] LongArrayProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongArrays
    {
        public long[][] LongArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongDictionary
    {
        public Dictionary<string, long> LongDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongICollection
    {
        public ICollection<long> LongICollection { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongDictionaryArrays
    {
        public Dictionary<string, long[][]> LongDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongDictionaryRequired
    {
        [Required]
        public Dictionary<string, long> LongDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongICollectionRequired
    {
        [Required]
        public ICollection<long> LongICollectionRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongNullable
    {
        public long? LongNullableProp { get; set; }
    }
}