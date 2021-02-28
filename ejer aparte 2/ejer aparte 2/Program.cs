using System;

namespace ejer_aparte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero;
            factorial largo=1;
            Consola.Escribir(" Ingrese un número:");
            numero=int.Analizar(Consola.ReadLine());
            Consola.WriteLine("\ n"+numero +"!=1");
            para(i=2;i<=numero;i++);
            {
                factorial*=i;
                Consola.WriteLine("\u00D7"+ i);
            }
            Consola.WriteLine("="+factorial);
            Consola.WriteLine("Presione cualquier tecla para terminar...");
            Consola.ReadKey();
        }
    }
}
