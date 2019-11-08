using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador01
{
    class CNitrogeno:IComponentes
    {
        //Variable de referencia, para comunicarnos con quien decoramos
        private IComponentes decoramosA;

        //Pasamos el objeto que va a ser decorado
        public CNitrogeno(IComponentes pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Sistema de nitrongeno\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 450;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ",Nitrogeno listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno listo");
        }
    }
}
