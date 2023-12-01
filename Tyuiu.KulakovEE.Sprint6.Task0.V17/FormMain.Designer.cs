using System;

namespace Tyuiu.KulakovEE.Sprint6.Task0.V17
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


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxNamedTwo_KEE = new System.Windows.Forms.PictureBox();
            this.groupBoxNamedTwo_KEE = new System.Windows.Forms.GroupBox();
            this.textBoxNamedFour_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxNamedThree_KEE = new System.Windows.Forms.GroupBox();
            this.groupBoxNamedSix_KEE = new System.Windows.Forms.GroupBox();
            this.nameX_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxNamedFour_KEE = new System.Windows.Forms.GroupBox();
            this.Result_KEE = new System.Windows.Forms.TextBox();
            this.groupBoxNameddTwo_KEE = new System.Windows.Forms.GroupBox();
            this.buttonNamedOne_KEE = new System.Windows.Forms.Button();
            this.buttonNamedThree_KEE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamedTwo_KEE)).BeginInit();
            this.groupBoxNamedTwo_KEE.SuspendLayout();
            this.groupBoxNamedThree_KEE.SuspendLayout();
            this.groupBoxNamedSix_KEE.SuspendLayout();
            this.groupBoxNamedFour_KEE.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxNamedTwo_KEE
            // 
            this.pictureBoxNamedTwo_KEE.ErrorImage = null;
            this.pictureBoxNamedTwo_KEE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNamedTwo_KEE.Image")));
            this.pictureBoxNamedTwo_KEE.Location = new System.Drawing.Point(508, 21);
            this.pictureBoxNamedTwo_KEE.Name = "pictureBoxNamedTwo_KEE";
            this.pictureBoxNamedTwo_KEE.Size = new System.Drawing.Size(123, 88);
            this.pictureBoxNamedTwo_KEE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNamedTwo_KEE.TabIndex = 0;
            this.pictureBoxNamedTwo_KEE.TabStop = false;
            this.pictureBoxNamedTwo_KEE.Click += new System.EventHandler(this.pictureBoxNamedTwo_KEE_Click);
            // 
            // groupBoxNamedTwo_KEE
            // 
            this.groupBoxNamedTwo_KEE.Controls.Add(this.textBoxNamedFour_KEE);
            this.groupBoxNamedTwo_KEE.Controls.Add(this.pictureBoxNamedTwo_KEE);
            this.groupBoxNamedTwo_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNamedTwo_KEE.Location = new System.Drawing.Point(12, 25);
            this.groupBoxNamedTwo_KEE.Name = "groupBoxNamedTwo_KEE";
            this.groupBoxNamedTwo_KEE.Size = new System.Drawing.Size(666, 184);
            this.groupBoxNamedTwo_KEE.TabIndex = 2;
            this.groupBoxNamedTwo_KEE.TabStop = false;
            this.groupBoxNamedTwo_KEE.Text = "Условие";
            // 
            // textBoxNamedFour_KEE
            // 
            this.textBoxNamedFour_KEE.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNamedFour_KEE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamedFour_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamedFour_KEE.Location = new System.Drawing.Point(6, 21);
            this.textBoxNamedFour_KEE.Multiline = true;
            this.textBoxNamedFour_KEE.Name = "textBoxNamedFour_KEE";
            this.textBoxNamedFour_KEE.ReadOnly = true;
            this.textBoxNamedFour_KEE.Size = new System.Drawing.Size(345, 51);
            this.textBoxNamedFour_KEE.TabIndex = 1;
            this.textBoxNamedFour_KEE.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxNamedThree_KEE
            // 
            this.groupBoxNamedThree_KEE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedThree_KEE.Controls.Add(this.groupBoxNamedSix_KEE);
            this.groupBoxNamedThree_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNamedThree_KEE.Location = new System.Drawing.Point(12, 215);
            this.groupBoxNamedThree_KEE.Name = "groupBoxNamedThree_KEE";
            this.groupBoxNamedThree_KEE.Size = new System.Drawing.Size(406, 137);
            this.groupBoxNamedThree_KEE.TabIndex = 3;
            this.groupBoxNamedThree_KEE.TabStop = false;
            this.groupBoxNamedThree_KEE.Text = "Ввод данных";
            // 
            // groupBoxNamedSix_KEE
            // 
            this.groupBoxNamedSix_KEE.Controls.Add(this.nameX_KEE);
            this.groupBoxNamedSix_KEE.Location = new System.Drawing.Point(33, 38);
            this.groupBoxNamedSix_KEE.Name = "groupBoxNamedSix_KEE";
            this.groupBoxNamedSix_KEE.Size = new System.Drawing.Size(324, 77);
            this.groupBoxNamedSix_KEE.TabIndex = 7;
            this.groupBoxNamedSix_KEE.TabStop = false;
            this.groupBoxNamedSix_KEE.Text = "Переменная X:";
            // 
            // nameX_KEE
            // 
            this.nameX_KEE.BackColor = System.Drawing.SystemColors.Menu;
            this.nameX_KEE.Location = new System.Drawing.Point(12, 39);
            this.nameX_KEE.Name = "nameX_KEE";
            this.nameX_KEE.Size = new System.Drawing.Size(306, 31);
            this.nameX_KEE.TabIndex = 1;
            this.nameX_KEE.TextChanged += new System.EventHandler(this.nameX_KEE_TextChanged);
            this.nameX_KEE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonResult_KEE_KeyPress);
            // 
            // groupBoxNamedFour_KEE
            // 
            this.groupBoxNamedFour_KEE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedFour_KEE.Controls.Add(this.Result_KEE);
            this.groupBoxNamedFour_KEE.Controls.Add(this.groupBoxNameddTwo_KEE);
            this.groupBoxNamedFour_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNamedFour_KEE.Location = new System.Drawing.Point(424, 215);
            this.groupBoxNamedFour_KEE.Name = "groupBoxNamedFour_KEE";
            this.groupBoxNamedFour_KEE.Size = new System.Drawing.Size(254, 137);
            this.groupBoxNamedFour_KEE.TabIndex = 4;
            this.groupBoxNamedFour_KEE.TabStop = false;
            this.groupBoxNamedFour_KEE.Text = "Вывод данных";
            // 
            // Result_KEE
            // 
            this.Result_KEE.BackColor = System.Drawing.SystemColors.Menu;
            this.Result_KEE.Location = new System.Drawing.Point(37, 77);
            this.Result_KEE.Name = "Result_KEE";
            this.Result_KEE.ReadOnly = true;
            this.Result_KEE.Size = new System.Drawing.Size(182, 31);
            this.Result_KEE.TabIndex = 2;
            // 
            // groupBoxNameddTwo_KEE
            // 
            this.groupBoxNameddTwo_KEE.Location = new System.Drawing.Point(24, 38);
            this.groupBoxNameddTwo_KEE.Name = "groupBoxNameddTwo_KEE";
            this.groupBoxNameddTwo_KEE.Size = new System.Drawing.Size(210, 77);
            this.groupBoxNameddTwo_KEE.TabIndex = 3;
            this.groupBoxNameddTwo_KEE.TabStop = false;
            this.groupBoxNameddTwo_KEE.Text = "Результат";
            // 
            // buttonNamedOne_KEE
            // 
            this.buttonNamedOne_KEE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNamedOne_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamedOne_KEE.ForeColor = System.Drawing.Color.Black;
            this.buttonNamedOne_KEE.Location = new System.Drawing.Point(490, 371);
            this.buttonNamedOne_KEE.Name = "buttonNamedOne_KEE";
            this.buttonNamedOne_KEE.Size = new System.Drawing.Size(168, 40);
            this.buttonNamedOne_KEE.TabIndex = 0;
            this.buttonNamedOne_KEE.Text = "Выполнить";
            this.buttonNamedOne_KEE.UseVisualStyleBackColor = false;
            this.buttonNamedOne_KEE.Click += new System.EventHandler(this.buttonResult_KEE_Click);
            // 
            // buttonNamedThree_KEE
            // 
            this.buttonNamedThree_KEE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNamedThree_KEE.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamedThree_KEE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNamedThree_KEE.Location = new System.Drawing.Point(425, 371);
            this.buttonNamedThree_KEE.Name = "buttonNamedThree_KEE";
            this.buttonNamedThree_KEE.Size = new System.Drawing.Size(54, 39);
            this.buttonNamedThree_KEE.TabIndex = 6;
            this.buttonNamedThree_KEE.Text = "? ";
            this.buttonNamedThree_KEE.UseVisualStyleBackColor = false;
            this.buttonNamedThree_KEE.Click += new System.EventHandler(this.buttonHelp_KEE_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.buttonNamedThree_KEE);
            this.Controls.Add(this.buttonNamedOne_KEE);
            this.Controls.Add(this.groupBoxNamedFour_KEE);
            this.Controls.Add(this.groupBoxNamedThree_KEE);
            this.Controls.Add(this.groupBoxNamedTwo_KEE);
            this.Font = new System.Drawing.Font("Cattedrale [RUS by penka220]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 17 | Кулаков Е. Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamedTwo_KEE)).EndInit();
            this.groupBoxNamedTwo_KEE.ResumeLayout(false);
            this.groupBoxNamedTwo_KEE.PerformLayout();
            this.groupBoxNamedThree_KEE.ResumeLayout(false);
            this.groupBoxNamedSix_KEE.ResumeLayout(false);
            this.groupBoxNamedSix_KEE.PerformLayout();
            this.groupBoxNamedFour_KEE.ResumeLayout(false);
            this.groupBoxNamedFour_KEE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxNamedTwo_KEE;
        private System.Windows.Forms.GroupBox groupBoxNamedTwo_KEE;
        private System.Windows.Forms.GroupBox groupBoxNamedThree_KEE;
        private System.Windows.Forms.GroupBox groupBoxNamedFour_KEE;
        private System.Windows.Forms.Button buttonNamedOne_KEE;
        private System.Windows.Forms.Button buttonNamedThree_KEE;
        private System.Windows.Forms.TextBox nameX_KEE;
        private System.Windows.Forms.GroupBox groupBoxNamedSix_KEE;
        private System.Windows.Forms.TextBox textBoxNamedFour_KEE;
        private System.Windows.Forms.GroupBox groupBoxNameddTwo_KEE;
        private System.Windows.Forms.TextBox Result_KEE;
    }
}