using Microsoft.EntityFrameworkCore.Migrations;

namespace ChamadosTI.Migrations
{
    public partial class ChamadoTI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perifericosContext",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomePerifericos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    especificacaoPerifericos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantidadePerifericos = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perifericosContext", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarioContext",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maquinaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    setorUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioContext", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chamadosContext",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuariosnomeUsuarioid = table.Column<int>(type: "int", nullable: true),
                    descricaoChamados = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chamadosContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_chamadosContext_usuarioContext_usuariosnomeUsuarioid",
                        column: x => x.usuariosnomeUsuarioid,
                        principalTable: "usuarioContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "solicitacoesContext",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeUsuarioSolicitacoesid = table.Column<int>(type: "int", nullable: true),
                    perifericosSolicitacoesid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solicitacoesContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_solicitacoesContext_perifericosContext_perifericosSolicitacoesid",
                        column: x => x.perifericosSolicitacoesid,
                        principalTable: "perifericosContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_solicitacoesContext_usuarioContext_nomeUsuarioSolicitacoesid",
                        column: x => x.nomeUsuarioSolicitacoesid,
                        principalTable: "usuarioContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chamadosContext_usuariosnomeUsuarioid",
                table: "chamadosContext",
                column: "usuariosnomeUsuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_solicitacoesContext_nomeUsuarioSolicitacoesid",
                table: "solicitacoesContext",
                column: "nomeUsuarioSolicitacoesid");

            migrationBuilder.CreateIndex(
                name: "IX_solicitacoesContext_perifericosSolicitacoesid",
                table: "solicitacoesContext",
                column: "perifericosSolicitacoesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chamadosContext");

            migrationBuilder.DropTable(
                name: "solicitacoesContext");

            migrationBuilder.DropTable(
                name: "perifericosContext");

            migrationBuilder.DropTable(
                name: "usuarioContext");
        }
    }
}
