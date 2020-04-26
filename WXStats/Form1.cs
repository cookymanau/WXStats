using System;
using System.Drawing;
using System.Windows.Forms;

// this is a semi experimental program to test out the
// scottplot plotting/charting program.  So far we have 
//developed a  pretty good XY plot for testing and I think it
// woulod be fine foir the QAQC dashboard.  Better than the one  I wrote in
//any case.

namespace WXStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xYPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.tname1 = comboBoxTn1.Text;
            Globals.tname2 = comboBoxTn2.Text;
            Globals.pointcount = int.Parse(textBoxNoPoints.Text);

            frmXYplot XYplot = new frmXYplot();
            XYplot.Show();
        } // end of function

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Globals.startDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Globals.endDate = dateTimePicker2.Value;
        }

        private void comboBoxTempPlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.tname1 = comboBoxTempPlot.Text;
        }

        private void temperaturePlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.tname1 = comboBoxTempPlot.Text;
            Globals.pointcount = int.Parse(textBoxNoPoints.Text);
            frmTempPlot tplot = new frmTempPlot();
            tplot.Show();
        }
    }//end class
}
