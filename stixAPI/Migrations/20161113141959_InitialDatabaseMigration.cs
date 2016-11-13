namespace stixAPI.Migrations
{
	using Microsoft.EntityFrameworkCore.Migrations;
	using Microsoft.EntityFrameworkCore.Metadata;

	public partial class InitialDatabaseMigration : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Stig",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: false),
					Location = table.Column<string>(nullable: true),
					Title = table.Column<string>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Stig", x => x.Id);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Stig");
		}
	}
}
