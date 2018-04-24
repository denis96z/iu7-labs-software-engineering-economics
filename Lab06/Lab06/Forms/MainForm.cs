using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
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

                lblTotalLabor.Text = @"Трудозатраты: " + labor.ToString(CultureInfo.InvariantCulture);
                lblTotalTime.Text = @"Время: " + time.ToString(CultureInfo.InvariantCulture);
            });
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            TryAction(() =>
            {
                var parser = new XmlParser("project.xml");

                var loc = parser.LoadLOC();
                var drivers = parser.LoadDrivers();
                SetParameters(loc, drivers);

                var lifecycle = parser.LoadLifecycle();
                var decomposition = parser.LoadDecomposition();

                throw new NotImplementedException();
            });
        }

        private void SetParameters(int loc, IEnumerable<Driver> drivers)
        {
            nudLOC.Value = calculator.LOC = loc;
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
    }
}
