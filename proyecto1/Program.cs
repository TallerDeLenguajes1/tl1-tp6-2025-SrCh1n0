// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);

string numero = Console.ReadLine();
int salida;
int contador = 0;

bool resultado = int.TryParse(numero, out salida);

if (resultado && salida > 0)
{
    contador = numero.Length;
    var aux = new StringBuilder();
    var inverso = new StringBuilder();
    aux.Append(salida.ToString());
    inverso.Append(salida.ToString());
    for (int i = 0; i < contador; i++)
    {
        char caracter = aux[contador - i - 1];
        inverso[i] = caracter;
    }
    Console.WriteLine("Numero invertido: " + inverso);
} else
{
    Console.WriteLine("El valor ingresado no es un numero");
}