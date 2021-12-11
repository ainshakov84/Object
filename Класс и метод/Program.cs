using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класс_и_метод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Say();

            Console.WriteLine(cat.color);
            Console.ReadKey;
          
        }
    }
    class Cat
    {
        public string name;
        public string color;
        public int age;

       

       public void Say()
        {
            Console.WriteLine("Мау. меня зовут {0}", name);
        }
    }
}
