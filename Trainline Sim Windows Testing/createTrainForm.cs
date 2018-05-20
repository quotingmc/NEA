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
    public partial class createTrainForm : Form
    {
        public createTrainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAdvancedOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdvancedOptions.Checked == true)
            {
                panelAdvancedOptions.Enabled = true;
            }
            else
            {
                panelAdvancedOptions.Enabled = false;
            }
        }

        private void pictureColourSelect_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();

            //Once user presses OK button with colour selected
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureColourSelect.BackColor = colorDialog.Color;
            }

        }

        private void createTrainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
