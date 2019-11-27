using System;
using System.Collections.Generic;

namespace Patron_Flyweight
{
    /// <summary>
    /// Administra los objetos flyweight
    /// </summary>
    internal class CFlyweightFactory
    {
        private List<IFlyweight> Flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {
            //Verificamos si ya existe
            bool existe = false;

            foreach (IFlyweight f in Flyweights)
            {
                if (f.ObtenerNombre() == pNombre)
                    existe = true;
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(pNombre);
                Flyweights.Add(miReceta);
                conteo = Flyweights.Count;
                return conteo - 1;
            }
        }

        /// <summary>
        /// Indexador
        /// </summary>
        ///
        public IFlyweight this[int index]
        {
            get { return Flyweights[index]; }
        }
    }
}