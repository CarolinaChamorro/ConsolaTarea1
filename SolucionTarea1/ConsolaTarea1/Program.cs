using System;

namespace ConsolaTarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Autor:Carolina Chamorro
            //APP de Consola para calcular numeros
            if (args.Length > 0)
            {
                Console.WriteLine($"\t Usuario: { args[0] }");
                Console.WriteLine($"\t Constraseña: { args[1] }");
                Console.WriteLine($"\t Un gusto saludarte {args[0]}");
            }
            //Declarar variables
            int numero1;
            int numero2;

            //inicio de la consola
            Console.WriteLine($"Bienvenido a la APP de consola");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Por favor ingrese un número y luego presione Enter");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese un número y luego presione Enter");
            numero2 = int.Parse(Console.ReadLine());
            //preguntas en la consola
            Console.WriteLine("¿Qué opción escoges?: ");
            Console.WriteLine("\ta - Suma");
            Console.WriteLine("\tb - Resta");
            Console.WriteLine("\tc - Multiplicación");
            Console.WriteLine("\td - División");
            //Respuestas
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado es: {numero1} + {numero2} = " + (numero1 + numero2));
                    break;
                case "b":
                    if (numero1 < 0 || numero2 < 0)
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} - {numero2} = " + (numero1 + numero2));
                    }
                    else
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} - {numero2} = " + (numero1 - numero2));
                    }

                    break;
                case "c":
                    if (numero1 == 0 || numero2 == 0)
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} * {numero2} = 0");
                    }
                    else
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} * {numero2} = " + (numero1 * numero2));
                    }
                    break;
                case "d":
                    if (numero2 == 0)
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} / {numero2} =  No se puede realizar esta división");
                    }
                    else
                    {
                        Console.WriteLine($"Tu resultado es: {numero1} / {numero2} = " + (numero1 / numero2));
                    }

                    break;
            }

            //Ingreso de Argumentos
            Console.WriteLine("Para finalizar menciona 3 amigos que te gustaría que usen esta app consola");
            Console.WriteLine("Escribe el nombre y luego presiona Enter");
            string amigo1 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre y luego presiona Enter");
            string amigo2 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre y luego presiona Enter");
            string amigo3 = Console.ReadLine();
            Console.WriteLine("---------------------------");
            MiArgumento(amigo1);
            MiArgumento(amigo2);
            MiArgumento(amigo3);

            //fin de la app consola
            Console.WriteLine("Presiona Enter para cerrar la app console");
            Console.ReadKey();
        }
        //salida de argumentos
        static void MiArgumento(string invitados)
        {
            Console.WriteLine(invitados + " ha sido invitado");

        }

    }
}

