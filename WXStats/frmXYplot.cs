using System;
using System.Drawing;
using System.Windows.Forms;
using static WXStats.Globals;

namespace WXStats
{
    public partial class frmXYplot : Form
    {

        double[] t1 = new double[Globals.pointcount];
        double[] t2 = new double[Globals.pointcount];
        int cntG;


        public frmXYplot()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            // this is the plotting place - all in the Load

            //           string tname1 = "WXROVER";
            //           string tname2 = "WXIN";
            //           int pointcount = 5000;
            //           double[,] tempData;

            int cnt = 0;
            //            double[] t1 = new double[Globals.pointcount];
            //            double[] t2 = new double[Globals.pointcount];

            classWXstnChk WXchk = new classWXstnChk(); //make an object WXck
            WXchk.cnxstring("192.168.1.15", "DAWES_SQL2008", "WeatherStation", "WeatherStation", "Esp32a.b."); //a constructor - no arguments

            Globals.tempData = WXchk.getTemperatureData(Globals.pointcount, Globals.tname1, Globals.tname2);  //this gets the data as an XY pair
                                                                                                              //there will be a lot of duplcates in this array.  Lets remove the dupes - done in the SQL


            //for scotterplot to work, these need to be in two separate Arrays, so we seperate them out in
            //this loop and we might as well get rid of the empty slots
            //maybe this would also work
            // double [] tab1 = new double[tempData.Length];

            for (int i = 0; i < pointcount - 1; i++)
            {
                if (Globals.tempData[i, 0] > 0)
                {
                    t1[i] = tempData[i, 0];
                    t2[i] = tempData[i, 1];

                    //might as well put the data in the grid
                    dgXY.Rows.Add();
                    dgXY.Rows[i].Cells["dgXYrecord"].Value = i.ToString();
                    dgXY.Rows[i].Cells["dgXYx"].Value = t1[i];
                    dgXY.Rows[i].Cells["dgXYy"].Value = t2[i];

                    cnt += 1;
                }
            }

            // the arrays are declared a certain size and are now full of 0's
            //this will reduce them down to just data.
            Array.Resize(ref t1, cnt);
            Array.Resize(ref t2, cnt);
            cntG = cnt;

            // int aa = cnt;
            int ab = t2.GetLength(0);
            // create a Population object from the data
            var popt1 = new ScottPlot.Statistics.Population(t1);
            var popt2 = new ScottPlot.Statistics.Population(t2);

            // now lets fill the stats box
            lblT1.Text = tname1;
            lblT2.Text = tname2;
            lblMeanT1.Text = Math.Round(popt1.mean, 2).ToString();
            lblMeanT2.Text = Math.Round(popt2.mean, 2).ToString();
            lblMedT1.Text = Math.Round(popt1.median, 2).ToString();
            lblMedT2.Text = Math.Round(popt2.median, 2).ToString();
            lblQ3T1.Text = popt1.Q3.ToString();
            lblq3table2.Text = popt1.Q3.ToString();
            lblQ1t1.Text = popt1.Q1.ToString();
            lblQ1T2.Text = popt2.Q1.ToString();
            lblstderrT1.Text = Math.Round(popt1.stdErr, 2).ToString();
            lblstderrT2.Text = Math.Round(popt2.stdErr, 2).ToString();
            lblstdevT1.Text = Math.Round(popt1.stDev, 2).ToString();
            lblstdevT2.Text = Math.Round(popt2.stDev, 2).ToString();
            lblIQRt1.Text = Math.Round(popt1.IQR, 2).ToString();
            lblIQRt2.Text = Math.Round(popt2.IQR, 2).ToString();
            lblNtn1.Text = cnt.ToString();//opt1.aa.ToString();
                                          // lblNtn2.Text = ab.ToString(); // popt2.count.ToString();


            //this gives us the regression line and the correlation coeficient
            var model = new ScottPlot.Statistics.LinearRegressionLine(t1, t2);
            string line = $"Y={model.slope:0.0000}X + {model.offset:0.0}";

            lblLine.Text = line;
            lblCorrel.Text = $"R² = {model.rSquared:0.0000}";

            formsPlot1.plt.Title($"ScarpWeather Temperature XY Plot");
            formsPlot1.plt.XLabel(tname1);
            formsPlot1.plt.YLabel(tname2);
            //formsPlot1.plt.AxisAuto(horizontalMargin: 0, verticalMargin: 0.5);
            //                 xmin,xmax,ymin,ymax

            int axisMin, axisMax;
            axisMin = (int)popt1.min - 2;  //get some data from the arrays
            //axisMin = 0;
            axisMax = (int)popt1.max + 2;

            formsPlot1.plt.Axis(axisMin, axisMax, axisMin, axisMax); //defines the min and max of the chart
                                                                     //            formsPlot1.plt.Axis(15,40,15,40);

            formsPlot1.plt.Legend();

            //this draws the scatter plot
            formsPlot1.plt.PlotScatter(t1, t2, Color.Red, lineWidth: 0, markerSize: 5);

            //draws the regrsson line
            // formsPlot1.plt.PlotLine(model.slope,model.offset,(t1[(int)0],t1[(int)popt1.max]),lineWidth:2);
            //formsPlot1.plt.PlotLine(model.slope,model.offset,(t1[0],t1.Length-1),lineWidth:2);
            formsPlot1.plt.PlotLine(model.slope, model.offset, (axisMin, axisMax), lineWidth: 2, color: Color.BlueViolet);

            //plot a 45 degree line = X=Y
            formsPlot1.plt.PlotLine(1.0, 0.0, (0, 100), Color.Goldenrod);

            formsPlot1.Render();//draw the chart on the PC screen


        }//end function

        private void formsPlot1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);

            MessageBox.Show("Here");
        }




        private void formsPlot1_MouseMoved(object sender, MouseEventArgs e)
        {

            //int cnt = 0;
            //double hFactor = 0.05;
            //lblPointIndex.Text = null;
            //dgXY.ClearSelection();
            var pointXY = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);  //var will end up holding the coords of the point
            lblX.Text = $@"(X: {Math.Round(pointXY.X,2).ToString()})";
            lblY.Text = $@"(Y: {Math.Round(pointXY.Y,2).ToString()})";

            ////so we have the coords of the point, maybe we can find the closest point to this from the arrays
            //double Xp = pointXY.X;
            //double Yp = pointXY.Y;
            ////so given the coordinates let iterate throgh the arrays, the data is held in Globals.tempData
            //for (int i = 0; i < cntG ; i++)
            //{
            //    //lets find X axis points
            //    if (Xp >= t1[i]-hFactor && Xp <= t1[i]+ hFactor) {
            //        if (Yp >= t2[i]- hFactor && Yp <= t2[i]+ hFactor)
            //        {
            //            cnt = i;
            //            lblPointIndex.Text = cnt.ToString();
            //            dgXY.Rows[cnt].Selected = true; //highlight the row
            //            dgXY.FirstDisplayedScrollingRowIndex = cnt;  //scroll to the top of the grid for visibility
            //            formsPlot1.plt.PlotPoint(Xp, Yp, color: Color.Magenta, markerSize: 15);
            //        }

            //    }


        }//end

        private void formsPlot1_MouseDown(object sender, MouseEventArgs e)
        {
            //int cnt = 0;
            //double hFactor = 0.05;
            //lblPointIndex.Text = null;
            //dgXY.ClearSelection();
            //var pointXY = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);  //var will end up holding the coords of the point
            //lblX.Text = pointXY.ToString();

            ////so we have the coords of the point, maybe we can find the closest point to this from the arrays
            //double Xp = pointXY.X;
            //double Yp = pointXY.Y;
            ////so given the coordinates let iterate throgh the arrays, the data is held in Globals.tempData
            //for (int i = 0; i < cntG; i++)
            //{
            //    //lets find X axis points
            //    if (Xp >= t1[i] - hFactor && Xp <= t1[i] + hFactor)
            //    {
            //        if (Yp >= t2[i] - hFactor && Yp <= t2[i] + hFactor)
            //        {
            //            cnt = i;
            //            lblPointIndex.Text = cnt.ToString();
            //            dgXY.Rows[cnt].Selected = true; //highlight the row
            //            dgXY.FirstDisplayedScrollingRowIndex = cnt;  //scroll to the top of the grid for visibility
            //            formsPlot1.plt.PlotPoint(Xp, Yp, color: Color.Magenta, markerSize: 15);
            //        }

            //    }
            //}
        }//end

        private void formsPlot1_MouseHover(object sender, EventArgs e)
        {

        }


        //double Xplast = 0;
        //double Yplast = 0;
        private void formsPlot1_MouseClicked(object sender, MouseEventArgs e)
        {
            int cnt = 0;
            double hFactor = 0.02;
            lblPointIndex.Text = null;
            //private Color bg;

            dgXY.ClearSelection();
            // formsPlot1.plt.Clear();
          //  formsPlot1.plt.PlotPoint(Xplast, Yplast, color: Color.FromArgb(System.Drawing.SystemColors.Window.ToArgb()) ,markerSize: 11);
          //  formsPlot1.plt.PlotPoint(Xplast, Yplast, color: Color.Red, markerSize: 5);
            var pointXY = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);  //var will end up holding the coords of the point
            lblX.Text = pointXY.ToString();

            //so we have the coords of the point, maybe we can find the closest point to this from the arrays
            double Xp = pointXY.X;
            double Yp = pointXY.Y;
            //so given the coordinates let iterate throgh the arrays, the data is held in Globals.tempData
            for (int i = 0; i < cntG; i++)
            {
                //lets find X axis points
                if (Xp >= t1[i] - hFactor && Xp <= t1[i] + hFactor)
                {
                    if (Yp >= t2[i] - hFactor && Yp <= t2[i] + hFactor)
                    {
                        cnt = i;
                        lblPointIndex.Text = cnt.ToString();
                        dgXY.Rows[cnt].Selected = true; //highlight the row
                        dgXY.FirstDisplayedScrollingRowIndex = cnt;  //scroll to the top of the grid for visibility
                      //  formsPlot1.plt.PlotPoint(Xp, Yp, color: Color.Green, markerSize: 10);
                     //   Xplast = Xp;
                       // Yplast = Yp;
                    }

                }
            }
        }
    }//end class
}//end namespace
