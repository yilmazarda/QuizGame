using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGameAPI.models;

namespace QuizGameAPI.Services
{
    public interface IGameService
    {
        Task AddGameAsync(Game game);
        Task<bool> DeleteGameAsync(int id);
        Task<IEnumerable<Game>> GetGamesAsync();

    }
}