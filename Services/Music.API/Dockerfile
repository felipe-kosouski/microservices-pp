FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Services/Music.API/Music.API.csproj Services/Music.API/
RUN dotnet restore "Services/Music.API/Music.API.csproj"
COPY . .
WORKDIR "/src/Services/Music.API"
RUN dotnet ef migrations add InitialCreate
RUN dotnet build "Music.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Music.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Music.API.dll"]
