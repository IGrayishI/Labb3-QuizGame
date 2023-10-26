using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Labb3_NET22.DataModels;

public class Question
{
    public string? ImagePath    { get; set; }
    public string Catagory      { get; }
    public string Statement     { get; }
    public string[] Answers     { get; }
    public int CorrectAnswer    { get; }

        public static List<String> ListOfCatagory = new()
        {
            "History",
            "Science",
            "Geography",
            "Literature",
            "Mathematics",
            "Misc"
        };

    public Question(string catagory, string statement, int correctAnswer, string imagePath, string[] answers)
    {
        Catagory = catagory;
        Statement = statement;
        Answers = answers;
        CorrectAnswer = correctAnswer;
        ImagePath = imagePath;

    }
}