using System;

class minhaClasse
{

    public static void Main()
    {
        int n;

        Console.WriteLine("Digite um número emtre 1 é 1000: ");
        n = int.Parse(Console.ReadLine());
        if (1 <= n && n < 1000)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        else
        {
            Console.WriteLine("Número inválido");
        }
        Console.ReadLine();

    }
}