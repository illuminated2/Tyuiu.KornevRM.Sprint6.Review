using Tyuiu.KornevRM.Sprint6.TaskReview.V7.Lib;
namespace Tyuiu.KornevRM.Sprint6.TaskReview.V7
{
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
        {
            InitializeComponent();
        }

        private void buttonDone_KRM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int m = Convert.ToInt32(textBoxM_KRM.Text);
            int n = Convert.ToInt32(textBoxN_KRM.Text);
            int n1 = Convert.ToInt32(textBoxn1_KRM.Text);
            int n2 = Convert.ToInt32(textBoxn2_KRM.Text);
            int k = Convert.ToInt32(textBoxK_KRM.Text);
            int l = Convert.ToInt32(textBoxL_KRM.Text);
            int c = Convert.ToInt32(textBoxC_KRM.Text);

            int[,] array = new int[m, n];
            bool isPositive = true;

            
            array = RandomTable(n, m, n1, n2);
            dataGridViewMatrix_KRM.ColumnCount = n;
            dataGridViewMatrix_KRM.RowCount = m;

            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrix_KRM.Columns[i].Width = 25;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridViewMatrix_KRM.Rows[i].Cells[j].Value = array[i, j];
                }
            }


            int minValue = 0;
            int minCount = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (c == j && i >= k && i <= l)
                        continue;
                    if (array[i, j] < minValue)
                    {
                        minCount++;
                    }

                }
            }

            textBoxMin_KRM.Text = $"Количество: {minCount}";

            if ((n1 > n2) || (k > l))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int[,] RandomTable(int N, int M, int n1, int n2)
        {
            int[,] result = new int[N, M];
            Random random = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    double new_min = 0;
                    double new_range = 0;
                    if (j % 2 == 0)
                    {
                        new_min = n1;
                        new_range = -1 - n1;
                    }
                    else
                    {
                        new_min = 1;
                        new_range = n2;
                    }
                    double converted = (random.NextDouble() * new_range) + new_min;
                    result[i, j] = (int)converted;
                }
            }
            return result;
        }
        private void FormMain_KRM_Load(object sender, EventArgs e)
        {

        }
    }
}
