using System;
using System.Collections.Generic;
using System.Text;

namespace CriptoMax
{
    class Quadrado
    {
        public int lado;

        public Quadrado(int lado)
        {
            this.lado = lado;
        }

        public int Area()
        {
            return this.lado * this.lado;
        }
    }
}
