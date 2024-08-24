using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TestingDynamik.HelpMethods
{
    public static class FileHandler
    {
        
        const string ProjectName = "TestingDynamik";
        /// <summary>
        /// Skapar ett filnamn och mapp namn 
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="fileName"></param>
        /// <returns>File Path</returns>
        public static string Setup(string folderName, string fileName)
        {
            try
            {
                return GetProjectSolutionDirectory()
                 .CreateFolder(folderName)
                 .CreateTxtFile(fileName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
           
        }

        private static string GetProjectSolutionDirectory()
        {
            //Dirctory GetParent similar example source https://stackoverflow.com/questions/35316942/loading-a-dll-in-c-sharp-from-a-relative-path 
            return Directory.GetParent(Assembly.GetEntryAssembly().Location)?.Parent?.Parent?.Parent?.FullName.Replace('\\', '/') ?? string.Empty;
        }
        /// <summary>
        /// Skapar en mapp om den fattas
        /// </summary>
        /// <param name="solutionRelativePath"></param>
        /// <param name="folderName"></param>
        /// <returns>Folder path</returns>
        private static string CreateFolder(this string solutionRelativePath, string folderName)
        {
            if (string.IsNullOrEmpty(folderName)
                || string.IsNullOrEmpty(solutionRelativePath))
                return string.Empty;

            var folderPath = solutionRelativePath += $"/{ProjectName}/{folderName}";

            //Create directory source https://www.educative.io/answers/how-to-create-a-directory-in-c-sharp
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return folderPath;
        }
        /// <summary>
        /// Creates .txt file if it is missing
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="fileName"></param>
        /// <returns>File path</returns>
        private static string CreateTxtFile(this string folderPath, string fileName)
        {
            if (string.IsNullOrEmpty(folderPath)
                || string.IsNullOrEmpty(fileName))
                return string.Empty;


            string path = $"{folderPath}/{fileName}.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }

            return path;
        }
        public static bool PrintToFile(this string path, string[] textRows)
        {

            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            try
            {
                using var sw = new StreamWriter(path);

                foreach (string row in textRows)
                {
                    sw.WriteLine(row);
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }


    }
}
