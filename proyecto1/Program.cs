// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Ingrese un numero para invertirlo: ");
string numero = Console.ReadLine();
int salida;
int contador = 0;

bool resultado = int.TryParse(numero, out salida);

if (resultado)
{
    if (salida > 0)
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
        Console.WriteLine("El valor ingresado debe ser mayor a 0");
    }
} else
{
    Console.WriteLine("El valor ingresado no es un numero");
}