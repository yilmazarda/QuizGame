using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGameAPI.models;
using QuizGameAPI.Repositories;

namespace QuizGameAPI.Services
{
    public class GameService : IGameService
    {
        public readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<Game> AddGameAsync(Game game)
        {
            await _gameRepository.AddAsync(game);
            return game;
        }

        public async Task<bool> DeleteGameAsync(int id)
        {
            Game? game = await _gameRepository.GetByIdAsync(id);
            if (game == null) return false;
            await _gameRepository.DeleteAsync(game);
            return true;
        }

        public async Task<IEnumerable<Game>> GetGamesAsync()
        {
            return await _gameRepository.GetAsync();
        }

        public async Task<Game> GetGameByIdAsync(int id)
        {
            Game? game = await _gameRepository.GetByIdAsync(id);
            if (game == null)
            {
                throw new KeyNotFoundException($"Game with id {id} not found.");
            }

            return game;
        }
    }
}