using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    [TestFixture]
    internal class AttributesExample
    {
        private int x;
        private int i = 0;

        [Test(Description = "Tests for Math Operations")]
        public void DemoTest()
        {
            Console.WriteLine($"{this}: DemoTest... {x++}");
        }

        [Test, Category("Example")]
        public void BigTest()
        {
            Console.WriteLine($"{this}: BigTest... {x++}");
        }

        [Test, Ignore("Ignoring these tests for now.")]
        public void AlphaTest()
        {
            Console.WriteLine($"{this}: AlphaTest... {x++}");
        }

        [Test, Order(1)]
        public void ZTest()
        {
            Console.WriteLine($"{this}: ZTest... {x++}");
        }

        [Test, Order(2)]
        public void XTest()
        {
            Console.WriteLine($"{this}: XTest... {x++}");
        }

        [Test, Order(2)]
        [Author("Jane Doe", "jane.doe@example.com")]
        [Author("Another Developer", "email@example.com")]
        public void AuthorTest()
        {
            Console.WriteLine($"{this}: AuthorTest... {x++}");
        }

        [Test]
        [Repeat(5)]
        public void RepeatTest()
        {
            Console.WriteLine($"{this}: RepeatTest... ");
        }

        [Test]
        [Retry(3)]
        public void RetryTest()
        {
            Console.WriteLine($"{this}: RetryTest... {++i}");
            if (i == 3) Assert.Pass();
            else Assert.Fail();
        }

        [Test, MaxTime(2000)]
        public void TimeTest()
        {
            Thread.Sleep(2000);

        }

        [Test]
        public void RandomValuesTest([Random(1, 20, 2)]int randomnuber)
        {
            Console.WriteLine($"{this}: randomnuber... {randomnuber}");
        }

        [Test]
        public void RandomAndValuesTest(
       [Values(1, 2, 3)] int numberInt,
       [Random(-1.0, 1.0, 2)] double numberDouble)
        {
            // public Random(<T> min, <T> max, int count);
            Console.WriteLine($"{this}: RandomAndValuesTest... {numberInt} {numberDouble}");
        }

        [Test]
        public void RangeTest([Range(1, 20, 2)] int randomnuber)
        {
            Console.WriteLine($"{this}: Rangenuber... {randomnuber}");
        }

        [Test]
        public void ValuesTest([Values(1, 5, 2)] int randomnuber)
        {
            Console.WriteLine($"{this}: Valuesnuber... {randomnuber}");
        }

        [Test, Combinatorial] // Генерирует все возможные пары, используется по умолчанию, можно не писать
        public void CombinatorialTest(
       [Values(1, 2, 3)] int number,
       [Values("A", "B")] string text)
        {
            Console.WriteLine($"{this}: XTest... {number} {text}");
        }

        [Test, Pairwise]
        public void PairwiseTest(
       [Values("a", "b", "c")] string a,
       [Values("+", "-")] string b,
       [Values("x", "y")] string c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        // Property
        [Test, Property("Severity", "Critical")]
        public void PropertyTest()
        {
            Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
        }

        [Test, SeverityAttrimutes(SeverityLevel.Minor)]
       // [Test, Severity(SeverityLevel.Major)]
        public void AdvancedPropertyTest()
        { Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}"); }
    }
}
