# Objectives

In the `docker-compose.yaml` file, define the file syntax version as 3.1.

Define one service with the attributes below.

Define the service with the `mongodb` name.

Use the official `mongo:6.0.8` image.

Define a container name with the `hyper-mongo value`.

Map the host port as `27027` to the container port `27017`.

Define the `MONGO_INITDB_ROOT_USERNAME` environment variable with the `${MONGO_INITDB_ROOT_USERNAME}` value.
Define the `MONGO_INITDB_ROOT_PASSWORD` environment variable with the `${MONGO_INITDB_ROOT_PASSWORD}` value.
Define the `env_file` option for the `.env` file.
