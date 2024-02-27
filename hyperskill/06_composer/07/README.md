# Objectives

Stop the services, and delete containers, networks, and volumes.

Remove the `hyper-service` image from the system:

```bash
docker compose down --rmi all --volumes
```
