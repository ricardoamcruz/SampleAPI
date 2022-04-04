using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.PositiveClasses
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeLongJsonInt
    {
        public int[] LongIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeLongArrayJsonInt
    {
        public int LongIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeFloatJsonArrayDouble
    {
        public double[] FloatArrayDoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeDateTimeCollectionJsonArrayString
    {
        public string[] DateTimeArrayStringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeDateTimeJsonWithArrayString
    {
        public string DateTimeArrayStringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeStringListJsonArrayBool
    {
        public bool[] StringListArrayBoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ReferenceWithTypeStringJsonWithArrayBool
    {
        public bool StringListArrayBoolProp { get; set; }
    }
}