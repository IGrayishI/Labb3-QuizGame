using Labb3_NET22.DataModels;
using System;
using System.Collections.Generic;
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

namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        int userChoice;
        int amountOfGuesses = 0;
        int correctGuesses = 0;
            Question? currentQuiz;
            Quiz quizClass = new Quiz();
        List<Question> questionList = new List<Question>();

        public QuizWindow(List<string> listOfCatagories)
        {
            List<Question> allQuestions = quizClass.Questions.ToList();
            
            foreach (string catagory in listOfCatagories)
            {
                foreach (Question question in allQuestions)
                {
                    if (question.Catagory == catagory)
                    {
                        questionList.Add(question);
                    }
                }
            }

            InitializeComponent();
            LabelProcentageCorrectAnswers.Content = $"{amountOfGuesses + 1} / {questionList.Count}";
            NextQuesion();

        }

        private void OptionA_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 1;
            SubmitAnswer();
        }

        private void OptionB_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 2;
            SubmitAnswer();
        }

        private void OptionC_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 3;
            SubmitAnswer();
        }

        private void OptionD_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 4;
            SubmitAnswer();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //if (userChoice != 0)
            //{
                
            //    if (userChoice == currentQuiz.CorrectAnswer)
            //    {
            //        ProgressBarAmountOfQuestions.Value += 100 / questionList.Count;
            //        NextQuesion();
            //        MessageBox.Show("Correct!");
                    
            //    } else
            //    {
            //        ProgressBarAmountOfQuestions.Value += 100 / questionList.Count;
            //        NextQuesion();
            //        MessageBox.Show("Not Correct.");
            //    }
            //} else
            //{
            //    MessageBox.Show("Please select an answer");
            //}
        }

        private void SubmitAnswer()
        {
            
            if (userChoice != 0)
            {
                LabelProcentageCorrectAnswers.Content = $"{amountOfGuesses +1} / {questionList.Count}";
                amountOfGuesses++;
                
                if (userChoice == currentQuiz.CorrectAnswer)
                {
                    correctGuesses++;
                    MessageBox.Show("Correct!");

                    ProgressBarAmountOfQuestions.Value += 100 / questionList.Count;
                }
                else
                {
                    MessageBox.Show("Not Correct.");
                }
            }
            else
            {
                MessageBox.Show("Please select an answer");
            }
            
            if (amountOfGuesses == questionList.Count) { Back(); }
            NextQuesion();
            
        }

        private void ButtonNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            NextQuesion();
        }

        private void NextQuesion()
        {
            currentQuiz = quizClass.GetRandomQuestion(questionList);
            LabelQuestion.Text = currentQuiz.Statement;
            LabelOptionA.Content = currentQuiz.Answers[0];
            LabelOptionB.Content = currentQuiz.Answers[1];
            LabelOptionC.Content = currentQuiz.Answers[2];
            LabelOptionD.Content = currentQuiz.Answers[3];
            userChoice = 0;
            string? imagePath = currentQuiz.ImagePath; // The path to your new image
            if (imagePath != "null" && imagePath != null)
            {
                Uri imageUri = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                ImageQuestion.Source = new BitmapImage(imageUri);
                return;
            }

            
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Back();
        }

        private void Back()
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
