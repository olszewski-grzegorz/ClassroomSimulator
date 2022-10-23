using ClassroomSimulator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSimulator.Tests
{
    [TestClass]
    public class StudentDataReaderTests
    {
        [TestMethod]
        public void Should_Read_Studnet_Names_From_Valid_Line()
        {
            // Arrange
            string content = "Anna, Błażej,Cyprian ";
            List<string> expectedNames = new List<string>() { "Anna", "Błażej", "Cyprian" };

            // Act
            List<string> result = StudentDataReader.GetStudentNamesFromString(content);

            // Assert
            CollectionAssert.AreEqual(expectedNames, result);

            //Assert.AreEqual(expectedNames.Count, result.Count);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Assert.AreEqual(expectedNames[i], result[i]);
            //}
        }
    }
}
