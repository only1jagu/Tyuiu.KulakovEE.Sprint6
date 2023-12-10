using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KulakovEE.Sprint6.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.KulakovEE.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        string openFilePath;
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                openFilePath = openFileDialog1.FileName;
                textBox2.Text = File.ReadAllText(openFilePath);
                groupBox2.Text = groupBox2.Text + " " + openFileDialog1.FileName;
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
