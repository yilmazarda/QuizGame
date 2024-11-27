using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizGameAPI.models;
using QuizGameAPI.Services;

namespace QuizGameAPI.Controllers
{    
    [Route("api/[controller]")]
    [ApiController] // Use [ApiController] for automatic model validation and other features
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            var quizzes = await _gameService.GetGamesAsync();
            return Ok(quizzes);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetGameById(int id)
        {
            var quiz = await _gameService.GetGameByIdAsync(id);
            if (quiz == null) return NotFound("Quiz not found.");
            return Ok(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> AddGame(Game game)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdGame = await _gameService.AddGameAsync(game);

            return CreatedAtAction(nameof(GetGameById), new { id = createdGame.Id }, createdGame);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _gameService.GetGameByIdAsync(id);
            if (game == null) return NotFound("Quiz not found.");

            await _gameService.DeleteGameAsync(id);
            return NoContent();
        }
    }
}