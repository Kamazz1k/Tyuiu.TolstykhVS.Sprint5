using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.TolstykhVS.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)

                {
                    double num = Convert.ToDouble(line);
                    if (num % 5 == 0)
                    {
                        double min = 0;
                        if (num > min)
                        {
                            min = num;
                        }
                        res = min;
                    }
                }
            }
            return res;
        }
    }
}