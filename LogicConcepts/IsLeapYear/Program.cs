do
{
    Console.WriteLine("ANNO BISESTILE");

    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = GetInt("Inserire l'anno: ");

    if (year == currentYear)
    {
        message = "è";
    }
    else if (year > currentYear)
    {
        message = "sarà";
    }
    else
    {
        message = "era";
    }

    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"L'anno inserito: {year}, {message} bisestile.");
            }
            else
            {
                Console.WriteLine($"L'anno inserito: {year}, non {message} bisestile.");
            }
        }
        else
        {
            Console.WriteLine($"L'anno inserito: {year}, {message} bisestile.");
        }
    }
    else
    {
        Console.WriteLine($"L'anno inserito: {year}, non {message} bisestile.");
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
