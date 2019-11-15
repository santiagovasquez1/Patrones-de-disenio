using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{
    internal class Compuesto<T> : IComponente<T>
    {
        private List<IComponente<T>> elementos;

        // Identificador

        public T Nombre { get; set; }

        public Compuesto(T pNombre)
        {
            Nombre = pNombre;
            elementos = new List<IComponente<T>>();
        }

        public void Adicionar(IComponente<T> pElemento)
        {
            elementos.Add(pElemento);
        }

        public IComponente<T> Borrar(T pElemento)
        {
            IComponente<T> elemento = this.Buscar(pElemento);

            if (elemento != null)
            {
                (this as Compuesto<T>).elementos.Remove(elemento);
            }
            return this;
        }

        public IComponente<T> Buscar(T pElemento)
        {
            // Si somos quien se busca nos regresamos
            if (Nombre.Equals(pElemento))
                return this;

            IComponente<T> encontrado = null;

            //Recorremos la lista y buscamos  en nuestros elementos

            foreach (IComponente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }

            return encontrado;
        }

        public string Mostrar(int pProfundidad)
        {
            //Construimos la cadena con una cantida de - igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-', pProfundidad));

            //Adicionamos la info del compuesto
            infoElemento.Append("Compuesto: " + Nombre + " elementos: " + elementos.Count + "\r\n");

            //Adicionamos los elemtnos
            foreach (IComponente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad + 1));

            return infoElemento.ToString();
        }
    }
}