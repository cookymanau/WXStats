using System;
using System.Drawing;
using System.Windows.Forms;


namespace WXStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
   //         double[] dataX = new double[] { 1, 2, 3, 4, 5, 6, 7, 8 };
   //         double[] dataY = new double[] { 1, 4, 9, 16, 25, 23, 20, 13 };
            //formsPlot1.plt.PlotScatter(dataX, dataY);
    //        formsPlot1.plt.PlotScatter(dataX, dataY, Color.Red, lineWidth: 0, markerSize: 10);
      //      formsPlot1.Render();

        }

        private void getDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tname1 = "WXIN";
            string tname2 = "WXROVER";

            int pointcount = 50000;
            double[] tname1Data;
            double[] tname2Data;

            classWXstnChk WXchk = new classWXstnChk(); //make an object WXck

            //lets setup the datbase
            WXchk.cnxstring("192.168.1.15", "DAWES_SQL2008", "WeatherStation", "WeatherStation", "Esp32a.b."); //a constructor - no arguments

           tname1Data =  WXchk.getTemperatureData(pointcount, tname1);
           tname2Data =  WXchk.getTemperatureData(pointcount, tname2);



            formsPlot1.plt.PlotScatter(tname1Data, tname2Data, Color.Red, lineWidth: 0, markerSize: 5);
            formsPlot1.Render();

        }
    }
}
