using System.IO;

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
            var nums = new int[] { 1000000000, 1000000000 };
            var actual = Summator.Sum(nums);
            var expected = 2000000000;

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

        [Test]  
        
        public void AssertionsExaple()
        {
            //assert boolean condition
            Assert.That(9 == 9);

            Assert.That(9, Is.GreaterThan(6));

            //Range Assertions
            double percetage = 99.95;
            Assert.That(percetage, Is.InRange(80, 100));

            Assert.That("I want to become the best QA", 
                Does.Contain("QA"));

            //regax
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));
            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());

            //Assert.That(() => Summator.Sum(new int[] { 3, 4, 5 }), Throws.TypeOf<IndexOutOfRangeException>());

            //Assert.That(new int [] {4, 5 ,6}), Has.Member (6));

            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));

           
        }

        [Test]  

        public void Test_Summator_AverageTwoPositiveDoubleNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Average(nums);
            var expected = 1.5;

            Assert.AreEqual(expected, actual);  
        }

        [Test]

        public void Test_Summator_AverageTwoPositiveIntNumbers()
        {
            var nums = new int[] { 3, 5 };
            var actual = Summator.Average(nums);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1}, 1)]
        [TestCase(new int[] { -3, -8 }, -11)]
        [TestCase(new int[] { 5, 0 }, 5)]
        [TestCase(new int[] {}, 0)]
        public void Test_Sumator_SumDDT(int[] values, long expected)
        {
            var actual = Summator.Sum(values);

            Assert.That(actual, Is.EqualTo(expected));

        }

    }

}


