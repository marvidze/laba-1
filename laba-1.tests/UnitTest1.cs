namespace laba_1.tests
{
    public class UnitTestForLibrary
    {
        [Fact]
        public void IWantTotestTest_10_110returned()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            int actual = Library.IWantToTest(x, y);
            

            Assert.Equal(expected, actual); 
        }
    }
}