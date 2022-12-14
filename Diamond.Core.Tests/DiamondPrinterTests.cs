namespace Diamond.Core.Tests
{
    public class PrinterTests
    {
        private DiamondPrinter printer;

        [SetUp]
        public void Setup()
        {
            // arrange
            printer = new DiamondPrinter();
        }

        [Test]
        public void GivenA_PrintsA_WithNewLines_AndSpaces()
        {
            // act
            var result = printer.Print('A');

            // assert
            Assert.AreEqual("A\r\n", result);
        }

        [Test]
        public void GivenB_PrintsABB_WithNewLines_AndSpaces_AndCorrectSuffix()
        {
            // act
            var result = printer.Print('B');

            // assert
            Assert.AreEqual(
                " A" + Environment.NewLine +
                "B B" + Environment.NewLine +
                " A" + Environment.NewLine, result);
        }

        [Test]
        public void GivenC_PrintsABBCC_WithNewLines_AndSpaces_AndCorrectSuffix()
        {
            // act
            var result = printer.Print('C');

            // assert
            Assert.AreEqual(
                "  A" + Environment.NewLine +
                " B B" + Environment.NewLine +
                "C   C" + Environment.NewLine +
                " B B" + Environment.NewLine +
                "  A" + Environment.NewLine, result);
        }

        [TestCase('a')]
        [TestCase('1')]
        [TestCase('&')]
        public void GivenNotSuportedChar_ArgumentException(char c)
        {
            // act
            Assert.Throws<ArgumentException>(() => printer.Print(c));
        }
    }
}