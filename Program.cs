using System;

namespace aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculo infoPlayer = new Calculo();
            System.Console.WriteLine(infoPlayer.Calcular());
            System.Console.WriteLine(infoPlayer.Calcular(140));
            System.Console.WriteLine(infoPlayer.Calcular(50, 100, 200));
            System.Console.WriteLine(infoPlayer.Calcular("john", "Wick"));
        }
    }
}
