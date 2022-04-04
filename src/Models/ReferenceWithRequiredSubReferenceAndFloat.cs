using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithRequiredSubReferenceAndFloat
    {
        [Required]
        public DummyInnerClass DummyInnerProp { get; set; }

        [Required]
        public Dictionary<string, DummyInnerClass> DummyInnerDictionary { get; set; }

        [Required]
        public DummyInnerClass[] DummyInnerArray { get; set; }

        [Required]
        public float FloatProp { get; set; }
    }
}