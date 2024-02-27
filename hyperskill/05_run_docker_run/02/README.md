# Objectives

Build your image from `python:3.11-slim`.

Expose port 8000.

Define the working directory `/home/app`.

Add the content of the `hyper-app` to the working directory.

Add a run instruction with `pip install -r requirements.txt` to the Dockerfile. This command will install the dependencies that are required for your project.

Make the entrypoint of the image, run the following command with parameters `["python3", "main.py"]`.
