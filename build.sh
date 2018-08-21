#!/usr/bin/env bash

frameworkVersion=netstandard2.0
echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Run 'dotnet' to build bin/Square.Connect.dll"
dotnet build src/Square.Connect/Square.Connect.csproj \
-o ../../bin \
-f $frameworkVersion

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Square.Connect.dll was created successfully"
fi
