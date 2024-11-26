using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGameAPI.models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public List<Answer> Answers { get; set; }   
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}