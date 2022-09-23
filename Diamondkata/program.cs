using DiamondKata;

namespace Diamondkata
{
    internal class program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the letter : ");
            Diamond diamond = new Diamond();
            char userInput = (char)Console.Read();
            
            if (!char.IsLetter(userInput)) { Console.Write("Please enter a character.");return; }
            
            string diamondShape = diamond.PopulateDiamond(userInput);
            Console.WriteLine(diamondShape);
            Console.ReadLine();

        }
    }
}
