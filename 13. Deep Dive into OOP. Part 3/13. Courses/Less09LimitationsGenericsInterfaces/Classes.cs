using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09LimitationsGenericsInterfaces
{
    /// <summary>
    /// Represents a class implementing interface IInterface1.
    /// </summary>
    class A : IInterface1
    {
        /// <summary>
        /// Property1 implementation from IInterface1.
        /// </summary>
        public int Property1 { get; set; }
    }

    /// <summary>
    /// Represents a class implementing interface IInterface2.
    /// </summary>
    class B : IInterface2
    {
        /// <summary>
        /// Property2 implementation from IInterface2.
        /// </summary>
        public int Property2 { get; set; }
    }

    /// <summary>
    /// Represents a class implementing interface IInterface3 with a generic type of string.
    /// </summary>
    class C : IInterface3<string>
    {
        /// <summary>
        /// Property3 implementation from IInterface3 with a generic type of string.
        /// </summary>
        public string Property3 { get; set; }
    }

    /// <summary>
    /// Represents a class implementing interface IInterface3 with a generic type of int.
    /// </summary>
    class D : IInterface3<int>
    {
        /// <summary>
        /// Property3 implementation from IInterface3 with a generic type of int.
        /// </summary>
        public int Property3 { get; set; }
    }

    /// <summary>
    /// Represents a class implementing multiple interfaces: IInterface1, IInterface2, and IInterface3 with a generic type of string.
    /// </summary>
    class E : IInterface1, IInterface2, IInterface3<string>
    {
        /// <summary>
        /// Property1 implementation from IInterface1.
        /// </summary>
        public int Property1 { get; set; }

        /// <summary>
        /// Property2 implementation from IInterface2.
        /// </summary>
        public int Property2 { get; set; }

        /// <summary>
        /// Property3 implementation from IInterface3 with a generic type of string.
        /// </summary>
        public string Property3 { get; set; }
    }
}
