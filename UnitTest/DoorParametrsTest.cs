

using System;
using KompasLib;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class DoorParametrsTest
    {
        [TestCase(2000, 801, 60, 200, 1000, TestName = "(Positive)DoorParametrsConstructor")]
        [Test]
        public void TestPositiveDoorParametrsConstructor(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.DoesNotThrow(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); });
        }

        [TestCase(-100, -50, -3, -5, -100, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
