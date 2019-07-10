FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Services/Movie.API/Movie.API.csproj Services/Movie.API/
RUN dotnet restore "Services/Movie.API/Movie.API.csproj"
COPY . .
WORKDIR "/src/Services/Movie.API"
RUN dotnet ef migrations add InitialCreate
RUN dotnet build "Movie.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Movie.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Movie.API.dll"]
