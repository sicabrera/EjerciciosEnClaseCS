int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] restavector = new int[5];

Console.WriteLine("Ingrese los elementos del primer vector: ");
for(int i=0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());

    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}

Console.WriteLine("\n Ingrese los elementos del segundo vector: ");
for (int i=0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }

}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n La resta de los elementos de ambos vectores es: ");
Console.ResetColor();
for (int i=0; i < restavector.Length; i++)
{
    restavector[i] = vector1[i] - vector2[i];
    Console.WriteLine($"Elementos {i + 1} es {restavector[i]}");
}
