using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Point
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }



    class GameField
    {
        public int[][] Field { get; set; } //1 - X; 0 - O; -1 - empty
        public int N { get; set; }
        //public int M { get; set; }

        public Point[] VerticalWin { get; set; }
        public Point[] HorizontalWin { get; set; }
        public Point[] DiagonalWinToRight { get; set; }
        public Point[] DiagonalWinToLeft { get; set; }

        public GameField(int _N/*, int _M*/)
        {
            this.N = _N;
            this.Field = new int[N][];
            for (int i = 0; i < N; i++) this.Field[i] = new int[N];
            //this.M = _M;
        }
        
        /** Проверяем горизонтальные и вертикальные линии */
        public bool checkLanes(char symb, int offsetX, int offsetY, int M)
        {
            bool cols, rows;
            for (int col = offsetX; col < M + offsetX; col++)
            {
                cols = true;
                rows = true;
                for (int row = offsetY; row < M + offsetY; row++)
                {
                    cols &= (Field[col][row] == symb);
                    rows &= (Field[row][col] == symb);
                }

                if (cols || rows) return true;
            }

            return false;
        }

        /** Проверяем диагонали */
        public bool checkDiagonal(char symb, int offsetX, int offsetY, int M)
        {
            bool toright, toleft;
            toright = true;
            toleft = true;
            for (int i = offsetX; i < M + offsetX; i++)
            {
                toright &= (Field[i][i] == symb);
                toleft &= (Field[M - i - 1][i] == symb);
            }

            if (toright || toleft) return true;

            return false;
        }

        public bool checkWin(char symb, int M)
        {
            for (int col = 0; col <= N - M; col++)
            {
                for (int row = 0; row <= N - M; row++)
                {
                    // Вызываем методы проверки и если хоть один блок заполнен,
                    // то игрок, который проставляет это символ, выиграл
                    // иначе продолжаем для другого смещения
                    if (checkDiagonal(symb, col, row, M) || checkLanes(symb, col, row, M)) return true;
                }
            }
            // Все подквадраты в квадрате проверены. 4-х последовательностей
            // подряд не выявлено. Значит еще не победа.
            return false;
        }



        /*
        public int[,] matrix;
        public int size;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="size">Размер матрицы</param>
        public Matrix(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }

        /// <summary>
        /// Заполнение матрицы из DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        public void FillFromGrid(DataGridView dgv)
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    if ((string)dgv.Rows[i + 1].Cells[j + 1].Value != "")
                        matrix[i, j] = Convert.ToInt32(dgv.Rows[i + 1].Cells[j + 1].Value);

        }
        */
    }
}
