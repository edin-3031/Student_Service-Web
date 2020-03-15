using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Skracenica = table.Column<string>(nullable: true),
                    Kontinent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "KorisničkiNalog",
                columns: table => new
                {
                    KorisnickiNalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisničkiNalog", x => x.KorisnickiNalogID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Drzava_ID_FK = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Skracenica = table.Column<string>(nullable: true),
                    Postanski_Broj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_Drzava_ID_FK",
                        column: x => x.Drzava_ID_FK,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Administracija",
                columns: table => new
                {
                    AdministracijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisničkiNalog_ID_FK = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Datum_Rodjenja = table.Column<DateTime>(nullable: false),
                    Datum_Zaposlenja = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    Staz = table.Column<int>(nullable: false),
                    Stalan_Zapolsenik = table.Column<string>(nullable: true),
                    Kancelarija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administracija", x => x.AdministracijaID);
                    table.ForeignKey(
                        name: "FK_Administracija_KorisničkiNalog_KorisničkiNalog_ID_FK",
                        column: x => x.KorisničkiNalog_ID_FK,
                        principalTable: "KorisničkiNalog",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Polaznik",
                columns: table => new
                {
                    PolaznikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisničkiNalog_ID_FK = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Datum_Rodjenja = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    Broj_Dosijea = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Nacin_Studiranja = table.Column<string>(nullable: true),
                    Upisan_Semestar = table.Column<int>(nullable: false),
                    Ovjeren_Semestar = table.Column<int>(nullable: false),
                    Godina_Upisa = table.Column<int>(nullable: false),
                    Godina_Studija = table.Column<int>(nullable: false),
                    Obnavlja_Godinu = table.Column<string>(nullable: true),
                    Prosjecna_Ocjena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polaznik", x => x.PolaznikID);
                    table.ForeignKey(
                        name: "FK_Polaznik_KorisničkiNalog_KorisničkiNalog_ID_FK",
                        column: x => x.KorisničkiNalog_ID_FK,
                        principalTable: "KorisničkiNalog",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    ProfesorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisničkiNalog_ID_FK = table.Column<int>(nullable: false),
                    Zvanje = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Datum_Rodjenja = table.Column<DateTime>(nullable: false),
                    Datum_Zaposlenja = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    Staz = table.Column<int>(nullable: false),
                    Stalan_Zaposlenik = table.Column<string>(nullable: true),
                    Kancelarija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.ProfesorID);
                    table.ForeignKey(
                        name: "FK_Profesor_KorisničkiNalog_KorisničkiNalog_ID_FK",
                        column: x => x.KorisničkiNalog_ID_FK,
                        principalTable: "KorisničkiNalog",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Akademija",
                columns: table => new
                {
                    AkademijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    GradID_FK = table.Column<int>(nullable: false),
                    DrzavaID_FK = table.Column<int>(nullable: false),
                    Izgradjeno = table.Column<DateTime>(nullable: false),
                    Broj_Zaposlenih = table.Column<int>(nullable: false),
                    Broj_Polaznika = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akademija", x => x.AkademijaID);
                    table.ForeignKey(
                        name: "FK_Akademija_Drzava_DrzavaID_FK",
                        column: x => x.DrzavaID_FK,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Akademija_Grad_GradID_FK",
                        column: x => x.GradID_FK,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Svrha = table.Column<string>(nullable: true),
                    Iznos = table.Column<float>(nullable: false),
                    Datum_uplate = table.Column<DateTime>(nullable: false),
                    Ovjereno = table.Column<string>(nullable: true),
                    Polaznik_ID_FK = table.Column<int>(nullable: false),
                    Administracija_ID_FK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK_Uplata_Administracija_Administracija_ID_FK",
                        column: x => x.Administracija_ID_FK,
                        principalTable: "Administracija",
                        principalColumn: "AdministracijaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Uplata_Polaznik_Polaznik_ID_FK",
                        column: x => x.Polaznik_ID_FK,
                        principalTable: "Polaznik",
                        principalColumn: "PolaznikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Radi",
                columns: table => new
                {
                    RadiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AkademijId_FK = table.Column<int>(nullable: false),
                    Administracija_FK = table.Column<int>(nullable: false),
                    ProfesorId_FK = table.Column<int>(nullable: false),
                    Broj_Sati_U_Sedmici = table.Column<int>(nullable: false),
                    Plata = table.Column<float>(nullable: false),
                    Vrsta_Ugovora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radi", x => x.RadiID);
                    table.ForeignKey(
                        name: "FK_Radi_Administracija_Administracija_FK",
                        column: x => x.Administracija_FK,
                        principalTable: "Administracija",
                        principalColumn: "AdministracijaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Radi_Akademija_AkademijId_FK",
                        column: x => x.AkademijId_FK,
                        principalTable: "Akademija",
                        principalColumn: "AkademijaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Radi_Profesor_ProfesorId_FK",
                        column: x => x.ProfesorId_FK,
                        principalTable: "Profesor",
                        principalColumn: "ProfesorID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Studijski_Program",
                columns: table => new
                {
                    Studijski_programID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Akademija_ID_FK = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Trajanje = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studijski_Program", x => x.Studijski_programID);
                    table.ForeignKey(
                        name: "FK_Studijski_Program_Akademija_Akademija_ID_FK",
                        column: x => x.Akademija_ID_FK,
                        principalTable: "Akademija",
                        principalColumn: "AkademijaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    KursID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Studijski_Program_ID_FK = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    ECTS = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    Trajanje = table.Column<int>(nullable: false),
                    Trazenost = table.Column<string>(nullable: true),
                    Cilj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.KursID);
                    table.ForeignKey(
                        name: "FK_Kurs_Studijski_Program_Studijski_Program_ID_FK",
                        column: x => x.Studijski_Program_ID_FK,
                        principalTable: "Studijski_Program",
                        principalColumn: "Studijski_programID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Pohadja",
                columns: table => new
                {
                    PohadjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KursID_FK = table.Column<int>(nullable: false),
                    PolaznikID_FK = table.Column<int>(nullable: false),
                    Pocetak = table.Column<DateTime>(nullable: false),
                    Kraj = table.Column<DateTime>(nullable: false),
                    Obnavlja = table.Column<string>(nullable: true),
                    Broj_Obnavljanja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pohadja", x => x.PohadjaID);
                    table.ForeignKey(
                        name: "FK_Pohadja_Kurs_KursID_FK",
                        column: x => x.KursID_FK,
                        principalTable: "Kurs",
                        principalColumn: "KursID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pohadja_Polaznik_PolaznikID_FK",
                        column: x => x.PolaznikID_FK,
                        principalTable: "Polaznik",
                        principalColumn: "PolaznikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Predaje",
                columns: table => new
                {
                    PredajeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfesorId_FK = table.Column<int>(nullable: false),
                    KursId_FK = table.Column<int>(nullable: false),
                    Datum_Predavanja = table.Column<DateTime>(nullable: false),
                    Odrzano = table.Column<string>(nullable: true),
                    Vrsta = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predaje", x => x.PredajeID);
                    table.ForeignKey(
                        name: "FK_Predaje_Kurs_KursId_FK",
                        column: x => x.KursId_FK,
                        principalTable: "Kurs",
                        principalColumn: "KursID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Predaje_Profesor_ProfesorId_FK",
                        column: x => x.ProfesorId_FK,
                        principalTable: "Profesor",
                        principalColumn: "ProfesorID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Testovi",
                columns: table => new
                {
                    TestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KursId_FK = table.Column<int>(nullable: false),
                    Broj_Pitanja = table.Column<int>(nullable: false),
                    Trajanje = table.Column<int>(nullable: false),
                    Maksimalan_Broj_Bodova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testovi", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Testovi_Kurs_KursId_FK",
                        column: x => x.KursId_FK,
                        principalTable: "Kurs",
                        principalColumn: "KursID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administracija_KorisničkiNalog_ID_FK",
                table: "Administracija",
                column: "KorisničkiNalog_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Akademija_DrzavaID_FK",
                table: "Akademija",
                column: "DrzavaID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Akademija_GradID_FK",
                table: "Akademija",
                column: "GradID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_Drzava_ID_FK",
                table: "Grad",
                column: "Drzava_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Kurs_Studijski_Program_ID_FK",
                table: "Kurs",
                column: "Studijski_Program_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Pohadja_KursID_FK",
                table: "Pohadja",
                column: "KursID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Pohadja_PolaznikID_FK",
                table: "Pohadja",
                column: "PolaznikID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Polaznik_KorisničkiNalog_ID_FK",
                table: "Polaznik",
                column: "KorisničkiNalog_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Predaje_KursId_FK",
                table: "Predaje",
                column: "KursId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Predaje_ProfesorId_FK",
                table: "Predaje",
                column: "ProfesorId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_KorisničkiNalog_ID_FK",
                table: "Profesor",
                column: "KorisničkiNalog_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Radi_Administracija_FK",
                table: "Radi",
                column: "Administracija_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Radi_AkademijId_FK",
                table: "Radi",
                column: "AkademijId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Radi_ProfesorId_FK",
                table: "Radi",
                column: "ProfesorId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Studijski_Program_Akademija_ID_FK",
                table: "Studijski_Program",
                column: "Akademija_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Testovi_KursId_FK",
                table: "Testovi",
                column: "KursId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_Administracija_ID_FK",
                table: "Uplata",
                column: "Administracija_ID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_Polaznik_ID_FK",
                table: "Uplata",
                column: "Polaznik_ID_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pohadja");

            migrationBuilder.DropTable(
                name: "Predaje");

            migrationBuilder.DropTable(
                name: "Radi");

            migrationBuilder.DropTable(
                name: "Testovi");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Administracija");

            migrationBuilder.DropTable(
                name: "Polaznik");

            migrationBuilder.DropTable(
                name: "Studijski_Program");

            migrationBuilder.DropTable(
                name: "KorisničkiNalog");

            migrationBuilder.DropTable(
                name: "Akademija");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
