using TriangleProblem.Controllers;

namespace TriangleProblem.Test
{

    [TestClass]
    public class TriangleTests
    {
        private const string FilePath = "triangle.txt";

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
                Assert.AreEqual(30, result);
            }
        }
    } 
}