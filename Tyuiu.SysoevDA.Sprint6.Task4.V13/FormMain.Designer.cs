
namespace Tyuiu.SysoevDA.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_SDA = new System.Windows.Forms.Label();
            this.textBoxVarStop_SDA = new System.Windows.Forms.TextBox();
            this.labelVarStart_SDA = new System.Windows.Forms.Label();
            this.textBoxVarStart_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxData_SDA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SDA = new System.Windows.Forms.PictureBox();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_SDA = new System.Windows.Forms.Button();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SDA.SuspendLayout();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp_SDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(381, 210);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonHelp_SDA.TabIndex = 19;
            this.buttonHelp_SDA.Text = "Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SDA.Location = new System.Drawing.Point(381, 164);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonDone_SDA.TabIndex = 18;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.chartFunction_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(512, 12);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(548, 292);
            this.groupBoxOutput_SDA.TabIndex = 17;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод данных";
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_SDA.Controls.Add(this.labelVarStop_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarStop_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.labelVarStart_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarStart_SDA);
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(12, 161);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(363, 87);
            this.groupBoxInput_SDA.TabIndex = 16;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод данных";
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
            this.groupBoxTask_SDA.Controls.Add(this.textBoxData_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(479, 131);
            this.groupBoxTask_SDA.TabIndex = 15;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxData_SDA
            // 
            this.textBoxData_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_SDA.Location = new System.Drawing.Point(19, 19);
            this.textBoxData_SDA.Multiline = true;
            this.textBoxData_SDA.Name = "textBoxData_SDA";
            this.textBoxData_SDA.Size = new System.Drawing.Size(454, 64);
            this.textBoxData_SDA.TabIndex = 0;
            this.textBoxData_SDA.Text = resources.GetString("textBoxData_SDA.Text");
            // 
            // pictureBoxFormula_SDA
            // 
            this.pictureBoxFormula_SDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SDA.Image")));
            this.pictureBoxFormula_SDA.Location = new System.Drawing.Point(101, 80);
            this.pictureBoxFormula_SDA.Name = "pictureBoxFormula_SDA";
            this.pictureBoxFormula_SDA.Size = new System.Drawing.Size(242, 41);
            this.pictureBoxFormula_SDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_SDA.TabIndex = 1;
            this.pictureBoxFormula_SDA.TabStop = false;
            // 
            // chartFunction_SDA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend4);
            this.chartFunction_SDA.Location = new System.Drawing.Point(222, 30);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series4);
            this.chartFunction_SDA.Size = new System.Drawing.Size(300, 239);
            this.chartFunction_SDA.TabIndex = 7;
            this.chartFunction_SDA.Text = "chart1";
            // 
            // buttonSave_SDA
            // 
            this.buttonSave_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave_SDA.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave_SDA.Location = new System.Drawing.Point(134, 264);
            this.buttonSave_SDA.Name = "buttonSave_SDA";
            this.buttonSave_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonSave_SDA.TabIndex = 18;
            this.buttonSave_SDA.Text = "Сохранить";
            this.buttonSave_SDA.UseVisualStyleBackColor = false;
            this.buttonSave_SDA.Click += new System.EventHandler(this.buttonSave_SDA_Click);
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Location = new System.Drawing.Point(32, 30);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(146, 239);
            this.textBoxResult_SDA.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 321);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.buttonSave_SDA);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.MinimumSize = new System.Drawing.Size(1093, 360);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 13 | Сысоев Д. А.";
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxOutput_SDA.PerformLayout();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.Label labelVarStop_SDA;
        private System.Windows.Forms.TextBox textBoxVarStop_SDA;
        private System.Windows.Forms.Label labelVarStart_SDA;
        private System.Windows.Forms.TextBox textBoxVarStart_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SDA;
        private System.Windows.Forms.TextBox textBoxData_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
        private System.Windows.Forms.Button buttonSave_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
    }
}

