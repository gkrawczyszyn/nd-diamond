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
        public void GivenA_PrintsA()
        {
            // act
            var result = printer.Print('A');

            // assert
            Assert.AreEqual("A", result);
        }

        [Test]
        public void GivenB_PrintsABB()
        {
            // act
            var result = printer.Print('B');

            // assert
            Assert.AreEqual("ABB", result);
        }

        [Test]
        public void GivenC_PrintsABBCC()
        {
            // act
            var result = printer.Print('C');

            // assert
            Assert.AreEqual("ABBCC", result);
        }
    }
}