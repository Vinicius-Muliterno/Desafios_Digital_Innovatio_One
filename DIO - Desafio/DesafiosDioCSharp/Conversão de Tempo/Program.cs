using System;

class MinhaClasse
{
    static void Main(string[] args)
    {
        var TempoDoEvento = int.Parse(Console.ReadLine());
        var horas = (TempoDoEvento / 3600);
        var minutos = (TempoDoEvento % 3600) / 60;
        var segundos = (TempoDoEvento % 3600) % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}
