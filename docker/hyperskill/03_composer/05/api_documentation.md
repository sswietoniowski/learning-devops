### Documentation
- If jq is not installed on your system, you can omit that part

#### Create a task

```bash
curl -X POST -H "Content-Type: application/json" -d '{"title":"Task title","description":"Task description"}' http://localhost:8000/tasks
```

#### Get task by ID

```bash
curl --silent http://localhost:8000/tasks/{task_id} | jq
```

#### Get task by Title

```bash
curl --silent http://localhost:8000/tasks/title/{task_title} | jq
```

#### Get all tasks

```bash
curl --silent http://localhost:8000/tasks | jq
```

#### Delete task by ID

```bash
curl --silent -X DELETE  http://localhost:8000/tasks/{task_id} | jq
```
