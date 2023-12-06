using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SysoevDA.Sprint6.Task5.V6.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        public string path = @"C:\DataSprint6\InPutFileTask5V6.txt";
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                
                string strLine;
                int len = ds.LoadFromDataFile(path).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.LoadFromDataFile(path);

                this.chartFunction_SDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SDA.ChartAreas[0].AxisY.Title = "Ось Y";
                chartFunction_SDA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                    this.chartFunction_SDA.Series[0].Points.AddXY(i, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТБ-23-1 Сысоев Данил Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFile_SDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
