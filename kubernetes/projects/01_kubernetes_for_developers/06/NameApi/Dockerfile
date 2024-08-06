FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY "NameApi.csproj" .
RUN dotnet restore "NameApi.csproj"
COPY . .
RUN dotnet build "NameApi.csproj" -c Release -o /app/build
RUN dotnet publish "NameApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 8080
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "NameApi.dll"]
