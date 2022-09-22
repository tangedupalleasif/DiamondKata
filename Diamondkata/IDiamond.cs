using System.Text;

namespace Diamondkata
{
    public interface IDiamond
    {
        string PopulateDiamond(char character);
        bool IsLetter(char character);
        bool IsUserInput_Is_Character_A(char character);
        StringBuilder DrawDiamond(int level);

    }
}
