# TaskFlow

Plateforme collaborative de gestion de projets en temps réel — board Kanban
multi-utilisateurs avec synchronisation instantanée.

> 🚧 Projet en cours de développement. Ce README sera enrichi au fil des
> fonctionnalités (démo animée, schéma d'architecture).

## Stack technique

- **Backend** : ASP.NET Core 8 (MVC), Entity Framework Core, PostgreSQL
- **Frontend** : KnockoutJS (board Kanban interactif, à venir)
- **Temps réel** : SignalR (à venir)
- **Infra** : Docker / docker-compose, CI GitHub Actions, tests xUnit

## Lancer le projet

Prérequis : Docker.

```bash
docker compose up --build
```

Puis ouvrir <http://localhost:8081>.

## Lancer les tests

```bash
dotnet test
```
