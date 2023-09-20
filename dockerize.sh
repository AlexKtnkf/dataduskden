#!/bin/bash

if [ "$1" == "dev" ]; then
    echo "Running for DEV !!!" && docker compose -f compose.yml -f compose.dev.yml up --build
elif [ "$1" == "build" ]; then
    echo "Building for PROD \o/" && docker compose -f compose.yml -f compose.prod.yml up --build
else 
    echo "Missing command parameter :°( "
fi
