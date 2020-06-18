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
                //フィートからメートルへの対応表を出力
                PrintFeetToMeter(5, 50);
            }
            else
            {
                //メートルからフィートへの対応表
                PrintMeterToFeetList(10,100);
            }
        }

        //static FeetConverter feetConverter = new FeetConverter();

        //フィートからメートルへの対応表を出力
        static void PrintFeetToMeter(int start,int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                Console.WriteLine("{0}ft = {1:0.0000}", feet, FeetConverter.ToMeter(feet));
            }
        }

        //メートルからフィートへの対応表を出力
        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                Console.WriteLine("{0}ft = {1:0.0000}", meter, FeetConverter.FromMeter(meter));
            }
        }
    }
}
