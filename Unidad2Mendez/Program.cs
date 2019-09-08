using System;

namespace Unidad2Mendez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio2();
            // Ejercicio3();
            Ejercicio4();

        }
        public static void Ejercicio2()
        {
            int numero;
            string valor = " ";
            Console.WriteLine("Dame un numero");
            valor = Console.ReadLine();

            do
            {

                if (valor.Contains( "0") || valor.Contains("1") || valor.Contains("2") || valor.Contains("3") || valor.Contains("4") || valor.Contains("5") || valor.Contains("6") || valor.Contains("7") || valor.Contains("8") || valor.Contains("9"))
                {
                    numero = Convert.ToInt32(valor);
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("El número es par");

                        valor = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("El número es impar");
                        valor = Console.ReadLine();
                    }
                }



                else
                {
                    Console.WriteLine("Error, número invalido");
                      Console.WriteLine( "Escriba nuevamente un número");
                    valor = Console.ReadLine();
                }



            }

            while (valor == " " || valor != "");






        }


        public static void Ejercicio3()
        {
            string dia = " ";
            string valor = "";
            int opcion = 0;
            Console.WriteLine("Dame un Número del 1 al 7");

            valor = Console.ReadLine();
            do
            {

                if (valor.Contains("0") || valor.Contains("1") || valor.Contains("2") || valor.Contains("3") || valor.Contains("4") || valor.Contains("5") || valor.Contains("6") || valor.Contains("7") || valor.Contains("8") || valor.Contains("9"))
                {
                    opcion = Convert.ToInt32(valor);
                    switch (opcion)
                    {
                        case 1:
                            dia = "Lunes";
                            break;
                        case 2:
                            dia = "Martes";
                            break;
                        case 3:
                            dia = "Miercoles";
                            break;
                        case 4:
                            dia = "Jueves";
                            break;
                        case 5:
                            dia = "Viernes";
                            break;
                        case 6:
                            dia = "Sábado";
                            break;
                        case 7:
                            dia = "Domingo";
                            break;
                        default:
                            Console.WriteLine("Opción no valida");
                            break;

                    }
                    Console.WriteLine("El día que eligió es {0}", dia);
                    valor = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error, número invalido");
                    Console.WriteLine("Escriba nuevamente un número");
                    valor = Console.ReadLine();
                }
            }

            while (valor == " " || valor != "");

        }
        public static void Ejercicio4()
        {

            int numero;
            int mult = 0;
            string valor = " ";
            Console.WriteLine("Dame un número del 1 al 10");
            valor = Console.ReadLine();
            do
            {

                if (valor.Contains("0") || valor.Contains("1") || valor.Contains("2") || valor.Contains("3") || valor.Contains("4") || valor.Contains("5") || valor.Contains("6") || valor.Contains("7") || valor.Contains("8") || valor.Contains("9"))
                {
                    numero = Convert.ToInt32(valor);

                    for (int i = 0; i <= 10; i++)
                    {

                        mult = numero * i;

                        Console.WriteLine(+numero + " X " + i + " = " + mult);
                    }
                    valor = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error, número invalido");
                    Console.WriteLine("Escriba nuevamente un número");
                    valor = Console.ReadLine();
                }
            }
            while (valor == " " || valor != "");





        }
}    }
