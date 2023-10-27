using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Labb3_NET22.DataModels;

namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for EditQuizWindow.xaml
    /// </summary>
    public partial class EditQuizWindow : Window
    {

        Quiz editQuizList = new Quiz();
        int[] answerArray = new int[] { 1, 2, 3, 4 };

        //Constructor --------------------------------------------------------------------
        public EditQuizWindow()
        {
            InitializeComponent();
            ListOfQuestions.ItemsSource = editQuizList.Questions;
            ComboBoxCatagoryChoices.ItemsSource = Question.ListOfCatagory;
            ComboBoxRightAnswerInt.ItemsSource = answerArray;

        }

        //Methods -------------------------------------------------------------------------
        //Adds a new question to the IEnumerable list of question, with or without a image.
        private void ButtonAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxRightAnswerInt.SelectedItem is int rightAnswer && ComboBoxCatagoryChoices.Text != null && TextBoxStatement.Text != null && TextBoxAnswer1.Text != null && TextBoxAnswer2.Text != null && TextBoxAnswer3.Text != null && TextBoxAnswer4.Text != null)
            {
                if (TextBoxImage == null)
                {
                    editQuizList.AddQuestion(ComboBoxCatagoryChoices.Text, TextBoxStatement.Text, rightAnswer, TextBoxAnswer1.Text, TextBoxAnswer2.Text, TextBoxAnswer3.Text, TextBoxAnswer4.Text);
                    editQuizList = new();
                    ListOfQuestions.ItemsSource = editQuizList.Questions;

                }
                else
                {
                    editQuizList.AddQuestion(ComboBoxCatagoryChoices.Text, TextBoxStatement.Text, rightAnswer, TextBoxImage.Text, TextBoxAnswer1.Text, TextBoxAnswer2.Text, TextBoxAnswer3.Text, TextBoxAnswer4.Text);
                    editQuizList = new();
                    ListOfQuestions.ItemsSource = editQuizList.Questions;

                }
            }
            else
            {
                MessageBox.Show("Please select a right answer.");
            }
        }

        //instantiate a new mainwindow and switches to it.
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        //Sends the index of a question to be removed from the IEnumerable list of questions.
        private void ButtonRemoveQuestion_Click(object sender, RoutedEventArgs e)
        {
            editQuizList.RemoveQuestion(ListOfQuestions.SelectedIndex);
            editQuizList = new();
            ListOfQuestions.ItemsSource = editQuizList.Questions;
        }

        //Overwrites the question, in question, by sending the corrected info and index.
        private void ButtonEditQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxRightAnswerInt.SelectedItem is int rightAnswer)
            {
                editQuizList.EditQuestion(ListOfQuestions.SelectedIndex, ComboBoxCatagoryChoices.Text, TextBoxStatement.Text, rightAnswer, TextBoxImage.Text, TextBoxAnswer1.Text, TextBoxAnswer2.Text, TextBoxAnswer3.Text, TextBoxAnswer4.Text);
                editQuizList = new();
                ListOfQuestions.ItemsSource = editQuizList.Questions;
            }
            else
            {
                MessageBox.Show("Please select a right answer.");
            }
        }

        //A Method that adds the information of a question from the list on selection
        private void ListOfQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ListOfQuestions.SelectedItem is Question question)
            {
                TextBoxStatement.Text = question.Statement;
                TextBoxAnswer1.Text = question.Answers[0];
                TextBoxAnswer2.Text = question.Answers[1];
                TextBoxAnswer3.Text = question.Answers[2];
                TextBoxAnswer4.Text = question.Answers[3];
                TextBoxImage.Text = question.ImagePath;

                ComboBoxCatagoryChoices.Text = question.Catagory;

                ComboBoxRightAnswerInt.SelectedItem = question.CorrectAnswer;
            }

        }

        //Clears all textboxes, to make it easier to type in a new question.
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxStatement.Text = string.Empty;
            TextBoxAnswer1.Text = string.Empty;
            TextBoxAnswer2.Text = string.Empty;
            TextBoxAnswer3.Text = string.Empty;
            TextBoxAnswer4.Text = string.Empty;

            ComboBoxCatagoryChoices.Text = string.Empty;

            ComboBoxRightAnswerInt.SelectedItem = null;
        }
    }
}
