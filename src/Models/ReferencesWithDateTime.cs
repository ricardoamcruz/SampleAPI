using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithDateTime
    {
        public DateTime DateTimeProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeRequired
    {
        [Required]
        public DateTime DateTimePropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeArray
    {
        public DateTime[] DateTimeArrayProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeDictionary
    {
        public Dictionary<string, DateTime> DateTimeDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeArraysDictionary
    {
        public Dictionary<string, DateTime[][]> DateTimeDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeDictionaryRequired
    {
        [Required]
        public Dictionary<string, DateTime> DateTimeDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeCollectionReference
    {
        public Collection<WithDateTime> DateTimeCollection { get; set; }
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
    public class WithDateTimeNullable
    {
        public DateTime? DateTimeNullableProp { get; set; }
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

    [ExcludeFromCodeCoverage]
    public class WithDateTimeCollectionsReference
    {
        public Collection<Collection<WithDateTime>> DateTimeCollections { get; set; }
    }
}