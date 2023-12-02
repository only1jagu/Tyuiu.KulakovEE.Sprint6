
namespace Tyuiu.KulakovEE.Sprint6.Task2.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KEE = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.ButtonLaunch_KEE = new System.Windows.Forms.Button();
            this.ButtonHelp_KEE = new System.Windows.Forms.Button();
            this.textBoxTask_KEE = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KEE = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_KEE = new System.Windows.Forms.TextBox();
            this.labelStart_KEE = new System.Windows.Forms.Label();
            this.laberlFinish_KEE = new System.Windows.Forms.Label();
            this.dataGridViewResult_KEE = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KEE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KEE.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KEE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEE
            // 
            this.groupBoxTask_KEE.Controls.Add(this.textBoxTask_KEE);
            this.groupBoxTask_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTask_KEE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KEE.Name = "groupBoxTask_KEE";
            this.groupBoxTask_KEE.Size = new System.Drawing.Size(352, 206);
            this.groupBoxTask_KEE.TabIndex = 0;
            this.groupBoxTask_KEE.TabStop = false;
            this.groupBoxTask_KEE.Text = "Условие";
            this.groupBoxTask_KEE.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.chartFunction_KEE);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult_KEE);
            this.groupBoxResult.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResult.Location = new System.Drawing.Point(386, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(749, 353);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.laberlFinish_KEE);
            this.groupBoxInput.Controls.Add(this.labelStart_KEE);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep_KEE);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep_KEE);
            this.groupBoxInput.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInput.Location = new System.Drawing.Point(12, 224);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(352, 214);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // ButtonLaunch_KEE
            // 
            this.ButtonLaunch_KEE.BackColor = System.Drawing.Color.Green;
            this.ButtonLaunch_KEE.Font = new System.Drawing.Font("TL header RUS", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLaunch_KEE.Location = new System.Drawing.Point(386, 371);
            this.ButtonLaunch_KEE.Name = "ButtonLaunch_KEE";
            this.ButtonLaunch_KEE.Size = new System.Drawing.Size(133, 67);
            this.ButtonLaunch_KEE.TabIndex = 3;
            this.ButtonLaunch_KEE.Text = "Выполнить";
            this.ButtonLaunch_KEE.UseVisualStyleBackColor = false;
            this.ButtonLaunch_KEE.Click += new System.EventHandler(this.ButtonLaunch_KEE_Click);
            this.ButtonLaunch_KEE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLaunch_KEE_MouseDown);
            this.ButtonLaunch_KEE.MouseEnter += new System.EventHandler(this.ButtonLaunch_KEE_MouseEnter);
            this.ButtonLaunch_KEE.MouseLeave += new System.EventHandler(this.ButtonLaunch_KEE_MouseLeave);
            // 
            // ButtonHelp_KEE
            // 
            this.ButtonHelp_KEE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonHelp_KEE.Font = new System.Drawing.Font("TL header RUS", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHelp_KEE.Location = new System.Drawing.Point(525, 371);
            this.ButtonHelp_KEE.Name = "ButtonHelp_KEE";
            this.ButtonHelp_KEE.Size = new System.Drawing.Size(67, 67);
            this.ButtonHelp_KEE.TabIndex = 4;
            this.ButtonHelp_KEE.Text = "? ";
            this.ButtonHelp_KEE.UseVisualStyleBackColor = false;
            this.ButtonHelp_KEE.Click += new System.EventHandler(this.ButtonHelp_KEE_Click);
            // 
            // textBoxTask_KEE
            // 
            this.textBoxTask_KEE.Font = new System.Drawing.Font("TL header RUS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask_KEE.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KEE.Multiline = true;
            this.textBoxTask_KEE.Name = "textBoxTask_KEE";
            this.textBoxTask_KEE.ReadOnly = true;
            this.textBoxTask_KEE.Size = new System.Drawing.Size(339, 180);
            this.textBoxTask_KEE.TabIndex = 0;
            this.textBoxTask_KEE.Text = "Произвести табулирование функции f(x) в заданном диапазоне. \r\nРезультат вывести в" +
    " DataGridView, построить график функции.\r\n";
            this.textBoxTask_KEE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxStartStep_KEE
            // 
            this.textBoxStartStep_KEE.Location = new System.Drawing.Point(6, 43);
            this.textBoxStartStep_KEE.Name = "textBoxStartStep_KEE";
            this.textBoxStartStep_KEE.Size = new System.Drawing.Size(91, 31);
            this.textBoxStartStep_KEE.TabIndex = 0;
            this.textBoxStartStep_KEE.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxStartStep_KEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxStopStep_KEE
            // 
            this.textBoxStopStep_KEE.Location = new System.Drawing.Point(6, 97);
            this.textBoxStopStep_KEE.Name = "textBoxStopStep_KEE";
            this.textBoxStopStep_KEE.Size = new System.Drawing.Size(91, 31);
            this.textBoxStopStep_KEE.TabIndex = 1;
            this.textBoxStopStep_KEE.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxStopStep_KEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelStart_KEE
            // 
            this.labelStart_KEE.AutoSize = true;
            this.labelStart_KEE.Font = new System.Drawing.Font("TL header RUS", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart_KEE.Location = new System.Drawing.Point(7, 24);
            this.labelStart_KEE.Name = "labelStart_KEE";
            this.labelStart_KEE.Size = new System.Drawing.Size(65, 12);
            this.labelStart_KEE.TabIndex = 2;
            this.labelStart_KEE.Text = "старт шага";
            // 
            // laberlFinish_KEE
            // 
            this.laberlFinish_KEE.AutoSize = true;
            this.laberlFinish_KEE.Font = new System.Drawing.Font("TL header RUS", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlFinish_KEE.Location = new System.Drawing.Point(7, 82);
            this.laberlFinish_KEE.Name = "laberlFinish_KEE";
            this.laberlFinish_KEE.Size = new System.Drawing.Size(66, 12);
            this.laberlFinish_KEE.TabIndex = 3;
            this.laberlFinish_KEE.Text = "конец шага";
            // 
            // dataGridViewResult_KEE
            // 
            this.dataGridViewResult_KEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KEE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewResult_KEE.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewResult_KEE.Name = "dataGridViewResult_KEE";
            this.dataGridViewResult_KEE.RowHeadersVisible = false;
            this.dataGridViewResult_KEE.Size = new System.Drawing.Size(240, 317);
            this.dataGridViewResult_KEE.TabIndex = 5;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.HeaderText = "f(x)";
            this.y.Name = "y";
            // 
            // chartFunction_KEE
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction_KEE.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFunction_KEE.Legends.Add(legend6);
            this.chartFunction_KEE.Location = new System.Drawing.Point(252, 30);
            this.chartFunction_KEE.Name = "chartFunction_KEE";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction_KEE.Series.Add(series6);
            this.chartFunction_KEE.Size = new System.Drawing.Size(491, 228);
            this.chartFunction_KEE.TabIndex = 6;
            this.chartFunction_KEE.Text = "chartFunction";
            this.chartFunction_KEE.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.ButtonHelp_KEE);
            this.Controls.Add(this.ButtonLaunch_KEE);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTask_KEE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 21 | Кулаков Е. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KEE.ResumeLayout(false);
            this.groupBoxTask_KEE.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KEE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEE;
        private System.Windows.Forms.TextBox textBoxTask_KEE;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button ButtonLaunch_KEE;
        private System.Windows.Forms.Button ButtonHelp_KEE;
        private System.Windows.Forms.DataGridView dataGridViewResult_KEE;
        private System.Windows.Forms.Label laberlFinish_KEE;
        private System.Windows.Forms.Label labelStart_KEE;
        private System.Windows.Forms.TextBox textBoxStopStep_KEE;
        private System.Windows.Forms.TextBox textBoxStartStep_KEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KEE;
    }
}

