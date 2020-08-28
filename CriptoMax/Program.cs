using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using CriptoMax.Objetos;

namespace CriptoMax
{
    class Program
    {
        static void Main(string[] args)
        {

            Criptografia encriptador = new Criptografia();
            
            Console.WriteLine("digite uma frase curta");
            string frase = Console.ReadLine().ToLower();

            string fraseCriptografada = "";

            char[] fraseChar = frase.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("O texto convertido é:");
            foreach (char letra in fraseChar)
            {
                fraseCriptografada += encriptador.Criptografar(letra);
            }

            Console.WriteLine(fraseCriptografada);
            Console.WriteLine(fraseCriptografada.Length);
            Console.WriteLine();
            Console.WriteLine("A frase descriptografada é:");
            Console.WriteLine(encriptador.Descriptografar(fraseCriptografada));
            
        }
    }
}