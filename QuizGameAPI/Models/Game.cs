using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGameAPI.models
{
    public class Game
    {
        public int Id { get; set;}
        public string Username { get; set;}
        public int QuizId { get; set; }
        public Quiz Quiz { get; set;}
    }
}