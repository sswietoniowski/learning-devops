#!/usr/bin/env bash

echo "File Janitor $(date +%Y)"
echo 'Powered by Bash'

if [ "$#" -ge "1" ] && [ "$#" -le "2" ] && [ "$1" == "list" ]; then
    directory='.'
    if [ "$#" -eq "2" ]; then
        directory=$2
        echo "Listing files in $directory"
    else 
        echo 'Listing files in the current directory'
    fi

    if [ -e "$directory" ]; then
        if [ -d "$directory" ]; then
            ls -A -v "$directory"
        else
                echo "$directory is not a directory"
        fi
    else
        echo "$directory is not found"
    fi
elif [ "$#" -eq "1" ] && [ "$1" == "help" ]; then
    cat file-janitor-help.txt
else
    echo "Type $0 help to see available options"
fi