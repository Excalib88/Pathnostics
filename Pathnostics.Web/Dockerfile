FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Pathnostics.Web/Pathnostics.Web.csproj", "Pathnostics.Web/"]
RUN dotnet restore "Pathnostics.Web/Pathnostics.Web.csproj"
COPY . .
WORKDIR "/src/Pathnostics.Web"
RUN dotnet build "Pathnostics.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pathnostics.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pathnostics.Web.dll"]
