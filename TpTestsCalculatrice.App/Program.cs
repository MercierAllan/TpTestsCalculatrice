namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        Calculatrice calc = new Calculatrice();

        Console.WriteLine(calc.Addition(2, 3));
        Console.WriteLine(calc.Soustraction(10, 2));
    }
    //Ce test manuel n'est pas suffisant car il ne couvre pas tous les cas possibles
}
