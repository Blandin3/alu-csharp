#!/usr/bin/env bash
# Script to initialize a new C# console project

# Create the project directory
mkdir -p 0-new_project

# Navigate into the project directory
cd 0-new_project

# Initialize a new console project using dotnet CLI
dotnet new console --output . --name 0-new_project

