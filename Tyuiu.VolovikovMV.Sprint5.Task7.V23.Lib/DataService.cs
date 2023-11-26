using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.VolovikovMV.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(pathSaveFile); }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string strLine = "";
                while ((line = reader.ReadLine()) != null)
                {
                    strLine = Regex.Replace(line, @"\b[а-яё]+\b", "", RegexOptions.IgnoreCase);

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
