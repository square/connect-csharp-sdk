#!/usr/bin/env bash

echo "[INFO] Build the solution and run the unit test"
dotnet test src/Square.Connect.Test/Square.Connect.Test.csproj -v n
