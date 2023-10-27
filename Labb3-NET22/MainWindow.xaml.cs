using Labb3_NET22.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constructor --------------------------------------------------------------
        public MainWindow()
        {
            JSON_Function.GenerateDataFolder();
            InitializeComponent();
        }

        /// <summary>
        /// Generates the Appdata Folder on runtime
        /// </summary>

        //Methods ------------------------------------------------------------------------------------------
        //Checks if any checkboxes are checked, and sends the catagories to create a quiz in the QuizWindow
        //If not, promps the user to add catagories to the quiz
        private void StartQuiz_Click(object sender, RoutedEventArgs e)
        {
            List<string> listOfCatagories = new List<string>();


            if (CheckBoxHistory.IsChecked == true)
            {
                listOfCatagories.Add("History");
            }
            if (CheckBoxScience.IsChecked == true)
            {
                listOfCatagories.Add("Science");
            }
            if (CheckBoxLiterature.IsChecked == true)
            {
                listOfCatagories.Add("Literature");
            }
            if (CheckBoxGeography.IsChecked == true)
            {
                listOfCatagories.Add("Geography");
            }
            if (CheckBoxMathematics.IsChecked == true)
            {
                listOfCatagories.Add("Mathematics");
            }
            if (CheckBoxMisc.IsChecked == true)
            {
                listOfCatagories.Add("Misc");
            }

            if (listOfCatagories.Count != 0)
            {
                QuizWindow quizWindow = new QuizWindow(listOfCatagories);
                this.Close();
                quizWindow.Show();
            }
            else
            {
                MessageBox.Show("Please Select Catagories");
            }
        }

        //Creates a new EditQuizWindow and switches to it.
        private void EditQuiz_Click(object sender, RoutedEventArgs e)
        {
            EditQuizWindow editWindow = new EditQuizWindow();
            this.Close();
            editWindow.Show();
        }

        //Closes mainWindow, which ends the program.
        private void QuitQuiz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
