using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NegativeClasses
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeLongJsonInt
    {
        public long LongIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeLongArrayJsonInt
    {
        public long[] LongIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeFloatJsonArrayDouble
    {
        public float FloatArrayDoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeDateTimeCollectionJsonArrayString
    {
        public Collection<DateTime> DateTimeArrayStringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeDateTimeJsonWithArrayString
    {
        public DateTime DateTimeArrayStringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeStringListJsonArrayBool
    {
        public List<string> StringListArrayBoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeStringJsonWithArrayBool
    {
        public string StringListArrayBoolProp { get; set; }
    }
}