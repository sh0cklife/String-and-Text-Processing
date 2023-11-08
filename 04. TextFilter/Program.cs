string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    //string censor = "".PadLeft(bannedWord.Length, '*');
    string censor = new string('*', bannedWord.Length);

    while (text.Contains(bannedWord))
    {
        text = text.Replace(bannedWord, censor);
    }
}

Console.WriteLine(text);