using BarGraphClientServerApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace BarGraphClientServerApp.Services
{
    public class TxtToObjectConverterService
    {

        public List<Bar> GetDataList()
        {
        string path = "C:/Users/Admin/source/repos/BarGraphClientServerApp/BarGraphClientServerApp/App_Data/data.txt";
            List<Bar> barList = new List<Bar>();
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();   // reads one line from the file
                        string[] barProperties = line.Split(':');   // splits the line into an array of strings, using cologne separator
                        Bar bar = new Bar() { ID = barProperties[0], Color = barProperties[1], Height = Convert.ToInt32(barProperties[2]) };     // creates a new bar object, and assigns it properties read from the file
                        barList.Add(bar);    // adds the bar object to the list
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

            return barList;
        }
    }
}