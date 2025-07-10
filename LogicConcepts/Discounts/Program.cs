var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var desks = GetInt("Numero di scrivanie..: ");
    var valueToPay = CalculateValue(desks);   
    Console.WriteLine($"Il prezzo da pagare è: {valueToPay:C2}");

        do
        {
            answer = GetValidOptions("Desidera continuare [S]i, [N]o?: ", options);
        } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("GAME OVER");

decimal CalculateValue(int desks)
{
    float discount;

    if (desks < 5)
    {
        discount = 0.1f;
    }
    else if (desks >= 5 && desks < 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }

    return desks * 650000M * (decimal)(1 - discount);
}

int GetInt(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    if (int.TryParse(numberString, out int numberInt))
    {
        return numberInt;
    }
    return 0;
}

string? GetValidOptions(string message, List<string> options)
{
    Console.Write(message);
    var answer = Console.ReadLine();
    if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
    {
        return answer;
    }
    return null;
}
