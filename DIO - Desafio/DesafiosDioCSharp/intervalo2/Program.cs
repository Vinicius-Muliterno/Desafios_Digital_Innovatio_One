using System;

class Intervalo2
{

    public static void Main()
    {

        int n, x;

        int Interval = 0;
        int outInterval = 0;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());

            if ((x >= 10 && x <= 20))
            {
                Interval++;
            }
            else
            {
                outInterval++;
            }

        }
        Console.WriteLine("{0} in", Interval);
        Console.WriteLine("{0} out", outInterval);


        Console.ReadLine();
    }

}
