
namespace Tyuiu.SysoevDA.Sprint6.Task7.V28
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
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.buttonFile_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxData_SDA = new System.Windows.Forms.TextBox();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.dataGridViewIn_SDA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_SDA = new System.Windows.Forms.DataGridView();
            this.toolTip_SDA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_SDA = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave_SDA = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_SDA = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxOutput_SDA.SuspendLayout();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SDA.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SDA.Image")));
            this.buttonHelp_SDA.Location = new System.Drawing.Point(785, 2);
            this.buttonHelp_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonHelp_SDA.TabIndex = 32;
            this.toolTip_SDA.SetToolTip(this.buttonHelp_SDA, "Сведение о программе");
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_SDA.Controls.Add(this.dataGridViewOut_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(444, 144);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(444, 304);
            this.groupBoxOutput_SDA.TabIndex = 33;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод:";
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_SDA.Controls.Add(this.dataGridViewIn_SDA);
            this.groupBoxInput_SDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(0, 144);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(444, 304);
            this.groupBoxInput_SDA.TabIndex = 34;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод:";
            // 
            // buttonFile_SDA
            // 
            this.buttonFile_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile_SDA.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonFile_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile_SDA.Image")));
            this.buttonFile_SDA.Location = new System.Drawing.Point(5, 2);
            this.buttonFile_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFile_SDA.Name = "buttonFile_SDA";
            this.buttonFile_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonFile_SDA.TabIndex = 30;
            this.toolTip_SDA.SetToolTip(this.buttonFile_SDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonFile_SDA.UseVisualStyleBackColor = false;
            this.buttonFile_SDA.Click += new System.EventHandler(this.buttonFile_SDA_Click);
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_SDA.Controls.Add(this.textBoxData_SDA);
            this.groupBoxTask_SDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(0, 54);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(888, 103);
            this.groupBoxTask_SDA.TabIndex = 31;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxData_SDA
            // 
            this.textBoxData_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_SDA.Location = new System.Drawing.Point(27, 19);
            this.textBoxData_SDA.Multiline = true;
            this.textBoxData_SDA.Name = "textBoxData_SDA";
            this.textBoxData_SDA.Size = new System.Drawing.Size(848, 59);
            this.textBoxData_SDA.TabIndex = 0;
            this.textBoxData_SDA.Text = resources.GetString("textBoxData_SDA.Text");
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_SDA.Enabled = false;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SDA.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SDA.Image")));
            this.buttonDone_SDA.Location = new System.Drawing.Point(105, 2);
            this.buttonDone_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonDone_SDA.TabIndex = 29;
            this.toolTip_SDA.SetToolTip(this.buttonDone_SDA, "Изменить в седьмой строке числа не равные 13 на 0");
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // dataGridViewIn_SDA
            // 
            this.dataGridViewIn_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewIn_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SDA.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewIn_SDA.Name = "dataGridViewIn_SDA";
            this.dataGridViewIn_SDA.Size = new System.Drawing.Size(426, 276);
            this.dataGridViewIn_SDA.TabIndex = 0;
            // 
            // dataGridViewOut_SDA
            // 
            this.dataGridViewOut_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOut_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SDA.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewOut_SDA.Name = "dataGridViewOut_SDA";
            this.dataGridViewOut_SDA.Size = new System.Drawing.Size(426, 276);
            this.dataGridViewOut_SDA.TabIndex = 0;
            // 
            // toolTip_SDA
            // 
            this.toolTip_SDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SDA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_SDA
            // 
            this.openFileDialogTask_SDA.FileName = "openFileDialog1";
            // 
            // buttonSave_SDA
            // 
            this.buttonSave_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave_SDA.Enabled = false;
            this.buttonSave_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SDA.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonSave_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SDA.Image")));
            this.buttonSave_SDA.Location = new System.Drawing.Point(205, 2);
            this.buttonSave_SDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave_SDA.Name = "buttonSave_SDA";
            this.buttonSave_SDA.Size = new System.Drawing.Size(90, 50);
            this.buttonSave_SDA.TabIndex = 29;
            this.toolTip_SDA.SetToolTip(this.buttonSave_SDA, "Сохранить в файл\r\nСохранить обработанные данные в файл в формате CSV\r\n\r\n");
            this.buttonSave_SDA.UseVisualStyleBackColor = false;
            this.buttonSave_SDA.Click += new System.EventHandler(this.buttonSave_SDA_Click);
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
            this.Controls.Add(this.buttonSave_SDA);
            this.Controls.Add(this.buttonDone_SDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Сысоев Д. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.Button buttonFile_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxData_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.DataGridView dataGridViewOut_SDA;
        private System.Windows.Forms.DataGridView dataGridViewIn_SDA;
        private System.Windows.Forms.ToolTip toolTip_SDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SDA;
        private System.Windows.Forms.Button buttonSave_SDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SDA;
    }
}

