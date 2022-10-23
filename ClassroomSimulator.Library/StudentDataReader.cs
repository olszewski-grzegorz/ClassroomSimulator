﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassroomSimulator.Library
{
    public class StudentDataReader
    {
        public static List<string> GetStudentNamesFromFile(string fileName)
        {
           string content = File.ReadAllText(fileName);
            return GetStudentNamesFromString(content);
        }

        public static List<string> GetStudentNamesFromString(string content)
        {
           string[] unformatedNames = content.Split(',');
            List<string> studentNames = new List<string>();
            foreach (var unformatedName in unformatedNames)
            {
                string name = unformatedName.Trim();
                studentNames.Add(name);
                
            }
            return studentNames;
        }
    }
}
