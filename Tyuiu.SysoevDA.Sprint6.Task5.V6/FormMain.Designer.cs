
namespace Tyuiu.SysoevDA.Sprint6.Task5.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxData_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_SDA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonFile_SDA = new System.Windows.Forms.Button();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxOutput_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.buttonHelp_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.buttonFile_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.buttonDone_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.textBoxData_SDA);
            this.groupBoxTask_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(881, 84);
            this.groupBoxTask_SDA.TabIndex = 20;
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
            this.textBoxData_SDA.Size = new System.Drawing.Size(454, 38);
            this.textBoxData_SDA.TabIndex = 0;
            this.textBoxData_SDA.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView. Дан списо" +
    "к из 20 чисел. Вывести все числа, кратные 3. Построить диаграмму по этим значени" +
    "ям.";
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Controls.Add(this.chartFunction_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.dataGridViewFunction_SDA);
            this.groupBoxOutput_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(0, 84);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(881, 366);
            this.groupBoxOutput_SDA.TabIndex = 26;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_SDA
            // 
            this.dataGridViewFunction_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SDA.ColumnHeadersVisible = false;
            this.dataGridViewFunction_SDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewFunction_SDA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFunction_SDA.Name = "dataGridViewFunction_SDA";
            this.dataGridViewFunction_SDA.RowHeadersVisible = false;
            this.dataGridViewFunction_SDA.Size = new System.Drawing.Size(100, 347);
            this.dataGridViewFunction_SDA.TabIndex = 6;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_SDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea1);
            this.chartFunction_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend1);
            this.chartFunction_SDA.Location = new System.Drawing.Point(103, 16);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawSideBySide=True, DrawingStyle=LightToDark, MaxPixelPointWidth=100";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series1);
            this.chartFunction_SDA.Size = new System.Drawing.Size(775, 347);
            this.chartFunction_SDA.TabIndex = 7;
            this.chartFunction_SDA.Text = "chart1";
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SDA.Location = new System.Drawing.Point(479, 19);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(120, 50);
            this.buttonDone_SDA.TabIndex = 26;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonFile_SDA
            // 
            this.buttonFile_SDA.BackColor = System.Drawing.Color.Yellow;
            this.buttonFile_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFile_SDA.Location = new System.Drawing.Point(605, 19);
            this.buttonFile_SDA.Name = "buttonFile_SDA";
            this.buttonFile_SDA.Size = new System.Drawing.Size(120, 50);
            this.buttonFile_SDA.TabIndex = 27;
            this.buttonFile_SDA.Text = "Открыть файл";
            this.buttonFile_SDA.UseVisualStyleBackColor = false;
            this.buttonFile_SDA.Click += new System.EventHandler(this.buttonFile_SDA_Click);
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(731, 19);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(120, 50);
            this.buttonHelp_SDA.TabIndex = 28;
            this.buttonHelp_SDA.Text = "Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 | Сысоев Д. А.";
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxOutput_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxData_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonFile_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
    }
}

