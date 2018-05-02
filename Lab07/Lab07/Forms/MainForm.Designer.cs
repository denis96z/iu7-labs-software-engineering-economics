﻿namespace Lab07.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcPages = new System.Windows.Forms.TabControl();
            this.tpProjectParameters = new System.Windows.Forms.TabPage();
            this.nudSLOC = new System.Windows.Forms.NumericUpDown();
            this.lblKSLOC = new System.Windows.Forms.Label();
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.dgvFactorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFactorsLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFactorsComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFactors = new System.Windows.Forms.Label();
            this.dgvProductParameters = new System.Windows.Forms.DataGridView();
            this.dgvProductParametersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductParametersValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductParameters = new System.Windows.Forms.Label();
            this.dgvLaborCoeffs = new System.Windows.Forms.DataGridView();
            this.dgvLaborCoeffsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLaborCoeffsValue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblLaborCoeffs = new System.Windows.Forms.Label();
            this.tpProjectWorks = new System.Windows.Forms.TabPage();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.miRevert = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine3 = new System.Windows.Forms.ToolStripSeparator();
            this.miCut = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.lblTotalLabor = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.tcPages.SuspendLayout();
            this.tpProjectParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborCoeffs)).BeginInit();
            this.msMainMenu.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPages
            // 
            this.tcPages.Controls.Add(this.tpProjectParameters);
            this.tcPages.Controls.Add(this.tpProjectWorks);
            this.tcPages.Controls.Add(this.tpResults);
            this.tcPages.Location = new System.Drawing.Point(12, 27);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(760, 522);
            this.tcPages.TabIndex = 0;
            // 
            // tpProjectParameters
            // 
            this.tpProjectParameters.Controls.Add(this.nudSLOC);
            this.tpProjectParameters.Controls.Add(this.lblKSLOC);
            this.tpProjectParameters.Controls.Add(this.dgvFactors);
            this.tpProjectParameters.Controls.Add(this.lblFactors);
            this.tpProjectParameters.Controls.Add(this.dgvProductParameters);
            this.tpProjectParameters.Controls.Add(this.lblProductParameters);
            this.tpProjectParameters.Controls.Add(this.dgvLaborCoeffs);
            this.tpProjectParameters.Controls.Add(this.lblLaborCoeffs);
            this.tpProjectParameters.Location = new System.Drawing.Point(4, 22);
            this.tpProjectParameters.Name = "tpProjectParameters";
            this.tpProjectParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjectParameters.Size = new System.Drawing.Size(752, 496);
            this.tpProjectParameters.TabIndex = 0;
            this.tpProjectParameters.Text = "Параметры";
            this.tpProjectParameters.UseVisualStyleBackColor = true;
            // 
            // nudSLOC
            // 
            this.nudSLOC.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSLOC.Location = new System.Drawing.Point(9, 19);
            this.nudSLOC.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSLOC.Name = "nudSLOC";
            this.nudSLOC.Size = new System.Drawing.Size(259, 20);
            this.nudSLOC.TabIndex = 7;
            this.nudSLOC.ValueChanged += new System.EventHandler(this.NudSLOC_ValueChanged);
            // 
            // lblKSLOC
            // 
            this.lblKSLOC.AutoSize = true;
            this.lblKSLOC.Location = new System.Drawing.Point(6, 3);
            this.lblKSLOC.Name = "lblKSLOC";
            this.lblKSLOC.Size = new System.Drawing.Size(38, 13);
            this.lblKSLOC.TabIndex = 6;
            this.lblKSLOC.Text = "SLOC:";
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFactorsName,
            this.dgvFactorsLevel,
            this.dgvFactorsComment});
            this.dgvFactors.Location = new System.Drawing.Point(9, 315);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.Size = new System.Drawing.Size(737, 175);
            this.dgvFactors.TabIndex = 5;
            this.dgvFactors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFactors_CellEndEdit);
            // 
            // dgvFactorsName
            // 
            this.dgvFactorsName.HeaderText = "Название";
            this.dgvFactorsName.Name = "dgvFactorsName";
            this.dgvFactorsName.ReadOnly = true;
            // 
            // dgvFactorsLevel
            // 
            this.dgvFactorsLevel.HeaderText = "Уровень";
            this.dgvFactorsLevel.Name = "dgvFactorsLevel";
            // 
            // dgvFactorsComment
            // 
            this.dgvFactorsComment.HeaderText = "Пояснение";
            this.dgvFactorsComment.Name = "dgvFactorsComment";
            this.dgvFactorsComment.ReadOnly = true;
            this.dgvFactorsComment.Width = 450;
            // 
            // lblFactors
            // 
            this.lblFactors.AutoSize = true;
            this.lblFactors.Location = new System.Drawing.Point(6, 299);
            this.lblFactors.Name = "lblFactors";
            this.lblFactors.Size = new System.Drawing.Size(58, 13);
            this.lblFactors.TabIndex = 4;
            this.lblFactors.Text = "Факторы:";
            // 
            // dgvProductParameters
            // 
            this.dgvProductParameters.AllowUserToAddRows = false;
            this.dgvProductParameters.AllowUserToDeleteRows = false;
            this.dgvProductParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductParametersName,
            this.dgvProductParametersValue});
            this.dgvProductParameters.Location = new System.Drawing.Point(274, 19);
            this.dgvProductParameters.Name = "dgvProductParameters";
            this.dgvProductParameters.Size = new System.Drawing.Size(472, 277);
            this.dgvProductParameters.TabIndex = 3;
            this.dgvProductParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductParameters_CellEndEdit);
            // 
            // dgvProductParametersName
            // 
            this.dgvProductParametersName.HeaderText = "Название";
            this.dgvProductParametersName.Name = "dgvProductParametersName";
            this.dgvProductParametersName.ReadOnly = true;
            this.dgvProductParametersName.Width = 250;
            // 
            // dgvProductParametersValue
            // 
            this.dgvProductParametersValue.HeaderText = "Значение";
            this.dgvProductParametersValue.Name = "dgvProductParametersValue";
            // 
            // lblProductParameters
            // 
            this.lblProductParameters.AutoSize = true;
            this.lblProductParameters.Location = new System.Drawing.Point(271, 3);
            this.lblProductParameters.Name = "lblProductParameters";
            this.lblProductParameters.Size = new System.Drawing.Size(142, 13);
            this.lblProductParameters.TabIndex = 2;
            this.lblProductParameters.Text = "Характеристики продукта:";
            // 
            // dgvLaborCoeffs
            // 
            this.dgvLaborCoeffs.AllowUserToAddRows = false;
            this.dgvLaborCoeffs.AllowUserToDeleteRows = false;
            this.dgvLaborCoeffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaborCoeffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLaborCoeffsName,
            this.dgvLaborCoeffsValue});
            this.dgvLaborCoeffs.Location = new System.Drawing.Point(9, 58);
            this.dgvLaborCoeffs.Name = "dgvLaborCoeffs";
            this.dgvLaborCoeffs.Size = new System.Drawing.Size(259, 238);
            this.dgvLaborCoeffs.TabIndex = 1;
            this.dgvLaborCoeffs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaborCoeffs_CellEndEdit);
            // 
            // dgvLaborCoeffsName
            // 
            this.dgvLaborCoeffsName.HeaderText = "Название";
            this.dgvLaborCoeffsName.Name = "dgvLaborCoeffsName";
            this.dgvLaborCoeffsName.ReadOnly = true;
            // 
            // dgvLaborCoeffsValue
            // 
            this.dgvLaborCoeffsValue.HeaderText = "Уровень";
            this.dgvLaborCoeffsValue.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Нормальный",
            "Высокий",
            "Очень высокий",
            "Сверхвысокий"});
            this.dgvLaborCoeffsValue.Name = "dgvLaborCoeffsValue";
            // 
            // lblLaborCoeffs
            // 
            this.lblLaborCoeffs.AutoSize = true;
            this.lblLaborCoeffs.Location = new System.Drawing.Point(6, 42);
            this.lblLaborCoeffs.Name = "lblLaborCoeffs";
            this.lblLaborCoeffs.Size = new System.Drawing.Size(142, 13);
            this.lblLaborCoeffs.TabIndex = 0;
            this.lblLaborCoeffs.Text = "Множители трудоемкости:";
            // 
            // tpProjectWorks
            // 
            this.tpProjectWorks.Location = new System.Drawing.Point(4, 22);
            this.tpProjectWorks.Name = "tpProjectWorks";
            this.tpProjectWorks.Size = new System.Drawing.Size(752, 496);
            this.tpProjectWorks.TabIndex = 1;
            this.tpProjectWorks.Text = "Распределение";
            this.tpProjectWorks.UseVisualStyleBackColor = true;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miView,
            this.miHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(784, 24);
            this.msMainMenu.TabIndex = 1;
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miLine1,
            this.miSave,
            this.miSaveAs,
            this.miLine2,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(162, 22);
            this.miNew.Text = "Создать";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(162, 22);
            this.miOpen.Text = "Открыть";
            // 
            // miLine1
            // 
            this.miLine1.Name = "miLine1";
            this.miLine1.Size = new System.Drawing.Size(159, 6);
            // 
            // miSave
            // 
            this.miSave.Enabled = false;
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(162, 22);
            this.miSave.Text = "Сохранить";
            // 
            // miSaveAs
            // 
            this.miSaveAs.Enabled = false;
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(162, 22);
            this.miSaveAs.Text = "Сохранить как...";
            // 
            // miLine2
            // 
            this.miLine2.Name = "miLine2";
            this.miLine2.Size = new System.Drawing.Size(159, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(162, 22);
            this.miExit.Text = "Выход";
            // 
            // miEdit
            // 
            this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCancel,
            this.miRevert,
            this.miLine3,
            this.miCut,
            this.miCopy,
            this.miPaste,
            this.miDelete});
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(59, 20);
            this.miEdit.Text = "Правка";
            // 
            // miCancel
            // 
            this.miCancel.Enabled = false;
            this.miCancel.Name = "miCancel";
            this.miCancel.Size = new System.Drawing.Size(139, 22);
            this.miCancel.Text = "Отменить";
            // 
            // miRevert
            // 
            this.miRevert.Enabled = false;
            this.miRevert.Name = "miRevert";
            this.miRevert.Size = new System.Drawing.Size(139, 22);
            this.miRevert.Text = "Вернуть";
            // 
            // miLine3
            // 
            this.miLine3.Name = "miLine3";
            this.miLine3.Size = new System.Drawing.Size(136, 6);
            // 
            // miCut
            // 
            this.miCut.Enabled = false;
            this.miCut.Name = "miCut";
            this.miCut.Size = new System.Drawing.Size(139, 22);
            this.miCut.Text = "Вырезать";
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(139, 22);
            this.miCopy.Text = "Копировать";
            // 
            // miPaste
            // 
            this.miPaste.Enabled = false;
            this.miPaste.Name = "miPaste";
            this.miPaste.Size = new System.Drawing.Size(139, 22);
            this.miPaste.Text = "Вставить";
            // 
            // miDelete
            // 
            this.miDelete.Enabled = false;
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(139, 22);
            this.miDelete.Text = "Удалить";
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSettings});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(39, 20);
            this.miView.Text = "Вид";
            // 
            // miSettings
            // 
            this.miSettings.Enabled = false;
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(211, 22);
            this.miSettings.Text = "Настройки отображения";
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShowHelp,
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(65, 20);
            this.miHelp.Text = "Справка";
            // 
            // miShowHelp
            // 
            this.miShowHelp.Enabled = false;
            this.miShowHelp.Name = "miShowHelp";
            this.miShowHelp.Size = new System.Drawing.Size(179, 22);
            this.miShowHelp.Text = "Просмотр справки";
            // 
            // miAbout
            // 
            this.miAbout.Enabled = false;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(179, 22);
            this.miAbout.Text = "О программе";
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.lblTotalTime);
            this.tpResults.Controls.Add(this.lblTotalLabor);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Size = new System.Drawing.Size(752, 496);
            this.tpResults.TabIndex = 2;
            this.tpResults.Text = "Результаты";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // lblTotalLabor
            // 
            this.lblTotalLabor.AutoSize = true;
            this.lblTotalLabor.Location = new System.Drawing.Point(16, 18);
            this.lblTotalLabor.Name = "lblTotalLabor";
            this.lblTotalLabor.Size = new System.Drawing.Size(176, 13);
            this.lblTotalLabor.TabIndex = 0;
            this.lblTotalLabor.Text = "Общая трудоемкость (чел./мес.):";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(19, 50);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(112, 13);
            this.lblTotalTime.TabIndex = 1;
            this.lblTotalTime.Text = "Общее время (мес.):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tcPages);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №7";
            this.tcPages.ResumeLayout(false);
            this.tpProjectParameters.ResumeLayout(false);
            this.tpProjectParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborCoeffs)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tpResults.ResumeLayout(false);
            this.tpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tpProjectParameters;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miCancel;
        private System.Windows.Forms.ToolStripMenuItem miRevert;
        private System.Windows.Forms.ToolStripMenuItem miCut;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ToolStripMenuItem miPaste;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miShowHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripSeparator miLine1;
        private System.Windows.Forms.ToolStripSeparator miLine2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripSeparator miLine3;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.Label lblLaborCoeffs;
        private System.Windows.Forms.DataGridView dgvLaborCoeffs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLaborCoeffsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvLaborCoeffsValue;
        private System.Windows.Forms.Label lblProductParameters;
        private System.Windows.Forms.DataGridView dgvProductParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductParametersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductParametersValue;
        private System.Windows.Forms.Label lblFactors;
        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFactorsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFactorsLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFactorsComment;
        private System.Windows.Forms.TabPage tpProjectWorks;
        private System.Windows.Forms.Label lblKSLOC;
        private System.Windows.Forms.NumericUpDown nudSLOC;
        private System.Windows.Forms.TabPage tpResults;
        private System.Windows.Forms.Label lblTotalLabor;
        private System.Windows.Forms.Label lblTotalTime;
    }
}

