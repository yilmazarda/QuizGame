using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGameAPI.models;

namespace QuizGameAPI.dummies
{
    public static class DummyData
    {
        public static List<Quiz> GetQuizzes()
        {
            var quizzes = new List<Quiz>
            {
                new Quiz { Id = 1, Name = "General Knowledge" },
                new Quiz { Id = 2, Name = "Science" },
                new Quiz { Id = 3, Name = "History" },
                new Quiz { Id = 4, Name = "Geography" },
                new Quiz { Id = 5, Name = "Math" }
            };

            return quizzes;
        }

        public static List<Question> GetQuestions()
        {
            var questions = new List<Question>
            {
                // General Knowledge Questions
                new Question { QuestionId = 1, Name = "Who is the founder of Microsoft?", QuizId = 1 },
                new Question { QuestionId = 2, Name = "What is the capital of Japan?", QuizId = 1 },
                new Question { QuestionId = 3, Name = "What does HTTP stand for?", QuizId = 1 },
                new Question { QuestionId = 4, Name = "Which country is known as the Land of the Rising Sun?", QuizId = 1 },
                new Question { QuestionId = 5, Name = "What is the national flower of India?", QuizId = 1 },
                
                // Science Questions
                new Question { QuestionId = 6, Name = "What is the chemical symbol for gold?", QuizId = 2 },
                new Question { QuestionId = 7, Name = "Which gas is most abundant in the Earth's atmosphere?", QuizId = 2 },
                new Question { QuestionId = 8, Name = "What is the boiling point of water in Celsius?", QuizId = 2 },
                new Question { QuestionId = 9, Name = "Who invented the telephone?", QuizId = 2 },
                new Question { QuestionId = 10, Name = "What does DNA stand for?", QuizId = 2 },
                
                // History Questions
                new Question { QuestionId = 11, Name = "Who was the first Emperor of Rome?", QuizId = 3 },
                new Question { QuestionId = 12, Name = "When did World War II end?", QuizId = 3 },
                new Question { QuestionId = 13, Name = "Which dynasty built the Great Wall of China?", QuizId = 3 },
                new Question { QuestionId = 14, Name = "Who was known as the Iron Lady?", QuizId = 3 },
                new Question { QuestionId = 15, Name = "What year did the Berlin Wall fall?", QuizId = 3 },
                
                // Geography Questions
                new Question { QuestionId = 16, Name = "What is the highest mountain in the world?", QuizId = 4 },
                new Question { QuestionId = 17, Name = "Which ocean is the largest?", QuizId = 4 },
                new Question { QuestionId = 18, Name = "What is the capital city of Australia?", QuizId = 4 },
                new Question { QuestionId = 19, Name = "Which country is famous for its maple syrup?", QuizId = 4 },
                new Question { QuestionId = 20, Name = "What is the smallest ocean in the world?", QuizId = 4 },
                
                // Math Questions
                new Question { QuestionId = 21, Name = "What is 10 squared?", QuizId = 5 },
                new Question { QuestionId = 22, Name = "What is 7 times 8?", QuizId = 5 },
                new Question { QuestionId = 23, Name = "What is the square root of 81?", QuizId = 5 },
                new Question { QuestionId = 24, Name = "What is the integral of 2x?", QuizId = 5 },
                new Question { QuestionId = 25, Name = "What is the value of 5 factorial (5!)?", QuizId = 5 }
            };

            return questions;
        }

        public static List<Answer> GetAnswers()
        {
            var answers = new List<Answer>
            {
                // General Knowledge Answers
                new Answer { AnswerId = 1, Name = "Bill Gates", IsCorrect = true, QuestionId = 1 },
                new Answer { AnswerId = 2, Name = "Steve Jobs", IsCorrect = false, QuestionId = 1 },
                new Answer { AnswerId = 3, Name = "Elon Musk", IsCorrect = false, QuestionId = 1 },
                new Answer { AnswerId = 4, Name = "Mark Zuckerberg", IsCorrect = false, QuestionId = 1 },
                new Answer { AnswerId = 5, Name = "Tokyo", IsCorrect = true, QuestionId = 2 },
                new Answer { AnswerId = 6, Name = "Kyoto", IsCorrect = false, QuestionId = 2 },
                new Answer { AnswerId = 7, Name = "Osaka", IsCorrect = false, QuestionId = 2 },
                new Answer { AnswerId = 8, Name = "Hokkaido", IsCorrect = false, QuestionId = 2 },
                new Answer { AnswerId = 9, Name = "HyperText Transfer Protocol", IsCorrect = true, QuestionId = 3 },
                new Answer { AnswerId = 10, Name = "HyperText Transfer Program", IsCorrect = false, QuestionId = 3 },
                new Answer { AnswerId = 11, Name = "Hyperlink Text Protocol", IsCorrect = false, QuestionId = 3 },
                new Answer { AnswerId = 12, Name = "Hyperlink Transfer Program", IsCorrect = false, QuestionId = 3 },
                // Add similar patterns for remaining questions...
            };

            return answers;
        }


    }
}