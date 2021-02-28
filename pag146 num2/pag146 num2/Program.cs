using System;

namespace pag146_num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Exponente;

            Consola.WriteLine("Ingresa la base de la operacion:");
            Base = Convertir.ToInt32(Console.ReadLine());

            Consola.Borrar();

            Consola.WriteLine("Ahora ingrese el exponente a elevarlo.");
            Exponente = Convertir.ToInt32(Console.ReadLine());

            Consola.Borrar();

            Consola.WriteLine( $ " Base: { Base }, Exponente { Exponente }. -> { Base } ^ { Exponente } \ n Resultado: { Math . Pow ( Base , Exponente )} ");

            Consola.ReadKey();
        }
    }
}
