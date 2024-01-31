FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.Sanatorium/Bridge.Sanatorium.csproj", "src/Bridge.Sanatorium/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Extensions.Logging/Bridge.Extensions.Logging.csproj", "src/Bridge.Extensions.Logging/"]
COPY ["src/Bridge.Logger/Bridge.Logger.csproj", "src/Bridge.Logger/"]
RUN dotnet restore "./src/Bridge.Sanatorium/./Bridge.Sanatorium.csproj"
COPY . .
WORKDIR "/src/src/Bridge.Sanatorium"
RUN dotnet build "./Bridge.Sanatorium.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.Sanatorium.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.Sanatorium.dll"]