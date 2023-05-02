using TriangleProblem.Controllers;

namespace TriangleControllers.Test
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
            Assert.That(result, Is.EqualTo(732506));
        }

        [Test]
        public void TestFindMaxTotal()
        {
            // Arrange
            int[][] triangle = new int[][] {
        new int[] { 5 },
        new int[] { 9, 6 },
        new int[] { 4, 6, 8 },
        new int[] { 0, 7, 1, 5 },
        new int[] { 8, 3, 1, 1, 2 }
    };
            int expected = 30;
            

            // Act
            int result = TriangleController.FindMaxTotal(triangle);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFindMaxTotal_TriangleWithOneValue()
        {
            // Arrange
            int[][] triangle = new int[][] {
        new int[] { 5 }
    };
            int expected = 5;

            // Act
            int result = TriangleController.FindMaxTotal(triangle);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFindMaxTotal_TriangleWithTwoRows()
        {
            // Arrange
            int[][] triangle = new int[][] {
        new int[] { 5 },
        new int[] { 2, 3 }
    };
            int expected = 8;

            // Act
            int result = TriangleController.FindMaxTotal(triangle);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFindMaxTotal_TriangleWithNegativeValues()
        {
            // Arrange
            int[][] triangle = new int[][] {
        new int[] { -1 },
        new int[] { 2, -3 },
        new int[] { 1, 1, -1 },
        new int[] { 3, -2, 1, 2 },
        new int[] { -1, 3, -2, -1, 5 }
    };
            int expected = 8;

            // Act
            int result = TriangleController.FindMaxTotal(triangle);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFindMaxTotal_TriangleWithAllSameValues()
        {
            // Arrange
            int[][] triangle = new int[][] {
        new int[] { 5 },
        new int[] { 5, 5 },
        new int[] { 5, 5, 5 },
        new int[] { 5, 5, 5, 5 },
        new int[] { 5, 5, 5, 5, 5 }
    };
            int expected = 25;

            // Act
            int result = TriangleController.FindMaxTotal(triangle);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }


    }
}