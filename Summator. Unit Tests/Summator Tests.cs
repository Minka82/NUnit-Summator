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

            var expected = -100;

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
        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
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

        [Test]
        public void AssertionsExample()
        {
            //Assert boolean condition 
            Assert.That(9 == 9);

            Assert.That(9, Is.GreaterThan(6));

            //Reange Assertions
            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("I want to become the best QA", 
                Does.Contain("QA"));

            //regex
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(() => "abc"[45], Throws.InstanceOf<Exception>());

            Assert.That(new int [] {4, 5, 6}, Has.Member(6));

            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));

            Assert.That(percentage, Is.EqualTo(100), "DDS-ToString koeto ne se vryshta");

            
        }

    }
}

