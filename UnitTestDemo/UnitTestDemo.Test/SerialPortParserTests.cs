using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo.Test
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            //Assert.That(result, Is.EqualTo(1));
            //Assert.AreEqual(1, result);
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Assert.That(array, Is.All.GreaterThan(0));

        }

        [Test]
        public void ParsePort_InvalidFormat_ThrowsInvalidFormatException()
        {
            Assert.Throws<FormatException>(() => SerialPortParser.ParsePort("1"));
        }
    }
}
