using System;
using System.Drawing;
using System.Windows.Forms;
using static WXStats.Globals;
using System.Collections.Generic;

namespace WXStats
{
    public partial class frmXYplot : Form
    {

        double[] t1 = new double[Globals.pointcount];
        double[] t2 = new double[Globals.pointcount];
        double[] t1qq = new double[Globals.pointcount];
        double[] t2qq = new double[Globals.pointcount];
        int cntG;
        double dgXY_X; //this will hold the index number from the selected cell in the datagrid
        double dgXY_Y; //this will hold the index number from the selected cell in the datagrid
        bool plotRegression = true;
        bool plotErrorLines = true;
        bool plot45line = true;
        bool showLegendYN = true;
        bool showQQ = false;
        bool showXY = true;

        // vars for being able to turn on or off bits of the plot
        ScottPlot.PlottableScatter regLine;
        ScottPlot.PlottableScatter errorLineA;
        ScottPlot.PlottableScatter errorLineB;
        ScottPlot.PlottableScatter XequalsYLine;
        ScottPlot.PlottableScatter hiLitePoints;
        ScottPlot.PlottableScatter QQplotPoints;
        ScottPlot.PlottableScatter XYplotPoints;

        

        public frmXYplot()
        {
            InitializeComponent();
 //           btnRegression.BackColor = Color.LightGreen;
 //           btnError.BackColor = Color.LightGreen;
 //           btn45Line.BackColor = Color.LightGreen;

            //turn off the right click
            formsPlot1.Configure(enableRightClickMenu: false);  //this does not work
            formsPlot1.ContextMenuStrip = null;  //this works but kills the program eventually

            ContextMenuStrip customMenu = new ContextMenuStrip();
            customMenu.Items.Add(new ToolStripMenuItem("Legend     Toggle", null, new EventHandler(LegendToggle)));
            customMenu.Items.Add(new ToolStripMenuItem("X=Y Line   Toggle", null, new EventHandler(XYToggle)));
            customMenu.Items.Add(new ToolStripMenuItem("10% Error  Toggle", null, new EventHandler(error10pctToggle)));
            customMenu.Items.Add(new ToolStripMenuItem("Regression Toggle", null, new EventHandler(RegressionToggle)));
            customMenu.Items.Add(new ToolStripSeparator());
            customMenu.Items.Add(new ToolStripMenuItem("Show XY Data", null, new EventHandler(XYplotToggle)));
            customMenu.Items.Add(new ToolStripMenuItem("Show QQ Data", null, new EventHandler(QQplotToggle)));
            customMenu.Items.Add(new ToolStripSeparator());

            customMenu.Items.Add(new ToolStripMenuItem("Help", null, new EventHandler(Help)));
            formsPlot1.ContextMenuStrip = customMenu;


            // as a play lets add one to the datagrid
            ContextMenuStrip dgXYmenu = new ContextMenuStrip();
            dgXYmenu.Items.Add(new ToolStripMenuItem("XY", null, new EventHandler(dgXYPlotMenuItem)));
            dgXYmenu.Items.Add(new ToolStripMenuItem("XY Clear", null, new EventHandler(dgXYClearMenuItem)));
            dgXYmenu.Items.Add(new ToolStripSeparator());
            dgXYmenu.Items.Add(new ToolStripMenuItem("Help", null, new EventHandler(dgXYHelpMenuItem)));
            dgXY.ContextMenuStrip = dgXYmenu;

        }


        private void dgXYClearMenuItem(object sender, EventArgs e)
        {

            hiLitePoints.visible = false;
            formsPlot1.Render();//draw the chart on the PC screen
        }

        private void dgXYPlotMenuItem(object sender, EventArgs e)
        {
            var row = this.dgXY.CurrentRow;
            dgXY_X = (double)row.Cells["dgXYx"].Value;
            dgXY_Y = (double)row.Cells["dgXYy"].Value;

            hiLitePoints = formsPlot1.plt.PlotPoint(dgXY_X, dgXY_Y, color: Color.Magenta, markerSize: 10);
            formsPlot1.Render();//draw the chart on the PC screen

        }




        private void dgXYHelpMenuItem(object sender, EventArgs e)
        {

            string helptxt = $@"
This grid shows you the data returned from the SQL
database.  When you click on a point in XY plot
the corresponding line will be shown highlighted.
";
            MessageBox.Show(helptxt);


        }

        private void Help(object sender, EventArgs e)
        {
            //formsPlot1.plt.Clear();
            //formsPlot1.plt.AxisAuto();
            //formsPlot1.Render();
            string helpText = $@"
This is a new XY Plot of paired values.  You can
can zoom, pan and get values for the points in
the XY plot.  

Zoom using the mouse wheel or marquee zoom by 
clicking the mouse wheel and dragging.

Use the buttons at the bottom of the plot to 
toggle items off and on.  Green is on.

Click on a point to see its values in the data
grid.  You may have to zoom in for this to work.

Use the windows snipping tool to screen shot and 
put into a document.

";

            MessageBox.Show(helpText, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);


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

            // a couple of local lists
            List<double> orgs = new List<double> { };
            List<double> chks = new List<double> { };




            classWXstnChk WXchk = new classWXstnChk(); //make an object WXck
            WXchk.cnxstring("192.168.1.15", "DAWES_SQL2008", "WeatherStation", "WeatherStation", "Esp32a.b."); //a constructor - no arguments

            //go get the data
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
                    t1qq[i] = tempData[i, 0];
                    t2qq[i] = tempData[i, 1];

                    //might as well put the data in the grid
                    dgXY.Rows.Add();
                    try
                    {
                        dgXY.Rows[i].Cells["dgXYrecord"].Value = i.ToString(); //puts the record no on the dgXY
                        dgXY.Rows[i].Cells["dgXYx"].Value = t1[i];
                        dgXY.Rows[i].Cells["dgXYy"].Value = t2[i];
                   } 
                    catch { }

                    cnt += 1;
                }
            }//end of for loop

            // we have two arrays lets sort them to form a QQ plot
            Array.Sort(t1qq);
            Array.Sort(t2qq);
           


            // the arrays are declared a certain size and are now full of 0's
            //this will reduce them down to just data.
            // if there is no data in the arrays then cnt will = 0
            if (cnt == 0)
            {

                MessageBox.Show("No Data in your selection." , "No data",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }


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

            
            formsPlot1.plt.Legend();  // got ot have this be we toggle it with hte context menu

            //this draws the scatter plot
            XYplotPoints = formsPlot1.plt.PlotScatter(t1, t2, Color.DarkCyan, lineWidth: 0, markerSize: 5,label:"XYData");
            //draw the QQ plot
            QQplotPoints = formsPlot1.plt.PlotScatter(t1qq, t2qq, Color.DarkGreen, lineWidth: 0, markerSize: 5,label:"QQData");
            QQplotPoints.visible = false;

            // draws the regresion line
            //if (plotRegression)
            regLine =   formsPlot1.plt.PlotLine(model.slope, model.offset, (axisMin, axisMax), lineWidth: 2, label:"Regression",color: Color.BlueViolet);

            //plot a 45 degree line = X=Y
            XequalsYLine = formsPlot1.plt.PlotLine(1.0, 0.0, (0, 100), Color.Goldenrod,lineWidth:2,label:"X=Y",lineStyle:ScottPlot.LineStyle.Dot); //uses the equation of the line to plot

            //the 10% error lines
            errorLineA = formsPlot1.plt.PlotLine(0, 0, 100.0 - 0.1 * 100, 100, color: Color.OrangeRed, lineWidth: 2, label:"10%error", lineStyle: ScottPlot.LineStyle.Dash);
            errorLineB =  formsPlot1.plt.PlotLine(0, 0, 100,100.0 - 0.1 * 100, color: Color.OrangeRed, lineWidth: 2, lineStyle:ScottPlot.LineStyle.Dash);

            formsPlot1.Render();//draw the chart on the PC screen


        }//end function

        private void formsPlot1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);

            MessageBox.Show("Here");
        }




        private void formsPlot1_MouseMoved(object sender, MouseEventArgs e)
        {
            var pointXY = formsPlot1.plt.CoordinateFromPixel(e.X, e.Y);  //var will end up holding the coords of the point
            lblX.Text = $@"(X: {Math.Round(pointXY.X,2).ToString()})";
            lblY.Text = $@"(Y: {Math.Round(pointXY.Y,2).ToString()})";
        }//end


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
                    }

                }
            }
        }//end function



        private void LegendToggle(object sender, EventArgs e)
        {
            showLegendYN = !showLegendYN;

            if (showLegendYN)
                formsPlot1.plt.Legend(enableLegend: true);
            else
                formsPlot1.plt.Legend(enableLegend: false);

            formsPlot1.Render();
        }

        private void XYToggle(object sender, EventArgs e)
        {
            plot45line = !plot45line;

            XequalsYLine.visible = plot45line;
            formsPlot1.Render();
        }


        private void error10pctToggle(object sender, EventArgs e)
        {
            plotErrorLines = !plotErrorLines;
            errorLineA.visible = plotErrorLines;
            errorLineB.visible = plotErrorLines;
            formsPlot1.Render();//(re)draw the chart on the PC screen

        }

        private void RegressionToggle(object sender, EventArgs e)
        {
            plotRegression = !plotRegression;  //this should cause the toggle
            regLine.visible = plotRegression;
            formsPlot1.Render();//(re)draw the chart on the PC screen
        }

        private void QQplotToggle(object sender, EventArgs e)
        {
            //throw new NotImplementedException();


            showQQ = !showQQ;
            QQplotPoints.visible = showQQ;
            formsPlot1.Render();//(re)draw the chart on the PC screen
            

        }


        private void XYplotToggle(object sender, EventArgs e)
        {
            showXY = !showXY;
            XYplotPoints.visible = showXY;
            formsPlot1.Render();//(re)draw the chart on the PC screen
        }












    }//end class
}//end namespace
