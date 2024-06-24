FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.TelegramBot/Bridge.TelegramBot.csproj", "src/Bridge.TelegramBot/"]
COPY ["src/Bridge.DefaultServices/Bridge.DefaultServices.csproj", "src/Bridge.DefaultServices/"]
COPY ["src/Bridge.Cache.Memory/Bridge.Cache.Memory.csproj", "src/Bridge.Cache.Memory/"]
COPY ["src/Bridge.Cache/Bridge.Cache.csproj", "src/Bridge.Cache/"]
COPY ["src/Bridge.Cache.Redis/Bridge.Cache.Redis.csproj", "src/Bridge.Cache.Redis/"]
COPY ["src/Bridge.Extensions.Logging/Bridge.Extensions.Logging.csproj", "src/Bridge.Extensions.Logging/"]
COPY ["src/Bridge.EventBus.RabbitMq/Bridge.EventBus.RabbitMq.csproj", "src/Bridge.EventBus.RabbitMq/"]
COPY ["src/Bridge.EventBus.Abstractions/Bridge.EventBus.Abstractions.csproj", "src/Bridge.EventBus.Abstractions/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Services.Control/Bridge.Services.Control.csproj", "src/Bridge.Services.Control/"]
RUN dotnet restore "./src/Bridge.TelegramBot/./Bridge.TelegramBot.csproj"
COPY . .
WORKDIR "/src/src/Bridge.TelegramBot"
RUN dotnet build "./Bridge.TelegramBot.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.TelegramBot.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.TelegramBot.dll"]
