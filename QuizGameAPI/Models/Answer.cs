using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGameAPI.models
{
    public class Answer
    {
        public int AnswerId { get; set;}
        public string Name { get; set;}
        public bool IsCorrect { get; set;}
        public int QuestionId { get; set;}
        public Question Question { get; set;}
    }
}