﻿using System;
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

        private void LoadLaborCoeffs()
        {
            PerformAction(() =>
            {
                _model.LaborCoeffs = new LaborCoeffsLoader().GetDefault();
                UpdateLaborCoeffsTable();
            });
        }

        private void UpdateLaborCoeffsTable()
        {
            dgvLaborCoeffs.Rows.Clear();
            foreach (LaborCoeff coeff in _model.LaborCoeffs)
            {
                dgvLaborCoeffs.Rows.Add(coeff.Name, LaborCoeffLevelConverter.Convert(coeff.Level));
            }
        }

        private void DgvLaborCoeffs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLaborCoeffs.Rows)
            {
                var name = (string)row.Cells["dgvLaborCoeffsName"].Value;

                var coeff = _model.LaborCoeffs[name];
                coeff.Level = LaborCoeffLevelConverter
                    .Convert((string)row.Cells["dgvLaborCoeffsValue"].Value);

                _model.LaborCoeffs[name] = coeff;
            }
        }

        protected void PerformAction(Action action)
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
    }
}