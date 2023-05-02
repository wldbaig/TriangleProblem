using TriangleProblem.Controllers;

namespace TriangleProblems.Test
{
    [TestFixture]
    public class TriangleControllerTests
    {
        [Test]
        public void GetMaxTotal_ReturnsExpectedResult()
        {
            // Arrange
            var controller = new TriangleController();

            // Act
            int result = controller.GetMaxTotal().Value;

            // Assert
            Assert.AreEqual(732506, result);
        }

        [Test]
        public void GetMaxTotal_ReturnsExpectedResult_ForTriangleWithOneRow()
        {
            // Arrange
            var controller = new TriangleController();
            string triangleText = "5";
            File.WriteAllText("triangle.txt", triangleText);

            // Act
            int result = controller.GetMaxTotal().Value;

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void GetMaxTotal_ReturnsExpectedResult_ForTriangleWithTwoRows()
        {
            // Arrange
            var controller = new TriangleController();
            string triangleText = "5\n9 6";
            File.WriteAllText("triangle.txt", triangleText);

            // Act
            int result = controller.GetMaxTotal().Value;

            // Assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void GetMaxTotal_ReturnsExpectedResult_ForTriangleWithMultipleRows()
        {
            // Arrange
            var controller = new TriangleController();
            string triangleText = "5\n9 6\n4 6 8\n0 7 1 5\n8 3 1 1 2";
            File.WriteAllText("triangle.txt", triangleText);

            // Act
            int result = controller.GetMaxTotal().Value;

            // Assert
            Assert.AreEqual(30, result);
        }
 
    }
}