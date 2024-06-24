FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.Sanatorium/Bridge.Sanatorium.csproj", "src/Bridge.Sanatorium/"]
COPY ["src/Bridge.DefaultServices/Bridge.DefaultServices.csproj", "src/Bridge.DefaultServices/"]
COPY ["src/Bridge.Cache.Memory/Bridge.Cache.Memory.csproj", "src/Bridge.Cache.Memory/"]
COPY ["src/Bridge.Cache/Bridge.Cache.csproj", "src/Bridge.Cache/"]
COPY ["src/Bridge.Cache.Redis/Bridge.Cache.Redis.csproj", "src/Bridge.Cache.Redis/"]
COPY ["src/Bridge.Extensions.Logging/Bridge.Extensions.Logging.csproj", "src/Bridge.Extensions.Logging/"]
COPY ["src/Bridge.EventBus.RabbitMq/Bridge.EventBus.RabbitMq.csproj", "src/Bridge.EventBus.RabbitMq/"]
COPY ["src/Bridge.EventBus.Abstractions/Bridge.EventBus.Abstractions.csproj", "src/Bridge.EventBus.Abstractions/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Services.Control/Bridge.Services.Control.csproj", "src/Bridge.Services.Control/"]
COPY ["src/Bridge.EventBus.Shared/Bridge.EventBus.Shared.csproj", "src/Bridge.EventBus.Shared/"]
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