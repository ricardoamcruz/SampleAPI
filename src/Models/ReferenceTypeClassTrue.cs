using System;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class ReferenceTypeClassTrue
    {
        public int FirstPropInt { get; set; }
        public long SecondPropInt { get; set; }
        public double FirstPropNumber { get; set; }
        public float SecondPropNumber { get; set; }
        public string StringProp { get; set; }
        public DateTime DateTimeProp { get; set; }
        public bool BoolProp { get; set; }
    }
}