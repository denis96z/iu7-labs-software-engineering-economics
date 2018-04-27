namespace Lab07.Forms
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
            this.tcPages.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPages
            // 
            this.tcPages.Controls.Add(this.tpProjectParameters);
            this.tcPages.Location = new System.Drawing.Point(12, 27);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(760, 522);
            this.tcPages.TabIndex = 0;
            // 
            // tpProjectParameters
            // 
            this.tpProjectParameters.Location = new System.Drawing.Point(4, 22);
            this.tpProjectParameters.Name = "tpProjectParameters";
            this.tpProjectParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjectParameters.Size = new System.Drawing.Size(752, 496);
            this.tpProjectParameters.TabIndex = 0;
            this.tpProjectParameters.Text = "Параметры";
            this.tpProjectParameters.UseVisualStyleBackColor = true;
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
            this.miCancel.Size = new System.Drawing.Size(152, 22);
            this.miCancel.Text = "Отменить";
            // 
            // miRevert
            // 
            this.miRevert.Enabled = false;
            this.miRevert.Name = "miRevert";
            this.miRevert.Size = new System.Drawing.Size(152, 22);
            this.miRevert.Text = "Вернуть";
            // 
            // miLine3
            // 
            this.miLine3.Name = "miLine3";
            this.miLine3.Size = new System.Drawing.Size(149, 6);
            // 
            // miCut
            // 
            this.miCut.Enabled = false;
            this.miCut.Name = "miCut";
            this.miCut.Size = new System.Drawing.Size(152, 22);
            this.miCut.Text = "Вырезать";
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(152, 22);
            this.miCopy.Text = "Копировать";
            // 
            // miPaste
            // 
            this.miPaste.Enabled = false;
            this.miPaste.Name = "miPaste";
            this.miPaste.Size = new System.Drawing.Size(152, 22);
            this.miPaste.Text = "Вставить";
            // 
            // miDelete
            // 
            this.miDelete.Enabled = false;
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(152, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tcPages);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №7";
            this.tcPages.ResumeLayout(false);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
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
    }
}

