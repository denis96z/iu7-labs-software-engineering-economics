namespace Lab06.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbVisualization = new System.Windows.Forms.GroupBox();
            this.tctlVisualization = new System.Windows.Forms.TabControl();
            this.tpgTables = new System.Windows.Forms.TabPage();
            this.tpgGraphs = new System.Windows.Forms.TabPage();
            this.lblLaborTime = new System.Windows.Forms.Label();
            this.dgvLaborTime = new System.Windows.Forms.DataGridView();
            this.lblDecomposition = new System.Windows.Forms.Label();
            this.dgvDecomposition = new System.Windows.Forms.DataGridView();
            this.lblStaff = new System.Windows.Forms.Label();
            this.chrtStaff = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbModeEmbedded = new System.Windows.Forms.RadioButton();
            this.rbModeMedium = new System.Windows.Forms.RadioButton();
            this.rbModeCommon = new System.Windows.Forms.RadioButton();
            this.lblLOC = new System.Windows.Forms.Label();
            this.nudLOC = new System.Windows.Forms.NumericUpDown();
            this.ftbSCED = new Lab06.Forms.FloatTrackBar();
            this.lblSCED = new System.Windows.Forms.Label();
            this.ftbTOOL = new Lab06.Forms.FloatTrackBar();
            this.lblTOOL = new System.Windows.Forms.Label();
            this.ftbMODP = new Lab06.Forms.FloatTrackBar();
            this.lblMODP = new System.Windows.Forms.Label();
            this.ftbLEXP = new Lab06.Forms.FloatTrackBar();
            this.lblLEXP = new System.Windows.Forms.Label();
            this.ftbVEXP = new Lab06.Forms.FloatTrackBar();
            this.lblVEXP = new System.Windows.Forms.Label();
            this.ftbPCAP = new Lab06.Forms.FloatTrackBar();
            this.lblPCAP = new System.Windows.Forms.Label();
            this.ftbAEXP = new Lab06.Forms.FloatTrackBar();
            this.lblAEXP = new System.Windows.Forms.Label();
            this.ftbACAP = new Lab06.Forms.FloatTrackBar();
            this.lblACAP = new System.Windows.Forms.Label();
            this.ftbTURN = new Lab06.Forms.FloatTrackBar();
            this.lblTURN = new System.Windows.Forms.Label();
            this.ftbVIRT = new Lab06.Forms.FloatTrackBar();
            this.lblVIRT = new System.Windows.Forms.Label();
            this.ftbSTOR = new Lab06.Forms.FloatTrackBar();
            this.lblSTOR = new System.Windows.Forms.Label();
            this.ftbTIME = new Lab06.Forms.FloatTrackBar();
            this.lblTIME = new System.Windows.Forms.Label();
            this.ftbCPLX = new Lab06.Forms.FloatTrackBar();
            this.lblCPLX = new System.Windows.Forms.Label();
            this.ftbDATA = new Lab06.Forms.FloatTrackBar();
            this.lblDATA = new System.Windows.Forms.Label();
            this.ftbRELY = new Lab06.Forms.FloatTrackBar();
            this.lblRELY = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblTotalLabor = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.gbVisualization.SuspendLayout();
            this.tctlVisualization.SuspendLayout();
            this.tpgTables.SuspendLayout();
            this.tpgGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecomposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStaff)).BeginInit();
            this.gbParameters.SuspendLayout();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbSCED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTOOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbMODP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbLEXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbVEXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbPCAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbAEXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbACAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTURN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbVIRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbSTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbCPLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbRELY)).BeginInit();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisualization
            // 
            this.gbVisualization.Controls.Add(this.tctlVisualization);
            this.gbVisualization.Location = new System.Drawing.Point(292, 12);
            this.gbVisualization.Name = "gbVisualization";
            this.gbVisualization.Size = new System.Drawing.Size(480, 537);
            this.gbVisualization.TabIndex = 2;
            this.gbVisualization.TabStop = false;
            this.gbVisualization.Text = "Представление результатов:";
            // 
            // tctlVisualization
            // 
            this.tctlVisualization.Controls.Add(this.tpgTables);
            this.tctlVisualization.Controls.Add(this.tpgGraphs);
            this.tctlVisualization.Location = new System.Drawing.Point(6, 16);
            this.tctlVisualization.Name = "tctlVisualization";
            this.tctlVisualization.SelectedIndex = 0;
            this.tctlVisualization.Size = new System.Drawing.Size(468, 515);
            this.tctlVisualization.TabIndex = 4;
            // 
            // tpgTables
            // 
            this.tpgTables.Controls.Add(this.dgvDecomposition);
            this.tpgTables.Controls.Add(this.lblDecomposition);
            this.tpgTables.Controls.Add(this.dgvLaborTime);
            this.tpgTables.Controls.Add(this.lblLaborTime);
            this.tpgTables.Location = new System.Drawing.Point(4, 22);
            this.tpgTables.Name = "tpgTables";
            this.tpgTables.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTables.Size = new System.Drawing.Size(460, 489);
            this.tpgTables.TabIndex = 0;
            this.tpgTables.Text = "Таблицы";
            this.tpgTables.UseVisualStyleBackColor = true;
            // 
            // tpgGraphs
            // 
            this.tpgGraphs.Controls.Add(this.chrtStaff);
            this.tpgGraphs.Controls.Add(this.lblStaff);
            this.tpgGraphs.Location = new System.Drawing.Point(4, 22);
            this.tpgGraphs.Name = "tpgGraphs";
            this.tpgGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.tpgGraphs.Size = new System.Drawing.Size(460, 489);
            this.tpgGraphs.TabIndex = 1;
            this.tpgGraphs.Text = "Графики";
            this.tpgGraphs.UseVisualStyleBackColor = true;
            // 
            // lblLaborTime
            // 
            this.lblLaborTime.AutoSize = true;
            this.lblLaborTime.Location = new System.Drawing.Point(3, 3);
            this.lblLaborTime.Name = "lblLaborTime";
            this.lblLaborTime.Size = new System.Drawing.Size(335, 13);
            this.lblLaborTime.TabIndex = 0;
            this.lblLaborTime.Text = "Распределение работ и времени по стадиям жизненного цикла:";
            // 
            // dgvLaborTime
            // 
            this.dgvLaborTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaborTime.Location = new System.Drawing.Point(6, 19);
            this.dgvLaborTime.Name = "dgvLaborTime";
            this.dgvLaborTime.Size = new System.Drawing.Size(448, 220);
            this.dgvLaborTime.TabIndex = 1;
            // 
            // lblDecomposition
            // 
            this.lblDecomposition.AutoSize = true;
            this.lblDecomposition.Location = new System.Drawing.Point(6, 242);
            this.lblDecomposition.Name = "lblDecomposition";
            this.lblDecomposition.Size = new System.Drawing.Size(119, 13);
            this.lblDecomposition.TabIndex = 2;
            this.lblDecomposition.Text = "Декомпозиция работ:";
            // 
            // dgvDecomposition
            // 
            this.dgvDecomposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecomposition.Location = new System.Drawing.Point(6, 258);
            this.dgvDecomposition.Name = "dgvDecomposition";
            this.dgvDecomposition.Size = new System.Drawing.Size(448, 225);
            this.dgvDecomposition.TabIndex = 3;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(6, 3);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(60, 13);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Персонал:";
            // 
            // chrtStaff
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtStaff.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtStaff.Legends.Add(legend2);
            this.chrtStaff.Location = new System.Drawing.Point(6, 19);
            this.chrtStaff.Name = "chrtStaff";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Число сотрудников";
            this.chrtStaff.Series.Add(series2);
            this.chrtStaff.Size = new System.Drawing.Size(448, 300);
            this.chrtStaff.TabIndex = 1;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.gbMode);
            this.gbParameters.Controls.Add(this.lblLOC);
            this.gbParameters.Controls.Add(this.nudLOC);
            this.gbParameters.Controls.Add(this.ftbSCED);
            this.gbParameters.Controls.Add(this.lblSCED);
            this.gbParameters.Controls.Add(this.ftbTOOL);
            this.gbParameters.Controls.Add(this.lblTOOL);
            this.gbParameters.Controls.Add(this.ftbMODP);
            this.gbParameters.Controls.Add(this.lblMODP);
            this.gbParameters.Controls.Add(this.ftbLEXP);
            this.gbParameters.Controls.Add(this.lblLEXP);
            this.gbParameters.Controls.Add(this.ftbVEXP);
            this.gbParameters.Controls.Add(this.lblVEXP);
            this.gbParameters.Controls.Add(this.ftbPCAP);
            this.gbParameters.Controls.Add(this.lblPCAP);
            this.gbParameters.Controls.Add(this.ftbAEXP);
            this.gbParameters.Controls.Add(this.lblAEXP);
            this.gbParameters.Controls.Add(this.ftbACAP);
            this.gbParameters.Controls.Add(this.lblACAP);
            this.gbParameters.Controls.Add(this.ftbTURN);
            this.gbParameters.Controls.Add(this.lblTURN);
            this.gbParameters.Controls.Add(this.ftbVIRT);
            this.gbParameters.Controls.Add(this.lblVIRT);
            this.gbParameters.Controls.Add(this.ftbSTOR);
            this.gbParameters.Controls.Add(this.lblSTOR);
            this.gbParameters.Controls.Add(this.ftbTIME);
            this.gbParameters.Controls.Add(this.lblTIME);
            this.gbParameters.Controls.Add(this.ftbCPLX);
            this.gbParameters.Controls.Add(this.lblCPLX);
            this.gbParameters.Controls.Add(this.ftbDATA);
            this.gbParameters.Controls.Add(this.lblDATA);
            this.gbParameters.Controls.Add(this.ftbRELY);
            this.gbParameters.Controls.Add(this.lblRELY);
            this.gbParameters.Location = new System.Drawing.Point(12, 12);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(274, 403);
            this.gbParameters.TabIndex = 0;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Параметры:";
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbModeEmbedded);
            this.gbMode.Controls.Add(this.rbModeMedium);
            this.gbMode.Controls.Add(this.rbModeCommon);
            this.gbMode.Location = new System.Drawing.Point(9, 328);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(259, 67);
            this.gbMode.TabIndex = 32;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Режим:";
            // 
            // rbModeEmbedded
            // 
            this.rbModeEmbedded.AutoSize = true;
            this.rbModeEmbedded.Location = new System.Drawing.Point(6, 42);
            this.rbModeEmbedded.Name = "rbModeEmbedded";
            this.rbModeEmbedded.Size = new System.Drawing.Size(87, 17);
            this.rbModeEmbedded.TabIndex = 2;
            this.rbModeEmbedded.Text = "Встроенный";
            this.rbModeEmbedded.UseVisualStyleBackColor = true;
            // 
            // rbModeMedium
            // 
            this.rbModeMedium.AutoSize = true;
            this.rbModeMedium.Location = new System.Drawing.Point(84, 19);
            this.rbModeMedium.Name = "rbModeMedium";
            this.rbModeMedium.Size = new System.Drawing.Size(108, 17);
            this.rbModeMedium.TabIndex = 1;
            this.rbModeMedium.Text = "Промежуточный";
            this.rbModeMedium.UseVisualStyleBackColor = true;
            // 
            // rbModeCommon
            // 
            this.rbModeCommon.AutoSize = true;
            this.rbModeCommon.Checked = true;
            this.rbModeCommon.Location = new System.Drawing.Point(6, 19);
            this.rbModeCommon.Name = "rbModeCommon";
            this.rbModeCommon.Size = new System.Drawing.Size(72, 17);
            this.rbModeCommon.TabIndex = 0;
            this.rbModeCommon.TabStop = true;
            this.rbModeCommon.Text = "Обычный";
            this.rbModeCommon.UseVisualStyleBackColor = true;
            // 
            // lblLOC
            // 
            this.lblLOC.AutoSize = true;
            this.lblLOC.Location = new System.Drawing.Point(6, 304);
            this.lblLOC.Name = "lblLOC";
            this.lblLOC.Size = new System.Drawing.Size(31, 13);
            this.lblLOC.TabIndex = 31;
            this.lblLOC.Text = "LOC:";
            // 
            // nudLOC
            // 
            this.nudLOC.Location = new System.Drawing.Point(71, 302);
            this.nudLOC.Name = "nudLOC";
            this.nudLOC.Size = new System.Drawing.Size(197, 20);
            this.nudLOC.TabIndex = 30;
            // 
            // ftbSCED
            // 
            this.ftbSCED.AutoSize = false;
            this.ftbSCED.FloatValue = 1.165D;
            this.ftbSCED.Location = new System.Drawing.Point(71, 283);
            this.ftbSCED.MaxFloatValue = 1.23D;
            this.ftbSCED.Maximum = 100;
            this.ftbSCED.MinFloatValue = 1.1D;
            this.ftbSCED.Name = "ftbSCED";
            this.ftbSCED.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbSCED.Size = new System.Drawing.Size(197, 13);
            this.ftbSCED.TabIndex = 29;
            this.ftbSCED.Value = 50;
            // 
            // lblSCED
            // 
            this.lblSCED.AutoSize = true;
            this.lblSCED.Location = new System.Drawing.Point(6, 283);
            this.lblSCED.Name = "lblSCED";
            this.lblSCED.Size = new System.Drawing.Size(39, 13);
            this.lblSCED.TabIndex = 28;
            this.lblSCED.Text = "SCED:";
            // 
            // ftbTOOL
            // 
            this.ftbTOOL.AutoSize = false;
            this.ftbTOOL.FloatValue = 1.035D;
            this.ftbTOOL.Location = new System.Drawing.Point(71, 264);
            this.ftbTOOL.MaxFloatValue = 1.24D;
            this.ftbTOOL.Maximum = 100;
            this.ftbTOOL.MinFloatValue = 0.83D;
            this.ftbTOOL.Name = "ftbTOOL";
            this.ftbTOOL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbTOOL.Size = new System.Drawing.Size(197, 13);
            this.ftbTOOL.TabIndex = 27;
            this.ftbTOOL.Value = 50;
            // 
            // lblTOOL
            // 
            this.lblTOOL.AutoSize = true;
            this.lblTOOL.Location = new System.Drawing.Point(6, 264);
            this.lblTOOL.Name = "lblTOOL";
            this.lblTOOL.Size = new System.Drawing.Size(39, 13);
            this.lblTOOL.TabIndex = 26;
            this.lblTOOL.Text = "TOOL:";
            // 
            // ftbMODP
            // 
            this.ftbMODP.AutoSize = false;
            this.ftbMODP.FloatValue = 1.03D;
            this.ftbMODP.Location = new System.Drawing.Point(71, 245);
            this.ftbMODP.MaxFloatValue = 1.24D;
            this.ftbMODP.Maximum = 100;
            this.ftbMODP.MinFloatValue = 0.82D;
            this.ftbMODP.Name = "ftbMODP";
            this.ftbMODP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbMODP.Size = new System.Drawing.Size(197, 13);
            this.ftbMODP.TabIndex = 25;
            this.ftbMODP.Value = 50;
            // 
            // lblMODP
            // 
            this.lblMODP.AutoSize = true;
            this.lblMODP.Location = new System.Drawing.Point(6, 245);
            this.lblMODP.Name = "lblMODP";
            this.lblMODP.Size = new System.Drawing.Size(42, 13);
            this.lblMODP.TabIndex = 24;
            this.lblMODP.Text = "MODP:";
            // 
            // ftbLEXP
            // 
            this.ftbLEXP.AutoSize = false;
            this.ftbLEXP.FloatValue = 0.99749999999999994D;
            this.ftbLEXP.Location = new System.Drawing.Point(71, 226);
            this.ftbLEXP.MaxFloatValue = 1.14D;
            this.ftbLEXP.Maximum = 100;
            this.ftbLEXP.MinFloatValue = 0.95D;
            this.ftbLEXP.Name = "ftbLEXP";
            this.ftbLEXP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbLEXP.Size = new System.Drawing.Size(197, 13);
            this.ftbLEXP.TabIndex = 23;
            this.ftbLEXP.Value = 25;
            // 
            // lblLEXP
            // 
            this.lblLEXP.AutoSize = true;
            this.lblLEXP.Location = new System.Drawing.Point(6, 226);
            this.lblLEXP.Name = "lblLEXP";
            this.lblLEXP.Size = new System.Drawing.Size(37, 13);
            this.lblLEXP.TabIndex = 22;
            this.lblLEXP.Text = "LEXP:";
            // 
            // ftbVEXP
            // 
            this.ftbVEXP.AutoSize = false;
            this.ftbVEXP.FloatValue = 0.9775D;
            this.ftbVEXP.Location = new System.Drawing.Point(71, 207);
            this.ftbVEXP.MaxFloatValue = 1.21D;
            this.ftbVEXP.Maximum = 100;
            this.ftbVEXP.MinFloatValue = 0.9D;
            this.ftbVEXP.Name = "ftbVEXP";
            this.ftbVEXP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbVEXP.Size = new System.Drawing.Size(197, 13);
            this.ftbVEXP.TabIndex = 21;
            this.ftbVEXP.Value = 25;
            // 
            // lblVEXP
            // 
            this.lblVEXP.AutoSize = true;
            this.lblVEXP.Location = new System.Drawing.Point(6, 207);
            this.lblVEXP.Name = "lblVEXP";
            this.lblVEXP.Size = new System.Drawing.Size(38, 13);
            this.lblVEXP.TabIndex = 20;
            this.lblVEXP.Text = "VEXP:";
            // 
            // ftbPCAP
            // 
            this.ftbPCAP.AutoSize = false;
            this.ftbPCAP.FloatValue = 1.06D;
            this.ftbPCAP.Location = new System.Drawing.Point(71, 188);
            this.ftbPCAP.MaxFloatValue = 1.42D;
            this.ftbPCAP.Maximum = 100;
            this.ftbPCAP.MinFloatValue = 0.7D;
            this.ftbPCAP.Name = "ftbPCAP";
            this.ftbPCAP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbPCAP.Size = new System.Drawing.Size(197, 13);
            this.ftbPCAP.TabIndex = 19;
            this.ftbPCAP.Value = 50;
            // 
            // lblPCAP
            // 
            this.lblPCAP.AutoSize = true;
            this.lblPCAP.Location = new System.Drawing.Point(6, 188);
            this.lblPCAP.Name = "lblPCAP";
            this.lblPCAP.Size = new System.Drawing.Size(38, 13);
            this.lblPCAP.TabIndex = 18;
            this.lblPCAP.Text = "PCAP:";
            // 
            // ftbAEXP
            // 
            this.ftbAEXP.AutoSize = false;
            this.ftbAEXP.FloatValue = 1.055D;
            this.ftbAEXP.Location = new System.Drawing.Point(71, 169);
            this.ftbAEXP.MaxFloatValue = 1.29D;
            this.ftbAEXP.Maximum = 100;
            this.ftbAEXP.MinFloatValue = 0.82D;
            this.ftbAEXP.Name = "ftbAEXP";
            this.ftbAEXP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbAEXP.Size = new System.Drawing.Size(197, 13);
            this.ftbAEXP.TabIndex = 17;
            this.ftbAEXP.Value = 50;
            // 
            // lblAEXP
            // 
            this.lblAEXP.AutoSize = true;
            this.lblAEXP.Location = new System.Drawing.Point(6, 169);
            this.lblAEXP.Name = "lblAEXP";
            this.lblAEXP.Size = new System.Drawing.Size(38, 13);
            this.lblAEXP.TabIndex = 16;
            this.lblAEXP.Text = "AEXP:";
            // 
            // ftbACAP
            // 
            this.ftbACAP.AutoSize = false;
            this.ftbACAP.FloatValue = 1.085D;
            this.ftbACAP.Location = new System.Drawing.Point(71, 150);
            this.ftbACAP.MaxFloatValue = 1.46D;
            this.ftbACAP.Maximum = 100;
            this.ftbACAP.MinFloatValue = 0.71D;
            this.ftbACAP.Name = "ftbACAP";
            this.ftbACAP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ftbACAP.Size = new System.Drawing.Size(197, 13);
            this.ftbACAP.TabIndex = 15;
            this.ftbACAP.Value = 50;
            // 
            // lblACAP
            // 
            this.lblACAP.AutoSize = true;
            this.lblACAP.Location = new System.Drawing.Point(6, 150);
            this.lblACAP.Name = "lblACAP";
            this.lblACAP.Size = new System.Drawing.Size(38, 13);
            this.lblACAP.TabIndex = 14;
            this.lblACAP.Text = "ACAP:";
            // 
            // ftbTURN
            // 
            this.ftbTURN.AutoSize = false;
            this.ftbTURN.FloatValue = 0.94D;
            this.ftbTURN.Location = new System.Drawing.Point(71, 131);
            this.ftbTURN.MaxFloatValue = 1.15D;
            this.ftbTURN.Maximum = 100;
            this.ftbTURN.MinFloatValue = 0.87D;
            this.ftbTURN.Name = "ftbTURN";
            this.ftbTURN.Size = new System.Drawing.Size(197, 13);
            this.ftbTURN.TabIndex = 13;
            this.ftbTURN.Value = 25;
            // 
            // lblTURN
            // 
            this.lblTURN.AutoSize = true;
            this.lblTURN.Location = new System.Drawing.Point(6, 131);
            this.lblTURN.Name = "lblTURN";
            this.lblTURN.Size = new System.Drawing.Size(41, 13);
            this.lblTURN.TabIndex = 12;
            this.lblTURN.Text = "TURN:";
            // 
            // ftbVIRT
            // 
            this.ftbVIRT.AutoSize = false;
            this.ftbVIRT.FloatValue = 0.9775D;
            this.ftbVIRT.Location = new System.Drawing.Point(71, 111);
            this.ftbVIRT.MaxFloatValue = 1.3D;
            this.ftbVIRT.Maximum = 100;
            this.ftbVIRT.MinFloatValue = 0.87D;
            this.ftbVIRT.Name = "ftbVIRT";
            this.ftbVIRT.Size = new System.Drawing.Size(197, 13);
            this.ftbVIRT.TabIndex = 11;
            this.ftbVIRT.Value = 25;
            // 
            // lblVIRT
            // 
            this.lblVIRT.AutoSize = true;
            this.lblVIRT.Location = new System.Drawing.Point(6, 111);
            this.lblVIRT.Name = "lblVIRT";
            this.lblVIRT.Size = new System.Drawing.Size(35, 13);
            this.lblVIRT.TabIndex = 10;
            this.lblVIRT.Text = "VIRT:";
            // 
            // ftbSTOR
            // 
            this.ftbSTOR.AutoSize = false;
            this.ftbSTOR.FloatValue = 1D;
            this.ftbSTOR.Location = new System.Drawing.Point(71, 92);
            this.ftbSTOR.MaxFloatValue = 1.56D;
            this.ftbSTOR.Maximum = 100;
            this.ftbSTOR.MinFloatValue = 1D;
            this.ftbSTOR.Name = "ftbSTOR";
            this.ftbSTOR.Size = new System.Drawing.Size(197, 13);
            this.ftbSTOR.TabIndex = 9;
            // 
            // lblSTOR
            // 
            this.lblSTOR.AutoSize = true;
            this.lblSTOR.Location = new System.Drawing.Point(6, 92);
            this.lblSTOR.Name = "lblSTOR";
            this.lblSTOR.Size = new System.Drawing.Size(40, 13);
            this.lblSTOR.TabIndex = 8;
            this.lblSTOR.Text = "STOR:";
            // 
            // ftbTIME
            // 
            this.ftbTIME.AutoSize = false;
            this.ftbTIME.FloatValue = 1D;
            this.ftbTIME.Location = new System.Drawing.Point(71, 73);
            this.ftbTIME.MaxFloatValue = 1.66D;
            this.ftbTIME.Maximum = 100;
            this.ftbTIME.MinFloatValue = 1D;
            this.ftbTIME.Name = "ftbTIME";
            this.ftbTIME.Size = new System.Drawing.Size(197, 13);
            this.ftbTIME.TabIndex = 7;
            // 
            // lblTIME
            // 
            this.lblTIME.AutoSize = true;
            this.lblTIME.Location = new System.Drawing.Point(6, 73);
            this.lblTIME.Name = "lblTIME";
            this.lblTIME.Size = new System.Drawing.Size(36, 13);
            this.lblTIME.TabIndex = 6;
            this.lblTIME.Text = "TIME:";
            // 
            // ftbCPLX
            // 
            this.ftbCPLX.AutoSize = false;
            this.ftbCPLX.FloatValue = 1.1749999999999998D;
            this.ftbCPLX.Location = new System.Drawing.Point(71, 54);
            this.ftbCPLX.MaxFloatValue = 1.65D;
            this.ftbCPLX.Maximum = 100;
            this.ftbCPLX.MinFloatValue = 0.7D;
            this.ftbCPLX.Name = "ftbCPLX";
            this.ftbCPLX.Size = new System.Drawing.Size(197, 13);
            this.ftbCPLX.TabIndex = 5;
            this.ftbCPLX.Value = 50;
            // 
            // lblCPLX
            // 
            this.lblCPLX.AutoSize = true;
            this.lblCPLX.Location = new System.Drawing.Point(6, 54);
            this.lblCPLX.Name = "lblCPLX";
            this.lblCPLX.Size = new System.Drawing.Size(37, 13);
            this.lblCPLX.TabIndex = 4;
            this.lblCPLX.Text = "CPLX:";
            // 
            // ftbDATA
            // 
            this.ftbDATA.AutoSize = false;
            this.ftbDATA.FloatValue = 1.0499999999999998D;
            this.ftbDATA.Location = new System.Drawing.Point(71, 35);
            this.ftbDATA.MaxFloatValue = 1.16D;
            this.ftbDATA.Maximum = 100;
            this.ftbDATA.MinFloatValue = 0.94D;
            this.ftbDATA.Name = "ftbDATA";
            this.ftbDATA.Size = new System.Drawing.Size(197, 13);
            this.ftbDATA.TabIndex = 3;
            this.ftbDATA.Value = 50;
            // 
            // lblDATA
            // 
            this.lblDATA.Location = new System.Drawing.Point(6, 35);
            this.lblDATA.Name = "lblDATA";
            this.lblDATA.Size = new System.Drawing.Size(38, 13);
            this.lblDATA.TabIndex = 2;
            this.lblDATA.Text = "DATA:";
            // 
            // ftbRELY
            // 
            this.ftbRELY.AutoSize = false;
            this.ftbRELY.FloatValue = 1.075D;
            this.ftbRELY.Location = new System.Drawing.Point(71, 16);
            this.ftbRELY.MaxFloatValue = 1.4D;
            this.ftbRELY.Maximum = 100;
            this.ftbRELY.MinFloatValue = 0.75D;
            this.ftbRELY.Name = "ftbRELY";
            this.ftbRELY.Size = new System.Drawing.Size(197, 13);
            this.ftbRELY.TabIndex = 1;
            this.ftbRELY.Value = 50;
            // 
            // lblRELY
            // 
            this.lblRELY.AutoSize = true;
            this.lblRELY.Location = new System.Drawing.Point(6, 16);
            this.lblRELY.Name = "lblRELY";
            this.lblRELY.Size = new System.Drawing.Size(38, 13);
            this.lblRELY.TabIndex = 0;
            this.lblRELY.Text = "RELY:";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lblTotalTime);
            this.gbResults.Controls.Add(this.lblTotalLabor);
            this.gbResults.Location = new System.Drawing.Point(12, 421);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(274, 128);
            this.gbResults.TabIndex = 3;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Результат:";
            // 
            // lblTotalLabor
            // 
            this.lblTotalLabor.AutoSize = true;
            this.lblTotalLabor.Location = new System.Drawing.Point(6, 27);
            this.lblTotalLabor.Name = "lblTotalLabor";
            this.lblTotalLabor.Size = new System.Drawing.Size(94, 13);
            this.lblTotalLabor.TabIndex = 0;
            this.lblTotalLabor.Text = "Трудозатраты: ---";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(6, 60);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(55, 13);
            this.lblTotalTime.TabIndex = 1;
            this.lblTotalTime.Text = "Время: ---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbVisualization);
            this.Controls.Add(this.gbParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №6";
            this.gbVisualization.ResumeLayout(false);
            this.tctlVisualization.ResumeLayout(false);
            this.tpgTables.ResumeLayout(false);
            this.tpgTables.PerformLayout();
            this.tpgGraphs.ResumeLayout(false);
            this.tpgGraphs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaborTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecomposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStaff)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbSCED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTOOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbMODP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbLEXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbVEXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbPCAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbAEXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbACAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTURN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbVIRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbSTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbTIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbCPLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftbRELY)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVisualization;
        private System.Windows.Forms.TabControl tctlVisualization;
        private System.Windows.Forms.TabPage tpgTables;
        private System.Windows.Forms.TabPage tpgGraphs;
        private System.Windows.Forms.Label lblLaborTime;
        private System.Windows.Forms.DataGridView dgvLaborTime;
        private System.Windows.Forms.Label lblDecomposition;
        private System.Windows.Forms.DataGridView dgvDecomposition;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtStaff;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbModeEmbedded;
        private System.Windows.Forms.RadioButton rbModeMedium;
        private System.Windows.Forms.RadioButton rbModeCommon;
        private System.Windows.Forms.Label lblLOC;
        private System.Windows.Forms.NumericUpDown nudLOC;
        private FloatTrackBar ftbSCED;
        private System.Windows.Forms.Label lblSCED;
        private FloatTrackBar ftbTOOL;
        private System.Windows.Forms.Label lblTOOL;
        private FloatTrackBar ftbMODP;
        private System.Windows.Forms.Label lblMODP;
        private FloatTrackBar ftbLEXP;
        private System.Windows.Forms.Label lblLEXP;
        private FloatTrackBar ftbVEXP;
        private System.Windows.Forms.Label lblVEXP;
        private FloatTrackBar ftbPCAP;
        private System.Windows.Forms.Label lblPCAP;
        private FloatTrackBar ftbAEXP;
        private System.Windows.Forms.Label lblAEXP;
        private FloatTrackBar ftbACAP;
        private System.Windows.Forms.Label lblACAP;
        private FloatTrackBar ftbTURN;
        private System.Windows.Forms.Label lblTURN;
        private FloatTrackBar ftbVIRT;
        private System.Windows.Forms.Label lblVIRT;
        private FloatTrackBar ftbSTOR;
        private System.Windows.Forms.Label lblSTOR;
        private FloatTrackBar ftbTIME;
        private System.Windows.Forms.Label lblTIME;
        private FloatTrackBar ftbCPLX;
        private System.Windows.Forms.Label lblCPLX;
        private FloatTrackBar ftbDATA;
        private System.Windows.Forms.Label lblDATA;
        private FloatTrackBar ftbRELY;
        private System.Windows.Forms.Label lblRELY;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.Label lblTotalLabor;
        private System.Windows.Forms.Label lblTotalTime;
    }
}

