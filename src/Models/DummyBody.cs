using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class DummyBody
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string[] Tags { get; set; }
        public DummyInnerClass Inner { get; set; }
        public List<string> StringList { get; set; }
        public List<DummyInnerClass> ObjectList { get; set; }
        public Dictionary<string, int> Dict { get; set; }
    }
}