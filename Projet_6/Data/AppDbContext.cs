namespace Projet_6.Data
{
    using Microsoft.EntityFrameworkCore;
    using Projet_6.Models.Entities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData
                (
                new Product { ProductId = 1, ProductName = "Maître des Investissements" },
                new Product { ProductId = 2, ProductName = "Planificateur d’Anxiété Sociale" },
                new Product { ProductId = 3, ProductName = "Planificateur d’Entraînement" },
                new Product { ProductId = 4, ProductName = "Trader en Herbe" }
                );

            modelBuilder.Entity<OperatingSystem>().HasData
                (
                new OperatingSystem { OperatingSystemId = 1, OperatingSystemName = "Android" },
                new OperatingSystem { OperatingSystemId = 2, OperatingSystemName = "Linux" },
                new OperatingSystem { OperatingSystemId = 3, OperatingSystemName = "MacOS" },
                new OperatingSystem { OperatingSystemId = 4, OperatingSystemName = "Windows" },
                new OperatingSystem { OperatingSystemId = 5, OperatingSystemName = "Windows Mobile" },
                new OperatingSystem { OperatingSystemId = 6, OperatingSystemName = "iOS" }
                );

            modelBuilder.Entity<ProductVersion>().HasData
                (
                new ProductVersion { ProductVersionId = 1, ProductId = 1, Number = "1.0" },
                new ProductVersion { ProductVersionId = 2, ProductId = 1, Number = "1.1" },
                new ProductVersion { ProductVersionId = 3, ProductId = 1, Number = "1.2" },
                new ProductVersion { ProductVersionId = 4, ProductId = 1, Number = "1.3" },
                new ProductVersion { ProductVersionId = 5, ProductId = 2, Number = "1.0" },
                new ProductVersion { ProductVersionId = 6, ProductId = 2, Number = "2.0" },
                new ProductVersion { ProductVersionId = 7, ProductId = 2, Number = "2.1" },
                new ProductVersion { ProductVersionId = 8, ProductId = 3, Number = "1.0" },
                new ProductVersion { ProductVersionId = 9, ProductId = 3, Number = "1.1" },
                new ProductVersion { ProductVersionId = 10, ProductId = 3, Number = "2.0" },
                new ProductVersion { ProductVersionId = 11, ProductId = 4, Number = "1.0" },
                new ProductVersion { ProductVersionId = 12, ProductId = 4, Number = "1.1" }
                );

            modelBuilder.Entity<ProductVersionOperatingSystem>().HasData
                (
                // Trader en Herbe - 1.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 1, ProductVersionId = 1, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 2, ProductVersionId = 1, OperatingSystemId = 4 },

                // Trader en Herbe - 1.1
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 3, ProductVersionId = 2, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 4, ProductVersionId = 2, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 5, ProductVersionId = 2, OperatingSystemId = 3 },

                // Trader en Herbe - 1.2
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 6, ProductVersionId = 3, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 7, ProductVersionId = 3, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 8, ProductVersionId = 3, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 9, ProductVersionId = 3, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 10, ProductVersionId = 3, OperatingSystemId = 5 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 11, ProductVersionId = 3, OperatingSystemId = 6 },

                // Trader en Herbe - 1.3
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 12, ProductVersionId = 4, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 13, ProductVersionId = 4, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 14, ProductVersionId = 4, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 15, ProductVersionId = 4, OperatingSystemId = 4 },

                // Maître des Investissements - 1.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 16, ProductVersionId = 5, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 17, ProductVersionId = 5, OperatingSystemId = 3 },

                // Maître des Investissements - 2.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 18, ProductVersionId = 6, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 19, ProductVersionId = 6, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 20, ProductVersionId = 6, OperatingSystemId = 3 },

                // Maître des Investissements - 2.1
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 21, ProductVersionId = 7, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 22, ProductVersionId = 7, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 23, ProductVersionId = 7, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 24, ProductVersionId = 7, OperatingSystemId = 4 },

                // Planificateur d’Entraînement - 1.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 25, ProductVersionId = 8, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 26, ProductVersionId = 8, OperatingSystemId = 3 },

                // Planificateur d’Entraînement - 1.1
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 27, ProductVersionId = 9, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 28, ProductVersionId = 9, OperatingSystemId = 2 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 29, ProductVersionId = 9, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 30, ProductVersionId = 9, OperatingSystemId = 4 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 31, ProductVersionId = 9, OperatingSystemId = 5 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 32, ProductVersionId = 9, OperatingSystemId = 6 },

                // Planificateur d’Entraînement - 2.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 33, ProductVersionId = 10, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 34, ProductVersionId = 10, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 35, ProductVersionId = 10, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 36, ProductVersionId = 10, OperatingSystemId = 4 },

                // Planificateur d’Anxiété Sociale - 1.0
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 37, ProductVersionId = 11, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 38, ProductVersionId = 11, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 39, ProductVersionId = 11, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 40, ProductVersionId = 11, OperatingSystemId = 4 },

                // Planificateur d’Anxiété Sociale - 1.1
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 41, ProductVersionId = 12, OperatingSystemId = 1 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 42, ProductVersionId = 12, OperatingSystemId = 6 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 43, ProductVersionId = 12, OperatingSystemId = 3 },
                new ProductVersionOperatingSystem { ProductVersionOperatingSystemId = 44, ProductVersionId = 12, OperatingSystemId = 4 }
                );

            modelBuilder.Entity<Ticket>().HasData
                (
                // 1 - Maître des Investissements, 2.1, Windows
                new Ticket { TicketId = 1, ProductVersionOperatingSystemId = 24, TicketStatusId = 2, CreationDate = new DateTime(2024, 1, 12), ResolutionDate = new DateTime(2024, 1, 18), Issue = "Lors de la connexion à l’application, un message d’erreur \"token invalide\" s’affiche systématiquement après la saisie du mot de passe, même lorsque les identifiants sont corrects. Le problème semble apparaître uniquement après une mise à jour automatique de Windows.", Resolution = "Un conflit de cache a été identifié entre la version 2.1 de l’application et le stockage local de Windows. Une mise à jour a été déployée pour forcer le nettoyage du cache lors de l’ouverture de l’application. L’équipe de développement a également ajouté un bouton manuel \"Vider le cache\" dans les paramètres avancés." },
                
                // 2 - Planificateur d’Anxiété Sociale, 1.1, Windows
                new Ticket { TicketId = 2, ProductVersionOperatingSystemId = 44, TicketStatusId = 2, CreationDate = new DateTime(2024, 2, 10), ResolutionDate = new DateTime(2024, 2, 16), Issue = "Plusieurs utilisateurs ont signalé recevoir les notifications push en double pour un même événement, ce qui créait de la confusion et nuisait à l’expérience utilisateur. Par exemple, lorsqu’un rappel était programmé pour une tâche à 9h00, deux notifications identiques étaient affichées sur le téléphone à la même seconde.", Resolution = "Après investigation, l’anomalie provenait d’un problème de logique dans le service de notifications du serveur. Un même événement était traité deux fois à cause d’une condition mal formulée dans la file de traitement asynchrone. L’équipe technique a modifié l’algorithme de génération des envois afin de garantir l’unicité des messages par événement et utilisateur. Des tests automatisés ont également été ajoutés pour éviter toute régression future sur ce mécanisme." },
                
                // 3 - Planificateur d’Anxiété Sociale, 1.0, iOS
                new Ticket { TicketId = 3, ProductVersionOperatingSystemId = 38, TicketStatusId = 2, CreationDate = new DateTime(2024, 1, 24), ResolutionDate = new DateTime(2024, 2, 5), Issue = "Lorsqu’un utilisateur se reconnecte à son compte, l’application oublie le thème sombre précédemment sélectionné et revient au thème clair.", Resolution = "Le paramètre d’apparence n’était pas correctement stocké dans la session utilisateur après une déconnexion. Le système a été mis à jour pour persister cette préférence dans la base de données et la recharger automatiquement à chaque connexion." },
                
                // 4 - Trader en Herbe, 1.1, Windows
                new Ticket { TicketId = 4, ProductVersionOperatingSystemId = 3, TicketStatusId = 2, CreationDate = new DateTime(2024, 2, 14), ResolutionDate = new DateTime(2024, 3, 2), Issue = "Le bouton 'valider' reste grisé même après avoir rempli tous les champs du formulaire d'ajout d'investissement. L'utilisateur est bloqué et ne peut pas enregistrer ses données.", Resolution = "Une condition de validation trop stricte empêchait l'activation du bouton si le champ facultatif 'notes' restait vide. Le contrôle a été ajusté et le bouton est désormais activé dès que les champs obligatoires sont remplis." },
                
                // 5 - Planificateur d’Entraînement, 1.1, iOS
                new Ticket { TicketId = 5, ProductVersionOperatingSystemId = 32, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 7), ResolutionDate = null, Issue = "Le champ 'durée' dans le planificateur se réinitialise après validation d’un exercice, effaçant les données saisies.", Resolution = "" },
               
                // 6 - Planificateur d’Entraînement, 2.0, Android
                new Ticket { TicketId = 6, ProductVersionOperatingSystemId = 33, TicketStatusId = 1, CreationDate = new DateTime(2024, 3, 8), ResolutionDate = null, Issue = "L’application se ferme inopinément dès que l’utilisateur passe en mode avion.", Resolution = "" },
                
                // 7 - Planificateur d’Entraînement, 1.1, iOS
                new Ticket { TicketId = 7, ProductVersionOperatingSystemId = 32, TicketStatusId = 2, CreationDate = new DateTime(2024, 1, 26), ResolutionDate = new DateTime(2024, 2, 6), Issue = "Lorsqu’un utilisateur tente de planifier une séance d'entraînement avec une durée personnalisée, l’heure de fin calculée automatiquement est incorrecte. Par exemple, en saisissant une durée de 45 minutes à partir de 14h30, l’heure de fin affichée est 14h00. Ce dysfonctionnement rend la planification peu fiable et génère des conflits dans l’agenda.", Resolution = "Une erreur dans le calcul de la durée provenait d’un décalage entre le fuseau horaire de l’appareil et l’heure système utilisée par l’application. L’équipe a corrigé la méthode de calcul pour prendre en compte l’heure locale réelle de l’utilisateur. Des tests ont été ajoutés pour vérifier la cohérence horaire sur plusieurs plateformes (iOS, Android, Web)." },
                
                // 8 - Planificateur d’Anxiété Sociale, 1.1, MacOS
                new Ticket { TicketId = 8, ProductVersionOperatingSystemId = 43, TicketStatusId = 1, CreationDate = new DateTime(2024, 1, 20), ResolutionDate = null, Issue = "Lorsqu’un utilisateur tente d’ajouter un événement personnalisé dans son programme hebdomadaire, le texte saisi dans le champ de description disparaît après validation, laissant l’événement sans intitulé. Ce bug rend la planification confuse et oblige l’utilisateur à saisir à nouveau les informations.", Resolution = "" },
                
                // 9 - Trader en Herbe, 1.2, Windows Mobile
                new Ticket { TicketId = 9, ProductVersionOperatingSystemId = 10, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 9), ResolutionDate = null, Issue = "Sur certains appareils Windows Mobile, le clavier virtuel masque partiellement les champs du formulaire d’achat, empêchant l’utilisateur de visualiser correctement le montant saisi. Ce problème est particulièrement gênant sur les écrans de petite taille et peut entraîner des erreurs de saisie lors de l’exécution de transactions financières.", Resolution = "" },

                // 10 - Planificateur d’Anxiété Sociale, 1.0, Android
                new Ticket { TicketId = 10, ProductVersionOperatingSystemId = 39, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 20), ResolutionDate = null, Issue = "Certains utilisateurs rapportent ne jamais recevoir l’e-mail de confirmation d’inscription, même après plusieurs tentatives.", Resolution = "" },

                // 11 - Trader en Herbe, 1.2, Windows
                new Ticket { TicketId = 11, ProductVersionOperatingSystemId = 9, TicketStatusId = 2, CreationDate = new DateTime(2024, 2, 27), ResolutionDate = new DateTime(2024, 3, 11), Issue = "Après la mise à jour vers la version 1.2, certains utilisateurs ne parviennent plus à synchroniser leur portefeuille avec le serveur. Une erreur générique « Connexion impossible » s’affiche sans détails, empêchant l’actualisation des données financières et bloquant l’utilisation de l’application en mode actif.", Resolution = "Le bug était lié à une modification récente du protocole de chiffrement TLS utilisé par l’API. Les anciennes versions de Windows n’étaient pas compatibles avec le nouveau niveau de sécurité requis. Une mise à jour corrective a été déployée pour prendre en charge les configurations les plus courantes tout en maintenant un niveau de sécurité suffisant." },

                // 12 - Maître des Investissements, 1.0, MacOS
                new Ticket { TicketId = 12, ProductVersionOperatingSystemId = 17, TicketStatusId = 2, CreationDate = new DateTime(2024, 4, 10), ResolutionDate = new DateTime(2024, 4, 22), Issue = "Des erreurs d'arrondi apparaissent dans les totaux affichés après plusieurs opérations d’achat ou de vente.", Resolution = "Après analyse du code côté client, il a été identifié que l'erreur provenait d'une gestion approximative des valeurs calculées en virgule flottante. Des ajustements ont été faits pour appliquer un arrondi au centime près, respectant les conventions financières standards." },

                // 13 - Maître des Investissements, 1.0, iOS
                new Ticket { TicketId = 13, ProductVersionOperatingSystemId = 16, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 4), ResolutionDate = null, Issue = "La recherche d’actions spécifiques n’affiche aucun résultat même si le titre est bien coté.", Resolution = "" },

                // 14 - Planificateur d’Entraînement, 2.0, Windows
                new Ticket { TicketId = 14, ProductVersionOperatingSystemId = 36, TicketStatusId = 2, CreationDate = new DateTime(2024, 2, 13), ResolutionDate = new DateTime(2024, 2, 20), Issue = "Lorsqu’un utilisateur termine une séance programmée, celle-ci n’apparaît pas dans le résumé quotidien de l’activité. Cela donne l’impression que l’effort fourni n’a pas été pris en compte.", Resolution = "Le problème venait d’un déclencheur d’événement mal implémenté côté client, qui n’enregistrait pas la fin de séance si l’utilisateur quittait l’écran trop rapidement. L’équipe de développement a modifié le processus de validation pour que les données soient sauvegardées dès la fin de la minuterie, quelle que soit la navigation de l’utilisateur." },

                // 15 - Planificateur d’Entraînement, 2.0, Windows
                new Ticket { TicketId = 15, ProductVersionOperatingSystemId = 36, TicketStatusId = 1, CreationDate = new DateTime(2024, 1, 12), ResolutionDate = null, Issue = "Lorsque l’utilisateur planifie plusieurs séances pour la même journée, seule la première est visible dans le calendrier hebdomadaire. Cela rend difficile la gestion des doubles entraînements ou des variations de programme.", Resolution = "" },

                // 16 - Maître des Investissements, 2.0, Windows
                new Ticket { TicketId = 16, ProductVersionOperatingSystemId = 20, TicketStatusId = 2, CreationDate = new DateTime(2024, 1, 20), ResolutionDate = new DateTime(2024, 1, 27), Issue = "La sauvegarde automatique du portefeuille personnalisé ne fonctionne pas après une modification.", Resolution = "Une erreur de synchronisation entre le cache local et les données du serveur empêchait l’actualisation immédiate. L’équipe a intégré une commande de rafraîchissement forcé après chaque opération pour refléter les changements en temps réel." },

                // 17 - Trader en Herbe, 1.2, Windows Mobile
                new Ticket { TicketId = 17, ProductVersionOperatingSystemId = 10, TicketStatusId = 1, CreationDate = new DateTime(2024, 3, 16), ResolutionDate = null, Issue = "Le simulateur de risque affiche des résultats incohérents lorsqu’un portefeuille contient plus de 10 valeurs.", Resolution = "" },

                // 18 - Trader en Herbe, 1.1, Linux
                new Ticket { TicketId = 18, ProductVersionOperatingSystemId = 4, TicketStatusId = 2, CreationDate = new DateTime(2024, 1, 23), ResolutionDate = new DateTime(2024, 2, 3), Issue = "Les taux d'intérêt affichés dans les profils ne sont pas mis à jour malgré une connexion au serveur.", Resolution = "Le moteur de rendu des graphiques n'était pas compatible avec les résolutions inférieures à 720p. Une refonte du système d'affichage adaptatif a été réalisée pour améliorer la compatibilité avec les petits écrans." },

                // 19 - Maître des Investissements, 1.0, MacOS
                new Ticket { TicketId = 19, ProductVersionOperatingSystemId = 16, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 20), ResolutionDate = null, Issue = "Le mode tutoriel se relance à chaque ouverture de l'application même après avoir été désactivé.", Resolution = "" },

                // 20 - Maître des Investissements, 2.0, iOS
                new Ticket { TicketId = 20, ProductVersionOperatingSystemId = 18, TicketStatusId = 2, CreationDate = new DateTime(2024, 3, 18), ResolutionDate = new DateTime(2024, 3, 27), Issue = "Les alertes programmées pour les plafonds ne se déclenchent pas lorsque l’application est en arrière-plan.", Resolution = "Le système de sauvegarde n’envoyait pas les modifications en cas de perte temporaire de connexion. Un système de file d’attente a été mis en place pour garantir que les modifications soient bien enregistrées dès que la connexion est restaurée." },

                // 21 - Maître des Investissements, 2.1, Windows
                new Ticket { TicketId = 21, ProductVersionOperatingSystemId = 24, TicketStatusId = 1, CreationDate = new DateTime(2024, 3, 29), ResolutionDate = null, Issue = "Certaines actions s’affichent en double après l’opération d’un achat.", Resolution = "" },

                // 22 - Planificateur d’Anxiété Sociale, 1.0, iOS
                new Ticket { TicketId = 22, ProductVersionOperatingSystemId = 38, TicketStatusId = 2, CreationDate = new DateTime(2024, 2, 26), ResolutionDate = new DateTime(2024, 3, 2), Issue = "Les citations motivationnelles du jour n’apparaissent pas dans l’interface d’accueil, laissant un espace vide censé motiver l’utilisateur.", Resolution = "Le bug provenait d’une erreur dans le système de récupération des citations via l’API. Une mauvaise gestion des dates dans la requête empêchait l’affichage des contenus journaliers. L’équipe a corrigé la logique de sélection côté serveur pour renvoyer correctement une citation." },

                // 23 - Trader en Herbe, 1.3, iOS
                new Ticket { TicketId = 23, ProductVersionOperatingSystemId = 13, TicketStatusId = 2, CreationDate = new DateTime(2024, 3, 29), ResolutionDate = new DateTime(2024, 4, 1), Issue = "Lorsqu’un utilisateur tente de modifier une position déjà ouverte, l’interface ne prend pas en compte les nouvelles valeurs saisies et affiche toujours les paramètres d’origine. Cela peut induire en erreur l’utilisateur sur le statut réel de ses ordres.", Resolution = "Le système de mise à jour du portefeuille ne rafraîchissait pas les données après une modification partielle. L’équipe a corrigé cette anomalie en forçant une resynchronisation locale après chaque modification d’ordre. Des tests ont été ajoutés pour valider les cas d’édition multiples." },

                // 24 - Planificateur d’Anxiété Sociale, 1.0, Windows
                new Ticket { TicketId = 24, ProductVersionOperatingSystemId = 40, TicketStatusId = 1, CreationDate = new DateTime(2024, 1, 28), ResolutionDate = null, Issue = "Lors de la rédaction d’une note dans le journal émotionnel, un retour à la page d’accueil sans enregistrement automatique entraîne la perte totale du contenu rédigé.", Resolution = "" },

                // 25 - Planificateur d’Anxiété Sociale, 1.1, MacOS
                new Ticket { TicketId = 25, ProductVersionOperatingSystemId = 43, TicketStatusId = 1, CreationDate = new DateTime(2024, 2, 10), ResolutionDate = null, Issue = "La fonction 'journal émotionnel' ne sauvegarde pas les entrées si l’utilisateur ferme la page web trop rapidement.", Resolution = "" }
                );

            modelBuilder.Entity<TicketStatus>().HasData
                (            
                new TicketStatus { TicketStatusId = 1, Label = "in_progress" },
                new TicketStatus { TicketStatusId = 2, Label = "resolved" },
                new TicketStatus { TicketStatusId = 3, Label = "cancelled" }
                );
        }
    }
}
