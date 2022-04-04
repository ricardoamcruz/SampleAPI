using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithInfiniteRerefence
    {
        public WithInfiniteRerefence InfiniteReferenceProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithInfiniteRerefenceAndIntProp
    {
        public int PropInt { get; set; }
        public WithInfiniteRerefenceAndIntProp SubWithInfiniteRerefenceAndIntProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ParentReferenceWithInfiniteRecursionInsideTheProperties
    {
        public ChildReferenceWithInfiniteRecursionInsideTheProperties Child { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChildReferenceWithInfiniteRecursionInsideTheProperties
    {
        public ParentReferenceWithInfiniteRecursionInsideTheProperties ParentChild { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ParentClass
    {
        public string Name { get; set; }
        public Dictionary<string, int> Dict { get; set; }
        public List<string> StringList { get; set; }
        public Int32 Id { get; set; }
        public List<string> Tags { get; set; }
        public ChildClass ChildClass { get; set; }
        public ChildClass[] ObjectList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChildClass
    {
        public string LastName { get; set; }
        public ChildClassWithInfiniteRecursion ChildClassWithInfiniteRecursion { get; set; }
        public string Name { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChildClassWithInfiniteRecursion
    {
        public string LastName { get; set; }
        public ChildClassWithInfiniteRecursion SubChildClassWithInfiniteRecursion { get; set; }
        public string Name { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ParentWithProperties
    {
        public Dictionary<string, float> DictionaryProperty { get; set; }
        public long[] ArrayProperty { get; set; }
        public ParentWithProperties InfiniteReferenceProperty { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ParentWithChildInfiniteRecursion
    {
        public Dictionary<string, float> DictionaryProperty { get; set; }
        public Collection<long> ArrayProperty { get; set; }
        public ChildClassWithInfiniteRecursion ChildRecursionProperty { get; set; }
        public ParentWithChildInfiniteRecursion InfiniteReferenceProperty { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ParentWithChildToParentInfiniteRecursion
    {
        public Dictionary<string, float> DictionaryProperty { get; set; }
        public Collection<long> CollectionProperty { get; set; }
        public ChildToParentInfiniteRecursion ChildInfiniteReferenceProperty { get; set; }
        public ParentWithChildInfiniteRecursion SubParentProperty { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChildToParentInfiniteRecursion
    {
        public Dictionary<int, int> DictionaryProperty { get; set; }
        public ICollection<string> CollectionProperty { get; set; }
        public ParentWithChildToParentInfiniteRecursion InfiniteReferenceProperty { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithSelfReference
    {
        public WithSelfReference MyClass { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithSelfReferenceAndInt
    {
        public int IntProp { get; set; }
        public WithSelfReference MyClass { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithChildToParentReference
    {
        public ClassChildToParent MyClassA { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ClassChildToParent
    {
        public WithChildToParentReference MyClassB { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithChildToParentReferenceAndInt
    {
        public int IntProp { get; set; }
        public ClassChildToParentAndString MyClassA { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ClassChildToParentAndString
    {
        public string StringProp { get; set; }
        public WithChildToParentReference MyClassB { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithChildSelfReference
    {
        public ClassChildSelfReference MyClassA { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ClassChildSelfReference
    {
        public ClassChildSelfReference MyClassB { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithChildSelfReferenceAndInt
    {
        public int IntProp { get; set; }
        public ClassChildSelfReferenceAndString MyClassA { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ClassChildSelfReferenceAndString
    {
        public string StringProp { get; set; }
        public ClassChildSelfReference MyClassB { get; set; }
    }
}