import os

from fastapi import FastAPI
from pydantic import BaseModel
from pymongo import MongoClient
from bson.objectid import ObjectId

app = FastAPI()

# Get MongoDB connection parameters
host = os.environ.get('MONGO_HOST_NAME')
mongo_port_number = int(os.environ.get('MONGO_PORT_NUMBER'))
username = os.environ.get('MONGO_INITDB_ROOT_USERNAME')
password = os.environ.get('MONGO_INITDB_ROOT_PASSWORD')

# Create a MongoClient for DB operations
client = MongoClient(host,
                     mongo_port_number,
                     username=username,
                     password=password,
                     )

# Define DB and collection
db = client["task_manager"]
tasks_collection = db["tasks"]


class Task(BaseModel):
    title: str
    description: str


@app.post("/tasks")
def create_task(task: Task):
    task_dict = task.model_dump()
    task_id = tasks_collection.insert_one(task_dict).inserted_id
    task_dict["_id"] = str(task_id)
    return task_dict


@app.get("/tasks/{task_id}")
def get_task_by_id(task_id: str):
    task = tasks_collection.find_one({"_id": ObjectId(task_id)})
    if task:
        task["_id"] = str(task["_id"])
        return task
    return {"message": f"Task with id: {task_id} does not found!"}


@app.get("/tasks/title/{task_title}")
def get_task_by_title(task_title: str):
    task = tasks_collection.find_one({"title": task_title})
    if task:
        task["_id"] = str(task["_id"])
        return task
    return {"message": f"Task with title: {task_title} does not found!"}


@app.get("/tasks")
def get_all_tasks():
    tasks = tasks_collection.find()
    result = []
    for task in tasks:
        task["_id"] = str(task["_id"])
        result.append(task)
    return result


@app.delete("/tasks/{task_id}")
def delete_task(task_id: str):
    result = tasks_collection.delete_one({"_id": ObjectId(task_id)})
    if result.deleted_count:
        return {"message": "Task has been deleted successfully!"}
    return {"message": f"Task with id: {task_id} does not found!"}
