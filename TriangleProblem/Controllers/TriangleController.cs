
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TriangleProblem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleController : ControllerBase
    {
        private const string FilePath = "triangle.txt";  
 
        [HttpGet]
        public ActionResult<int> GetMaxTotal()
        { 
            try
            { 
                int[][] triangle = ReadTriangleFromFile();
                int maxTotal = FindMaxTotal(triangle);
                return maxTotal;
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        private static int[][] ReadTriangleFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            int[][] triangle = new int[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] row = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (!int.TryParse(numbers[j], out int number))
                    {
                        throw new FormatException($"Invalid number format at row {i + 1}, column {j + 1}");
                    }
                    row[j] = number;
                }
                triangle[i] = row;
            }
            return triangle;
        }

        private static int FindMaxTotal(int[][] triangle)
        {
            int numRows = triangle.Length;
            int[] maxTotals = triangle[numRows - 1];
            for (int i = numRows - 2; i >= 0; i--)
            {
                int[] row = triangle[i];
                int[] newMaxTotals = new int[row.Length];
                for (int j = 0; j < row.Length; j++)
                {
                    newMaxTotals[j] = row[j] + Math.Max(maxTotals[j], maxTotals[j + 1]);
                }
                maxTotals = newMaxTotals;
            }
            return maxTotals[0];
        }
    }


}
