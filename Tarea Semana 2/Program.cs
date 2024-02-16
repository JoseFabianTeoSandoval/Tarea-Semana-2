using System;

namespace ConversionDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numeroEntero = Convert.ToInt32(Console.ReadLine());
            decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
            Console.WriteLine("El número decimal es: " + numeroDecimal);

            Console.Write("Ingrese un número decimal: ");
            decimal numeroDecimal2 = Convert.ToDecimal(Console.ReadLine());
            float numeroFlotante = Convert.ToSingle(numeroDecimal2);
            Console.WriteLine("El número flotante es: " + numeroFlotante);

            Console.Write("Ingrese un número flotante: ");
            float numeroFlotante2 = Convert.ToSingle(Console.ReadLine());
            int numeroEntero2 = Convert.ToInt32(numeroFlotante2);
            Console.WriteLine("El número entero es: " + numeroEntero2);

            Console.Write("Ingrese un carácter: ");
            string caracter = Console.ReadLine();
            int numeroEntero3 = Convert.ToInt32(caracter);
            Console.WriteLine("El numero entero es: " + numeroEntero3);

            Console.Write("Ingrese un número entero: ");
            int numeroEntero4 = Convert.ToInt32(Console.ReadLine());
            string caracter2 = Convert.ToString(numeroEntero4);
            Console.WriteLine("El caracter es: " + caracter2);

            Console.ReadLine();
        }
    }
}

