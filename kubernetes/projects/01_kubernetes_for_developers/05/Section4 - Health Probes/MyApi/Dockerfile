FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY "MyApi.csproj" .
RUN dotnet restore "MyApi.csproj"
COPY . .
RUN dotnet build "MyApi.csproj" -c Release -o /app/build
RUN dotnet publish "MyApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 8080
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "MyApi.dll"]
