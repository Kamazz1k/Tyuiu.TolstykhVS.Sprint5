using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.TolstykhVS.Sprint5.Task7.V16.Lib
{

    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            path = @"C:\DataSprint5\InPutDataFileTask7V16.txt";
            string fileContent = File.ReadAllText(path);
            string replace = Regex.Replace(fileContent, @"\s\w{2}\s",  " XY ");
            File.AppendAllText(pathSaveFile, replace + Environment.NewLine);
            return pathSaveFile;

        }
    }
}
     

