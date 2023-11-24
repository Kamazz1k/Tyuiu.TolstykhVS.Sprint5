using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.TolstykhVS.Sprint5.Task0.V10.Lib
{
    public class DataService
    {   public double Calculate()
        {
            string OutPutFile = "OutPutFileTask0.txt";

            double number1 = 1.6;
            double number2 = 2.1;
            double number3 = 7;
            double x = 2;

            double rez = number1 * Math.Pow(x, 3) - number2 * Math.Pow(x, 2) + number3 * x;
            File.AppendAllText(OutPutFile, rez.ToString()); 
            return (Math.Round(rez, 3));
              
            }
    }
}
