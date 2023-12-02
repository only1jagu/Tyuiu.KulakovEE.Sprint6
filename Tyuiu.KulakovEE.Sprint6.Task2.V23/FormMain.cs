using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KulakovEE.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHelp_KEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Кулаков Егор Евгеньевич", "Сообщение");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void ButtonLaunch_KEE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStartStep_KEE.Text);
                int stopStep = int.Parse(textBoxStopStep_KEE.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = dataService.GetMassFunction(startStep, stopStep);

                this.chartFunction_KEE.Titles.Add("График функции f(x)");

                this.chartFunction_KEE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KEE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    this.dataGridViewResult_KEE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KEE.Series[0].Points.AddXY(startStep, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ButtonLaunch_KEE_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonLaunch_KEE.BackColor = Color.OrangeRed;
            
        }

        private void ButtonLaunch_KEE_MouseEnter(object sender, EventArgs e)
        {
            ButtonLaunch_KEE.BackColor = Color.Blue;
        }

        private void ButtonLaunch_KEE_MouseLeave(object sender, EventArgs e)
        {
            ButtonLaunch_KEE.BackColor = Color.White;
        }
    }
    }

