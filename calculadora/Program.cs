// See https://aka.ms/new-console-template for more information
int operacion = -1;
bool valido;

do
{
    Console.WriteLine("Ingrese operación a realizar:");
    Console.WriteLine("1. Suma" + $"2. Resta" + $"3. Multiplicación" + $"4. División");

    string? opcion = Console.ReadLine();
    valido = int.TryParse(opcion, out operacion);

    if (!valido)
    {
        Console.WriteLine("Ingrese un número válido.");
        continue;
    }
    
    switch (operacion)
    {
        case 1:
            Console.WriteLine("Suma");
            Console.Write("Ingrese el primer número: ");
            string? input1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            string? input2 = Console.ReadLine();

            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            {
                int resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;

        default:
            break;
    }
} while (true);