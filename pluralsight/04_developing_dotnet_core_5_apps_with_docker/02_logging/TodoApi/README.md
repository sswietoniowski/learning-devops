# TodoApi

Small example showing use of Docker & Kubernates. This sample was created for my own use during lectures, so nothing fancy here :-).

## Building the API Docker image

To build Docker image for the API, run the following:

```cmd
docker build --tag sswietoniowski/todoapi --file backend/api/Dockerfile ./backend/api
```

## Running the API Docker image (locally)

To run the API, run the following command:

```cmd
docker run -p 5000:5000 -p 5001:5001 -d sswietoniowski/todoapi
```

## Pushing the API Docker image to Docker Hub

To push the API Docker image to Docker Hub, run the following command:

```cmd
docker push sswietoniowski/todoapi
```

## Running the API Docker image (remotely)

To do so, execute the same commands as above, but do so from a [remote machine](https://labs.play-with-docker.com/).

## Running the API Docker image (locally) with Docker Compose

To run the API with Docker Compose, use the following command from the root of the repository:

```bash
docker-compose --file ./backend/api/docker-compose.yaml up -d
```
