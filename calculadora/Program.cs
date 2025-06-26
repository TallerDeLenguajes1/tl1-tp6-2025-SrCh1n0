int operacion = -1, num, resultado ;
bool valido;
string? input;
double numD;
do
{
    Console.WriteLine("Ingrese operación a realizar:");
    Console.WriteLine("1. Valor Absoluto \n2. Cuadrado \n3. Raiz Cuadrada \n4. Seno \n5. Coseno \n6.Parte Entera \n0. Salir");
    string? opcion = Console.ReadLine();
    valido = int.TryParse(opcion, out operacion);
    
    if (!valido)
    {
        Console.WriteLine("Ingrese un número válido.");
    }

    switch (operacion)
    {
        case 1:
            Console.WriteLine("Valor Absoluto");
            Console.Write("Ingrese un número: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                resultado = (num < 0) ? -num : num;
                Console.WriteLine($"El valor absoluto es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        
        case 2:
            Console.WriteLine("Cuadrado");
            Console.Write("Ingrese un número: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out num))
            {
                resultado = num * num;
                Console.WriteLine($"El resultado del cuadrado es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 3:
            Console.WriteLine("Raiz Cuadrada");
            Console.Write("Ingrese un número: ");
            input = Console.ReadLine();

            if (double.TryParse(input, out numD)) {
                if (numD >= 0)
                {
                    double raiz = Math.Sqrt(numD);
                    Console.WriteLine($"Raíz cuadrada: {raiz}");
                }
                else
                {
                    Console.WriteLine("Raíz cuadrada: No definida para números negativos.");
                }
            }
            break;
        case 4:
            Console.WriteLine("Seno");
            Console.Write("Ingrese un ángulo en grados: ");
            input = Console.ReadLine();

            if (double.TryParse(input, out numD))
            {
                double seno = Math.Sin(numD);
                Console.WriteLine($"Seno: {seno}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 0:
            Console.WriteLine("Cerrando calculadora.");
            break;
    }
} while (operacion != 0);