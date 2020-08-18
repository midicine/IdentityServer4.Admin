using Microsoft.EntityFrameworkCore.Migrations;
using Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Constants;

namespace Skoruba.IdentityServer4.Admin.EntityFramework.SqlServer.Migrations.AuditLogging
{
    public partial class ChangeAuditLogToLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_AuditLog", "AuditLog", SchemaConsts.Admin);

            migrationBuilder.AlterColumn<long>(
                schema: SchemaConsts.Admin,
                name: "Id",
                table: "AuditLog",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey("PK_AuditLog", "AuditLog", "Id", SchemaConsts.Admin);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_AuditLog", "AuditLog", SchemaConsts.Admin);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AuditLog",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey("PK_AuditLog", "AuditLog", "Id", SchemaConsts.Admin);
        }
    }
}
