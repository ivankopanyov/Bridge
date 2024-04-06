FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.Fias/Bridge.Fias.csproj", "src/Bridge.Fias/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Fias.Entities/Bridge.Fias.Entities.csproj", "src/Bridge.Fias.Entities/"]
COPY ["src/Bridge.Fias.Interface/Bridge.Fias.Interface.csproj", "src/Bridge.Fias.Interface/"]
RUN dotnet restore "./src/Bridge.Fias/./Bridge.Fias.csproj"
COPY . .
WORKDIR "/src/src/Bridge.Fias"
RUN dotnet build "./Bridge.Fias.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.Fias.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.Fias.dll"]