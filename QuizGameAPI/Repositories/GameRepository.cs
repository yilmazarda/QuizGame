using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGame.Data.Repositories;
using QuizGameAPI.data;
using QuizGameAPI.models;

namespace QuizGameAPI.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(QuizGameContext context) : base(context)
        {
        }
    }
}