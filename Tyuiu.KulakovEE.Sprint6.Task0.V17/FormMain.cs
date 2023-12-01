using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KulakovEE.Sprint6.Task0.V17.Lib;


namespace Tyuiu.KulakovEE.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_KEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб 23 - 1 Кулаков Егор Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_KEE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                Result_KEE.Text = ds.Calculate(Convert.ToInt32(nameX_KEE.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void buttonResult_KEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void nameX_KEE_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxNamedTwo_KEE_Click(object sender, EventArgs e)
        {

        }
    }
}