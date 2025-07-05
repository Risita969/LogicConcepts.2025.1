do
{
    Console.WriteLine("Inserire tre numeri differenti...");

    var a = GetInt("Inserire il primo numero  : ");
    var b = GetInt("Inserire il secondo numero: ");
    if (a == b)
    {
        Console.WriteLine("Devono essere numeri diversi, inizia di nuovo...");
        continue;
    }

    var c = GetInt("Inserire il terzo numero  : ");
    if (b == c || c == a)
    {
        Console.WriteLine("Devono essere numeri diversi, inizia di nuovo...");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"Il maggiore è {a}, l'intermedio è {b}, il minore è {c}.");
        }
        else
        {
            Console.WriteLine($"Il maggiore è {a}, l'intermedio è {c}, il minore è {b}.");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"Il maggiore è {b}, l'intermedio è {a}, il minore è {c}.");
        }
        else
        {
            Console.WriteLine($"Il maggiore è {b}, l'intermedio è {c}, il minore è {a}.");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"Il maggiore è {c}, l'intermedio è {a}, il minore è {b}.");
        }
        else
        {
            Console.WriteLine($"Il maggiore è {c}, l'intermedio è {b}, il minore è {a}.");
        }
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
