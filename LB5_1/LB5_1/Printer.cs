using System;

class Printer
{
    protected ConsoleColor color = Console.ForegroundColor;

    public void Print(string value)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
    }
}

class Company : Printer
{
    public Company()
    {
        color = ConsoleColor.Red;
    }
}

class Position : Printer
{
    public Position()
    {
        color = ConsoleColor.Green;
    }
}

class NamePerson : Printer
{
    public NamePerson()
    {
        color = ConsoleColor.Blue;
    }
}
