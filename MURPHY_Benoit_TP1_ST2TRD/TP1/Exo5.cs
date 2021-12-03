using System;

namespace TP1
{
    public class Exo5
    {
        public void ex5()
        {
            Console.WriteLine("Choose between: \n 1. Natural tree \n 2. Decorated tree ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    NaturalTree();
                    break;
                case 2:
                    DecoratedTree();
                    break;
                default:
                    Console.WriteLine("Error, pick a number between 1 and 2");
                    break;
            }

        }

        public void NaturalTree()
        {
            int n = 6;
            int x = 1;
            
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    
                    if (j!=1)
                    {
                        Console.Write(" ");
                    }

                }

                for (int j = 1; j <= x; j++)
                {
                    if (j!=x)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
                x = x + 2;
            }

            for (int i = 1; i <=n ; i++)
            {
                if (i==n-1)
                {
                    Console.Write("| |");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
         public void DecoratedTree()
        {
            int n = 6;
            int x = 1;
            Random random = new Random();
            int y = random.Next(1, 101);
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    
                    if (j!=1)
                    {
                        Console.Write(" ");
                    }

                }

                for (int j = 1; j <= x; j++)
                {
                    if (j!=x)
                    {
                        y = random.Next(1, 101);

                        if (y<=10)
                        {
                            Console.Write("o");
                        }
                        else if (y<=40 )
                        {
                            Console.Write("i");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        
                    }
                    else
                    {
                        if (y<=10)
                        {
                            Console.WriteLine("o");
                        }
                        else if (y<=40 )
                        {
                            Console.WriteLine("i");
                        }
                        else
                        {
                            Console.WriteLine("*");
                        }
                    }
                }
                x = x + 2;
            }

            for (int i = 1; i <=n ; i++)
            {
                if (i==n-1)
                {
                    Console.Write("| |");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
        
    }
}