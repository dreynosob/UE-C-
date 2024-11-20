using System;

namespace Calculadora
{
    class Calculadora1
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // Solicitar números
                double num1 = SolicitarNumero("Introduce el primer número (mayor o igual a 0): ");
                double num2 = SolicitarNumero("Introduce el segundo número (mayor o igual a 0): ");

                Console.WriteLine($"Números válidos: Operando 1 = {num1}, Operando 2 = {num2}");

                // Pedir operación
                Console.WriteLine("¿Qué operación necesitas hacer? (suma, resta, dividir, multiplicar, salir): ");
                string? operacion = Console.ReadLine()?.ToLower();

                // Calcular resultado
                if (operacion == "salir")
                {
                    Console.WriteLine("Saliendo del programa.");
                    break;
                }


                double resultado = Operaciones(operacion, num1, num2);
                Console.WriteLine($"El resultado de la operación '{operacion}' es: {resultado}");

            }
        }

        // Función para solicitar un número válido
        static double SolicitarNumero(string mensaje)
        {
            double numero;
            bool isValid;
            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();
                isValid = double.TryParse(entrada, out numero) && numero >= 0;

                if (!isValid)
                {
                    Console.WriteLine("El valor introducido es incorrecto. Por favor, introduce un número válido (mayor o igual a 0).");
                }
            } while (!isValid);
            return numero;
        }

        // Función para realizar operaciones
        static double Operaciones(string operacion, double num1, double num2)
        {
            double result = 0;

            switch (operacion)
            {
                case "suma":
                    result = num1 + num2;
                    break;
                case "resta":
                    result = num1 - num2;
                    break;
                case "dividir":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0.");
                    }
                    break;
                case "multiplicar":
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            return result;
        }
    }
}
