using System;

namespace CriptoMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int varLado;
            varLado = int.Parse(Console.ReadLine());
            Quadrado Square = new Quadrado(varLado);
            Console.WriteLine("Quadrado de area = "+ Square.Area());
            Console.WriteLine();
        }
        
    }
}