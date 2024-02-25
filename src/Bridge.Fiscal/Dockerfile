#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.Fiscal/Bridge.Fiscal.csproj", "src/Bridge.Fiscal/"]
COPY ["src/Bridge.EventBus.Shared/Bridge.EventBus.Shared.csproj", "src/Bridge.EventBus.Shared/"]
COPY ["src/Bridge.EventBus/Bridge.EventBus.csproj", "src/Bridge.EventBus/"]
COPY ["src/Bridge.Services.Control/Bridge.Services.Control.csproj", "src/Bridge.Services.Control/"]
RUN dotnet restore "./src/Bridge.Fiscal/./Bridge.Fiscal.csproj"
COPY . .
WORKDIR "/src/src/Bridge.Fiscal"
RUN dotnet build "./Bridge.Fiscal.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.Fiscal.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.Fiscal.dll"]