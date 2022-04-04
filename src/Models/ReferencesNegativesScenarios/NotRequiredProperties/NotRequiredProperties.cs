using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NotRequiredProperties
{
    [ExcludeFromCodeCoverage]
    public class WithIntRequired
    {
        public int IntPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLongRequired
    {
        public long LongPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleRequired
    {
        public double DoublePropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloatRequired
    {
        public float FloatPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringRequired
    {
        public string StringPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTimeRequired
    {
        public DateTime DateTimePropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolRequired
    {
        public bool BoolPropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithInt
    {
        [Required]
        public int IntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithLong
    {
        [Required]
        public long LongProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDouble
    {
        [Required]
        public double DoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithFloat
    {
        [Required]
        public float FloatProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithString
    {
        [Required]
        public string StringProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDateTime
    {
        [Required]
        public DateTime DateTimeProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBool
    {
        [Required]
        public bool BoolProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArrays
    {
        [Required]
        public int[][] IntArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrays
    {
        [Required]
        public double[][] DoubleArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArrays
    {
        [Required]
        public string[][] StringArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArrays
    {
        [Required]
        public bool[][] BoolArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithIntArraysRequired
    {
        public int[][] IntArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArraysRequired
    {
        public string[][] DoubleArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithStringArraysRequired
    {
        public string[][] StringArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithBoolArraysRequired
    {
        public bool[][] BoolArraysRequired { get; set; }
    }
}