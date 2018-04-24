using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Lab06.Calculations;
using Lab06.IO;

namespace Lab06.Forms
{
    public partial class MainForm : Form
    {
        private readonly Calculator calculator = new Calculator();

        public MainForm()
        {
            InitializeComponent();

            CreateTables();
            CreateCountTables();

            OnParameterChanged(null, null);
        }

        public void ParseParameters()
        {
            TryAction(() =>
            {
                calculator.RELY = ftbRELY.FloatValue;
                calculator.DATA = ftbDATA.FloatValue;
                calculator.CPLX = ftbCPLX.FloatValue;
                calculator.TIME = ftbTIME.FloatValue;
                calculator.STOR = ftbSTOR.FloatValue;
                calculator.VIRT = ftbVIRT.FloatValue;
                calculator.TURN = ftbTURN.FloatValue;
                calculator.ACAP = ftbACAP.FloatValue;
                calculator.AEXP = ftbAEXP.FloatValue;
                calculator.PCAP = ftbPCAP.FloatValue;
                calculator.VEXP = ftbVEXP.FloatValue;
                calculator.LEXP = ftbLEXP.FloatValue;
                calculator.MODP = ftbMODP.FloatValue;
                calculator.TOOL = ftbTOOL.FloatValue;
                calculator.SCED = ftbSCED.FloatValue;

                calculator.LOC = (int)nudLOC.Value;

                if (rbModeCommon.Checked)
                {
                    calculator.Mode = CalculatorMode.Common;
                }
                else if (rbModeMedium.Checked)
                {
                    calculator.Mode = CalculatorMode.Medium;
                }
                else if (rbModeEmbedded.Checked)
                {
                    calculator.Mode = CalculatorMode.Embedded;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            });
        }

        public void TryAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnParameterChanged(object sender, EventArgs e)
        {
            TryAction(() =>
            {
                ParseParameters();

                (var labor, var time) = calculator.CalculateLaborAndTime();
                var cost = calculator.CalculateCost();

                var lifecycleCount = calculator.CalculateLifecycle();    
                var staffCount = calculator.CountStaff();

                lblTotalLabor.Text = @"Трудозатраты: " + labor.ToString(CultureInfo.InvariantCulture);
                lblTotalTime.Text = @"Время: " + time.ToString(CultureInfo.InvariantCulture);
                lblBudget.Text = @"Бюджет: " + cost.ToString(CultureInfo.InvariantCulture);

                UpdateTables(lifecycleCount);
                UpdateCharts(lifecycleCount, staffCount);
            });
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            TryAction(() =>
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var parser = new XmlParser(openFileDialog.FileName);

                var loc = parser.LoadLOC();
                var manMonthCost = parser.LoadManMonthCost();
                var drivers = parser.LoadDrivers();
                SetParameters(loc, manMonthCost, drivers);

                var lifecycle = parser.LoadLifecycle();
                var decomposition = parser.LoadDecomposition();
                SetTablesRows(lifecycle, decomposition);

                OnParameterChanged(null, null);
            });
        }

        private void SetParameters(int loc, int manMonthCost, IEnumerable<Driver> drivers)
        {
            nudLOC.Value = calculator.LOC = loc;
            calculator.ManMonthCost = manMonthCost;

            foreach (var driver in drivers)
            {
                switch (driver.Name)
                {
                    case "RELY":
                        calculator.RELY = ftbRELY.Value = driver.Value;
                        break;

                    case "DATA":
                        calculator.DATA = ftbDATA.Value = driver.Value;
                        break;

                    case "CPLX":
                        calculator.CPLX = ftbCPLX.Value = driver.Value;
                        break;

                    case "TIME":
                        calculator.TIME = ftbTIME.Value = driver.Value;
                        break;

                    case "STOR":
                        calculator.STOR = ftbSTOR.Value = driver.Value;
                        break;

                    case "VIRT":
                        calculator.VIRT = ftbVIRT.Value = driver.Value;
                        break;

                    case "TURN":
                        calculator.TURN = ftbTURN.Value = driver.Value;
                        break;

                    case "ACAP":
                        calculator.ACAP = ftbACAP.Value = driver.Value;
                        break;

                    case "AEXP":
                        calculator.AEXP = ftbAEXP.Value = driver.Value;
                        break;

                    case "PCAP":
                        calculator.PCAP = ftbPCAP.Value = driver.Value;
                        break;

                    case "VEXP":
                        calculator.VEXP = ftbVEXP.Value = driver.Value;
                        break;

                    case "LEXP":
                        calculator.LEXP = ftbLEXP.Value = driver.Value;
                        break;

                    case "MODP":
                        calculator.MODP = ftbMODP.Value = driver.Value;
                        break;

                    case "TOOL":
                        calculator.TOOL = ftbTOOL.Value = driver.Value;
                        break;

                    case "SCED":
                        calculator.SCED = ftbSCED.Value = driver.Value;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void CreateTables()
        {
            var colTaskLT = new DataGridViewColumn
            {
                HeaderText = @"Вид деятельности",
                Width = 200,
                ReadOnly = true,
                Name = "Task",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var colLabor = new DataGridViewColumn
            {
                HeaderText = @"Работа (%)",
                Width = 100,
                ReadOnly = true,
                Name = "Labor",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var colTime = new DataGridViewColumn
            {
                HeaderText = @"Время (%)",
                Width = 100,
                ReadOnly = true,
                Name = "Time",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            dgvLifecycle.Columns.Add(colTaskLT);
            dgvLifecycle.Columns.Add(colLabor);
            dgvLifecycle.Columns.Add(colTime);
            dgvLifecycle.AllowUserToAddRows = false;

            var colTaskDC = new DataGridViewColumn
            {
                HeaderText = @"Вид деятельности",
                Width = 200,
                ReadOnly = true,
                Name = "Task",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var colBudget = new DataGridViewColumn
            {
                HeaderText = @"Бюджет (%)",
                Width = 100,
                ReadOnly = true,
                Name = "Budget",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            dgvDecomposition.Columns.Add(colTaskDC);
            dgvDecomposition.Columns.Add(colBudget);
            dgvDecomposition.AllowUserToAddRows = false;
        }

        public void CreateCountTables()
        {
            var colTaskLT = new DataGridViewColumn
            {
                HeaderText = @"Вид деятельности",
                Width = 200,
                ReadOnly = true,
                Name = "Task",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var colLabor = new DataGridViewColumn
            {
                HeaderText = @"Работа",
                Width = 100,
                ReadOnly = true,
                Name = "Labor",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var colTime = new DataGridViewColumn
            {
                HeaderText = @"Время",
                Width = 100,
                ReadOnly = true,
                Name = "Time",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            dgvLifecycleCount.Columns.Add(colTaskLT);
            dgvLifecycleCount.Columns.Add(colLabor);
            dgvLifecycleCount.Columns.Add(colTime);
            dgvLifecycleCount.AllowUserToAddRows = false;
        }

        public void SetTablesRows(List<Task> lifecycle, List<Task> decomposition)
        {
            calculator.Lifecycle = lifecycle;
            calculator.Decomposition = decomposition;

            dgvLifecycle.Rows.Clear();
            foreach (var task in lifecycle)
            {
                dgvLifecycle.Rows.Add(task.Name, task.LaborPercent, task.TimePercent);
            }

            dgvDecomposition.Rows.Clear();
            foreach (var task in decomposition)
            {
                dgvDecomposition.Rows.Add(task.Name, task.BudgetPercent);
            }

            dgvLifecycleCount.Rows.Clear();
            foreach (var task in lifecycle)
            {
                dgvLifecycleCount.Rows.Add(task.Name, 0, 0);
            }
        }

        public void UpdateTables(List<(double, double)> lifecycleCount)
        {
            for (var i = 0; i < lifecycleCount.Count; ++i)
            {
                dgvLifecycleCount["labor", i].Value = lifecycleCount[i].Item1;
                dgvLifecycleCount["time", i].Value = lifecycleCount[i].Item2;
            }
        }

        public void UpdateCharts(List<(double, double)> lifecycleCount, List<int> staffCount)
        {
            chrtStaff.Series.Clear();
            chrtStaff.Series.Add("Количество сотрудников");
            chrtStaff.Series[0].ChartType = SeriesChartType.Spline;
            chrtStaff.Series[0].Color = Color.Red;

            var index = 0;
            for (var i = 0; i < staffCount.Count; ++i)
            {
                var iterationLength = (int)Math.Ceiling(lifecycleCount[i].Item2);
                for (var j = 0; j < iterationLength; ++index, ++j)
                {
                    chrtStaff.Series[0].Points.AddXY(index, staffCount[i]);
                }
            }
        }
    }
}
