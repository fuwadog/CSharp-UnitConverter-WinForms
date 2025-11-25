using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private bool isHistoryVisible = false;
        private List<string> historyList = new List<string>();
        private int fadeStep = 20; 

        public Form1()
        {
            InitializeComponent();
            LoadUnits();
            SetupHistoryPanel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadUnits()
        {
            string[] units = { "m", "cm", "km" };
            fromBX.Items.AddRange(units);
            toBX.Items.AddRange(units);
        }

        private void SetupHistoryPanel()
        {
            panelHistory.Visible = false;
            panelHistory.BackColor = Color.FromArgb(0, Color.LightGray); 
        }

        private void convertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputTXT.Text))
                {
                    MessageBox.Show("Enter a number.");
                    return;
                }

                if (!double.TryParse(inputTXT.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    MessageBox.Show("Invalid number.");
                    return;
                }

                if (fromBX.SelectedItem == null || toBX.SelectedItem == null)
                {
                    MessageBox.Show("Select both units.");
                    return;
                }

                string fromUnit = fromBX.SelectedItem.ToString();
                string toUnit = toBX.SelectedItem.ToString();

                double resultValue = ConvertUnits(value, fromUnit, toUnit);

                resultTXT.Text = $"{resultValue:0.####} {toUnit}";
                AddHistory($"{value:0.####} {fromUnit} → {resultValue:0.####} {toUnit}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private double ConvertUnits(double value, string from, string to)
        {
            double meters = value;

            switch (from)
            {
                case "m": break;
                case "cm": meters = value / 100; break;
                case "km": meters = value * 1000; break;
            }

            switch (to)
            {
                case "m": return meters;
                case "cm": return meters * 100;
                case "km": return meters / 1000;
            }

            return value;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            inputTXT.Clear();
            resultTXT.Clear();
            fromBX.SelectedIndex = -1;
            toBX.SelectedIndex = -1;
        }

        private void AddHistory(string text)
        {
            historyList.Add(text);
            RefreshHistoryPanel();
        }

        private void RefreshHistoryPanel()
        {
            panelHistory.Controls.Clear();
            int y = 10;

            foreach (string entry in historyList)
            {
                Label lbl = new Label()
                {
                    Text = entry,
                    AutoSize = true,
                    Location = new Point(10, y),
                    Font = new Font("Yu Gothic UI", 10)
                };

                y += 25;
                panelHistory.Controls.Add(lbl);
            }
        }

        private void historyBTN_Click(object sender, EventArgs e)
        {
            if (!isHistoryVisible)
            {
                panelHistory.Visible = true;
                slidertimer.Start();
                isHistoryVisible = true;
            }
            else
            {
                panelHistory.Visible = false;
                isHistoryVisible = false;
            }
        }

        private void slidertimer_Tick(object sender, EventArgs e)
        {
            Color c = panelHistory.BackColor;
            int alpha = c.A + fadeStep;

            if (alpha >= 255)
            {
                alpha = 255;
                slidertimer.Stop();
            }

            panelHistory.BackColor = Color.FromArgb(alpha, c.R, c.G, c.B);
        }

        private void panelHistory_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
