using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizGameAPI.models;
using QuizGameAPI.Repositories;

namespace QuizGameAPI.Services
{
    public class QuizService : IQuizService
    {
        public QuizService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }
        public readonly IQuizRepository _quizRepository;

        public async Task<Quiz> AddQuizAsync(Quiz quiz)
        {
            var createdQuiz = await _quizRepository.AddAsync(quiz); // Wait for the repository method to complete.
            return createdQuiz; // Return the created quiz with its generated Id.
        }


        public async Task<bool>  DeleteQuizAsync(int id)
        {
            Quiz? quiz = await _quizRepository.GetByIdAsync(id);

            if(quiz == null)
            {
                return false;
            }

            await _quizRepository.DeleteAsync(quiz);
            return true;
        }
        public async Task<List<Quiz>> GetQuizzesAsync()
        {
            // Await the Task to get the actual IQueryable<Quiz>
            var quizzes = await _quizRepository.GetAsync();

            // Apply Include and ThenInclude on the resulting IQueryable
            var result = quizzes
                .Include(q => q.Questions)  // Include related questions
                .ThenInclude(q => q.Answers);  // Include related answers for questions

            // Execute the query and return as a List<Quiz>
            return result.ToList();  // Convert the result to a List<Quiz>
        }
        public async Task<Quiz> GetQuizByIdAsync(int id)
        {
            Quiz? quiz = await _quizRepository.GetByIdAsync(id);
            if (quiz == null)
            {
                throw new KeyNotFoundException($"Quiz with id {id} not found.");
            }

            return quiz;
        }

        public async Task<Quiz> UpdateQuizAsync(Quiz quiz)
        {
            await _quizRepository.UpdateAsync(quiz);

            return quiz;
        }
    }
}