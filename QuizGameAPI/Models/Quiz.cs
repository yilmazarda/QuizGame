using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGameAPI.models
{
    public class Quiz
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public ICollection<Question> Questions { get; set;}
        public ICollection<Game> Games { get; set;}
    }
}