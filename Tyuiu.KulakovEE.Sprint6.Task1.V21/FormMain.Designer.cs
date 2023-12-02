
namespace Tyuiu.KulakovEE.Sprint6.Task1.V21
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStopStep_KEE = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KEE = new System.Windows.Forms.TextBox();
            this.buttonHelp_KEE = new System.Windows.Forms.Button();
            this.buttonDone_KEE = new System.Windows.Forms.Button();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.label1);
            this.groupBoxResult.Controls.Add(this.textBoxResult_KEE);
            this.groupBoxResult.Location = new System.Drawing.Point(508, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(241, 292);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            this.groupBoxResult.Enter += new System.EventHandler(this.groupBoxResult_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // textBoxResult_KEE
            // 
            this.textBoxResult_KEE.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_KEE.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult_KEE.Multiline = true;
            this.textBoxResult_KEE.Name = "textBoxResult_KEE";
            this.textBoxResult_KEE.ReadOnly = true;
            this.textBoxResult_KEE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KEE.Size = new System.Drawing.Size(224, 249);
            this.textBoxResult_KEE.TabIndex = 3;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask_KEE);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(490, 227);
            this.groupBoxTask.TabIndex = 7;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask_KEE
            // 
            this.textBoxTask_KEE.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KEE.Multiline = true;
            this.textBoxTask_KEE.Name = "textBoxTask_KEE";
            this.textBoxTask_KEE.ReadOnly = true;
            this.textBoxTask_KEE.Size = new System.Drawing.Size(477, 201);
            this.textBoxTask_KEE.TabIndex = 0;
            this.textBoxTask_KEE.Text = "Протабулировать функцию f(x) на заданном диапозоне\r\nРезультат вывести в виде табл" +
    "ицы";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep_KEE);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep_KEE);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 241);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(280, 63);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конец шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Старт шага:";
            // 
            // textBoxStopStep_KEE
            // 
            this.textBoxStopStep_KEE.Location = new System.Drawing.Point(145, 33);
            this.textBoxStopStep_KEE.Name = "textBoxStopStep_KEE";
            this.textBoxStopStep_KEE.Size = new System.Drawing.Size(129, 20);
            this.textBoxStopStep_KEE.TabIndex = 1;
            this.textBoxStopStep_KEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_KEE_KeyPress);
            // 
            // textBoxStartStep_KEE
            // 
            this.textBoxStartStep_KEE.Location = new System.Drawing.Point(7, 33);
            this.textBoxStartStep_KEE.Name = "textBoxStartStep_KEE";
            this.textBoxStartStep_KEE.Size = new System.Drawing.Size(132, 20);
            this.textBoxStartStep_KEE.TabIndex = 0;
            this.textBoxStartStep_KEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_KEE_KeyPress);
            // 
            // buttonHelp_KEE
            // 
            this.buttonHelp_KEE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KEE.Location = new System.Drawing.Point(299, 241);
            this.buttonHelp_KEE.Name = "buttonHelp_KEE";
            this.buttonHelp_KEE.Size = new System.Drawing.Size(75, 53);
            this.buttonHelp_KEE.TabIndex = 2;
            this.buttonHelp_KEE.Text = "Справка";
            this.buttonHelp_KEE.UseVisualStyleBackColor = false;
            this.buttonHelp_KEE.Click += new System.EventHandler(this.buttonHelp_KEE_Click);
            // 
            // buttonDone_KEE
            // 
            this.buttonDone_KEE.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_KEE.Location = new System.Drawing.Point(374, 241);
            this.buttonDone_KEE.Name = "buttonDone_KEE";
            this.buttonDone_KEE.Size = new System.Drawing.Size(128, 54);
            this.buttonDone_KEE.TabIndex = 2;
            this.buttonDone_KEE.Text = "Выполнить";
            this.buttonDone_KEE.UseVisualStyleBackColor = false;
            this.buttonDone_KEE.Click += new System.EventHandler(this.buttonDone_KEE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 316);
            this.Controls.Add(this.buttonDone_KEE);
            this.Controls.Add(this.buttonHelp_KEE);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxResult);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 21 | Кулаков Е. Е";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult_KEE;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStopStep_KEE;
        private System.Windows.Forms.TextBox textBoxStartStep_KEE;
        private System.Windows.Forms.Button buttonHelp_KEE;
        private System.Windows.Forms.Button buttonDone_KEE;
        private System.Windows.Forms.TextBox textBoxTask_KEE;
    }
}

