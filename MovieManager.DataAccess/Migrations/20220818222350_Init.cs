using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManager.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteGenre = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Description", "Genre", "Title", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7437), "Scientist Jor-El rockets his infant son, Kal-El, to safety on Earth. Kal is raised as Clark Kent and develops unusual abilities and powers to become Superman who fights for truth and justice.", 6, "Superman", 1978 },
                    { 2, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7441), "Batman is called to intervene when the mayor of Gotham City is murdered. Soon, his investigation leads him to uncover a web of corruption, linked to his own dark past.", 3, "The Batman", 2022 },
                    { 3, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7443), "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", 5, "The Godfather", 1972 },
                    { 4, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7446), "When a Chinese consul's young daughter is kidnapped, Hong Kong Detective Lee must team up with Carter, a loud-mouthed LA detective. Distinctive work styles and cultural differences pose hiccups.", 1, "Rush Hour", 1998 },
                    { 5, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7447), "Duke reads the story of Allie and Noah, two lovers who were separated by fate, to Ms Hamilton, an old woman who suffers from dementia, on a daily basis out of his notebook.", 7, "The Notebook", 2004 },
                    { 6, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7449), "The Perron family moves into a farmhouse where they experience paranormal phenomena. They consult demonologists, Ed and Lorraine Warren, to help them get rid of the evil entity haunting them.", 2, "The Conjuring", 2013 },
                    { 7, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7451), "Nick Dunne discovers that the entire media focus has shifted on him when his wife, Amy Dunne, mysteriously disappears on the day of their fifth wedding anniversary.", 4, "Gone Girl", 2014 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "FavoriteGenre", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7278), 6, "Kristijan", "Karanfilovski", "kiko123", "kiko" },
                    { 2, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7311), 1, "Ilija", "Mitev", "ile123", "ile" },
                    { 3, new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7313), 3, "Trajan", "Stevkovski", "trajan123", "trajan" }
                });

            migrationBuilder.InsertData(
                table: "MovieUser",
                columns: new[] { "Id", "MovieId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_MovieId",
                table: "MovieUser",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UserId",
                table: "MovieUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
