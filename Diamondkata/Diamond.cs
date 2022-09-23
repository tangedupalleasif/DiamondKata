
using Diamondkata;
namespace DiamondKata
{
    public class Diamond : IDiamond
    {
        private const char upperFirstLetter = 'A';
        private const char lowerFirstLetter = 'a';
        private const string lineSeparator = "\n";
        private int position;
        private int ASCIIKey;
        private const char space = '-';
        private int maxCharacters;

        /// <summary>
        /// this method is used to decide the character case to draw the diamond shape
        /// </summary>
        /// <param name="character"></param>
        public string PopulateDiamond(char character)
        {
            if (!IsLetter(character)) { return "Given input is not an alphabet."; }

            if (IsUserInput_Is_Character_A(character))
            {
                return character.ToString();
            }

            position = char.ToUpper(character) - 64;

            maxCharacters = (2 * position) - 1;

            //condtion to check the whether character is uppercase or lowercase base up on that it prints characters diamond
            ASCIIKey = char.IsUpper(character) ? 65 : 97;

            var pyramid = new List<string>();
            for (int level = 0; level < position; level++)
            {
                pyramid.Add(Pyramid(level));
            }
            
            var diamond = FullDiamond(pyramid);
            return diamond;
        }

        /// <summary>
        /// this method is used to draw the Pyramid shape
        /// </summary>
        /// <param name="level"></param>
        public string Pyramid(int level)
        {
            int padding = maxCharacters / 2 - level;
            int middlePadding = level == 0 ? 0 : maxCharacters - ((padding * 2) + 2);

            string paddingCharacters = new(space, padding);
            string middleCharacters = new(space, middlePadding);

            char inputCharacter = (char)(level + ASCIIKey);
            string pyramid = level == 0 ? paddingCharacters + inputCharacter + paddingCharacters : paddingCharacters + inputCharacter + middleCharacters + inputCharacter + paddingCharacters;

            return pyramid;
        }

        /// <summary>
        /// this method is used to draw the full diamond by reversing the first half of diamond shape
        /// </summary>
        /// <param name="firstHalfDiamond"></param>
        /// <returns></returns>
        public string FullDiamond(List<string> pyramid)
        {
            var halfDiamond = string.Join(lineSeparator, pyramid);
            pyramid.Reverse();
            return halfDiamond + lineSeparator + string.Join(lineSeparator, pyramid.Skip(1));
        }

        /// <summary>
        /// this method is used to check whether the input is character or not
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public bool IsLetter(char character)
        {
            return char.IsLetter(character);
        }

        /// <summary>
        /// this method is used to check whether the user input is alphabet 'A' then we can directly return it as output
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public bool IsUserInput_Is_Character_A(char character)
        {
            return character is upperFirstLetter or lowerFirstLetter;
        }


    }
}