using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exo1 p = new Exo1();
            Exo2 g = new Exo2();
            Exo3 d = new Exo3();
            Exo4 t = new Exo4();
            Exo5 v = new Exo5();
            Console.WriteLine("Choose which exercise you want to see: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Exercise 1: Multiplication Tables");
                    p.ex1();
                    break;
                case 2 :
                    Console.WriteLine("Exercise 2: More math");
                    g.ex2();
                    break;
                case 3:
                    Console.WriteLine("Exercise 3: Try/Catch");
                    d.GomuGomu();
                    break;
                case 4:
                    Console.WriteLine("Exercise 4: Square");
                    t.Rectangle();
                    break;
                case 5:
                    Console.WriteLine("Exercise 5: Christmas Tree");
                    v.ex5();
                    break;
                default:
                    Console.WriteLine("Error, pick a number between 1 and 5...");
                    break;
            }
        }
    }
}