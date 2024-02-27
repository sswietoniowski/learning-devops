FROM python:3.11-slim

WORKDIR /home/app
ADD ./hyper-app .

RUN pip install -r requirements.txt

EXPOSE 8000

ENTRYPOINT ["python3", "main.py"]


