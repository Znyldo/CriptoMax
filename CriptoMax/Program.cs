using System;

namespace CriptoMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string varHuman = "Northon";
            Console.WriteLine("Hello World!");
            Console.WriteLine("jegue" + " " + varHuman);
            int varInt;
            string varTexto = Console.ReadLine();
            if (int.TryParse(varTexto, out varInt))
            {
                Console.WriteLine("Converteu inteiro! TOMA!");
            }
            else
            {
                Console.WriteLine("Não coverteu! Se fuDEU!");
            }
            Console.WriteLine(varTexto);
        }

    }
}