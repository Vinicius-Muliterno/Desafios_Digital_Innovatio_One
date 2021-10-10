using System;

class URI
{

    static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int codigo = 0;
        do
        {


            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:

                    break;
                default:
                    continue;
            }
        }

        while (codigo != 4);
        {
            System.Console.WriteLine("MUITO OBRIGADO");

            System.Console.WriteLine("Alcool: " + alcool);

            System.Console.WriteLine("Gasolina: " + gasolina);

            System.Console.WriteLine("Diesel: " + diesel);
        }



    }

}