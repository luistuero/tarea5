﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //probando ejercicios en c#
        // Console.WriteLine("vamos a hacer los ejercicios");

        // Tarea 1: Crea una función llamada "Signo";, que reciba un número real, y devuelva un
        //número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero


        /*public static int signo(float n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                if (n > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(signo(numero));
            Console.ReadLine();*/

        //Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como
        //parámetros. El resultado será otro número entero.

        /* int nro1;
         int nro2;
         int resultado;
         int Menor(int numero1, int numero2)
         {
             if (numero1 < numero2)
                 return numero1;
             else
                 return numero2;
         }

         Console.WriteLine("ingrese dos numero");
         nro1 = int.Parse(Console.ReadLine());
         nro2 = int.Parse(Console.ReadLine());
         resultado = Menor(nro1, nro2);
         Console.WriteLine("el menor es {0} ", resultado);
         Console.ReadKey();*/

        //Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano "true" 
        //si es un número primo o "false" en caso contrario.

        /*  int nro;
          bool resultado;

          Boolean EsPrimo(int numero)
          {
              int a = 0;
              for (int i = 1; i < (numero + 1); i++)
              {
                  if (numero % i == 0)
                      a++;
              }

              if (a != 2)
                  return false;
              else
                  return true;
          }

          Console.WriteLine("Ingrese un Numero: ");
          nro = int.Parse(Console.ReadLine());
          resultado = EsPrimo(nro);
          if (resultado)
          {
              Console.WriteLine("Es Primo");
          }
          else
          {
              Console.WriteLine("No es Primo");
          }
          Console.ReadKey();*/
        //Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del 
        //código con su resultado y análisis del mismo.
        /*
        static void Main(string[] args)
        {
            Console.Clear();
            //dibujo de cada linea (bucle externo)
            for (int fila = 1; fila <= 7; fila++)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" "); //espacio en blanco
                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");
                Console.WriteLine(" ");*/

        //Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del 
        //código con su resultado y análisis del mismo.

        //se forma un triangulo

        /*Console.Clear();

        for (int fila = 1; fila <= 7; fila++)
        {
                            for (int espacios = 7 - fila; espacios > 0; espacios--)
                Console.Write(" "); 
            for (int conta = 1; conta < (2 * fila); conta++)
                Console.Write("*");
            Console.WriteLine(" ");
            Console.ReadKey();
        }*/
        /*
   Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
   multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
   su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/

        /*float n;
        float num1, num2, resultado;

        float Calcula(float valor1, float valor2)
        {
            Console.WriteLine("Ingrese la operación a realizar + - / *");
            string operacion = Console.ReadLine();
            switch (operacion)
            {
                case "+":
                    n = valor1 + valor2;
                    Console.WriteLine("El resultado es {0}", n);
                    return n;
                case "-":
                    n = valor1 - valor2;
                    Console.WriteLine("El resultado es {0}", n);
                    return n;
                case "/":
                    n = valor1 / valor2;
                    Console.WriteLine("El resultado es {0}", n);
                    return n;
                case "*":
                    n = valor1 * valor2;
                    Console.WriteLine("El resultado es {0}", n);
                    return n;
                default:
                    return 0;
            }

        }
        Console.WriteLine("Ingrese el Primer Numero");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Segundo Numero");
        num2 = float.Parse(Console.ReadLine());
        resultado = Calcula(num1, num2);
        Console.ReadKey();*/

        /*
    Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que
    devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
    suma sería 6.
    */
        /*    public static int SumaCifras(String n)
            {
                int num = int.Parse(n);
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cifra deseada: ");
            string Cifras = Console.ReadLine();
            Console.WriteLine("La suma es {0}", SumaCifras(Cifras));
            Console.ReadKey();*/

        /* tarea 7: Crea una función "Triángulo" que reciba una letra y un número, y escriba
  un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha 
  indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir */

        public static void Triangulo(String letra, int numero)
        {
            for (int i = numero; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Letra deseada: ");
            string Letra = Console.ReadLine();
            Console.WriteLine("Ingrese el Ancho deseado: ");
            int Ancho = int.Parse(Console.ReadLine());
            Triangulo(Letra, Ancho);
            Console.ReadKey();
            

        }
}
}