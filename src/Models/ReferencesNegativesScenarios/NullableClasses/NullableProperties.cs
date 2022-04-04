using System;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NullableClasses
{
    #region It is Nullable properties

    [ExcludeFromCodeCoverage]
    public class WithInt
    {
        public int? IntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLong
    {
        public long? LongProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloat
    {
        public float? FloatProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDouble
    {
        public double? DoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBool
    {
        public bool? BoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTime
    {
        public DateTime? DateTimeProp { get; set; }
    }

    #endregion It is Nullable properties
}