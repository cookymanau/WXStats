using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXStats
{
    public static class Globals  //I added public static  : this is for Global variable across the namespace
    {

        //here are the arrays I dont want to pass across forms!!
        public static double[,] tempData;  //modifiable array 2D for temperature
        public static double[] tempDataS; //1d array 
        public static double[] tempDataDate; //1d array for the dates

        public static string tname1; //the first tablename that we name
        public static string tname2; //the first tablename that we name
        public static string fieldname;
        public static int pointcount;


        //set this so I dont have to keep selecting dates
        public static DateTime startDate = DateTime.Parse("1-Apr-2020");
        public static DateTime endDate = DateTime.Parse("20-Apr-2020");


    }
}
