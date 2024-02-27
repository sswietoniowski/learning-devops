# Objectives

Print the welcoming message: `Welcome to the True or False Game!`.

Use `curl`, connect to the endpoint `http://127.0.0.1:8000/download/file.txt`, and download the file as `ID_card.txt`.

Use the `--silent` option to avoid the terminal messages.

Use the `--output <filename>` option to name the output file.

Print the content of `ID_card.txt` to the standard output.

```bash
echo "Welcome to the True or False Game!"
curl --silent http://127.0.0.1:8000/download/file.txt --output ID_card.txt
cat ID_card.txt
```
