

using System;
using KompasLib;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class DoorParametrsTest
    {
        [TestCase(1000, 500, 50, 200, 1000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, 600, 60, 300, 2000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, 700, 70, 400, 3000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, 800, 80, 500, 4000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, 900, 90, 600, 5000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, 1000, 100, 700, 6000, true, TestName = "(Positive)DoorParametrsHeight")]
        [Test]
        public void TestPositiveDoorParametrsHeight6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(1000, 500, 50, 200, 1000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, 600, 60, 300, 2000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, 700, 70, 400, 3000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, 800, 80, 500, 4000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, 900, 90, 600, 5000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, 1000, 100, 700, 6000, true, TestName = "(Positive)DoorParametrsWidth")]
        [Test]
        public void TestPositiveDoorParametrsWidth6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(1000, 500, 50, 200, 1000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, 600, 60, 300, 2000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, 700, 70, 400, 3000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, 800, 80, 500, 4000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, 900, 90, 600, 5000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, 1000, 100, 700, 6000, true, TestName = "(Positive)DoorParametrsWeigtht")]
        [Test]
        public void TestPositiveDoorParametrsWeigtht6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(1000, 500, 50, 200, 1000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, 600, 60, 300, 2000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, 700, 70, 400, 3000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, 800, 80, 500, 4000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, 900, 90, 600, 5000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, 1000, 100, 700, 6000, true, TestName = "(Positive)DoorParametrsYkey")]
        [Test]
        public void TestPositiveDoorParametrsYkey6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(1000, 500, 50, 200, 1000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, 600, 60, 300, 2000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, 700, 70, 400, 3000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, 800, 80, 500, 4000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, 900, 90, 600, 5000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, 1000, 100, 700, 6000, true, TestName = "(Positive)DoorParametrsYeye")]
        [Test]
        public void TestPositiveDoorParametrsYeye6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-1000, -500, -50, -200, -1000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-2000, -600, -60, -300, -2000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-3000, -700, -70, -400, -3000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-4000, -800, -80, -500, -4000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-5000, -900, -90, -600, -5000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-6000, -1000, -100, -700, -6000, false, TestName = "(Negative)DoorParametrsConstructor")]
        [Test]
        public void TestNegativeDoorParametrsConstructor6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(1000, -500, -50, -100, -1000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(2000, -600, -60, -200, -2000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(3000, -700, -70, -300, -3000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(4000, -800, -80, -500, -4000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(5000, -900, -90, -600, -5000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(6000, -1000, -100, -700, -6000, false, TestName = "(Negative)DoorParametrsHeight")]
        [Test]
        public void TestNegativeDoorParametrsHeight6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-1000, 500, -50, -200, -1000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-2000, 600, -60, -300, -2000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-3000, 700, -70, -400, -3000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-4000, 800, -80, -500, -4000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-5000, 900, -90, -600, -5000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-6000, 1000, -100, -700, -6000, false, TestName = "(Negative)DoorParametrsWidthr")]
        [Test]
        public void TestNegativeDoorParametrsWidth6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-1000, -500, 50, -200, -1000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-2000, -600, 60, -300, -2000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-3000, -700, 70, -400, -3000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-4000, -800, 80, -500, -4000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-5000, -900, 90, -600, -5000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-6000, -1000, 100, -700, -6000, false, TestName = "(Negative)DoorParametrsWeigtht")]
        [Test]
        public void TestNegativeDoorParametrsWeigtht6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-1000, -500, -50, 200, -1000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-2000, -600, -60, 300, -2000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-3000, -700, -70, 400, -3000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-4000, -800, -80, 500, -4000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-5000, -900, -90, 600, -5000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-6000, -1000, -100, 700, -6000, false, TestName = "(Negative)DoorParametrsYKey")]
        [Test]
        public void TestNegativeDoorParametrsYkey6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-1000, -500, -50, -200, 1000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye1(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-2000, -600, -60, -300, 2000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye2(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-3000, -700, -70, -400, 3000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye3(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-4000, -800, -80, -500, 4000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye4(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-5000, -900, -90, -600, 5000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye5(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }

        [TestCase(-6000, -1000, -100, -700, 6000, false, TestName = "(Negative)DoorParametrsYEye")]
        [Test]
        public void TestNegativeDoorParametrsYeye6(int heightDoor, int widthDoor, int weigthDoor, int yKey,
            int yEye, bool isOpen)
        {
            Assert.That(() => { new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen); },
                Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
