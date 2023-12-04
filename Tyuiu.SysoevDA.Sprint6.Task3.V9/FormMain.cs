using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SysoevDA.Sprint6.Task3.V9.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТБ-23-1 Сысоев Данил Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {

                string strLine;
                

                int[,] valueArray;
                valueArray = new int[4,4];
                int[,] array = { { -14, 25, 26, 18, 17 },
                             { 28, 10,  6, -2, 4},
                             { 30, 25, -3, 11, -10},
                             { 11, 32, -5, -20, 25 },
                             { 2, -18, 11, 8, -20 } };
                valueArray = ds.Calculate(array);

                for (int i = 0; i < 5; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(valueArray[i, 0]), Convert.ToString(valueArray[i, 1]), Convert.ToString(valueArray[i, 2]), Convert.ToString(valueArray[i, 3]), Convert.ToString(valueArray[i, 4]));
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
