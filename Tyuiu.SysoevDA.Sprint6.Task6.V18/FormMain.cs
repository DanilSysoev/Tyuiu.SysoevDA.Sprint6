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

using Tyuiu.SysoevDA.Sprint6.Task6.V18.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_SDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SDA.ShowDialog();
            openFilePath = openFileDialogTask_SDA.FileName;
            textBoxLoadFromFile_SDA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_SDA.Text = groupBoxInput_SDA.Text + " " + openFileDialogTask_SDA.FileName;
            buttonDone_SDA.Enabled = true;
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            string str = "n";
            textBoxResult_SDA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
