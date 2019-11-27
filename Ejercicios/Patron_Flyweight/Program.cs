using System;
using System.Collections.Generic;

namespace Patron_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            #region unshared
            List<int> Americana = new List<int>();
            List<int> Mexicana = new List<int>();
            List<int> Italiana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapidas = new List<int>();

            #endregion

            CFlyweightFactory flyweightFactory = new CFlyweightFactory();

            i = flyweightFactory.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapidas.Add(i);

            i = flyweightFactory.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flyweightFactory.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flyweightFactory.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapidas.Add(i);

            i = flyweightFactory.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flyweightFactory.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flyweightFactory.Adiciona("Pizza");
            Italiana.Add(i);
            Rapidas.Add(i);

            foreach(int n in Rapidas)
            {
                CReceta receta = (CReceta)flyweightFactory[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("------");

            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)flyweightFactory[n];
                //receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("------");

            //Intentamos adicionar existente

            i = flyweightFactory.Adiciona("Pizza");
            Console.WriteLine("------");

            foreach (int n in Ensaladas)
            {
                CReceta receta = (CReceta)flyweightFactory[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("------");

            //Mostrar todo

            for (int m = 0; m < flyweightFactory.Conteo; m++)
            {
                CReceta receta = (CReceta)flyweightFactory[m];
                receta.Mostrar();
            }

        }
    }
}
