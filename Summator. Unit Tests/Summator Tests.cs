namespace Summator._Unit_Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositivNumbers()
        {
            var nums = new[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativNumbers()
        {
            var nums = new[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = - 100;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}

