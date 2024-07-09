FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY DockerCourseFrontend.csproj .
RUN dotnet restore "DockerCourseFrontend.csproj"
COPY . .
RUN dotnet publish "DockerCourseFrontend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM nginx:alpine
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
