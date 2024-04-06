FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bridge.HostApi/Bridge.HostApi.csproj", "src/Bridge.HostApi/"]
COPY ["src/Bridge.Services.Control/Bridge.Services.Control.csproj", "src/Bridge.Services.Control/"]
RUN dotnet restore "./src/Bridge.HostApi/./Bridge.HostApi.csproj"
COPY . .
WORKDIR "/src/src/Bridge.HostApi"
RUN dotnet build "./Bridge.HostApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bridge.HostApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.HostApi.dll"]