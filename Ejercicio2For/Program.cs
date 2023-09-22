Console.Write("Ingrese la base: ");
int numeroBase = int.Parse(Console.ReadLine());

Console.Write("Ingrese el exponente: ");
int exponente = int.Parse(Console.ReadLine());

int resultado = 1;

for (int i = 0; i < exponente; i++)
{
resultado = resultado * numeroBase;
}

Console.WriteLine("La potencia es: " +resultado+ "");
