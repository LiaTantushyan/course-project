using System;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class TaskForm : Form
    {
        private const int rows = 2;
        private const int columns = 2;
        private static int[,] arr1 = new int[rows, columns];

        public TaskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr1[i, j] = rnd.Next(1, 100);
                }
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sb.Append(arr1[i, j] + "  ");
                }
                sb.AppendLine();
            }
            label1.Text = sb.ToString();
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int n1 = mergeMatrixAddingColumn(arr1, rows, columns).GetLength(0);
            int m1 = mergeMatrixAddingColumn(arr1, rows, columns).GetLength(1);
            int[,] arr2 = mergeMatrixAddingColumn(arr1, rows, columns);

            int n2 = mergeMatrixAddingRows(arr2, n1, m1).GetLength(0);
            int m2 = mergeMatrixAddingRows(arr2, n1, m1).GetLength(1);
            int[,] arr5 = mergeMatrixAddingRows(arr2, n1, m1);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    sb.Append(arr5[i, j] + "   ");
                }
                sb.AppendLine();
            }
            label2.Text = sb.ToString();
        }
        static int[,] mergeMatrixAddingColumn(int[,] A, int n, int m)
        {
            int[,] C = new int[n, 2 * m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j];
                    C[i, j + m] = A[i, m - j - 1];
                }
            }
            return C;
        }
        static int[,] mergeMatrixAddingRows(int[,] A, int n, int m)
        {
            int[,] C = new int[2 * n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j];
                    C[i + n, j] = A[n - i - 1, j];
                }
            }
            return C;
        }
    }
}
