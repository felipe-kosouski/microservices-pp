FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Discovery/Discovery.csproj Discovery/
RUN dotnet restore "Discovery/Discovery.csproj"
COPY . .
WORKDIR "/src/Discovery"
RUN dotnet build "Discovery.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Discovery.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Discovery.dll"]
