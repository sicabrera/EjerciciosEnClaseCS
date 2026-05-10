int [] vector1 = new int [5];
int [] vector2 = new int [5];
int multiplicacion = 0;
int productoescalar = 0;

Console.WriteLine("Ingrese los datos del primer vector: ");

for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}:");
        vector1[i] = int.Parse(Console.ReadLine());
    }

    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }

}

Console.WriteLine("\nIngrese los datos del segundo vector: ");

for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}:");
        vector2[i] = int.Parse(Console.ReadLine());
    }

    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }

}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nMULTIPLICACION\n");
for (int i=0; i < vector1.Length; i++)
{
    multiplicacion = vector1[i] * vector2[i];
    
    
    Console.WriteLine($"El producto de los elementos en la posicion {i + 1} es: {multiplicacion}");

    productoescalar += multiplicacion;
}
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\nPRODUCTO ESCALAR\n\nEl producto escalar de los vectores es: {productoescalar}");
Console.ResetColor();


