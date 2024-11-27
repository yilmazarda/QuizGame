using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGameAPI.models;

namespace QuizGameAPI.Services
{
    public interface IQuizService
    {
        Task<Quiz> AddQuizAsync(Quiz quiz);
        Task<bool> DeleteQuizAsync(int id);
        Task<List<Quiz>> GetQuizzesAsync();
        Task<Quiz> GetQuizByIdAsync(int id);

        Task<Quiz> UpdateQuizAsync(Quiz quiz);
    }
}