using System;

namespace TP1
{
    public class Exo4
    {
        public void Rectangle()
        {
            Console.WriteLine("Choose the number of rows and columns for your rectangle:  ");
            string[] read = Console.ReadLine().Split(' ');
            int n = int.Parse(read[0]);
            int m = int.Parse(read[1]);
            int i, j;
            int x = 0;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= m; j++)
                {
                    if (i == 1 && j == 1 || i == 1 && j == m || 
                        i == n && j == 1 || i == n && j == m )        
                        Console.Write("0");   
                    else if(i == 1 ||  i == n )
                        Console.Write("-");
                    else if(j == 1 ||  j == m )
                        Console.Write("|");
                    if (i != 1 & j != 1 & i != n & j != m)
                    {
                        if (x == 0)
                        {
                            Console.Write("*");
                            x++;
                        }
                        else if (x == 2)
                        {
                            Console.Write(" ");
                            x = 0;
                        }
                        else
                        {
                            Console.Write(" ");
                            x++;
                        }
                    }

                }
                Console.Write("\n");
            }

        }
    }
}