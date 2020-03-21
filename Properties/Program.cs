using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1989, 5, 28));
            Console.WriteLine(person.Age);
            Console.ReadKey();
        }
    }
}
