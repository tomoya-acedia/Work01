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

        //フィートからメートルへの対応表を出力
        //引数:start 最初の値
        //     stop  最後の値
        static void PrintFeetToMeter(int start,int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                Console.WriteLine("{0}ft = {1:0.0000}", feet, feet * 0.3048);
            }
        }

        //メートルからフィートへの対応表を出力
        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                Console.WriteLine("{0}ft = {1:0.0000}", feet, feet * 3.28084);
            }
        }
    }
}
