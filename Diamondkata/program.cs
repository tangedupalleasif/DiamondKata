using DiamondKata;

namespace Diamondkata
{
    internal class program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the letter : ");
            IDiamond diamond = new Diamond();

            char character = Console.ReadLine()[0];
            string diamondShape = diamond.PopulateDiamond(character);
            Console.WriteLine(diamondShape);
            Console.ReadLine();

        }
    }
}
