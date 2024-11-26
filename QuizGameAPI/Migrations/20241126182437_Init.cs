using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "Name" },
                values: new object[,]
                {
                    { 1, "General Knowledge" },
                    { 2, "Science" },
                    { 3, "History" },
                    { 4, "Geography" },
                    { 5, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Name", "QuizId" },
                values: new object[,]
                {
                    { 1, "Who is the founder of Microsoft?", 1 },
                    { 2, "What is the capital of Japan?", 1 },
                    { 3, "What does HTTP stand for?", 1 },
                    { 4, "Which country is known as the Land of the Rising Sun?", 1 },
                    { 5, "What is the national flower of India?", 1 },
                    { 6, "What is the chemical symbol for gold?", 2 },
                    { 7, "Which gas is most abundant in the Earth's atmosphere?", 2 },
                    { 8, "What is the boiling point of water in Celsius?", 2 },
                    { 9, "Who invented the telephone?", 2 },
                    { 10, "What does DNA stand for?", 2 },
                    { 11, "Who was the first Emperor of Rome?", 3 },
                    { 12, "When did World War II end?", 3 },
                    { 13, "Which dynasty built the Great Wall of China?", 3 },
                    { 14, "Who was known as the Iron Lady?", 3 },
                    { 15, "What year did the Berlin Wall fall?", 3 },
                    { 16, "What is the highest mountain in the world?", 4 },
                    { 17, "Which ocean is the largest?", 4 },
                    { 18, "What is the capital city of Australia?", 4 },
                    { 19, "Which country is famous for its maple syrup?", 4 },
                    { 20, "What is the smallest ocean in the world?", 4 },
                    { 21, "What is 10 squared?", 5 },
                    { 22, "What is 7 times 8?", 5 },
                    { 23, "What is the square root of 81?", 5 },
                    { 24, "What is the integral of 2x?", 5 },
                    { 25, "What is the value of 5 factorial (5!)?", 5 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "IsCorrect", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, true, "Bill Gates", 1 },
                    { 2, false, "Steve Jobs", 1 },
                    { 3, false, "Elon Musk", 1 },
                    { 4, false, "Mark Zuckerberg", 1 },
                    { 5, true, "Tokyo", 2 },
                    { 6, false, "Kyoto", 2 },
                    { 7, false, "Osaka", 2 },
                    { 8, false, "Hokkaido", 2 },
                    { 9, true, "HyperText Transfer Protocol", 3 },
                    { 10, false, "HyperText Transfer Program", 3 },
                    { 11, false, "Hyperlink Text Protocol", 3 },
                    { 12, false, "Hyperlink Transfer Program", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_QuizId",
                table: "Games",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
