using EspacioCalculadora;

Calculadora calc = new Calculadora();

string? texto;

do
{
    Console.WriteLine("CALCULADORA");
    Console.WriteLine("Resultado actual: " + calc.Resultado);
    Console.WriteLine("Ingrese una opcion:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("Esc - Salir");

    texto = Console.ReadLine();

    if (texto != "Esc")
    {
        int opcion;

        if (int.TryParse(texto, out opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el numero para sumar: ");
                    string? texto2 = Console.ReadLine();

                    double sumar;
                    if (double.TryParse(texto2, out sumar))
                    {
                        calc.Sumar(sumar);
                    }
                    else
                    {
                        Console.WriteLine("No se reconoce ese termino");
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el numero para restar: ");
                    string? texto3 = Console.ReadLine();

                    double restar;
                    if (double.TryParse(texto3, out restar))
                    {
                        calc.Restar(restar);
                    }
                    else
                    {
                        Console.WriteLine("No se reconoce ese termino");
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el numero para multiplicar: ");
                    string? texto4 = Console.ReadLine();

                    double mult;
                    if (double.TryParse(texto4, out mult))
                    {
                        calc.Multiplicar(mult);
                    }
                    else
                    {
                        Console.WriteLine("No se reconoce ese termino");
                    }
                    break;

                case 4:
                    Console.WriteLine("Ingrese el numero para dividir: ");
                    string? texto5 = Console.ReadLine();

                    double dividir;
                    if (double.TryParse(texto5, out dividir))
                    {
                        calc.Dividir(dividir);
                    }
                    else
                    {
                        Console.WriteLine("No se reconoce ese termino");
                    }
                    break;

                case 5:
                    Console.WriteLine("Limpiando resultado...");
                    calc.Limpiar();
                    break;

                default:
                    Console.WriteLine("El numero no esta entre las opciones.");
                    break;
            }

            Console.WriteLine("Resultado: " + calc.Resultado);
        }
        else
        {
            Console.WriteLine("Lo que ingresaste no es un numero.");
        }

        Console.WriteLine();
    }

} while (texto != "Esc");

Console.WriteLine("Saliendo de la calculadora...");