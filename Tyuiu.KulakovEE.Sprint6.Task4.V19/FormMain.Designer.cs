
namespace Tyuiu.KulakovEE.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInstop = new System.Windows.Forms.TextBox();
            this.textBoxInstart = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelUp.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.panelCentre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUp.Controls.Add(this.buttonHelp);
            this.panelUp.Controls.Add(this.buttonSave);
            this.panelUp.Controls.Add(this.buttonDone);
            this.panelUp.Controls.Add(this.groupBoxInput);
            this.panelUp.Controls.Add(this.groupBoxDescription);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(718, 93);
            this.panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(634, 7);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(73, 79);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(557, 7);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(73, 79);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone.Location = new System.Drawing.Point(454, 8);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(99, 79);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInstop);
            this.groupBoxInput.Controls.Add(this.textBoxInstart);
            this.groupBoxInput.Controls.Add(this.textBoxStop);
            this.groupBoxInput.Controls.Add(this.textBoxStart);
            this.groupBoxInput.Location = new System.Drawing.Point(291, 0);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Size = new System.Drawing.Size(159, 89);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxInstop
            // 
            this.textBoxInstop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInstop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstop.Location = new System.Drawing.Point(85, 45);
            this.textBoxInstop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInstop.Name = "textBoxInstop";
            this.textBoxInstop.ReadOnly = true;
            this.textBoxInstop.Size = new System.Drawing.Size(67, 13);
            this.textBoxInstop.TabIndex = 0;
            this.textBoxInstop.Text = "Конец шага:";
            // 
            // textBoxInstart
            // 
            this.textBoxInstart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInstart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstart.Location = new System.Drawing.Point(2, 45);
            this.textBoxInstart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInstart.Name = "textBoxInstart";
            this.textBoxInstart.ReadOnly = true;
            this.textBoxInstart.Size = new System.Drawing.Size(67, 13);
            this.textBoxInstart.TabIndex = 0;
            this.textBoxInstart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(85, 66);
            this.textBoxStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(68, 20);
            this.textBoxStop.TabIndex = 0;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(2, 66);
            this.textBoxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(68, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDescription.Size = new System.Drawing.Size(291, 89);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(2, 15);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(287, 72);
            this.textBoxDescription.TabIndex = 0;
            // 
            // panelCentre
            // 
            this.panelCentre.BackColor = System.Drawing.SystemColors.Control;
            this.panelCentre.Controls.Add(this.chartFunc);
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(0, 93);
            this.panelCentre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(718, 259);
            this.panelCentre.TabIndex = 0;
            // 
            // chartFunc
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea3);
            this.chartFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunc.Legends.Add(legend3);
            this.chartFunc.Location = new System.Drawing.Point(0, 0);
            this.chartFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartFunc.Name = "chartFunc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunc.Series.Add(series3);
            this.chartFunc.Size = new System.Drawing.Size(718, 259);
            this.chartFunc.TabIndex = 0;
            this.chartFunc.Text = "chartFunc";
            title3.Name = "TitleFunc";
            title3.Text = "График функции (5*x+2,5) / (Sin(x)-2) + 2 ";
            this.chartFunc.Titles.Add(title3);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.groupBoxRes);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 93);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(133, 259);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.textBoxDone);
            this.groupBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRes.Size = new System.Drawing.Size(133, 259);
            this.groupBoxRes.TabIndex = 0;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Вывод";
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDone.Location = new System.Drawing.Point(2, 15);
            this.textBoxDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDone.Multiline = true;
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.ReadOnly = true;
            this.textBoxDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDone.Size = new System.Drawing.Size(129, 242);
            this.textBoxDone.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(133, 93);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 259);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelUp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(734, 391);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Кулаков Е.Е.|";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelUp.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.panelCentre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelCentre;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInstop;
        private System.Windows.Forms.TextBox textBoxInstart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}