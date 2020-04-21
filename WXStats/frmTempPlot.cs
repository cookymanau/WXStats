using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WXStats
{
    public partial class frmTempPlot : Form
    {
        public frmTempPlot()
        {
            InitializeComponent();
        }//end

        private void formsPlot1_Load(object sender, EventArgs e)
        {



            classWXstnChk WXchk = new classWXstnChk(); //make an object WXck
            WXchk.cnxstring("192.168.1.15", "DAWES_SQL2008", "WeatherStation", "WeatherStation", "Esp32a.b."); //a constructor - no arguments

            Globals.fieldname = "TEMP";
            Globals.tempDataS = WXchk.getTemperatureData(Globals.pointcount, Globals.tname1);  //this gets the data as an XY pair

            Globals.fieldname = "TIME";
            Globals.tempDataDate = WXchk.getTemperatureData(Globals.pointcount, Globals.tname1);  //this gets the data as an XY pair



            formsPlot1.plt.PlotScatter(Globals.tempDataS, Globals.tempDataDate,lineWidth:1,color:Color.Red);   //   (Globals.tempDataS, sampleRate:1,xOffset:0,yOffset:0,color:Color.Red,lineWidth:1,markerSize:4,label:null,maxRenderIndex:null);
                                                                                                               // formsPlot1.plt.PlotScatter()
            formsPlot1.Render();//draw the chart on the PC screen

        }//end
    }//end class
}// end namespace
