using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_6.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatingSystemName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.OperatingSystemId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatuses",
                columns: table => new
                {
                    TicketStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatuses", x => x.TicketStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersions",
                columns: table => new
                {
                    ProductVersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersions", x => x.ProductVersionId);
                    table.ForeignKey(
                        name: "FK_ProductVersions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersionOperatingSystems",
                columns: table => new
                {
                    ProductVersionOperatingSystemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVersionId = table.Column<int>(type: "int", nullable: false),
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersionOperatingSystems", x => x.ProductVersionOperatingSystemId);
                    table.ForeignKey(
                        name: "FK_ProductVersionOperatingSystems_OperatingSystems_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystems",
                        principalColumn: "OperatingSystemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVersionOperatingSystems_ProductVersions_ProductVersionId",
                        column: x => x.ProductVersionId,
                        principalTable: "ProductVersions",
                        principalColumn: "ProductVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVersionOperatingSystemId = table.Column<int>(type: "int", nullable: false),
                    TicketStatusId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_ProductVersionOperatingSystems_ProductVersionOperatingSystemId",
                        column: x => x.ProductVersionOperatingSystemId,
                        principalTable: "ProductVersionOperatingSystems",
                        principalColumn: "ProductVersionOperatingSystemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketStatuses_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatuses",
                        principalColumn: "TicketStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "OperatingSystemId", "OperatingSystemName" },
                values: new object[,]
                {
                    { 1, "Android" },
                    { 2, "Linux" },
                    { 3, "MacOS" },
                    { 4, "Windows" },
                    { 5, "Windows Mobile" },
                    { 6, "iOS" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Maître des Investissements" },
                    { 2, "Planificateur d’Anxiété Sociale" },
                    { 3, "Planificateur d’Entraînement" },
                    { 4, "Trader en Herbe" }
                });

            migrationBuilder.InsertData(
                table: "TicketStatuses",
                columns: new[] { "TicketStatusId", "Label" },
                values: new object[,]
                {
                    { 1, "in_progress" },
                    { 2, "resolved" },
                    { 3, "cancelled" }
                });

            migrationBuilder.InsertData(
                table: "ProductVersions",
                columns: new[] { "ProductVersionId", "Number", "ProductId" },
                values: new object[,]
                {
                    { 1, "1.0", 1 },
                    { 2, "1.1", 1 },
                    { 3, "1.2", 1 },
                    { 4, "1.3", 1 },
                    { 5, "1.0", 2 },
                    { 6, "2.0", 2 },
                    { 7, "2.1", 2 },
                    { 8, "1.0", 3 },
                    { 9, "1.1", 3 },
                    { 10, "2.0", 3 },
                    { 11, "1.0", 4 },
                    { 12, "1.1", 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductVersionOperatingSystems",
                columns: new[] { "ProductVersionOperatingSystemId", "OperatingSystemId", "ProductVersionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 3, 2 },
                    { 6, 1, 3 },
                    { 7, 2, 3 },
                    { 8, 3, 3 },
                    { 9, 4, 3 },
                    { 10, 5, 3 },
                    { 11, 6, 3 },
                    { 12, 1, 4 },
                    { 13, 2, 4 },
                    { 14, 3, 4 },
                    { 15, 4, 4 },
                    { 16, 2, 5 },
                    { 17, 3, 5 },
                    { 18, 1, 6 },
                    { 19, 2, 6 },
                    { 20, 3, 6 },
                    { 21, 1, 7 },
                    { 22, 2, 7 },
                    { 23, 3, 7 },
                    { 24, 5, 7 },
                    { 25, 1, 8 },
                    { 26, 3, 8 },
                    { 27, 1, 9 },
                    { 28, 2, 9 },
                    { 29, 3, 9 },
                    { 30, 4, 9 },
                    { 31, 5, 9 },
                    { 32, 6, 9 },
                    { 33, 1, 10 },
                    { 34, 2, 10 },
                    { 35, 3, 10 },
                    { 36, 4, 10 },
                    { 37, 1, 11 },
                    { 38, 2, 11 },
                    { 39, 3, 11 },
                    { 40, 4, 11 },
                    { 41, 1, 12 },
                    { 42, 2, 12 },
                    { 43, 3, 12 },
                    { 44, 4, 12 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CreationDate", "Issue", "ProductVersionOperatingSystemId", "Resolution", "ResolutionDate", "TicketStatusId" },
                values: new object[,]
                {
                    { 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certains utilisateurs rapportent ne jamais recevoir l’e-mail de confirmation d’inscription, même après plusieurs tentatives.", 39, "", null, 1 },
                    { 11, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Après la mise à jour vers la version 1.2, certains utilisateurs ne parviennent plus à synchroniser leur portefeuille avec le serveur. Une erreur générique « Connexion impossible » s’affiche sans détails, empêchant l’actualisation des données financières et bloquant l’utilisation de l’application en mode actif.", 8, "Le bug était lié à une modification récente du protocole de chiffrement TLS utilisé par l’API. Les anciennes versions de Windows n’étaient pas compatibles avec le nouveau niveau de sécurité requis. Une mise à jour corrective a été déployée pour prendre en charge les configurations les plus courantes tout en maintenant un niveau de sécurité suffisant.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Des erreurs d'arrondi apparaissent dans les totaux affichés après plusieurs opérations d’achat ou de vente.", 16, "Après analyse du code côté client, il a été identifié que l'erreur provenait d'une gestion approximative des valeurs calculées en virgule flottante. Des ajustements ont été faits pour appliquer un arrondi au centime près, respectant les conventions financières standards.", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La recherche d’actions spécifiques n’affiche aucun résultat même si le titre est bien coté.", 20, "", null, 1 },
                    { 14, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorsqu’un utilisateur termine une séance programmée, celle-ci n’apparaît pas dans le résumé quotidien de l’activité. Cela donne l’impression que l’effort fourni n’a pas été pris en compte.", 35, "Le problème venait d’un déclencheur d’événement mal implémenté côté client, qui n’enregistrait pas la fin de séance si l’utilisateur quittait l’écran trop rapidement. L’équipe de développement a modifié le processus de validation pour que les données soient sauvegardées dès la fin de la minuterie, quelle que soit la navigation de l’utilisateur.", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorsque l’utilisateur planifie plusieurs séances pour la même journée, seule la première est visible dans le calendrier hebdomadaire. Cela rend difficile la gestion des doubles entraînements ou des variations de programme.", 35, "", null, 1 },
                    { 16, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La sauvegarde automatique du portefeuille personnalisé ne fonctionne pas après une modification.", 20, "Une erreur de synchronisation entre le cache local et les données du serveur empêchait l’actualisation immédiate. L’équipe a intégré une commande de rafraîchissement forcé après chaque opération pour refléter les changements en temps réel.", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Le simulateur de risque affiche des résultats incohérents lorsqu’un portefeuille contient plus de 10 valeurs.", 15, "", null, 1 },
                    { 18, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Les taux d'intérêt affichés dans les profils ne sont pas mis à jour malgré une connexion au serveur.", 12, "Le moteur de rendu des graphiques n'était pas compatible avec les résolutions inférieures à 720p. Une refonte du système d'affichage adaptatif a été réalisée pour améliorer la compatibilité avec les petits écrans.", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Le mode tutoriel se relance à chaque ouverture de l'application même après avoir été désactivé.", 19, "", null, 1 },
                    { 20, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Les alertes programmées pour les plafonds ne se déclenchent pas lorsque l’application est en arrière-plan.", 24, "Le système de sauvegarde n’envoyait pas les modifications en cas de perte temporaire de connexion. Un système de file d’attente a été mis en place pour garantir que les modifications soient bien enregistrées dès que la connexion est restaurée.", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certaines actions s’affichent en double après l’opération d’un achat.", 21, "", null, 1 },
                    { 22, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Les citations motivationnelles du jour n’apparaissent pas dans l’interface d’accueil, laissant un espace vide censé motiver l’utilisateur.", 40, "Le bug provenait d’une erreur dans le système de récupération des citations via l’API. Une mauvaise gestion des dates dans la requête empêchait l’affichage des contenus journaliers. L’équipe a corrigé la logique de sélection côté serveur pour renvoyer correctement une citation.", new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorsqu’un utilisateur tente de modifier une position déjà ouverte, l’interface ne prend pas en compte les nouvelles valeurs saisies et affiche toujours les paramètres d’origine. Cela peut induire en erreur l’utilisateur sur le statut réel de ses ordres.", 10, "Le système de mise à jour du portefeuille ne rafraîchissait pas les données après une modification partielle. L’équipe a corrigé cette anomalie en forçant une resynchronisation locale après chaque modification d’ordre. Des tests ont été ajoutés pour valider les cas d’édition multiples.", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lors de la rédaction d’une note dans le journal émotionnel, un retour à la page d’accueil sans enregistrement automatique entraîne la perte totale du contenu rédigé.", 38, "", null, 1 },
                    { 25, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La fonction 'journal émotionnel' ne sauvegarde pas les entrées si l’utilisateur ferme la page web trop rapidement.", 37, "", null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOperatingSystems_OperatingSystemId",
                table: "ProductVersionOperatingSystems",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOperatingSystems_ProductVersionId",
                table: "ProductVersionOperatingSystems",
                column: "ProductVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersions_ProductId",
                table: "ProductVersions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductVersionOperatingSystemId",
                table: "Tickets",
                column: "ProductVersionOperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketStatusId",
                table: "Tickets",
                column: "TicketStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "ProductVersionOperatingSystems");

            migrationBuilder.DropTable(
                name: "TicketStatuses");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "ProductVersions");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
