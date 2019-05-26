using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace Assignment1_Tests
{
    [TestFixture]
    class Assignment1_Tests
    {

        [Test]
        public void GetLenght_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length,l);

        }

        [Test]
        public void GetLenght_input0_expectLengthEquals0()
        {
            //Arrange
            int l = 0;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);

        }

        [Test]
        public void GetLenght_input999999999_expectLengthEquals999999999()
        {
            //Arrange
            int l = 999999999;
            int w = 999999999;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);

        }




        [Test]
        public void GetWidth_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);

        }

        [Test]
        public void GetWidth_input0_expectLengthEquals0()
        {
            //Arrange
            int l = 0;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);

        }

        [Test]
        public void GetWidth_input999999999_expectLengthEquals999999999()
        {
            //Arrange
            int l = 999999999;
            int w = 999999999;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);

        }

        [Test]
        public void SetLenght_input12_expectLengthEquals12()
        {
            //Arrange
            int l = 12;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(l);

            //Assert
            Assert.AreEqual(length, l);

        }




    }
}
