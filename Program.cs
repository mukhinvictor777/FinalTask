void PrintStringArray(string[] userText)
{
    Console.Write("[");
    Console.Write($"'{userText[0]}'");
    for (int i = 1; i < userText.Length; i++)
    {
        Console.Write($",'{userText[i]}'");
    }
    Console.Write("]");
}

string[] FindShortStringFromUserText (string[] userText)
{
    int countOfShortSting = 1;
    string[] shortString = new string[countOfShortSting];
    for (int i = 0; i < userText.Length; i++)
    {
        if (userText[i].Length <=3)
        {
           shortString[countOfShortSting-1] = userText[i];
           Array.Resize(ref shortString, shortString.Length+1);
           countOfShortSting++;
        }
    }
    if (countOfShortSting == 1)
    {
        return shortString;
    }
    else
    {
        Array.Resize(ref shortString, shortString.Length-1);
        return shortString;
    }
}

string[] userTextA = new string [4] {"hello", "2", "world", ":-)"};
string[] userTextB = new string [4] {"1234", "1567", "-2", "computer science"};
string[] userTextC = new string [3] {"Russia", "Denmark", "Kazan"};

Console.WriteLine();
PrintStringArray(userTextA);
Console.Write(" -> ");
string[] shortA = FindShortStringFromUserText(userTextA);
PrintStringArray(shortA);
Console.WriteLine();
PrintStringArray(userTextB);
Console.Write(" -> ");
string[] shortB = FindShortStringFromUserText(userTextB);
PrintStringArray(shortB);
Console.WriteLine();
PrintStringArray(userTextC);
Console.Write(" -> ");
string[] shortC = FindShortStringFromUserText(userTextC);
PrintStringArray(shortC);
Console.WriteLine();
Console.WriteLine();