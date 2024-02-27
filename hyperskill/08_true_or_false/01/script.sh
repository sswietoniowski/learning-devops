#!/usr/bin/env bash

echo "Welcome to the True or False Game!"
curl --silent http://127.0.0.1:8000/download/file.txt --output ID_card.txt
cat ID_card.txt