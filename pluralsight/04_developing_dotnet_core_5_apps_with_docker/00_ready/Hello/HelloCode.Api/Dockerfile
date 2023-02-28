FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HelloCode.Api.csproj", "./"]
RUN dotnet restore "HelloCode.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "HelloCode.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloCode.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloCode.Api.dll"]
