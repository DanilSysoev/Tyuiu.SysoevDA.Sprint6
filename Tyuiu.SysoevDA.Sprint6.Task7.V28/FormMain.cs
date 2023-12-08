using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.SysoevDA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for(int c = 0; c < columns;c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFile_SDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SDA.ShowDialog();
            openFilePath = openFileDialogTask_SDA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_SDA.ColumnCount = columns;
            dataGridViewIn_SDA.RowCount = rows;
            dataGridViewOut_SDA.ColumnCount = columns;
            dataGridViewOut_SDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_SDA.Columns[i].Width = 25;
                dataGridViewOut_SDA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_SDA.Enabled = true;
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SDA.Enabled = true;
        }

        private void buttonSave_SDA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SDA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SDA.ShowDialog();

            string path = saveFileDialogMatrix_SDA.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_SDA.RowCount;
            int columns = dataGridViewOut_SDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j!= columns - 1)
                    {
                        str = str + dataGridViewOut_SDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_SDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_SDA.ColumnCount = 50;
            dataGridViewOut_SDA.ColumnCount = 50;

            dataGridViewIn_SDA.RowCount = 50;
            dataGridViewOut_SDA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_SDA.Columns[i].Width = 25;
                dataGridViewOut_SDA.Columns[i].Width = 25;
            }
        }
    }
}
