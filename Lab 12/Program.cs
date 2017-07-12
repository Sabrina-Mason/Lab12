using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            interface ISampleInterface
        {
            void SampleMethod();
        }

        class ImplementationClass : ISampleInterface
        {
            // Explicit interface member implementation: 
            void ISampleInterface.SampleMethod()
            {
                // Method implementation.
            }

            static void Main()
            {
                // Declare an interface instance.
                ISampleInterface obj = new ImplementationClass();

                // Call the member.
                obj.SampleMethod();
            }
    }
}
