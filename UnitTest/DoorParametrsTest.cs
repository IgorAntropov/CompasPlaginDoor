using System;
using KompasLib;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class DoorParametrsTest
    {
        [Test]
        [TestCase(1000, 500, 50, 200, 1000, 
            true, TestName = "(Positive)DoorParametrsHeight 1")]
        [TestCase(2000, 600, 60, 300, 2000, 
            true, TestName = "(Positive)DoorParametrsHeight 2")]
        [TestCase(3000, 700, 70, 400, 3000, 
            true, TestName = "(Positive)DoorParametrsHeight 3")]

        [TestCase(1000, 500, 50, 200, 1000,
            true, TestName = "(Positive)DoorParametrsWidth 1")]
        [TestCase(2000, 600, 60, 300, 2000,
            true, TestName = "(Positive)DoorParametrsWidth 2")]
        [TestCase(3000, 700, 70, 400, 3000,
            true, TestName = "(Positive)DoorParametrsWidth 3")]

        [TestCase(1000, 500, 50, 200, 1000,
            true, TestName = "(Positive)DoorParametrsWeigtht 1")]
        [TestCase(2000, 600, 60, 300, 2000,
            true, TestName = "(Positive)DoorParametrsWeigtht 2")]
        [TestCase(3000, 700, 70, 400, 3000,
            true, TestName = "(Positive)DoorParametrsWeigtht 3")]

        [TestCase(1000, 500, 50, 200, 1000,
            true, TestName = "(Positive)DoorParametrsYkey 1")]
        [TestCase(2000, 600, 60, 300, 2000,
            true, TestName = "(Positive)DoorParametrsYkey 2")]
        [TestCase(3000, 700, 70, 400, 3000,
            true, TestName = "(Positive)DoorParametrsYkey 3")]

        [TestCase(1000, 500, 50, 200, 1000,
            true, TestName = "(Positive)DoorParametrsYeye 1")]
        [TestCase(2000, 600, 60, 300, 2000,
            true, TestName = "(Positive)DoorParametrsYeye 2")]
        [TestCase(3000, 700, 70, 400, 3000,
            true, TestName = "(Positive)DoorParametrsYeye 3")]

        [TestCase(-1000, -500, -50, -200, -1000,
            false, TestName = "(Negative)DoorParametrsConstructor 1")]
        [TestCase(-2000, -600, -60, -300, -2000,
            false, TestName = "(Negative)DoorParametrsConstructor 2")]
        [TestCase(-3000, -700, -70, -400, -3000,
            false, TestName = "(Negative)DoorParametrsConstructor 3")]

        [TestCase(1000, -500, -50, -100, -1000,
            false, TestName = "(Negative)DoorParametrsHeight 1")]
        [TestCase(2000, -600, -60, -200, -2000,
            false, TestName = "(Negative)DoorParametrsHeight 2")]
        [TestCase(3000, -700, -70, -300, -3000,
            false, TestName = "(Negative)DoorParametrsHeight 3")]

        [TestCase(-1000, 500, -50, -200, -1000,
            false, TestName = "(Negative)DoorParametrsWidthr 1")]
        [TestCase(-2000, 600, -60, -300, -2000,
            false, TestName = "(Negative)DoorParametrsWidthr 2")]
        [TestCase(-3000, 700, -70, -400, -3000,
            false, TestName = "(Negative)DoorParametrsWidthr 3")]

        [TestCase(-1000, -500, 50, -200, -1000,
            false, TestName = "(Negative)DoorParametrsWeigtht 1")]
        [TestCase(-2000, -600, 60, -300, -2000,
            false, TestName = "(Negative)DoorParametrsWeigtht 2")]
        [TestCase(-3000, -700, 70, -400, -3000,
            false, TestName = "(Negative)DoorParametrsWeigtht 3")]

        [TestCase(-1000, -500, -50, -200, 1000,
            false, TestName = "(Negative)DoorParametrsYEye 1")]
        [TestCase(-2000, -600, -60, -300, 2000,
            false, TestName = "(Negative)DoorParametrsYEye 2")]
        [TestCase(-3000, -700, -70, -400, 3000,
            false, TestName = "(Negative)DoorParametrsYEye 3")]

        [TestCase(-1000, -500, -50, 200, -1000,
            false, TestName = "(Negative)DoorParametrsYKey 1")]
        [TestCase(-2000, -600, -60, 300, -2000,
            false, TestName = "(Negative)DoorParametrsYKey 2")]
        [TestCase(-3000, -700, -70, 400, -3000,
            false, TestName = "(Negative)DoorParametrsYKey 3")]

        public void TestDoorParametrs(int heightDoor, 
            int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(weigthDoor, yKey, 
                yEye, isOpen, heightDoor, widthDoor); },
                Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
