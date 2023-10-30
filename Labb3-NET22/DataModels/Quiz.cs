using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.IO;
using System.Windows;

namespace Labb3_NET22.DataModels;
public class Quiz
{
    private IEnumerable<Question> _questions;
    private string _title = string.Empty;
    public IEnumerable<Question> Questions => _questions;
    public string Title => _title;

    

    List<int> usedQuestions = new();    


    public Quiz()
    {
        _questions = JSON_Function.LoadJSONList();
    }

    public Question GetRandomQuestion(List<Question> listOfQuestions)
    {
        bool isRunning = true;

        Random r = new Random();
        while (isRunning) 
        {
            int randomIndex = r.Next(0 , listOfQuestions.Count());

            if (!usedQuestions.Contains(randomIndex))
            {
                usedQuestions.Add(randomIndex);
                Question randomQuestion = listOfQuestions[randomIndex];
                if (randomQuestion.ImagePath == "null")
                {
                    randomQuestion.ImagePath = "/Images/CatWithShades.jpg";
                }
                return randomQuestion;
            } else if (usedQuestions.Count() == listOfQuestions.Count())
            {
                usedQuestions.Clear();
            }
        }
        throw new NotImplementedException("A random Question needs to be returned here!");
    }

    public void AddQuestion(string catagory, string statement, int correctAnswer, params string[] answers)
    {
        Question newQuestion = new Question(catagory, statement, correctAnswer, "null", answers);
        Quiz editQuizList = new Quiz();
        
        if ( editQuizList != null)
        {
            List<Question>allQuestionsList = Questions.ToList();
            allQuestionsList.Add(newQuestion);

            JSON_Function.SaveJSONList(allQuestionsList);
            return;
        } else
        {
            MessageBox.Show("Save Error");
            return;
        }
        throw new NotImplementedException("Question need to be instantiated and added to list of questions here!");
    }
    public async void AddQuestion(string catagory, string statement, int correctAnswer, string imagePath = "null", params string[] answers)
    {
        Question newQuestion = new Question(catagory, statement, correctAnswer, imagePath, answers);
        Quiz editQuizList = new Quiz();

        if (editQuizList != null)
        {
            List<Question> _questions = editQuizList.Questions.ToList();
            _questions.Add(newQuestion);

           await JSON_Function.SaveJSONList(_questions);
        }
        else
        {
            MessageBox.Show("Save Error");
        }
    }

    public void RemoveQuestion(int index)
    {
        Quiz editQuizList = new Quiz();

        if (editQuizList != null)
        {
            List<Question> _questions = editQuizList.Questions.ToList();
            _questions.RemoveAt(index);

            JSON_Function.SaveJSONList(_questions);
            return;
        }
        else
        {
            MessageBox.Show("Delete Error");
            return;
        }
        throw new NotImplementedException("Question at requested index need to be removed here!");
    }

    public void EditQuestion(int index, string catagory, string statement, int correctAnswer, string imagePath = "null", params string[] answers)
    {
        Question newQuestion = new Question(catagory, statement, correctAnswer, imagePath, answers);
        Quiz editQuizList = new Quiz();
        List<Question> _questions = editQuizList.Questions.ToList();

        if (editQuizList != null)
        {
            if (newQuestion == _questions[index])
            {
                return;
            }
            _questions[index] = newQuestion;

            JSON_Function.SaveJSONList(_questions);
        }
        else
        {
            MessageBox.Show("Edit Error");
        }
    }

    
}