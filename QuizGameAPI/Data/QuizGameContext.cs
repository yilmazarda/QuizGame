using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using QuizGameAPI.models;

namespace QuizGameAPI.data
{
    public class QuizGameContext : DbContext
    {
        public QuizGameContext(DbContextOptions<QuizGameContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set;}
        public DbSet<Game> Games { get; set;}
        public DbSet<Quiz> Quizzes { get; set;}
        public DbSet<Answer> Answers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasOne(g => g.Quiz)
                .WithMany(q => q.Games)
                .HasForeignKey(g => g.QuizId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Question>()
                .HasOne(g => g.Quiz)
                .WithMany(q => q.Questions)
                .HasForeignKey(g => g.QuizId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Seed();
        }
    }
}