using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        //-tom フィートからメートルへの対応表
        //-tof メートルからフィートへの対応表
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tof")
            {
                //フィートからメートルへの対応表
                for (int feet = 1; feet <= 10; feet++)
                {
                    //double meter = feet * 0.3048;
                    Console.WriteLine("{0}ft = {1:0.0000}m", feet, FeetToMeter(feet));
                }
            }
            else
            {
                for (int meter = 1; meter <= 10; meter++)
                {
                    //double meter = feet * 0.3048;
                    Console.WriteLine("{0}m = {1:0.0000}ft", meter, MeterToFeet (meter));
                }
            }
        }

        //フィートからメートルを求める
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        //メートルからフィートを求める
        static double MeterToFeet(int meter)
        {
            return meter * 3.2808;
        }
    }
}
