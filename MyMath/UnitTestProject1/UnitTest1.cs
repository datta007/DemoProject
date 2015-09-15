using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using NSubstitute;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Setting_return_value()
        {
            var calculator = Substitute.For<ICalculator>();
            calculator.Add(1, 2).Returns(3);
            //Assert.That(calculator.Add(1, 2), Is.EqualTo(3));
            calculator.Add(-100, 100).Returns(0);
        }

        [TestMethod]
        public void Setting_return_value1()
        {
            var calculator = Substitute.For<ICalculator>();
            //calculator.Add(1, 2).Returns(3);
            ////Assert.That(calculator.Add(1, 2), Is.EqualTo(3));
            //calculator.Add(-100, 100).Returns(0);
            //calculator.Mode.Returns("DEC");
            //Assert.AreEqual(calculator.Mode, "DEC");
            //Assert.That(calculator.Mode, Is.EqualTo("DEC"));

            calculator.Add(1, 2);
            calculator.Received().Add(1, 2);
            calculator.DidNotReceive().Add(5, 7);



        }
    }
}
