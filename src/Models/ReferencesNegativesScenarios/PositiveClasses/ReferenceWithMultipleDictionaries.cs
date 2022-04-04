using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models.ReferencesNegativesScenarios.PositiveClasses
{
    [ExcludeFromCodeCoverage]
    public class ReferenceWithMultipleDictionaries
    {
        public Dictionary<string, string> Name { get; set; }
        public Dictionary<string, string> Id { get; set; }
    }
}