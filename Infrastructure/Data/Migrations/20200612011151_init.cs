﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtistDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommonUserDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonUserDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLibraries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLibraries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributorDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributorDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributorDatas_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ArtId = table.Column<int>(nullable: true),
                    OwnerLibraryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Arts_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Arts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Playlists_UserLibraries_OwnerLibraryId",
                        column: x => x.OwnerLibraryId,
                        principalTable: "UserLibraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ArtId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true),
                    DistributorId = table.Column<int>(nullable: true),
                    UserLibraryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Arts_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Arts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_DistributorDatas_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "DistributorDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_UserLibraries_UserLibraryId",
                        column: x => x.UserLibraryId,
                        principalTable: "UserLibraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistToDistributor",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false),
                    DistributorId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistToDistributor", x => new { x.ArtistId, x.DistributorId });
                    table.ForeignKey(
                        name: "FK_ArtistToDistributor_ArtistDatas_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "ArtistDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistToDistributor_DistributorDatas_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "DistributorDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CommonUserDataId = table.Column<int>(nullable: true),
                    DistributorDataId = table.Column<int>(nullable: true),
                    UserLibraryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CommonUserDatas_CommonUserDataId",
                        column: x => x.CommonUserDataId,
                        principalTable: "CommonUserDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_DistributorDatas_DistributorDataId",
                        column: x => x.DistributorDataId,
                        principalTable: "DistributorDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserLibraries_UserLibraryId",
                        column: x => x.UserLibraryId,
                        principalTable: "UserLibraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Plays = table.Column<int>(nullable: false),
                    IsExplicit = table.Column<bool>(nullable: false),
                    AlbumId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrackToArtist",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackToArtist", x => new { x.TrackId, x.ArtistId });
                    table.ForeignKey(
                        name: "FK_TrackToArtist_ArtistDatas_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "ArtistDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackToArtist_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackToPlaylist",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false),
                    PlaylistId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackToPlaylist", x => new { x.TrackId, x.PlaylistId });
                    table.ForeignKey(
                        name: "FK_TrackToPlaylist_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackToPlaylist_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtId",
                table: "Albums",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_DistributorId",
                table: "Albums",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_UserLibraryId",
                table: "Albums",
                column: "UserLibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistToDistributor_DistributorId",
                table: "ArtistToDistributor",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorDatas_CountryId",
                table: "DistributorDatas",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_ArtId",
                table: "Playlists",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_OwnerLibraryId",
                table: "Playlists",
                column: "OwnerLibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackToArtist_ArtistId",
                table: "TrackToArtist",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackToPlaylist_PlaylistId",
                table: "TrackToPlaylist",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CommonUserDataId",
                table: "Users",
                column: "CommonUserDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DistributorDataId",
                table: "Users",
                column: "DistributorDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserLibraryId",
                table: "Users",
                column: "UserLibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistToDistributor");

            migrationBuilder.DropTable(
                name: "TrackToArtist");

            migrationBuilder.DropTable(
                name: "TrackToPlaylist");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ArtistDatas");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "CommonUserDatas");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "DistributorDatas");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "UserLibraries");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
