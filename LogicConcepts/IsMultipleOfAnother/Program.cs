do
{
    Console.WriteLine("Inserire due numeri...");

    var a = GetInt("Inserire il primo numero  : ");
    var b = GetInt("Inserire il secondo numero: ");
    
    if (a % b == 0)
    {
        Console.WriteLine($"Il numero {a} è multiplo del numero {b}.");
    }
    else
    {
        Console.WriteLine($"Il numero {a} non è multiplo del numero {b}.");
    }
} while (true);

static int GetInt(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        return numberInt;
    }
    return 0;
}

