using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trainline_Sim_Windows_Testing
{

    public partial class passengerForm : Form
    {
        public int[] pointsArray = { 0,0,0,0,0,0,0,0};
        public int[] pointsArray2 = { 60, 78, 130, 180, 220, 260, 200, 193 };

        public passengerForm()
        {
            InitializeComponent();
            
        }

        private void passengerForm_Load(object sender, EventArgs e)
        {
            chartPassengerInfo.ChartAreas[0].AxisX.Interval = 1;
            chartPassengerInfo.ChartAreas[0].AxisX.Minimum = 1;
            chartPassengerInfo.ChartAreas[0].AxisX.Maximum = 8;
            chartPassengerInfo.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chartPassengerInfo.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartPassengerInfo.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartPassengerInfo.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartPassengerInfo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPassengerInfo.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            updateGraph();
        }

        private void chartPassengerInfo_Click(object sender, EventArgs e)
        {

        }
        public void updateGraph()
        {
            chartPassengerInfo.Series[0].Points.Clear();
            for (int i = 0; i < pointsArray.Length; i++)
            {
                chartPassengerInfo.Series[0].Points.Add(pointsArray[i]);
            }

            for (int i = 0; i < pointsArray2.Length; i++)
            {

                chartPassengerInfo.Series[1].Points.Add(pointsArray2[i]);
            }
        }

    }
}
