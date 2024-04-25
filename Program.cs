using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Bienvenido al reconocedor de numeros");
            Console.WriteLine("Ingrese el numero a reconocer");
            numero = int.Parse(Console.ReadLine());
            if(numero == 0){
                Console.WriteLine("El numero " + numero + " es igual a 0");
            } else if(numero > 0){
                Console.WriteLine("El numero " + numero + " es positivo");
            } else {
                Console.WriteLine("El numero " + numero + " es negativo");
            }
        }
    }
}
