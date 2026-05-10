int [] vector = new int [5];
double sumavector = 0;
double magnitud = 0;


Console.WriteLine("Ingrese los elementos del vector: ");
for (int i=0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        i--;    
        Console.ResetColor();

    }

}

for (int i=0; i < vector.Length; i++)
{
    sumavector += vector[i] * vector[i];

}

magnitud = Math.Sqrt(sumavector);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"La magnitud del vector es: {magnitud}");
Console.WriteLine($"La magnitud del vector ≈ {magnitud:F2}");
Console.ResetColor();