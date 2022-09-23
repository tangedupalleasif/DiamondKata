using System.Text;

namespace Diamondkata
{
    public interface IDiamond
    {
        string PopulateDiamond(char character);
        string Pyramid(int level);
        string FullDiamond(List<string> firstHalfDiamond);
        bool IsLetter(char character);
        bool IsUserInput_Is_Character_A(char character);
       

    }
}
