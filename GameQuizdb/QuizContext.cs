using Microsoft.EntityFrameworkCore;

namespace GameQuiz
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Chapters> Chapters { get; set; }
        public DbSet<DataBaseQuestions> Questions { get; set; }
    }

}
