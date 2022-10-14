using Diamond.Core;

var letters = Environment.GetCommandLineArgs()[1];

var printer = new DiamondPrinter();
try
{
    Console.Write(printer.Print(letters.First()));
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}