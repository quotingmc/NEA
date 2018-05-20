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
        public passengerForm()
        {
            InitializeComponent();
            
        }

        private void passengerForm_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 8;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            int[] pointsArray = { 100, 120, 195, 210, 235, 210, 187, 200 };
            int[] pointsArray2 = { 60, 78, 130, 180, 220, 260, 200, 193 };
            for (int i = 0; i < pointsArray.Length; i++)
            {

                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[0].Points.Add(pointsArray[i]);


            }

            for (int i = 0; i < pointsArray2.Length; i++)
            {

                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[1].Points.Add(pointsArray2[i]);
            }
        }
    }
}
