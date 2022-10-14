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
    }
}