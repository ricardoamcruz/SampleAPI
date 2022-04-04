using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SampleAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class WithDouble
    {
        public double DoubleProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleRequired
    {
        [Required]
        public double DoublePropRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleNullable
    {
        public double? DoubleNullableProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrays
    {
        public double[][] DoubleArraysProp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleEnumerable
    {
        public IEnumerable<double> DoubleEnumerable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableRequired
    {
        [Required]
        public IEnumerable<double> DoubleIEnumerableRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerable
    {
        public IEnumerable<double> DoubleIEnumerable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerables
    {
        public IEnumerable<IEnumerable<double>> DoubleIEnumerables { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableDictionary
    {
        public IEnumerable<Dictionary<string, double>> DoubleIEnumerableDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerablesRequired
    {
        [Required]
        public IEnumerable<IEnumerable<double>> DoubleIEnumerablesRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArraysRequired
    {
        [Required]
        public string[][] DoubleArraysRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableReference
    {
        public IEnumerable<WithDouble> DoubleIEnumerable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrayDictionaryReference
    {
        public IEnumerable<Dictionary<string, WithDouble>> DoubleArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrayDictionaryReferenceNullable
    {
        public IEnumerable<Dictionary<string, WithDoubleNullable>> DoubleArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerableReferenceNullable
    {
        public IEnumerable<WithDoubleNullable> DoubleIEnumerableNullable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerablesReferenceNullable
    {
        public IEnumerable<IEnumerable<WithDoubleNullable>> DoubleIEnumerablesNullable { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleIEnumerablesReference
    {
        public IEnumerable<IEnumerable<WithDouble>> DoubleIEnumerables { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionary
    {
        public Dictionary<string, double> DoubleDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArray
    {
        public Dictionary<string, double[]> DoubleDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArrays
    {
        public Dictionary<string, double[][]> DoubleDictionaryArrays { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArrayDictionary
    {
        public Dictionary<string, double>[] DoubleArrayDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleArraysDictionary
    {
        public Dictionary<string, double>[][] DoubleArraysDictionary { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryRequired
    {
        [Required]
        public Dictionary<string, double> DoubleDictionaryRequired { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArrayReference
    {
        public Dictionary<string, IEnumerable<WithDouble>> DoubleDictionaryArray { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class WithDoubleDictionaryArrayReferenceNullable
    {
        public Dictionary<string, IEnumerable<WithDoubleNullable>> DoubleDictionaryArray { get; set; }
    }
}