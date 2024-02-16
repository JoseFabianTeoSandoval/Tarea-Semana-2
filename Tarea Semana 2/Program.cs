using System;

namespace ConversionDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Conversion de Tipos");

            Console.Write("\nIngrese un número entero: ");
            int numeroEntero = Convert.ToInt32(Console.ReadLine());
            decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
            Console.WriteLine("El número decimal es: " + numeroDecimal);

            Console.Write("\nIngrese un número decimal: ");
            decimal numeroDecimal2 = Convert.ToDecimal(Console.ReadLine());
            float numeroFlotante = Convert.ToSingle(numeroDecimal2);
            Console.WriteLine("El número flotante es: " + numeroFlotante);

            Console.Write("\nIngrese un número flotante: ");
            float numeroFlotante2 = Convert.ToSingle(Console.ReadLine());
            int numeroEntero2 = Convert.ToInt32(numeroFlotante2);
            Console.WriteLine("El número entero es: " + numeroEntero2);

            Console.Write("\nIngrese un carácter: ");
            string caracter = Console.ReadLine();
            int numeroEntero3 = Convert.ToInt32(caracter);
            Console.WriteLine("El numero entero es: " + numeroEntero3);

            Console.Write("\nIngrese un número entero: ");
            int numeroEntero4 = Convert.ToInt32(Console.ReadLine());
            string caracter2 = Convert.ToString(numeroEntero4);
            Console.WriteLine("El caracter es: " + caracter2);

            Console.Write("\nOperacion con tipos de datos");

            Console.WriteLine("\nSuma de dos Enteros");
            Console.Write("Ingrese el primer número entero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, suma);

            Console.WriteLine("\nResta de dos Decimales");
            Console.Write("Ingrese el primer número decimal:");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el segundo número decimal:");
            decimal num4 = Convert.ToDecimal(Console.ReadLine());
            decimal resta = num3 - num4;
            Console.WriteLine("La resta de {0} y {1} es: {2}", num3, num4, resta);

            Console.WriteLine("\nMultiplicacion de dos numeros flotantes");
            Console.Write("Ingrese el primer número flotante:");
            float num5 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el segundo número flotante:");
            float num6 = Convert.ToSingle(Console.ReadLine());
            float multiplicacion = num5 * num6;
            Console.WriteLine("La multiplicación de {0} y {1} es: {2}", num5, num6, multiplicacion);

            Console.WriteLine("\nDivision entre dos enteros");
            Console.Write("Ingrese el numerador (número entero):");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el denominador (número entero distinto de cero):");
            int num8 = Convert.ToInt32(Console.ReadLine());
            double division = (double)num7 / num8;
            Console.WriteLine("La división de {0} entre {1} es: {2}", num7, num8, division);

            Console.WriteLine("\nModulo de dos enteros");
            Console.Write("Ingrese el primer número entero:");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero:");
            int num10 = Convert.ToInt32(Console.ReadLine());
            int modulo = num9 % num10;
            Console.WriteLine("El módulo de {0} y {1} es: {2}", num9, num10, modulo);

            Console.ReadLine();
        }
    }
}

