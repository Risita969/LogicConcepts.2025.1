var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    do
    {
        var name = GetString("Inserire nome.........................: ");
        var workHours = GetFloat("Inserire numero di ore lavorate.......: ");
        var hourValue = GetDecimal("Inserire costo orario.................: ");
        var minimumSalary = GetDecimal("Inserire valore salario minimo mensile: ");

        var salary = (decimal)workHours * hourValue;
        if (salary < minimumSalary)
        {
            Console.WriteLine($"Nome..................................: {name}");
            Console.WriteLine($"Salario...............................: {minimumSalary:C2}");
        }
        else
        {
            Console.WriteLine($"Nome..................................: {name}");
            Console.WriteLine($"Salario...............................: {salary:C2}");
        }

            answer = GetValidOptions("Desidera continuare [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("GAME OVER");


static float GetFloat(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    if (float.TryParse(numberString, out float numberFloat))
    {
        return numberFloat;
    }
    return 0;
}

static decimal GetDecimal(string message)
{
    Console.Write(message);
    var numberString = Console.ReadLine();
    if (decimal.TryParse(numberString, out decimal numberDecimal))
    {
        return numberDecimal;
    }
    return 0;
}

static string? GetString(string message)
{
    Console.Write(message);
    var text = Console.ReadLine();
    return text;
}

static string? GetValidOptions(string message, List<string> options)
{
    Console.Write(message);
    var answer = Console.ReadLine();
    if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
    {
        return answer;
    }
    return null;
}