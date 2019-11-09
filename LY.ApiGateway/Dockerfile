FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["LY.ApiGateway/LY.ApiGateway.csproj", "LY.ApiGateway/"]
RUN dotnet restore "LY.ApiGateway/LY.ApiGateway.csproj"
COPY . .
WORKDIR "/src/LY.ApiGateway"
RUN dotnet build "LY.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LY.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LY.ApiGateway.dll"]