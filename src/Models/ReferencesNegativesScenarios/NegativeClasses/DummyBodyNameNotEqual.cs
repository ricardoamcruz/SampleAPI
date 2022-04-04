using System;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NegativeClasses
{
    [ExcludeFromCodeCoverage]
    public class DummyBodyNameNotEqual
    {
        public string OtherName { get; set; }
        public Int32 OtherId { get; set; }
    }
}