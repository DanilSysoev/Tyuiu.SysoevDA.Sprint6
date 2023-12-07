
namespace Tyuiu.SysoevDA.Sprint6.Task6.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.openFileDialogTask_SDA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SDA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.textBoxData_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.buttonFile_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxOutput_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SDA.Image")));
            this.buttonHelp_SDA.Location = new System.Drawing.Point(785, 5);
            this.buttonHelp_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonHelp_SDA.TabIndex = 28;
            this.toolTip_SDA.SetToolTip(this.buttonHelp_SDA, "Сведение о программе");
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // openFileDialogTask_SDA
            // 
            this.openFileDialogTask_SDA.FileName = "openFileDialog1";
            // 
            // toolTip_SDA
            // 
            this.toolTip_SDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SDA.ToolTipTitle = "Подсказка";
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_SDA.Enabled = false;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SDA.Image")));
            this.buttonDone_SDA.Location = new System.Drawing.Point(101, 5);
            this.buttonDone_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonDone_SDA.TabIndex = 26;
            this.toolTip_SDA.SetToolTip(this.buttonDone_SDA, "Выводит слова в которых встречается n.");
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // textBoxData_SDA
            // 
            this.textBoxData_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_SDA.Location = new System.Drawing.Point(19, 19);
            this.textBoxData_SDA.Multiline = true;
            this.textBoxData_SDA.Name = "textBoxData_SDA";
            this.textBoxData_SDA.Size = new System.Drawing.Size(848, 59);
            this.textBoxData_SDA.TabIndex = 0;
            this.textBoxData_SDA.Text = resources.GetString("textBoxData_SDA.Text");
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_SDA.Controls.Add(this.textBoxData_SDA);
            this.groupBoxTask_SDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(0, 57);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(888, 103);
            this.groupBoxTask_SDA.TabIndex = 27;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxLoadFromFile_SDA
            // 
            this.textBoxLoadFromFile_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLoadFromFile_SDA.Location = new System.Drawing.Point(12, 19);
            this.textBoxLoadFromFile_SDA.Multiline = true;
            this.textBoxLoadFromFile_SDA.Name = "textBoxLoadFromFile_SDA";
            this.textBoxLoadFromFile_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_SDA.Size = new System.Drawing.Size(426, 266);
            this.textBoxLoadFromFile_SDA.TabIndex = 0;
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_SDA.Controls.Add(this.textBoxLoadFromFile_SDA);
            this.groupBoxInput_SDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(0, 147);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(444, 304);
            this.groupBoxInput_SDA.TabIndex = 28;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод:";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_SDA.Location = new System.Drawing.Point(12, 19);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(426, 266);
            this.textBoxResult_SDA.TabIndex = 0;
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(444, 147);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(444, 304);
            this.groupBoxOutput_SDA.TabIndex = 28;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод:";
            // 
            // buttonFile_SDA
            // 
            this.buttonFile_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile_SDA.Image")));
            this.buttonFile_SDA.Location = new System.Drawing.Point(5, 5);
            this.buttonFile_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFile_SDA.Name = "buttonFile_SDA";
            this.buttonFile_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonFile_SDA.TabIndex = 27;
            this.toolTip_SDA.SetToolTip(this.buttonFile_SDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonFile_SDA.UseVisualStyleBackColor = false;
            this.buttonFile_SDA.Click += new System.EventHandler(this.buttonFile_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 451);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.buttonFile_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.Controls.Add(this.buttonDone_SDA);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Сысоев Д. А.";
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxOutput_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SDA;
        private System.Windows.Forms.ToolTip toolTip_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.TextBox textBoxData_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.Button buttonFile_SDA;
    }
}

