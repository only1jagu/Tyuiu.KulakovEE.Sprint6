
namespace Tyuiu.KulakovEE.Sprint6.Task3.V9
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
            this.buttonResult_KEE = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask_KEE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEE = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_KEE = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_KEE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KEE = new System.Windows.Forms.TextBox();
            this.textBoxTextRes_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KEE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KEE)).BeginInit();
            this.groupBoxResult_KEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonResult_KEE
            // 
            this.buttonResult_KEE.Location = new System.Drawing.Point(274, 249);
            this.buttonResult_KEE.Name = "buttonResult_KEE";
            this.buttonResult_KEE.Size = new System.Drawing.Size(145, 40);
            this.buttonResult_KEE.TabIndex = 0;
            this.buttonResult_KEE.Text = "Выполнить";
            this.buttonResult_KEE.UseVisualStyleBackColor = true;
            this.buttonResult_KEE.Click += new System.EventHandler(this.buttonResult_KEE_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(216, 249);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 40);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTask_KEE
            // 
            this.groupBoxTask_KEE.Controls.Add(this.groupBoxResult_KEE);
            this.groupBoxTask_KEE.Controls.Add(this.buttonResult_KEE);
            this.groupBoxTask_KEE.Controls.Add(this.buttonHelp);
            this.groupBoxTask_KEE.Controls.Add(this.textBoxTask_KEE);
            this.groupBoxTask_KEE.Controls.Add(this.dataGridViewMatrix_KEE);
            this.groupBoxTask_KEE.Font = new System.Drawing.Font("TL header RUS", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KEE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KEE.Name = "groupBoxTask_KEE";
            this.groupBoxTask_KEE.Size = new System.Drawing.Size(450, 298);
            this.groupBoxTask_KEE.TabIndex = 2;
            this.groupBoxTask_KEE.TabStop = false;
            this.groupBoxTask_KEE.Text = "Условие";
            // 
            // textBoxTask_KEE
            // 
            this.textBoxTask_KEE.Font = new System.Drawing.Font("TL header RUS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KEE.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KEE.Multiline = true;
            this.textBoxTask_KEE.Name = "textBoxTask_KEE";
            this.textBoxTask_KEE.ReadOnly = true;
            this.textBoxTask_KEE.Size = new System.Drawing.Size(413, 145);
            this.textBoxTask_KEE.TabIndex = 1;
            this.textBoxTask_KEE.Text = "Дана матрица 5 на 5:\r\n-14 25 26 18  17\r\n 28 10  6   -2   4\r\n 30 25 -3  11 -10\r\n 1" +
    "1 32 -5 -20  25\r\n 2 -18  11   8 -20\r\n Выполнить сортировку по возрастанию в пято" +
    "м столбце.";
            // 
            // dataGridViewMatrix_KEE
            // 
            this.dataGridViewMatrix_KEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KEE.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KEE.Location = new System.Drawing.Point(43, 170);
            this.dataGridViewMatrix_KEE.Name = "dataGridViewMatrix_KEE";
            this.dataGridViewMatrix_KEE.RowHeadersVisible = false;
            this.dataGridViewMatrix_KEE.Size = new System.Drawing.Size(137, 119);
            this.dataGridViewMatrix_KEE.TabIndex = 0;
            this.dataGridViewMatrix_KEE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_KEE_CellContentClick);
            // 
            // groupBoxResult_KEE
            // 
            this.groupBoxResult_KEE.Controls.Add(this.textBoxResult_KEE);
            this.groupBoxResult_KEE.Controls.Add(this.textBoxTextRes_KEE);
            this.groupBoxResult_KEE.Font = new System.Drawing.Font("TL header RUS", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_KEE.Location = new System.Drawing.Point(216, 170);
            this.groupBoxResult_KEE.Name = "groupBoxResult_KEE";
            this.groupBoxResult_KEE.Size = new System.Drawing.Size(203, 73);
            this.groupBoxResult_KEE.TabIndex = 3;
            this.groupBoxResult_KEE.TabStop = false;
            this.groupBoxResult_KEE.Text = "Вывод данных";
            // 
            // textBoxResult_KEE
            // 
            this.textBoxResult_KEE.Location = new System.Drawing.Point(6, 45);
            this.textBoxResult_KEE.Name = "textBoxResult_KEE";
            this.textBoxResult_KEE.ReadOnly = true;
            this.textBoxResult_KEE.Size = new System.Drawing.Size(191, 19);
            this.textBoxResult_KEE.TabIndex = 1;
            // 
            // textBoxTextRes_KEE
            // 
            this.textBoxTextRes_KEE.Location = new System.Drawing.Point(6, 19);
            this.textBoxTextRes_KEE.Name = "textBoxTextRes_KEE";
            this.textBoxTextRes_KEE.ReadOnly = true;
            this.textBoxTextRes_KEE.Size = new System.Drawing.Size(191, 19);
            this.textBoxTextRes_KEE.TabIndex = 0;
            this.textBoxTextRes_KEE.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 313);
            this.Controls.Add(this.groupBoxTask_KEE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Кулаков Е.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KEE.ResumeLayout(false);
            this.groupBoxTask_KEE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KEE)).EndInit();
            this.groupBoxResult_KEE.ResumeLayout(false);
            this.groupBoxResult_KEE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_KEE;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTask_KEE;
        private System.Windows.Forms.TextBox textBoxTask_KEE;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KEE;
        private System.Windows.Forms.GroupBox groupBoxResult_KEE;
        private System.Windows.Forms.TextBox textBoxResult_KEE;
        private System.Windows.Forms.TextBox textBoxTextRes_KEE;
    }
}

