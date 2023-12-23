// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

while (true)
{

    Console.WriteLine("insert ");

    string old = Console.ReadLine();
    string newBody = Console.ReadLine();

    Console.WriteLine(AggregateNotificationBody(old, newBody));

    Console.WriteLine();
}

Console.ReadKey();
static string AggregateNotificationBody(string oldBody, string newBody)
{
    string result = string.Empty;
    if (oldBody.Contains('['))
        result = UpdateBody(oldBody, newBody);
    else
    {
        var aggregatedOldBody = oldBody.Insert(oldBody.IndexOf('}') + 1, " and [0] others");
        result = UpdateBody(aggregatedOldBody, newBody);
    }
    return result;
}

static string UpdateBody(string oldBody, string newBody)

{
    // Extract the number from the first input
    int numberFromOldNotification = ExtractNumber(oldBody);

    // Extract the name from the second input
    string nameFromNewNotification = ExtractName(newBody);

    // Update the first input string
    string aggregatedNotification = ReplaceNumber(oldBody, numberFromOldNotification);
    aggregatedNotification = ReplaceName(aggregatedNotification, nameFromNewNotification);

    return aggregatedNotification;
}
static int ExtractNumber(string input)
{
    string pattern = @"\[(\d+)\]";
    Match match = Regex.Match(input, pattern);
    return match.Success ? int.Parse(match.Groups[1].Value) : 0;
}
static string ReplaceName(string input, string newName)
{
    int startIndex = input.IndexOf('{') + 1;
    int endIndex = input.IndexOf('}') - 1;

    input = input.Remove(startIndex, endIndex).Insert(startIndex, newName);

    return input;
}
static string ReplaceNumber(string input, int newNumber)
{
    return Regex.Replace(input, @"\[(\d+)\]", $"[{newNumber + 1}]");
}

static string ExtractName(string input)
{
    string pattern = @"\{([\s\w]+)\}";
    Match match = Regex.Match(input, pattern);
    return match.Success ? match.Groups[1].Value.Trim() : string.Empty;
}
