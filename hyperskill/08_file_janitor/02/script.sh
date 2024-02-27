#!/usr/bin/env bash

echo 'File Janitor, ' + `date +%Y`
echo 'Powered by Bash'

if [ "$#" -eq "0" -o $1 = "help" ]; then
    cat file-janitor-help.txt
fi