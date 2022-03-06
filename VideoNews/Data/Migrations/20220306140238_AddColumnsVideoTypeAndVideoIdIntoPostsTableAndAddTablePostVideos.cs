using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VideoNews.Data.Migrations
{
    public partial class AddColumnsVideoTypeAndVideoIdIntoPostsTableAndAddTablePostVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoId",
                table: "Posts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoType",
                table: "Posts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PostVideos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostId = table.Column<long>(type: "bigint", nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: true),
                    VideoId = table.Column<string>(type: "text", nullable: true),
                    VideoType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostVideos_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostVideos_PostId",
                table: "PostVideos",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostVideos");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "VideoType",
                table: "Posts");
        }
    }
}
