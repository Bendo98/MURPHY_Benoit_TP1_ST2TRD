using System;

namespace TP1
{
    public class Exo3
    {
        public void GomuGomu()
        {
            int x = 0;
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    x = 10 / (int) (Math.Pow(i, 2) - 4);
                    Console.WriteLine("F(" + i + ")= " + x);
                }
                catch (DivideByZeroException e)
                {
                    if (e.Source != null)
                        Console.WriteLine("We can't divide 10 by 0 with "+ i, e.Source);
                }
            }
        }

    }
}