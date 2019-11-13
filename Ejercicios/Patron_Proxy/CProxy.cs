using System;

namespace Patron_Proxy
{
    //Haremos uso de anidamiento adentro de la clase
    //Solo sera conocida por Cproxi

    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxiSencillo : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }

                if (pOpcion == 1)
                {
                    cocina.RecetaSecreta();
                }
                if (pOpcion == 2)
                {
                    cocina.Cocinar(5);
                }
            }
        }

        public class ProxiSeguro : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if (password == "abc123")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new CCocina();
                    }

                    if (pOpcion == 1)
                    {
                        cocina.RecetaSecreta();
                    }
                    if (pOpcion == 2)
                    {
                        cocina.Cocinar(5);
                    }
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }

        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }

            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas", n);
            }
        }
    }
}