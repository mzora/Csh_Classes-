using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{   
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, i am {1}", to, Name);
            Console.ReadKey();
        }

        //create a person obj from a string
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("jon");
            person.Introduce("mario");
        }
    }
}
