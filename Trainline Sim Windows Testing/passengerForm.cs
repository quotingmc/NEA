using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainline_Sim_Windows_Testing
{
    public partial class passengerForm : Form
    {
        public passengerForm()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void passengerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
