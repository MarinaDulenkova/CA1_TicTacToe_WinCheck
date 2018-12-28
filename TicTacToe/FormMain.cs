using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class fmMain : Form
    {
        private GameField Game;
        private string selected;// selected cell to be changed
        private int empty = -1;
        private int N;
        private int M;

        
        #region HELP
        void InitTable()
        {
            N = (int)nudN.Value;
            dgvTicTac.RowCount = N;
            dgvTicTac.ColumnCount = N;
            foreach (DataGridViewRow row in dgvTicTac.Rows)
                row.Height = dgvTicTac.Columns[0].Width;
            dgvTicTac.Height = (int)(dgvTicTac.Rows[0].Height * N) + 3;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    dgvTicTac.Rows[i].Cells[j].Value = "";
                }                
            }
            dgvTicTac.Rows[0].Cells[0].Selected = false;
            dgvTicTac.Update();
        }

        public int[][] GridToMatrix(DataGridView dgv, int size)
        {
            int[][] matr = new int[size][];
            for (int i = 0; i < size; i++) matr[i] = new int[size];
            DataGridViewCell cell;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    cell = dgv.Rows[i].Cells[j];
                    string s = cell.Value.ToString();
                    if (s == "")
                        matr[i][j] = empty;
                    else if ((s == "x") || (s == "X"))
                        matr[i][j] = 1;
                    else if ((s == "o") || (s == "O"))
                        matr[i][j] = 0;
                }
            }
            return matr;
        }

        private string ListToString(List<int[]> list)
        {
            string res = "";
            foreach (var x in list)
                res += "(" + (x[0]).ToString() + " , " + (x[1]).ToString() + ") ";
            return res;
        }
        /*
                private void ClearGame()
                {
                    DataTable table = (DataTable)dgvTicTac.DataSource;
                    if (table != null) table.Clear();
                    DrawEmptyField();
                }


                private void DrawEmptyField()
                {
                    Game = new GameField(N);

                    DataTable matr = new DataTable("Field");
                    DataColumn[] cols = new DataColumn[N];
                    for (int i = 0; i < N; i++)
                    {
                        cols[i] = new DataColumn((i + 1).ToString());
                        matr.Columns.Add(cols[i]);
                    }

                    for (int i = 0; i < N; i++)
                    {
                        DataRow newRow;
                        newRow = matr.NewRow();
                        matr.Rows.Add(newRow);
                    }

                    dgvTicTac.DataSource = matr;
                    for (int i = 0; i < N; i++)
                        dgvTicTac.Columns[i].Width = 30;
                    dgvTicTac.AllowUserToAddRows = false;
                    dgvTicTac.AllowUserToDeleteRows = false;
                }
        */
        #endregion



        #region GUI
        public fmMain()
        {
            InitializeComponent();
            btnCheck.Enabled = false;
            //btnClear.Enabled = false;
            InitTable();
            Game = new GameField((int)nudN.Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitTable();
            Game = new GameField((int)nudN.Value);
        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {
            //установка размера матрицы и DataGridView
            N = (int)nudN.Value;

            InitTable();
            Game = new GameField((int)nudN.Value);
        }

        private void nudM_ValueChanged(object sender, EventArgs e)
        {
            //изменение доступности btnCheck
            if (nudN.Value > 1)
                btnCheck.Enabled = true;
            else
                btnCheck.Enabled = false;
            
            M = (int)nudN.Value;
        }      
        
        
        private void dgvTicTac_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgvTicTac[e.ColumnIndex, e.RowIndex].Value.ToString();
            if ((selected != "x") && (selected != "X") && (selected != "o") && (selected != "O") && (selected != ""))
            {
                MessageBox.Show("Only 'X' or 'O' accepted! Repeat, please...");
                dgvTicTac[e.ColumnIndex, e.RowIndex].Value = "";
            }
        }

        private void dgvTicTac_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selected = dgvTicTac[e.ColumnIndex, e.RowIndex].Value.ToString();
            if ((selected == "x") || (selected == "X") || (selected == "o") || (selected == "O"))
            {
                MessageBox.Show("Cell is already filled! Choose another one...");
                e.Cancel = true;
            }
        }
        #endregion
    }
}
