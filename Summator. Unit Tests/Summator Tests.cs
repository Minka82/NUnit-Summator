namespace Summator._Unit_Tests
{
    public class SummatorTests
    {
        [SetUp]

        public void Setup()
        {
            Console.WriteLine("Test call: " + DateTime.Now.ToString());
        }


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

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }
        [Category("High")]
        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [Category("Smoke")]
        [Category("Low")]
        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Category("High")]
        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 6000000000;

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void Test_Summator_ThreePositiveNumbers()
        {
            //Arrange
            var nums = new int[] {1, 2, 88 };
            var expected = 91;
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(91, actual);

            Assert.That(expected, Is.EqualTo(actual));

            Assert.False(9 == 8);
        
        }
       
    }

}


