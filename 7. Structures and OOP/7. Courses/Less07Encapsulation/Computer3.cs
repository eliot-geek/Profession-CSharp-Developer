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
    public struct Computer3
    {
        /// <summary>
        /// Computer's Name
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// condition
        /// </summary>
        private bool condition;

        /// <summary>
        /// Indicator
        /// </summary>
        public int Indicator 
        { 
            get 
            { 
                return this.condition ? 1 : 0; 
            } 
        }

        /// <summary>
        /// Computer's creation
        /// </summary>
        /// <param name="Title"></param>
        public Computer3(string Title)
        {
            this.Title = Title;
            this.condition = false;
        }

        /// <summary>
        /// Power
        /// </summary>
        public void Power()
        {
            if (this.condition)
            {
                this.PowerOff();
                this.condition = false;
            }
            else
            {
                this.PowerOn();
                this.condition = true;
            }

        }

        #region Methods On\Off

        /// <summary>
        /// BIOS loading
        /// </summary>
        private void ActivationBIOS()
        {
            Console.WriteLine($"{this.Title} | Activation BIOS...");
        }

        /// <summary>
        /// OS loading
        /// </summary>
        private void ActivationOS()
        {
            Console.WriteLine($"{this.Title} | Activation OS...");
        }

        /// <summary>
        /// Greetings
        /// </summary>
        private void Greeting()
        {
            Console.WriteLine($"{this.Title} | Hello...");
        }

        /// <summary>
        /// BIOS unloading
        /// </summary>
        private void DeactivationBIOS()
        {
            Console.WriteLine($"{this.Title} | Deactivation BIOS...");
        }

        /// <summary>
        /// OS unloading
        /// </summary>
        private void DeactivationOS()
        {
            Console.WriteLine($"{this.Title} | Deactivation OS...");
        }

        /// <summary>
        /// Bye
        /// </summary>
        private void Parting()
        {
            Console.WriteLine($"{this.Title} | Bye...");
        }

        #endregion


        /// <summary>
        /// PowerOn
        /// </summary>
        public void PowerOn()
        {
            this.ActivationBIOS();
            this.ActivationOS();
            this.Greeting();
            this.Calculation();
        }

        /// <summary>
        /// PowerOff
        /// </summary>
        public void PowerOff()
        {
            this.Parting();
            this.DeactivationOS();
            this.DeactivationBIOS();
        }

        /// <summary>
        /// Method demonstrating operation
        /// </summary>
        private void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
