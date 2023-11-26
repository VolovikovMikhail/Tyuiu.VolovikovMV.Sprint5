using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VolovikovMV.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int count1 = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '0' | line[i] == '1' | line[i] == '2' | line[i] == '3' | line[i] == '4' | line[i] == '5' | line[i] == '6' | line[i] == '7' | line[i] == '8' | line[i] == '9')
                        {
                            count++;
                            if (count == 5)
                            {
                                count1 += 1;
                                count = 0;
                            }
                        }
                    }
                }
            }
            return count1;
        }
    }
}
