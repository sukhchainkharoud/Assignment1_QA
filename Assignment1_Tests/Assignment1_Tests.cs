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
        // GetLength 
        [Test]
        public void GetLenght_input3_expectLengthEquals3()// length=3
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
        public void GetLenght_input0_expectLengthEquals0()  //length=0
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
        public void GetLenght_input999999999_expectLengthEquals999999999() //length=999999999
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





        //GetLenght

        [Test]
        public void GetWidth_input3_expectLengthEquals3() // widht=4
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
        public void GetWidth_input0_expectLengthEquals0() // widht=0
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
        public void GetWidth_input999999999_expectLengthEquals999999999() // widht=999999999
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


        //SetLength

        [Test]
        public void SetLength_input12_expectLengthEquals12() //lenght =12
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


        [Test]
        public void SetLength_inputNegitive12_expectLengthEqualsNeg12() //lenght = -12 
        {
            //Arrange
            int l = -12;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(l);

            //Assert
            Assert.AreEqual(length, l);

        }

        // SetWidth
        [Test]
        public void SetWidth_input13_expectLengthEquals12() //width = 13
        {
            //Arrange
            int l = 0;
            int w = 13;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetWidth(l);

            //Assert
            Assert.AreEqual(length, l);

        }


        //perimeter

        [Test]
        public void GetPerimeter_inputLength13_Width12_expectLengthEquals() //lenth=13 ,width=12
        {
            //Arrange
            int l = 13;
            int w = 12;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, (w* 2) + (l* 2));

        }

        [Test]
        public void GetPerimeter_inputLengthNeg12_Width11_expectLengthEquals() //lenth=-1 ,width=19
        {
            //Arrange
            int l = -1;
            int w = 19;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, (w * 2) + (l * 2));

        }

        [Test]
        public void GetPerimeter_inputLengthNeg12_Width1Neg15_expectLengthEquals()//lenth=-12 ,width=-15
        {
            //Arrange
            int l = -12;
            int w = -15;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, (w * 2) + (l * 2));

        }


        [Test]
        public void GetPerimeter_inputLengthNeg999999999_Width1Neg999999999_expectLengthEquals() //lenth=999999999 ,width=999999999
        {
            //Arrange
            int l = 999999999;
            int w = 999999999;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, (w * 2) + (l * 2));

        }
        [Test]
        public void GetPerimeter_inputLengthNeg0_Width1Neg0_expectLengthEquals()//lenth=0 ,width=0
        {
            //Arrange
            int l = 0;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, (w * 2) + (l * 2));

        }





        //Area
        [Test]
        public void GetArea_inputLength13_Width12_expectLengthEquals()//lenth=13 ,width=12
        {
            //Arrange
            int l = 13;
            int w = 12;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, l*w );

        }

        [Test]
        public void GetArea_inputLengthNeg12_Width11_expectLengthEquals()//lenth=-12 ,width=12
        {
            //Arrange
            int l = -12;
            int w = 12;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, l * w);

        }

        [Test]
        public void GetArea_inputLengthNeg12_Width1Neg15_expectLengthEquals()//lenth=-12 ,width=-15
        {
            //Arrange
            int l = -12;
            int w = -15;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, l * w);

        }


        [Test]
        public void GetArea_inputLengthNeg999999999_Width1Neg999999999_expectLengthEquals()//lenth=999999999,width=999999999
        {
            //Arrange
            int l = 999999999;
            int w = 999999999;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, l * w);

        }
        [Test]
        public void GetArea_inputLengthNeg0_Width1Neg0_expectLengthEquals()  //lenth=0 ,width=0
        {
            //Arrange
            int l = 0;
            int w = 0;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, l * w);

        }





    }
}
