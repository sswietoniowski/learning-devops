# Developing React Apps with Docker

This course is about developing React apps with Docker.

## Dockerizing a Basic React App

Original sample code can be found [here](https://github.com/saravanan75/docker_react).

Scenario:

- the company Globomantics is growing, but as it grows, it is becoming more difficult to manage the development and deployment of its applications,
- they are using (at the moment) a single monolithic application that is deployed to a single server,
- current setup is reaching its limits, and current performance metrics are barely meeting SLAs expectations,
- the company decided to hire a consultant to help them with the transition to a microservices architecture,
- part of that switch would be to use Docker to containerize the applications.

To build the image, run the following command (inside "v1\Globomantics" directory):

````cmd

```cmd
docker build -f .\Dockerfile -t sswietoniowski/globomantics .
````

To run the container, run the following command:

```cmd
docker run -d -p 3000:3000 --name globomantics sswietoniowski/globomantics
```

We must change Vite configuration to make it work with Docker. To do that, we need to add the following line to the `vite.config.js` file:

```javascript
server: {
  host: true, // THIS IS CRITICAL!
  port: 3000,
}
```

Questions to answer:

- how to reduce the build time?
- what is the IP address provided by the Docker run?
- why I can't access the application from the browser (at localhost:3000)?

To reduce the build time, we can use `.dockerignore` file to exclude files and directories from the build context. Sample content of the file:

```text
node_modules
.git
.vscode
```

To expose the application to the host machine, we need to use the following command:

```cmd
docker run -d -p 3000:3000 --name globomantics sswietoniowski/globomantics
```

Where `-p` is a port mapping option. It maps the port 3000 on the host machine to the port 3000 on the container.

## Building a Multi-container Application Using Docker Compose

Now we're trying to build a multi-container application using Docker Compose.

We would have the client application (React), an API server (Express) and a database (Redis) (the new version of the system can be found inside "v2\Globomantics" directory).

While configuring Express you might find useful [this](https://dev.to/kevinqtogitty/how-to-set-up-an-express-server-with-typescript-and-es6-import-statements-using-vite-9l6) and [this](https://blog.logrocket.com/configuring-nodemon-with-typescript/) articles.

To run the database using Redis, just run the following command:

```cmd
docker run -d -p 6379:6379 --name redis redis
```

## Enhancing the Multi-container Application

## Debugging and Getting the Multi-container Application Ready for Production

Now you are ready to start developing React apps with Docker :-).
