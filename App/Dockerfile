FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PlyStarter.sln ./
COPY App/App.csproj App/
COPY Business/Business.csproj Business/
COPY DataAccess/DataAccess.csproj DataAccess/
RUN dotnet restore App/App.csproj
COPY . .
WORKDIR /src/App
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "App.dll"]
