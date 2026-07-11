# Étape de build : SDK complet pour restaurer et publier
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Restauration isolée pour profiter du cache de layers Docker
COPY TaskFlow.sln ./
COPY src/TaskFlow.Web/TaskFlow.Web.csproj src/TaskFlow.Web/
COPY tests/TaskFlow.Tests/TaskFlow.Tests.csproj tests/TaskFlow.Tests/
RUN dotnet restore

COPY . .
RUN dotnet publish src/TaskFlow.Web -c Release -o /app/publish --no-restore

# Étape d'exécution : runtime ASP.NET seul, image bien plus légère que le SDK
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "TaskFlow.Web.dll"]
