using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddNumbers;
using System.Windows.Forms;

namespace AddNumbers_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Testing()
        {
            //Arrange
            int x = 1;
            int y = 1;
            var number = new Form1();
            //Act
            int actual = number.Add(x, y);

            //Assert
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
