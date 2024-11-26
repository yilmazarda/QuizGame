using Microsoft.EntityFrameworkCore;
using QuizGameAPI.dummies;
using QuizGameAPI.models;

namespace QuizGame.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed Quizzes
            modelBuilder.Entity<Quiz>().HasData(
                DummyData.GetQuizzes().ToArray()
            );

            // Seed Questions
            modelBuilder.Entity<Question>().HasData(
                DummyData.GetQuestions().ToArray()
            );

            // Seed Answers
            modelBuilder.Entity<Answer>().HasData(
                DummyData.GetAnswers().ToArray()
            );
        }
    }
}
