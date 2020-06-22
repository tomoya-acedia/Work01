using System;                         
using System.Collections.Generic;     
using System.Linq;                    
using System.Text;                    
using System.Threading.Tasks;         
                                      
namespace DistanceConverter           
{                                     
    //フィートとメートルの単位変換クラス
    public static class FeetConverter 
    {                                 
        private const double retio = 0.3048;
        //メートルからフィートを求める(静的メソッドとして定義)
        public static double FromMeter(double meter)
        {                             
            return meter / retio;     
        }                             
                                      
        //フィートからメートルを求める(静的メソッドとして定義)
        public static double ToMeter(double feet)
        {                             
            return feet * retio;      
        }                             

    }
}
