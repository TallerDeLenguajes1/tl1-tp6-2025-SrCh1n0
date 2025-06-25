// See https://aka.ms/new-console-template for more information
int operacion = -1;
bool valido;

do
{
    Console.WriteLine($"Ingrese operación a realizar:");
    Console.WriteLine($"1. Suma \n2. Resta \n3. Multiplicación \n4. División");

    string? opcion = Console.ReadLine();
    valido = int.TryParse(opcion, out operacion);

    if (!valido)
    {
        Console.WriteLine($"Ingrese un número válido.");
        continue;
    }
    int num1, num2;
    string? input1, input2;
    switch (operacion)
    {
        case 1:
            Console.WriteLine("Suma");
            Console.Write("Ingrese el primer número: ");
            input1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            input2 = Console.ReadLine();

            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                int resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
            }
            else
            {
                Console.WriteLine($"Entrada inválida.");
            }
            break;
        case 2:
            Console.WriteLine("Resta");
            Console.Write("Ingrese el primer número: ");
            input1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            input2 = Console.ReadLine();

            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                int resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 0:
            Console.WriteLine("Cerrando consola.");
            break;
    }
} while (operacion != 0);