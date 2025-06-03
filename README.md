# Projet 6 — Modélisez et créez une base de données pour une application .NET

## Présentation

Ce projet consiste à modéliser une base de données pour la gestion de tickets d’application, à l’exploiter via des requêtes LINQ optimisées, et à livrer une sauvegarde complète de la base.  

---

## Structure du projet

- **Dossier `/Models/Entities/`** : Contient les entités EF Core (`Ticket`, `Product`, `OperatingSystem`, etc.)
- **Dossier `/Extensions/` ou “My Extensions” dans LINQPad** : Contient les méthodes d’extension pour simplifier les requêtes LINQ (ex: `ApplyFilters`)
- **Dossier `/`** : Contient la sauvegarde intégrale de la base de données (`aspnet-Projet_6_BackUp.bak`)

---

## Utilisation des requêtes LINQ

Toutes les requêtes principales du projet sont regroupées en une requête paramétrable via la méthode d’extension `ApplyFilters`.  
Il suffit de modifier les paramètres pour obtenir la plupart des cas d’usage métier.

## Pour restaurer la base de données

- Ouvrir SSMS > clic droit sur “Bases de données” > “Restaurer une base de données...”

- Sélectionner le fichier .bak fourni.

- Suivre l’assistant de restauration.
