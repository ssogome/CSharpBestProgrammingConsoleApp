using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBestProgrammingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Corn _corn = new Corn();
            Spinach  _spinach = new Spinach()  ;

            ActOn  _actOn = new ActOn();

            Console.WriteLine("Action on corn \n");
            _actOn.BakeVegetableWithAction(_corn, 5);


            Console.WriteLine("\n Action on Spinach \n");
            _actOn.FryVegetableWithAction(_spinach, 8);

            Console.ReadLine();
        }
    }
}
