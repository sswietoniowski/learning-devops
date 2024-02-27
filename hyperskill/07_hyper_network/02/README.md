# Objectives

Create a Postgres container with the name `hyper-postgres`.

Define an environment variable as the Postgres `password` with the value `hyper2023`.

Define an environment variable as the Postgres `user` with the value `hyper`.

Define an environment variable as the Postgres `database` with the value `hyper-db`.

Bind host port `5432` to container port `5432`. For container networks use `hyper-network``.

For container volume use `hyper-volume` and map it to `/var/lib/postgresql/data`.

Run the container in detached mode.

Use the official Postgres image with the tag `15.3`.

```bash
docker run -d \
  --name hyper-postgres \
  -e POSTGRES_PASSWORD=hyper2023 \
    -e POSTGRES_USER=hyper \
    -e POSTGRES_DB=hyper-db \
    -p 5432:5432 \
    --network hyper-network \
    -v hyper-volume:/var/lib/postgresql/data \
    postgres:15.3
```
