int operacion = -1, num, num1, num2, resultado;
bool valido;
string? input, input1, input2;
double numD;
do
{
    Console.WriteLine("Ingrese operación a realizar:");
    Console.WriteLine("1. Valor Absoluto \n2. Cuadrado \n3. Raiz Cuadrada \n4. Seno \n5. Coseno \n6.Parte Entera \n7. Mayor \n8. Menor \n0. Salir");
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
        case 5:
            Console.WriteLine("Coseno");
            Console.Write("Ingrese un ángulo en grados: ");
            input = Console.ReadLine();

            if (double.TryParse(input, out numD))
            {
                double coseno = Math.Cos(numD);
                Console.WriteLine($"Coseno: {coseno}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 6:
            Console.WriteLine("Parte Entera");
            Console.Write("Ingrese un número: ");
            input = Console.ReadLine();

            if (double.TryParse(input, out numD))
            {
                double parteEntera = double.Round(numD, 0);
                Console.WriteLine($"La parte entera es: {parteEntera}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 7:
            Console.WriteLine("Maximo");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();
            Console.Write("Ingrese otro número: ");
            input2 = Console.ReadLine();

            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                int maximo = int.Max(num1, num2);
                Console.WriteLine($"La parte entera es: {maximo}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 8:
            Console.WriteLine("Minimo");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();
            Console.Write("Ingrese otro número: ");
            input2 = Console.ReadLine();

            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                int minimo = int.Min(num1, num2);
                Console.WriteLine($"La parte entera es: {minimo}");
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