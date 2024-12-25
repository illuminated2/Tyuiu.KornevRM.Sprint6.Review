
namespace Tyuiu.KornevRM.Sprint6.TaskReview.V7.Lib
{
    public class DataService 
    {  // t != t
        public int[,] GetMatrix(int rows, int cols, int n1, int n2)
        {
            if (rows <= 1 || cols <= 1 || n1 >= n2)
                throw new ArgumentException("Некорректные входные данные.");

            Random rand = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    if (j % 2 == 0)
                    {
                        matrix[i, j] = rand.Next(n1, n2 + 1);
                    }
                    else
                    {
                        matrix[i, j] = -rand.Next(n1, n2 + 1);
                    }
                }
            }

            return matrix;
        }

        
        public int CountNegativeElements(int[,] array, int c, int k, int l)
        {
            if (array == null || array.GetLength(0) < 1 || array.GetLength(1) < 1)
                throw new ArgumentException("Массив не может быть пустым.");

            if (c < 0 || c >= array.GetLength(1))
                throw new ArgumentOutOfRangeException(nameof(c), "Индекс столбца превышает размер массива.");

            if (k < 0 || l < 0 || k >= array.GetLength(0) || l >= array.GetLength(0) || k > l)
                throw new ArgumentOutOfRangeException("Некорректные значения K и L.");

            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                if (i < k || i > l)
                {
                    if (array[i, c] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

