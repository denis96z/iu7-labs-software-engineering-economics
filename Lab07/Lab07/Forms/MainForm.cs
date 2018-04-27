using System;
using System.Windows.Forms;
using Lab07.IO.Config;
using Lab07.Calculations;

namespace Lab07.Forms
{
    public partial class MainForm : Form
    {
        private readonly Model _model = new Model();

        public MainForm()
        {
            InitializeComponent();
            LoadLaborCoeffs();
        }

        public void PerformAction(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLaborCoeffs()
        {
            PerformAction(() =>
            {
                _model.LaborCoeffs = new LaborCoeffsLoader().GetDefault();
            });
        }
    }
}
