using System;

namespace TP1
{
    public class Exo1
    {
        public void ex1()
        {
            Console.WriteLine("Choose between: \n 1. Simple multiplication table" +
                              "\n 2. Odd result multiplication table " +
                              "\n 3. Multiplication of N ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Inshallah(1);
                    break;
                case 2:
                    Inshallah(2);
                    break;
                case 3:
                    Inshallah2();
                    break;
                default:
                    Console.WriteLine("Error, pick a number between 1 and 3");
                    break;
            }

        }
        public void Inshallah(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Table de " + i + ":");
                
                for (int j = 1; j <= 10; j++)
                {
                    if (a == 1)
                    {
                        Console.WriteLine(i + "*" + j + " = " + i*j);
                    }
                    else if (a == 2)
                    {
                        if (i*j % 2 == 1)
                            Console.WriteLine(i + "*" + j + " = " + i*j);
                    }
                }
                Console.Write("\n");
                if (a == 2)
                {
                    i++;
                }
            }
        }
        public void Inshallah2()
        {
            Console.WriteLine("Please write a number and press enter : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table de " + b + ":");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(b + "*" + j + " = " + b * j);
            }
        }
    }
}