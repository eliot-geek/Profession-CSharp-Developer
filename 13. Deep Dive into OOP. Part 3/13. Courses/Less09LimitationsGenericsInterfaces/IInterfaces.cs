using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09LimitationsGenericsInterfaces
{
    /// <summary>
    /// Represents interface IInterface1 with a single property Property1.
    /// </summary>
    interface IInterface1 
    { 
        int Property1 { get; set; } 
    }

    /// <summary>
    /// Represents interface IInterface2 with a single property Property2.
    /// </summary>
    interface IInterface2 
    { 
        int Property2 { get; set; } 
    }

    /// <summary>
    /// Represents interface IInterface3 with a single property Property3 of generic type T.
    /// </summary>
    /// <typeparam name="T">The type of the property Property3.</typeparam>
    interface IInterface3<T> 
    { 
        T Property3 { get; set; } 
    }
}
