using System;

namespace pag146_num1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato;

            Consola.WriteLine(" Ingresa el número de la tabla que desees consultar: ");
            dato = int.Analizar(Consola.ReadLine());

            Consola.Borrar();

            para(int i = 1;i <= "12"; i++);
            {
                Consola.WriteLine(dato + " x " + i + " = " + (i * dato));
            }

            Consola.ReadKey();
        }
    }
}
