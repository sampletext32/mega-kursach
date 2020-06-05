using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    PicPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerId1 = table.Column<long>(nullable: true),
                    ArtId = table.Column<int>(nullable: false),
                    ArtId1 = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: true),
                    DistributorId = table.Column<int>(nullable: true),
                    DistributorId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Arts_ArtId1",
                        column: x => x.ArtId1,
                        principalTable: "Arts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false),
                    GenreId1 = table.Column<long>(nullable: true),
                    ArtId = table.Column<int>(nullable: false),
                    ArtId1 = table.Column<long>(nullable: true),
                    Explicit = table.Column<bool>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false),
                    AlbumId1 = table.Column<long>(nullable: true),
                    Plays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Playlists_AlbumId1",
                        column: x => x.AlbumId1,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Arts_ArtId1",
                        column: x => x.ArtId1,
                        principalTable: "Arts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Genres_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    Nickname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    AlbumId = table.Column<long>(nullable: true),
                    DistributorId = table.Column<long>(nullable: true),
                    TrackId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Playlists_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_DistributorId1",
                table: "Playlists",
                column: "DistributorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_ArtId1",
                table: "Playlists",
                column: "ArtId1");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_OwnerId1",
                table: "Playlists",
                column: "OwnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId1",
                table: "Tracks",
                column: "AlbumId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_ArtId1",
                table: "Tracks",
                column: "ArtId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_GenreId1",
                table: "Tracks",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_AlbumId",
                table: "User",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DistributorId",
                table: "User",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TrackId",
                table: "User",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_User_DistributorId1",
                table: "Playlists",
                column: "DistributorId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_User_OwnerId1",
                table: "Playlists",
                column: "OwnerId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_User_DistributorId1",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_User_OwnerId1",
                table: "Playlists");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Arts");
        }
    }
}
