using System.Linq.Expressions;
using System.Text;

string text = Console.ReadLine();

StringBuilder digits = new();
StringBuilder letters = new();
StringBuilder other = new();

foreach (char symbol in text)
{
    if (char.IsDigit(symbol))
    {
        digits.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        letters.Append(symbol);
    }
    else
    {
        other.Append(symbol);
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(other);
