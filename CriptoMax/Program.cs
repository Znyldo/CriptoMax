using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace CriptoMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dicionarioABC = new Dictionary<char, int>();

            dicionarioABC['a'] = 0;
            dicionarioABC['b'] = 1;
            dicionarioABC['c'] = 2;
            dicionarioABC['d'] = 3;
            dicionarioABC['e'] = 4;
            dicionarioABC['f'] = 5;
            dicionarioABC['g'] = 6;
            dicionarioABC['h'] = 7;
            dicionarioABC['i'] = 8;
            dicionarioABC['j'] = 9;
            dicionarioABC['k'] = 10;
            dicionarioABC['l'] = 11;
            dicionarioABC['m'] = 12;
            dicionarioABC['n'] = 13;
            dicionarioABC['o'] = 14;
            dicionarioABC['p'] = 15;
            dicionarioABC['q'] = 16;
            dicionarioABC['r'] = 17;
            dicionarioABC['s'] = 18;
            dicionarioABC['t'] = 19;
            dicionarioABC['u'] = 20;
            dicionarioABC['v'] = 21;
            dicionarioABC['w'] = 22;
            dicionarioABC['x'] = 23;
            dicionarioABC['y'] = 24;
            dicionarioABC['z'] = 25;
            dicionarioABC[' '] = 26;

            Console.WriteLine("digite uma frase curta");
            string frase = Console.ReadLine().ToLower();

            char[] fraseChar = frase.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("O texto convertido é:");
            foreach (char letra in fraseChar)
            {
                Console.Write(Convert.ToString(dicionarioABC[letra], 2).PadLeft(5, '0'));
            }

            
            
        }
    }
}