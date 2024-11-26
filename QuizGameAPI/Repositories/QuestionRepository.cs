using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGame.Data.Repositories;
using QuizGameAPI.data;
using QuizGameAPI.models;

namespace QuizGameAPI.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(QuizGameContext context) : base(context)
        {
        }
    }
}