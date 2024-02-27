# Objectives

Create an `adminer` container with the name `hyper-adminer`.

Bind the host port `8080` to container port `8080`.

For the container network use `hyper-network`.

Run the container in detached mode.

Use the official `adminer` image with the tag `4.8.1`.

```bash
docker run -d -p 8080:8080 --network hyper-network --name hyper-adminer adminer:4.8.1
```
