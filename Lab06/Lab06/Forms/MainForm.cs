using System;
using System.Globalization;
using System.Windows.Forms;
using Lab06.Calculations;

namespace Lab06.Forms
{
    public partial class MainForm : Form
    {
        private readonly Calculator calculator = new Calculator();

        public MainForm()
        {
            InitializeComponent();
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
                else if (rbModeCommon.Checked)
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
                MessageBox.Show(exception.Message, @"Error",
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

                lblTotalLabor.Text = @"Трудозатраты: " + labor.ToString(CultureInfo.InvariantCulture);
                lblTotalTime.Text = @"Время: " + time.ToString(CultureInfo.InvariantCulture);
            });
        }
    }
}
