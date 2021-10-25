using System;

class Problem
{

    static void Main(string[] args)
    {
        string[] V = Console.ReadLine().Split(" ");
        int n = int.Parse(V[0]);
        int l = int.Parse(V[1]);
        int x;
        if ((3 <= n && n <= 1000000) && (1 <= l && l <= 4000))
        {

            x = n * l;
            Console.WriteLine(x);


        }

    }

}