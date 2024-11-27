using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizGameAPI.Services;
using QuizGameAPI.models;

namespace QuizGameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Use [ApiController] for automatic model validation and other features
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuizzes()
        {
            var quizzes = await _quizService.GetQuizzesAsync();
            return Ok(quizzes);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetQuizById(int id)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz == null) return NotFound("Quiz not found.");
            return Ok(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuiz(Quiz quiz)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdQuiz = await _quizService.AddQuizAsync(quiz);
            return CreatedAtAction(nameof(GetQuizById), new { id = createdQuiz.Id }, createdQuiz);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteQuiz(int id)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz == null) return NotFound("Quiz not found.");

            await _quizService.DeleteQuizAsync(id);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuiz(Quiz quiz)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _quizService.UpdateQuizAsync(quiz);

            return Ok(quiz);
        }
    }
}
