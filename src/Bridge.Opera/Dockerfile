FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.Opera/Bridge.Opera.csproj", "src/Bridge.Opera/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Opera.Domain.Entities.Tables/Bridge.Opera.Domain.Entities.Tables.csproj", "src/Bridge.Opera.Domain.Entities.Tables/"]
COPY ["src/Bridge.Opera.Domain/Bridge.Opera.Domain.csproj", "src/Bridge.Opera.Domain/"]
RUN dotnet restore "./src/Bridge.Opera/./Bridge.Opera.csproj"
COPY . .
WORKDIR "/src/src/Bridge.Opera"
RUN dotnet build "./Bridge.Opera.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.Opera.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.Opera.dll"]