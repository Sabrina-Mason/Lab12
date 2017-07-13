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
            Rock  r = new Rock();
            Sciss s = new Sciss();
            Paper p = new Paper();

            Console.WriteLine("Enter a name and select an opponent: ");

            interface IGame
        {
            string ChooseRock();
            string ChooseScis();
            string ChoosePaper();

            class Rock : IGame
            {
                public string ChooseRock();
                {
                    return "Rock";
                }
            public string Scis;
            {

             return "Scissors";


        
        }
           


        }
    }
}
