using System;

namespace Decorador01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creamos el componente central con tipo IComponente
            // Para permitir la decoracion

            IComponentes miauto = new CAuto("2018", "4 puertas", 2000);
            Console.WriteLine(miauto);

            // Si necesitamos usar un metodo propio de CAuto
            // Se hace un type cast

            ((CAuto)miauto).puertas(true);
            Console.WriteLine("-----");

            //Decoracion del auto con un sistema de sonido
            miauto = new CSistemaSonido(miauto);
            miauto = new CNitrogeno(miauto);
            miauto = new Csuspension(miauto);

            Console.WriteLine(miauto.Costo());
            Console.WriteLine(miauto.Funciona());
            Console.WriteLine(miauto);

            //Ojo, no podemos usar metodos especificos una  vez que decoramos sobre esta, ya que cambio de clase, debido al poliformismo
            //((CNitrogeno)miauto).UsaN();

            Console.WriteLine("------");
            //Console.Read();
        }
    }
}
