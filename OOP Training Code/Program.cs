using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training_Code
{
    class Human
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0)
                {
                    age = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human mard1 = new Human();
            mard1.Age = 50;

            Console.WriteLine($"This human is {mard1.Age} years old");
        }
    }
}
