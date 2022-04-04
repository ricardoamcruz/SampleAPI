using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.NegativeClasses
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithName
    {
        public Dictionary<string, string> Name1 { get; set; }
    }
}