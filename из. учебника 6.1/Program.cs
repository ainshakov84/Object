using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace из.учебника_6._1

{
    class MyClass
    {
        public int namber;
        public char symbol;
        public void show ()
        {
            Console.WriteLine ("Целочисленное поле:" + namber);
            Console.WriteLine ("Символльное поле:" + symbol);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B;
            B = new MyClass();
            A.namber = Convert.ToInt32(Console.ReadLine());
            A.symbol = Convert.ToChar(Console.ReadLine());
            B.namber = 2;
            B.symbol = 'B';
            Console.WriteLine("Первый объект");
            A.show ();
            Console.WriteLine("Второй объект");
            B.show ();
            Console.ReadKey ();
        }
    }
}
