# Objectives

Fix the typo in the `main.py`.

Build and restart the services.

```bash
docker compose down
docker compose up -d --build
```

Create a task with the title `Study` and the description `Study DevOps`:

```bash
curl -X POST -H "Content-Type: application/json" -d '{"title":"Study","description":"Study DevOps"}' http://localhost:8000/tasks
```
