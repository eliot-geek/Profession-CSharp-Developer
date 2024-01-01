using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less07Encapsulation
{
    /// <summary>
    /// Computer
    /// </summary>
    public struct Computer1
    {
        /// <summary>
        /// Computer's Name
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Computer's creation
        /// </summary>
        /// <param name="Title"></param>
        public Computer1(string Title)
        {
            this.Title = Title;
        }

        #region Methods On\Off

        /// <summary>
        /// BIOS loading
        /// </summary>
        public void ActivationBIOS() 
        { 
            Console.WriteLine($"{this.Title} | Activation BIOS..."); 
        }

        /// <summary>
        /// OS loading
        /// </summary>
        public void ActivationOS() 
        { 
            Console.WriteLine($"{this.Title} | Activation OS..."); 
        }

        /// <summary>
        /// Greetings
        /// </summary>
        public void Greeting() 
        { 
            Console.WriteLine($"{this.Title} | Hello..."); 
        }

        /// <summary>
        /// BIOS unloading
        /// </summary>
        public void DeactivationBIOS() 
        { 
            Console.WriteLine($"{this.Title} | Deactivation BIOS..."); 
        }

        /// <summary>
        /// OS unloading
        /// </summary>
        public void DeactivationOS() 
        { 
            Console.WriteLine($"{this.Title} | Deactivation OS..."); 
        }

        /// <summary>
        /// Bye
        /// </summary>
        public void Parting() 
        { 
            Console.WriteLine($"{this.Title} | Bye..."); 
        }

        #endregion

        /// <summary>
        /// Method demonstrating operation
        /// </summary>
        public void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
