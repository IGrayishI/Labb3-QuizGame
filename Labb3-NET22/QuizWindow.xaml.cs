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
        //Fields
        double _correctAnswerProcent;
        private int _userChoice;
        private int _amountOfGuesses = 0;
        private int _correctGuesses = 0;

        Question? currentQuiz;
        Quiz quizClass = new Quiz();
        List<Question> questionList = new List<Question>();

        //Constructor --------------------------------------------------------------------------------------------
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
            LabelQuestionNumeral.Content = $"{_amountOfGuesses + 1} / {questionList.Count}";
            NextQuesion();

        }

        //Methods ------------------------------------------------------------------------------------------------
        //Sets the users choice to 1, checks if its right and then adds a new question.
        private void OptionA_Click(object sender, RoutedEventArgs e)
        {
            _userChoice = 1;
            SubmitAnswer();
        }

        //Sets the users choice to 2, checks if its right and then adds a new question.
        private void OptionB_Click(object sender, RoutedEventArgs e)
        {
            _userChoice = 2;
            SubmitAnswer();
        }

        //Sets the users choice to 3, checks if its right and then adds a new question.
        private void OptionC_Click(object sender, RoutedEventArgs e)
        {
            _userChoice = 3;
            SubmitAnswer();
        }

        //Sets the users choice to 4, checks if its right and then adds a new question.
        private void OptionD_Click(object sender, RoutedEventArgs e)
        {
            _userChoice = 4;
            SubmitAnswer();
        }

        //A method, that checks if the answer given is correct.
        //If all questions have been answered, it sends the user back to the main window.
        private void SubmitAnswer()
        {
            if (_userChoice != 0)
            {
                LabelQuestionNumeral.Content = $"{_amountOfGuesses + 1} / {questionList.Count}";
                _amountOfGuesses++;

                if (_userChoice == currentQuiz.CorrectAnswer)
                {
                    _correctGuesses++;
                    MessageBox.Show("Correct!");

                    _correctAnswerProcent += 100 / questionList.Count; 
                    ProgressBarAmountOfQuestions.Value += 100 / questionList.Count;
                    LabelProcentageCorrect.Content = $"{_correctAnswerProcent}%";
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
            if (_amountOfGuesses == questionList.Count) { MessageBox.Show($"Thats all the questions! Your score is {_correctAnswerProcent}%."); Back(); }
            NextQuesion();

        }

        //See NextQuestion
        private void ButtonNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            NextQuesion();
        }

        //Gets a new question, sets the labels with the content and adds a picture if any are given.
        private void NextQuesion()
        {
            currentQuiz = quizClass.GetRandomQuestion(questionList);
            LabelQuestion.Text = currentQuiz.Statement;
            LabelOptionA.Content = currentQuiz.Answers[0];
            LabelOptionB.Content = currentQuiz.Answers[1];
            LabelOptionC.Content = currentQuiz.Answers[2];
            LabelOptionD.Content = currentQuiz.Answers[3];
            _userChoice = 0;

            string? imagePath = currentQuiz.ImagePath;
            Uri imageUri = new Uri(imagePath, UriKind.RelativeOrAbsolute);

            if (imagePath.StartsWith("http://") || imagePath.StartsWith("https://"))
            {
                ImageQuestion.Source = new BitmapImage(imageUri);
                return;
            }
        }

        //See Back
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Back();
        }

        //Creates a new mainWindow, and switches to it.
        private void Back()
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
