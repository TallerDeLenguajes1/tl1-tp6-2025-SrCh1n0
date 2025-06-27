// See https://aka.ms/new-console-template for more information
int operacion = -1, num1, num2;
bool valido;
string? input1, input2, double1, double2;
double numA, numB;

do
{
    Console.WriteLine($"Ingrese operación a realizar:");
    Console.WriteLine($"1. Suma \n2. Resta \n3. Multiplicación \n4. División \n0. Cerrar");

    string? opcion = Console.ReadLine();
    valido = int.TryParse(opcion, out operacion);

    if (!valido)
    {
        Console.WriteLine($"Ingrese un número válido.");
        continue;
    }
    
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
        case 3:
            Console.WriteLine("Multiplicación");
            Console.Write("Ingrese el primer número: ");
            input1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            input2 = Console.ReadLine();

            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                int resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 4:
            Console.WriteLine("División");
            Console.Write("Ingrese el primer número: ");
            double1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            double2 = Console.ReadLine();

            if (double.TryParse(double1, out numA) && double.TryParse(double2, out numB))
            {
                if (numB != 0)
                {
                    double resultado = numA / numB;
                    double redondeado = Math.Round(resultado, 2);
                    Console.WriteLine($"El resultado de la división es: {redondeado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 5:
            Console.WriteLine("Valor Absoluto");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();

            if (int.TryParse(input1, out num1))
            {
                int resultado = (num1 < 0) ? -num1 : num1;
                Console.WriteLine($"El valor absoluto es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        
        case 6:
            Console.WriteLine("Cuadrado");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();
            if (int.TryParse(input1, out num1))
            {
                int resultado = num1 * num1;
                Console.WriteLine($"El resultado del cuadrado es: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 7:
            Console.WriteLine("Raiz Cuadrada");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();

            if (double.TryParse(input1, out numA)) {
                if (numA >= 0)
                {
                    double raiz = Math.Sqrt(numA);
                    Console.WriteLine($"Raíz cuadrada: {raiz}");
                }
                else
                {
                    Console.WriteLine("Raíz cuadrada: No definida para números negativos.");
                }
            }
            break;
        case 8:
            Console.WriteLine("Seno");
            Console.Write("Ingrese un ángulo en grados: ");
            input1 = Console.ReadLine();

            if (double.TryParse(input1, out numA))
            {
                double seno = Math.Sin(numA);
                Console.WriteLine($"Seno: {seno}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 9:
            Console.WriteLine("Coseno");
            Console.Write("Ingrese un ángulo en grados: ");
            input1 = Console.ReadLine();

            if (double.TryParse(input1, out numA))
            {
                double coseno = Math.Cos(numA);
                Console.WriteLine($"Coseno: {coseno}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 10:
            Console.WriteLine("Parte Entera");
            Console.Write("Ingrese un número: ");
            input1 = Console.ReadLine();

            if (double.TryParse(input1, out numA))
            {
                double parteEntera = double.Round(numA, 0);
                Console.WriteLine($"La parte entera es: {parteEntera}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 11:
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
        case 12:
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