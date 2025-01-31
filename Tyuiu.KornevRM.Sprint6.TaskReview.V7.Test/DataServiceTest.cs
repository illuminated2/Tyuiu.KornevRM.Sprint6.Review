using Tyuiu.KornevRM.Sprint6.TaskReview.V7.Lib;
namespace Tyuiu.KornevRM.Sprint6.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = {{1, 2, 3, 4, -5},
                            {5, 0, 2, -10, 11},
                            {-1, 4, 3, 15, 9},
                            {1, -3, 2, 4, 2},
                            {0, 1, 3, -1, 2 } };
            int k = 0;
            int l = 4;
            int c = 3;
            int res = ds.CountNegativeElements(array, c, k, l);
            int wait = 0;
            Assert.AreEqual(wait, res);

        }
    }
}