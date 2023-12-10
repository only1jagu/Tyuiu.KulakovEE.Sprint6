using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.KulakovEE.Sprint6.Task7.V7.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_KEE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_KEE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_KEE_Click(object sender, EventArgs e)
        {
            openFileDialog_KEE.ShowDialog();
            openFile = openFileDialog_KEE.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_KEE.RowCount = rows;
            dataGridViewInPutData_KEE.ColumnCount = columns;
            dataGridViewOutPutData_KEE.RowCount = rows;
            dataGridViewOutPutData_KEE.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_KEE.Columns[i].Width = 50;
                dataGridViewOutPutData_KEE.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_KEE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_KEE.Enabled = true;
        }

        private void buttonOpenFile_KEE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEE.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_KEE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_KEE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KEE.Enabled = true;
        }

        private void buttonDone_KEE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEE.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KEE_Click(object sender, EventArgs e)
        {
            saveFileDialog_KEE.FileName = "OutPutFileTask7.csv";
            saveFileDialog_KEE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KEE.ShowDialog();

            string path = saveFileDialog_KEE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_KEE.RowCount;
            int columns = dataGridViewOutPutData_KEE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_KEE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_KEE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSave_KEE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEE.ToolTipTitle = "Сохранить файл";
        }

        private void buttonAbout_KEE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonAbout_KEE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEE.ToolTipTitle = "Справка";
        }
    }
}
