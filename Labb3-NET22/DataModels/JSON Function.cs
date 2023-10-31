using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labb3_NET22.DataModels
{
    class JSON_Function
    {
        /// <summary>
        /// Generate the save file location and default questions.
        /// </summary>
        public static async void GenerateDataFolder()
        {
            string folderPath = FolderPath();
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    GeneratedQuestions gQ = new();
                    
                    Directory.CreateDirectory(folderPath); 
                    MessageBox.Show("Folder Created");

                   await SaveJSONList(gQ.allQuestions);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Catch Error");
            }
        }
        /// <summary>
        /// Method that saves to list and returns Task, for async methods.
        /// </summary>
        /// <param name="questions"></param>
        /// <returns></returns>
        public static Task SaveJSONList(List<Question> questions)
        {
            var Json = JsonConvert.SerializeObject(questions, Formatting.Indented);

            File.WriteAllText(FullPath(), Json);

            return Task.CompletedTask;
        }
        /// <summary>
        /// Returns the objects from the list and adds it to question list.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Question> LoadJSONList()
        {
            try
            {
                string json = File.ReadAllText(FullPath());

                if (json != string.Empty)
                {
                    return JsonConvert.DeserializeObject<List<Question>>(json);
                }
                else { MessageBox.Show("Load Error"); return null;  }
            }
            catch (Exception) { return null; }
        }
        /// <summary>
        /// Gets the folder path.
        /// </summary>
        /// <returns></returns>
        private static string FolderPath()
        {
            string folderName = "SimpleQuizGame";
            string localAppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = System.IO.Path.Combine(localAppdataPath, folderName);

            return folderPath;
        }
        /// <summary>
        /// Sets the path for the textfile list.
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        private static string TextPath(string folderPath)
        {
            string textName = "ListWithQuestions.txt";
            string textPath = System.IO.Path.Combine(folderPath, textName);

            return textPath;
        }
        /// <summary>
        /// Both FolderPath and Text Combined.
        /// </summary>
        /// <returns></returns>
        public static string FullPath()
        {
            string folderPath = FolderPath();
            string textPath = TextPath(folderPath);

            return textPath;
        }
    }
}
