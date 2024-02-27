# Objectives

Stop the container which has the image `hyper-web-app`:

```bash
docker ps -a | grep hyper-web-app | awk '{print $1}' | xargs docker stop
```

Delete the container that the image is `hyper-web-app`:

```bash
docker ps -a | grep hyper-web-app | awk '{print $1}' | xargs docker rm
```

Remove the image with the tag `hyper-web-app:latest`:

```bash
docker rmi hyper-web-app:latest
```
