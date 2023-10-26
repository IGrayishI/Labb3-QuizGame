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
        public MainWindow()
        {
            JSON_Function.GenerateDataFolder();
            InitializeComponent();


        }

        /// <summary>
        /// Generates the Appdata Folder on runtime
        /// </summary>
        

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

            if (listOfCatagories.Count != 0)
            {
                QuizWindow quizWindow = new QuizWindow(listOfCatagories);
                this.Close();
                quizWindow.Show();
            } else
            {
                MessageBox.Show("Please Select Catagories");
            }
        }

        private void EditQuiz_Click(object sender, RoutedEventArgs e)
        {
            EditQuizWindow editWindow = new EditQuizWindow();
            this.Close();
            editWindow.Show();
        }

        private void QuitQuiz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
