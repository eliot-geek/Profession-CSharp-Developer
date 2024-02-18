using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less08LimitationsStorages
{
    /// <summary>
    /// Represents an abstract base class with a property and a method to get the property value.
    /// </summary>
    internal abstract class A
    {
        /// <summary>
        /// Property with a default value of 0.
        /// </summary>
        public int Property { get; set; } = 0;

        /// <summary>
        /// Gets the value of the property.
        /// </summary>
        /// <returns>The value of the property as a formatted string.</returns>
        public string GetProperty()
        {
            return $"Property = {Property}";
        }
    }

    /// <summary>
    /// Represents a class inheriting from A.
    /// </summary>
    class B : A { }

    /// <summary>
    /// Represents a class inheriting from A.
    /// </summary>
    class C : A { }

    /// <summary>
    /// Represents a class inheriting from B.
    /// </summary>
    class D : B { }

    /// <summary>
    /// Represents a class inheriting from C.
    /// </summary>
    class E : C { }

    /// <summary>
    /// Represents a class inheriting from E.
    /// </summary>
    class F : E { }
}
