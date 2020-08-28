using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CriptoMax.Objetos
{
    class Criptografia
    {
        Dictionary<char, int> dicionario;
        int bitao = 5;
        public Criptografia()
        {
            dicionario = new Dictionary<char, int>();
            PreencherDicionario();
        }
        public string Descriptografar(string fraseBinaria)
        {
            string[] vetorString = new string[fraseBinaria.Length/bitao];

            string fraseDescriptografada = "";

            for (int i = 0; i < fraseBinaria.Length/bitao; i++)
            {
                vetorString[i] = fraseBinaria.Substring(i * bitao, bitao);
                
                int numeroDecimal = Convert.ToInt32(vetorString[i], 2);
                foreach (KeyValuePair<char,int> significado in dicionario)
                {
                    if (significado.Value == numeroDecimal)
                    {
                        fraseDescriptografada += significado.Key;
                    }
                }
            }
            return fraseDescriptografada;
        }
        public string Criptografar(char caracter)
        {
           
            return Convert.ToString(dicionario[caracter], 2).PadLeft(bitao, '0');
        }

        private void PreencherDicionario()
        {
            dicionario['a'] = 0;
            dicionario['b'] = 1;
            dicionario['c'] = 2;
            dicionario['d'] = 3;
            dicionario['e'] = 4;
            dicionario['f'] = 5;
            dicionario['g'] = 6;
            dicionario['h'] = 7;
            dicionario['i'] = 8;
            dicionario['j'] = 9;
            dicionario['k'] = 10;
            dicionario['l'] = 11;
            dicionario['m'] = 12;
            dicionario['n'] = 13;
            dicionario['o'] = 14;
            dicionario['p'] = 15;
            dicionario['q'] = 16;
            dicionario['r'] = 17;
            dicionario['s'] = 18;
            dicionario['t'] = 19;
            dicionario['u'] = 20;
            dicionario['v'] = 21;
            dicionario['w'] = 22;
            dicionario['x'] = 23;
            dicionario['y'] = 24;
            dicionario['z'] = 25;
            dicionario[' '] = 26;
        }
    }
}
