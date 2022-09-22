namespace Diamondkata.Test
{
    [TestClass]
    public class DiamondTest
    {
        /// <summary>
        /// this test method is used to test the program with letter 'A'
        /// </summary>
        [TestMethod]
        public void Diamond_with_letter_A()
        {
            const string output = "A";
            Assert.AreEqual(output, DiamondKata.Diamond.CreateDiamond('A'));
        }

        /// <summary>
        ///  this test method is used to test the program with letter 'a'
        /// </summary>
        [TestMethod]
        public void Diamond_with_letter_a()
        {
            const string output = "a";
            Assert.AreEqual(output, DiamondKata.Diamond.CreateDiamond('a'));
        }

        /// <summary>
        ///  this test method is used to test the program with letter 'B'
        /// </summary>
        [TestMethod]
        public void Diamond_with_letter_B()
        {
            const string output = "    A\n  B   B\n    A\n      \n";
            Assert.AreEqual(output, DiamondKata.Diamond.CreateDiamond('B'));
        }

        /// <summary>
        ///  this test method is used to test the program with numbers'
        /// </summary>
        [TestMethod]
        public void Diamond_with_number()
        {
            const string output = "Given input is not an alphabet : ";
            Assert.AreEqual(output, DiamondKata.Diamond.CreateDiamond('4'));
        }
    }
}
