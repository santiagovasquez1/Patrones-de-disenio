using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador01
{
    class CSistemaSonido:IComponentes
    {
        private IComponentes decoramosA;

        //Pasamos el objeto que va a ser decorado
        public CSistemaSonido(IComponentes pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 20;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ",Radio listo";
        }

    }
}
