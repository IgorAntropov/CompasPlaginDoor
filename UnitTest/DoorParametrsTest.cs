

using System;
using KompasLib;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class DoorParametrsTest
    {
        [TestCase(2000, 800, 60, 200, 1000, TestName = "(Positive)DoorParametrsConstructor")]
        [Test]
        public void TestPositiveDoorParametrsConstructor(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.DoesNotThrow(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); });
        }

        [TestCase(-2000, -800, -60, -200, -1000, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }

        [TestCase(2000, -800, -60, -200, -1000, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }

        [TestCase(-2000, 800, -60, -200, -1000, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }

        [TestCase(-2000, -800, 60, -200, -1000, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }

        [TestCase(-2000, -800, -60, 200, -1000, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }

        [TestCase(-2000, -800, -60, -200, 1000, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye); },
                Throws.TypeOf(typeof(ArgumentException)));
        }
    }
}
