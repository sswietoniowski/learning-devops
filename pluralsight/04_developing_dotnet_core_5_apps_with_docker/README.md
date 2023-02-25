# Developing .NET Core 5 Apps with Docker

## Getting Started with .NET Core and Docker

Basic introduction to .NET Core and Docker.

## Logging in Docker-based .NET Core Apps

Logging in containers:

- key success factor: enable understanding and ease-of-use, then get on with app,
- console is key: troubleshooting is made easy by console logging,
- analysis matters: get logs into a store that supports analysis and exploration.

Level up with Serilog:

- logging libraries provide benefits:
  - structured logging,
  - wide variety of "sinks" (targets),
  - enrichers (add context to log events),
  - filters (control what gets logged),
- Serilog is leading the pack:
  - NLog and Log4Net are also popular.

## Configuration in Docker-based .NET Core Apps

Types of configuration:

- environment-specific: URLs, server names, non-secret values,
- secrets: passwords, API keys, connection strings, license keys, etc.,
- runtime "knobs": things you don't want hard-coded (feature toggles?) - very subjective.

Layered configuration:

- appsettings.json: json-based text file,
- appsettings.{environment}.json: json-based text file, based on ASPNETCORE_ENVIRONMENT,
- user secrets: development only, not checked into source control,
- environment variables: set by the OS, can be set in Dockerfile,
- command-line arguments: set by the OS, can be set in Dockerfile.

Containers like environment variables: containers are immutable - build one image to run anywhere.

Typical approach:

- app settings with environment variables,
- eliminates env-specific appsettings files,
- leverage container capabilities,
- load secrets during runtime if needed.

Protect your secrets:

- different approaches are available,
- apply as environment variables from secrets in pipeline,
  - consider who can see variables,
- read at runtime from a vault:
  - you still need to auth to the vault.

## Building Docker Images for .NET Core Apps

## Simplify Complex Solutions with Docker Compose
