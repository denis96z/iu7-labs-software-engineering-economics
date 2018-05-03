using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Lab07.IO.Config;
using Lab07.Calculations;
using Lab07.IO.Data;

namespace Lab07.Forms
{
    public partial class MainForm : Form
    {
        private readonly Model _model = new Model();

        public MainForm()
        {
            InitializeComponent();

            LoadKsloc();
            LoadLanguages();

            LoadLaborCoeffs();
            LoadProductParameters();
            LoadFactors();

            LoadLifecycle();
            LoadDecomposition();

            PerformCalculations();
        }

        private void LoadKsloc()
        {
            PerformAction(() =>
            {
                _model.Ksloc = new KslocLoader().GetDefault();
                nudSLOC.Value = _model.Ksloc * 1000;
            });
        }

        private void LoadLaborCoeffs()
        {
            PerformAction(() =>
            {
                _model.LaborCoeffs = new LaborCoeffsLoader().GetDefault();
                UpdateLaborCoeffsTable();
            });
        }

        private void LoadProductParameters()
        {
            PerformAction(() =>
            {
                _model.ProductParameters = new ProductParametersLoader().GetDefault();
                UpdateProductParametersTable();
            });
        }

        private void LoadFactors()
        {
            PerformAction(() =>
            {
                _model.Factors = new FactorsLoader().GetDefault();
                UpdateFactorsTable();
            });
        }

        private void LoadLifecycle()
        {
            PerformAction(() =>
            {
                _model.Lifecycle = new LifecycleLoader().GetDefault();
                UpdateLifecycleTable();
            });
        }

        private void LoadDecomposition()
        {
            PerformAction(() =>
            {
                _model.Decomposition = new DecompositionLoader().GetDefault();
                UpdateDecompositionTable();
            });
        }

        private void LoadLanguages()
        {
            PerformAction(() =>
            {
                _model.Languages = new ProgLanguagesLoader().GetDefault();
            });
        }

        public void PerformCalculations()
        {
            PerformAction(() =>
            {
                var totalLabor = _model.CalculateTotalLabor();
                lblTotalLabor.Text = @"Общая трудоемкость(чел./ мес.): " + totalLabor;

                var totalTime = _model.CalculateTotalTime();
                lblTotalTime.Text = @"Общее время(мес.):" + totalTime;

                var totalBudget = _model.CalculateTotalBudget();
                lblTotalBudget.Text = @"Общий бюджет(руб.):" + totalBudget;

                UpdateStaffChart();
            });
        }

        private void NudSLOC_ValueChanged(object sender, EventArgs e)
        {
            PerformAction(() =>
            {
                _model.Ksloc = (int)(nudSLOC.Value / 1000);
                PerformCalculations();
            });
        }

        private void UpdateLaborCoeffsTable()
        {
            dgvLaborCoeffs.Rows.Clear();
            foreach (var coeff in _model.LaborCoeffs)
            {
                dgvLaborCoeffs.Rows.Add(coeff.Name, LaborCoeffLevelConverter.Convert(coeff.Level));
            }
        }

        private void DgvLaborCoeffs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PerformAction(() =>
            {
                foreach (DataGridViewRow row in dgvLaborCoeffs.Rows)
                {
                    var name = (string)row.Cells["dgvLaborCoeffsName"].Value;

                    var coeff = _model.LaborCoeffs[name];
                    coeff.Level = LaborCoeffLevelConverter
                        .Convert((string)row.Cells["dgvLaborCoeffsValue"].Value);

                    _model.LaborCoeffs[name] = coeff;
                }
                PerformCalculations();
            });
        }

        private void UpdateProductParametersTable()
        {
            dgvProductParameters.Rows.Clear();
            foreach (var parameter in _model.ProductParameters)
            {
                dgvProductParameters.Rows.Add(parameter.Name, parameter.Value.ToString());
            }
        }

        private void DgvProductParameters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PerformAction(() =>
            {
                foreach (DataGridViewRow row in dgvProductParameters.Rows)
                {
                    var name = (string) row.Cells["dgvProductParametersName"].Value;

                    var parameter = _model.ProductParameters[name];
                    parameter.Value = uint.Parse((string) row.Cells["dgvProductParametersValue"].Value);

                    _model.ProductParameters[name] = parameter;
                }
                PerformCalculations();
            });
        }

        private void UpdateFactorsTable()
        {
            dgvFactors.Rows.Clear();
            foreach (var factor in _model.Factors)
            {
                dgvFactors.Rows.Add(factor.Name, factor.Level.ToString(),
                    factor.Levels[factor.Level].Item1);
            }
        }

        private void DgvFactors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PerformAction(() =>
            {
                foreach (DataGridViewRow row in dgvFactors.Rows)
                {
                    var name = (string)row.Cells["dgvFactorsName"].Value;

                    var factor = _model.Factors[name];
                    factor.Level = byte.Parse((string)row.Cells["dgvFactorsLevel"].Value);

                    _model.Factors[name] = factor;
                }
                UpdateFactorsTable();
                PerformCalculations();
            });
        }

        private void UpdateLifecycleTable()
        {
            var labor = _model.CalculateLifecycleLabor();
            var time = _model.CalculateLifecycleTime();

            dgvLifecycle.Rows.Clear();
            for (var i = 0; i < _model.Lifecycle.Count(); ++i)
            {
                var oh = _model.Lifecycle[i].IsOverhead ? "+" : "";
                dgvLifecycle.Rows.Add(_model.Lifecycle[i].Name,
                    oh + _model.Lifecycle[i].LaborPercent,
                    oh + _model.Lifecycle[i].TimePercent,
                    labor[i], time[i]);
            }
        }

        private void UpdateDecompositionTable()
        {
            var budget = _model.CalculateDecompositionBudget();

            dgvDecomposition.Rows.Clear();
            for (var i = 0; i < _model.Decomposition.Count(); ++i)
            {
                dgvDecomposition.Rows.Add(_model.Decomposition[i].Name,
                    _model.Decomposition[i].BudgetPercent, budget[i]);
            }
        }

        private void UpdateStaffChart()
        {
            PerformAction(() =>
            {
                if (_model.Lifecycle == null) return;

                var lifecycleTime = _model.CalculateLifecycleTime();
                var staff = _model.CalculateStaff();

                chrtStaff.Series.Clear();
                chrtStaff.Series.Add("Количество сотрудников");
                chrtStaff.Series[0].ChartType = SeriesChartType.Column;
                chrtStaff.Series[0].Color = Color.Red;

                var index = 0;
                for (var i = 0; i < staff.Count; ++i)
                {
                    // ReSharper disable once PossibleInvalidOperationException
                    var iterationLength = (int)Math.Ceiling((decimal) lifecycleTime[i]);
                    for (var j = 0; j < iterationLength; ++index, ++j)
                    {
                        chrtStaff.Series[0].Points.AddXY(index, staff[i]);
                    }
                }
            });
        }

        protected void PerformAction(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception exception)
            {
                if (exception is NullReferenceException) return;
                MessageBox.Show(exception.Message, @"Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
