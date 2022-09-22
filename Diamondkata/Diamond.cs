
using Diamondkata;
using System.Text;
namespace DiamondKata
{
    public class Diamond : IDiamond
    {
        private const char upperFirstLetter = 'A';
        private const char lowerFirstLetter = 'a';
        private const string lineSeparator = "\n";
        private int position;
        private int ASCIIKey;
        private const string space = "   ";



        /// <summary>
        /// this method is used to decide the character case to draw the diamond shape
        /// </summary>
        /// <param name="character"></param>
        public string PopulateDiamond(char character)
        {
            if (!IsLetter(character)) { return "Given input is not an alphabet : "; }

            if (IsUserInput_Is_Character_A(character))
            {
                return character.ToString();
            }

            position = char.ToUpper(character) - 64;
            
            //condtion to check the whether character is uppercase or lowercase base up on that it prints characters diamond
            ASCIIKey = char.IsUpper(character) ? 65 : 97;

            var diamondtext = new StringBuilder();
            for (int level = 0; level <= (2 * position) - 1; level++)
            {
                diamondtext.Append(DrawDiamond(level));
            }

            return diamondtext.ToString();
        }

        
        /// <summary>
        /// this method is used to check whether the input is character or not
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public bool IsLetter(char character) {
            return char.IsLetter(character);
        }

        /// <summary>
        /// this method is used to check whether the user input is alphabet 'A' then we can directly return it as output
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public bool IsUserInput_Is_Character_A(char character) {
            return character is upperFirstLetter or lowerFirstLetter;
        }

        /// <summary>
        /// this method is used to draw the diamonds shape
        /// </summary>
        /// <param name="level"></param>
        public StringBuilder DrawDiamond(int level)
        {
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
            var diamondline = new StringBuilder();
            diamondline.Append(string.Concat(shape, text, lineSeparator));
            return diamondline;
        }
    }
}