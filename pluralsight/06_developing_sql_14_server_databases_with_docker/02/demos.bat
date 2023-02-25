docker run --rm -v C:/FlywayVols/sql:/flyway/sql flyway/flyway:7.5.2 baseline -url=jdbc:sqlserver://192.168.1.244:1433;databaseName=DessertStore -user=sa -password=G52ndT0ur
docker run --rm -v C:/FlywayVols/sql:/flyway/sql flyway/flyway:7.5.2 migrate -url=jdbc:sqlserver://192.168.1.244:1433;databaseName=DessertStore -user=sa -password=G52ndT0ur
