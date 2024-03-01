using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04OverloadingOperations
{
    /// <summary>
    /// Represents a complex number with real and imaginary parts.
    /// </summary>
    internal class Complex
    {
        /// <summary>
        /// Gets or sets the real part of the complex number.
        /// </summary>
        public int A { get; set; }

        /// <summary>
        /// Gets or sets the imaginary part of the complex number.
        /// </summary>
        public int B { get; set; }

        /// <summary>
        /// Returns a string representation of the complex number.
        /// </summary>
        /// <returns>A string representation of the complex number in the form "A + Bi".</returns>
        public override string ToString() => $"{A} + {B}i";

        /// <summary>
        /// Overloads the addition operator (+) to add two complex numbers.
        /// </summary>
        /// <param name="x">The first complex number.</param>
        /// <param name="y">The second complex number.</param>
        /// <returns>The result of adding the two complex numbers.</returns>
        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex() { A = x.A + y.B, B = x.B + y.B };
        }

        /// <summary>
        /// Overloads the greater-than operator (>) to compare the magnitudes of two complex numbers.
        /// </summary>
        /// <param name="x">The first complex number.</param>
        /// <param name="y">The second complex number.</param>
        /// <returns>True if the magnitude of x is greater than the magnitude of y; otherwise, false.</returns>
        public static bool operator >(Complex x, Complex y)
        {
            double m1 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            double m2 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            return m1 > m2;
        }

        /// <summary>
        /// Overloads the less-than operator (<) to compare the magnitudes of two complex numbers.
        /// </summary>
        /// <param name="x">The first complex number.</param>
        /// <param name="y">The second complex number.</param>
        /// <returns>True if the magnitude of x is less than the magnitude of y; otherwise, false.</returns>
        public static bool operator <(Complex x, Complex y)
        {
            double m1 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            double m2 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            return m1 > m2;
        }
    }
}
