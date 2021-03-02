using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Testing1.Controllers;

namespace XUnitTestProject1
{
    public class DataInitializer
    {
        public DataInitializer() { }

        [Fact]
        public void CreateUser()
        {
            //Act
            var id = 1;
            var fname = "Kajal";
            var lname = "Ramani";
            var phone = 8866554433;
            var expectedResult = "Kajal Ramani 8866554433";

            //Arrange
            var result = PassenegrsController.Create(id, fname, lname, phone);

            //Assert
            Assert.Equal(expectedResult, result,1);
        }

        public void Details()
        {
            //Act
            var id = 1;
            var expectedResult = "Kajal Ramani 8866554433";

            //Arrange
            var result = PassenegrsController.Details(id);

            //Assert
            Assert.Equal(expectedResult, result, 1);
        }

        public void Update()
        {
            //Act
            var id = 1;
            var fname = "K";
            var lname = "R";
            var phone = 8866554433;
            var expectedResult = "K R 8866554433";

            //Arrange
            var result = PassenegrsController.Edit(id);

            //Assert
            Assert.Equal(expectedResult, result, 1);
        }

        public void Delete()
        {
            //Act
            var id = 1;
            var phone = 8866554433;
            var expectedResult = "";

            //Arrange
            var result = PassenegrsController.Delete(id);

            //Assert
            Assert.Equal(expectedResult, result, 1);
        }
    }
}
