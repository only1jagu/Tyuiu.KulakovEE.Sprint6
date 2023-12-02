using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KulakovEE.Sprint6.Task3.V9.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14,  25,  26,  18,  17 },
                                      { 28,  10,   6,  -2,   4 },
                                      { 30,  25,  -3,  11, -10 },
                                      { 11,  32,  -5, -20,  25 },
                                      { 2, -18,  11,   8, -20} };

        private void buttonResult_KEE_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.GetUpperBound(1) + 1;

            dataGridViewMatrix_KEE.ColumnCount = columns;
            dataGridViewMatrix_KEE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KEE.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KEE.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Кулаков Егор Евгеньевич", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            {
                int rows = mtrx.GetUpperBound(0) + 1;
                int columns = mtrx.GetUpperBound(1) + 1;

                dataGridViewMatrix_KEE.ColumnCount = columns;
                dataGridViewMatrix_KEE.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMatrix_KEE.Columns[i].Width = 25;
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_KEE.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                    }
                }
            }
        }

        private void dataGridViewMatrix_KEE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

