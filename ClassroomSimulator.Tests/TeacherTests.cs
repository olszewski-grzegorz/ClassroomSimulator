using ClassroomSimulator.Library;

namespace ClassroomSimulator.Tests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void Should_Set_Name_During_Constructing()
        {
            // Arrange
            string name = "John";

            // Act
            Teacher teacher = new Teacher(name);

            // Assert
            Assert.AreEqual(name, teacher.Name);

        }
    }
}