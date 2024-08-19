FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY "HelloApi.csproj" .
RUN dotnet restore "HelloApi.csproj"
COPY . .
RUN dotnet build "HelloApi.csproj" -c Release -o /app/build
RUN dotnet publish "HelloApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 8080
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "HelloApi.dll"]
