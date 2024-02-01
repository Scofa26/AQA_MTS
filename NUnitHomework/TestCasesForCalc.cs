using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NUnitHomework
{
    [TestFixture, Author("Scofa")]
    internal class TestCasesForCalc
    {
        [TestCase(10, 5, 2),
         Category("Div int"),
         Category("positive"),
         Order(1),
         Repeat(3),
         Severity(SeverityLevel.Critical)]
        public void Test1(int x, int y, int result)
        {
            Assert.That(Calc.Div(x, y), Is.EqualTo(result));
        }

        [TestCase(-2.4, 2.0, ExpectedResult = -1.2),
         Category("Div double"),
         Category("positive"),
         Severity(SeverityLevel.Critical),
         Order(2),
         Retry(2)]
        public double Test2(double x, double y)
        {
            return Calc.Div(x, y);
        }

        [Test,
            Category("Div double"),
            Category("negative"),
            Severity(SeverityLevel.Critical)
           ]
        public void Test3()
        {
            Assert.That(Double.IsInfinity(Calc.Div(10.0, 0.0)));
        }

        [Test,
         Category("Div int"),
         Category("negative"),
         Severity(SeverityLevel.Critical)
        ]

        public void Test4()
        {
            var rez = Assert.Throws<DivideByZeroException>(() => Calc.Div(10, 0));
            StringAssert.Contains("Attempted to divide by zero.", rez.Message.ToString());
        }

        [Test,
         Ignore("Ignore this test "),
         Category("Div double"),
         Category("negative"),
         Severity(SeverityLevel.Low)]
        public void Test5(
           [Values(6)] int x,
           [Values(3)] int y,
           [Values(2)] int result)
        {
            Assert.That(Calc.Div(x, y), Is.EqualTo(result));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases)),
         Category("Div int"),
         Category("positive"),
         Severity(SeverityLevel.Low)]
        public void Test6(int x, int y, int result)
        {
            Assert.That(x / y, Is.EqualTo(result));
        }


        [Test,
         Combinatorial,
         Category("Div int"),
         Category("positive"),
         Severity(SeverityLevel.Low)]
        public void Test7(
           [Values(1, 1)] int x,
           [Values(1, 1)] int y,
           [Values(1, 1)] int result)
        {
            Assert.That(Calc.Div(x, y), Is.EqualTo(result));
        }

        [Test, 
         Pairwise,
         Category("Div double"),
         Category("positive"),
         Severity(SeverityLevel.Low)]
        public void PairwiseTest(
           [Values(6.0, 12.2)] double x,
           [Values(6.0, 12.2)] double y,
           [Values(1.0, 1.0)] double result)
        {
            Assert.That(Calc.Div(x, y), Is.EqualTo(result));
        }
    }
}

