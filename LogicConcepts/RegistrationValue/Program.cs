var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var credits = GetInt("Numero di crediti...........: ");
    var creditValue = GetDecimal("Valore del credito..........: ");
    var stratum = GetInt("Estratto dello studente.....: ");

    var registrationValue = CalculateRegistrationValue(credits, creditValue, stratum);
    var subsidy = CalculateSubsidy(stratum);

    Console.WriteLine($"Costo della matricola.......: {registrationValue,20:C2}");
    Console.WriteLine($"Valore del sussidio.........: {subsidy,20:C2}");

    do
    {
        answer = GetValidOptions("Desidera continuare [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("GAME OVER");

decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1)
    {
        return 200000m;
    }

    if (stratum == 2)
    {
        return 100000m;
    }

    return 0;
}

decimal CalculateRegistrationValue(int credits, decimal creditValue, int stratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * creditValue;
    }
    else
    {
        value = 20 * creditValue + (credits - 20) * creditValue * 2;
    }

    if (stratum == 1)
    {
        return value * 0.2m;
    }

    if (stratum == 2)
    {
        return value * 0.5m;
    }

    if (stratum == 3)
    {
        return value * 0.7m;
    }

    return value;
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

decimal GetDecimal(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    if (decimal.TryParse(numberString, out decimal numberDecimal))
    {
        return numberDecimal;
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
