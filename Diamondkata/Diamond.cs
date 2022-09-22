
using System.Text;
namespace DiamondKata
{
    public class Diamond
    {
        private const char upperFirstLetter = 'A';
        private const char lowerFirstLetter = 'a';
        private const string lineSeparator = "\n";
        private static int position;
        private static int ASCIIKey;
        private const string space = "   ";

        private static void Main(string[] args)
        {
            Console.Write("Enter the letter : ");


            char character = Console.ReadLine()[0];
            string diamond = CreateDiamond(character);
            Console.WriteLine(diamond);
            Console.ReadLine();

        }

        /// <summary>
        /// this method is used to decide the character case to draw the diamond shape
        /// </summary>
        /// <param name="character"></param>
        public static string CreateDiamond(char character)
        {
            if (!char.IsLetter(character)) { return "Given input is not an alphabet : "; }

            if (character is upperFirstLetter or lowerFirstLetter) return character.ToString();

            position = char.ToUpper(character) - 64;
            //condtion to check the whether character is uppercase or lowercase base up on that it prints characters diamond
            ASCIIKey = char.IsUpper(character) ? 65 : 97;

            StringBuilder diamondtext = new StringBuilder();

            for (int level = 0; level <= (2 * position) - 1; level++)
            {
                diamondtext.Append(DrawDiamond(level));
            }

            return diamondtext.ToString();
        }


        /// <summary>
        /// this method is used to draw the diamonds shape
        /// </summary>
        /// <param name="level"></param>
        public static StringBuilder DrawDiamond(int level)
        {
            StringBuilder diamondline = new StringBuilder();

            string text;
            int index;

            if (level < position)
            {
                index = position - level - 1;
                text = string.Join(space, new string((char)(level + ASCIIKey), level + 1).ToCharArray());
            }
            else
            {
                index = level - position + 1;
                text = string.Join(space, new string((char)(position - index + ASCIIKey - 1), position - index).ToCharArray());
            }

            const int margin = 2;
            string shape = new string(' ', (2 * index) + margin);
            diamondline.Append(string.Concat(shape, text, lineSeparator));
            return diamondline;
        }
    }
}