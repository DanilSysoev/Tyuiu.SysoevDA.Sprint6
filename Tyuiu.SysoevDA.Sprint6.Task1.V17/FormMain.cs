using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SysoevDA.Sprint6.Task1.V17.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task1.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_SDA.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_SDA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_SDA.Text = "";

                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SDA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SDA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТБ-23-1 Сысоев Данил Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
