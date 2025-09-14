#!/usr/bin/env bash

# Define project directory
PROJECT_DIR="1-new_project"

# Check if the project directory already exists
if [ -d "$PROJECT_DIR" ]; then
  echo "The directory $PROJECT_DIR already exists."
  exit 1
fi

# Create the project directory
mkdir $PROJECT_DIR
cd $PROJECT_DIR

# Create a new C# console project
dotnet new console

# Restore the project dependencies
dotnet restore

# Build the project
dotnet build

echo "The new C# project has been created and built successfully."

