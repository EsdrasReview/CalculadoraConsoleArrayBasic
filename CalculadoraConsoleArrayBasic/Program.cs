using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsoleArrayBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Definiendo los Operadores
            string[] Operadores = new string[] { "+", "-", "/", "*" };


            //Capturando el primer digito ingresado
            Console.WriteLine("Ingrese el primer digito:");
            string digito1 = Console.ReadLine();

            int numero1 = 0;
            if (!int.TryParse(digito1, out numero1))
            {
                Console.WriteLine("El valor ingresado " + "("  + digito1 + ")" + " no es valido.");
                Console.ReadLine();
                return;
            }

            //Capturando el operador seleccionado por el usuario
            Console.WriteLine("Escriba el operador:");
            string op = Console.ReadLine();

            if (!Operadores.Contains(op))
            {
                string resultado = "Operador no soportado solo: ";

                foreach (string opt in Operadores)
                {
                    resultado += " " + opt;
                }

                Console.WriteLine(resultado);
                Console.ReadLine();
                return;
            }

            //Capturando el segndo digito ingresado
            Console.WriteLine("Ingrese el segundo digito:");
            string digito2 = Console.ReadLine();

            int numero2 = 0;
            if (!int.TryParse(digito2, out numero2))
            {
                Console.WriteLine("El valor ingresado " + "(" + digito2 + ")" + " no es valido.");
                Console.ReadLine();
                return;
            }

            //Realizando la operacion
            switch (op){

                case "+":
                    Console.WriteLine("El resultado de la suma es: " + (numero1 + numero2));
                    break;

                case "-":
                    Console.WriteLine("El resultado de la resta es: " + (numero1 - numero2));
                    break;

                case "/":
                    Console.WriteLine("El resultado de la divicion es: " + (numero1 / numero2));
                    break;

                case "*":
                    Console.WriteLine("El resultado de la multiplicacion es: " + (numero1 * numero2));
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadLine();
        }
    }
}
