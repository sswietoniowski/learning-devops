FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY "JobDemoConsoleApp.csproj" .
RUN dotnet restore "JobDemoConsoleApp.csproj"
COPY . .
RUN dotnet build "JobDemoConsoleApp.csproj" -c Release -o /app/build
RUN dotnet publish "JobDemoConsoleApp.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 8080
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "JobDemoConsoleApp.dll"]
