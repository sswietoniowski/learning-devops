"Ensure container doesn't exist from previous run of this script..."
docker rm -f sqlserver-withvol

"Ensuring our volume doesn't exist..."
docker volume rm sqldb-data

"Creating SQL Server container using volume..."
docker run `
  --name sqlserver-withvol `
  -e "ACCEPT_EULA=Y" `
  -e "MSSQL_SA_PASSWORD=Dometrain#123" `
  -p 1433:1433 `
  -d `
  -v sqldb-data:/var/opt/mssql `
  mcr.microsoft.com/mssql/server:2022-latest

# Note that --mount syntax looks like this:
# --mount "type=volume,source=sqldb-data,target=/var/opt/mssql"

Read-Host 'Press enter to continue once database is seeded'

"Deleting SQL Server container..."
docker rm -f sqlserver-withvol

"Listing all containers..."
docker ps -a

"Listing all volumes..."
docker volume ls

"Creating another SQL Server container using the same volume..."
docker run `
  --name sqlserver-withvol `
  -e "ACCEPT_EULA=Y" `
  -e "MSSQL_SA_PASSWORD=Dometrain#123" `
  -p 1433:1433 `
  -d `
  -v sqldb-data:/var/opt/mssql `
  mcr.microsoft.com/mssql/server:2022-latest
