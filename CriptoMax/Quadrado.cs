using System;
using System.Collections.Generic;
using System.Text;

namespace CriptoMax
{
    class Quadrado
    {
        private int lado;

        public Quadrado(int lado)
        {
            this.lado = lado;
        }

        public int Area()
        {
            return this.lado * this.lado;
        }

        public int GetLado()
        {
            return this.lado;
        }
    }
}
