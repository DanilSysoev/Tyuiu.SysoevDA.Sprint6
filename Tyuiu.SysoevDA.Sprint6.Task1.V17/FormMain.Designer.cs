
namespace Tyuiu.SysoevDA.Sprint6.Task1.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.labelVarStart_SDA = new System.Windows.Forms.Label();
            this.textBoxVarStart_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SDA = new System.Windows.Forms.PictureBox();
            this.labelVarStop_SDA = new System.Windows.Forms.Label();
            this.textBoxVarStop_SDA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_SDA.SuspendLayout();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SDA.Location = new System.Drawing.Point(381, 228);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonDone_SDA.TabIndex = 8;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(509, 22);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(290, 290);
            this.groupBoxOutput_SDA.TabIndex = 7;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод данных";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SDA.Location = new System.Drawing.Point(26, 46);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(233, 214);
            this.textBoxResult_SDA.TabIndex = 4;
            this.textBoxResult_SDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(23, 30);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SDA.TabIndex = 3;
            this.labelResult_SDA.Text = "Результат:";
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Controls.Add(this.labelVarStop_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarStop_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarStart_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarStart_SDA);
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(12, 225);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(363, 87);
            this.groupBoxInput_SDA.TabIndex = 6;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод данных";
            // 
            // labelVarStart_SDA
            // 
            this.labelVarStart_SDA.AutoSize = true;
            this.labelVarStart_SDA.Location = new System.Drawing.Point(16, 30);
            this.labelVarStart_SDA.Name = "labelVarStart_SDA";
            this.labelVarStart_SDA.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_SDA.TabIndex = 1;
            this.labelVarStart_SDA.Text = "Старт шага:";
            // 
            // textBoxVarStart_SDA
            // 
            this.textBoxVarStart_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarStart_SDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarStart_SDA.Location = new System.Drawing.Point(19, 46);
            this.textBoxVarStart_SDA.Name = "textBoxVarStart_SDA";
            this.textBoxVarStart_SDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStart_SDA.TabIndex = 0;
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.pictureBoxFormula_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(468, 193);
            this.groupBoxTask_SDA.TabIndex = 5;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // pictureBoxFormula_SDA
            // 
            this.pictureBoxFormula_SDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SDA.Image")));
            this.pictureBoxFormula_SDA.Location = new System.Drawing.Point(8, 19);
            this.pictureBoxFormula_SDA.Name = "pictureBoxFormula_SDA";
            this.pictureBoxFormula_SDA.Size = new System.Drawing.Size(440, 146);
            this.pictureBoxFormula_SDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_SDA.TabIndex = 3;
            this.pictureBoxFormula_SDA.TabStop = false;
            // 
            // labelVarStop_SDA
            // 
            this.labelVarStop_SDA.AutoSize = true;
            this.labelVarStop_SDA.Location = new System.Drawing.Point(188, 30);
            this.labelVarStop_SDA.Name = "labelVarStop_SDA";
            this.labelVarStop_SDA.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_SDA.TabIndex = 3;
            this.labelVarStop_SDA.Text = "Конец шага:";
            // 
            // textBoxVarStop_SDA
            // 
            this.textBoxVarStop_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarStop_SDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarStop_SDA.Location = new System.Drawing.Point(191, 46);
            this.textBoxVarStop_SDA.Name = "textBoxVarStop_SDA";
            this.textBoxVarStop_SDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStop_SDA.TabIndex = 2;
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(381, 274);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonHelp_SDA.TabIndex = 9;
            this.buttonHelp_SDA.Text = "Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 379);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 17 | Сысоев Д. А.";
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxOutput_SDA.PerformLayout();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.groupBoxTask_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.Label labelVarStart_SDA;
        private System.Windows.Forms.TextBox textBoxVarStart_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SDA;
        private System.Windows.Forms.Label labelVarStop_SDA;
        private System.Windows.Forms.TextBox textBoxVarStop_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
    }
}

