#!/usr/bin/env bash

if [ ! `git diff --name-only ${TRAVIS_COMMIT_RANGE/.../..} -- src/Square.Connect` ]
then
  echo -e "\033[1;32mSkip packaging because no change was made to 'src/Square.Connect'"
  echo -e "\033[1;32mThis could also because of missing commit caused by force push."
  exit 0
fi

echo "[INFO] Target framework: ${frameworkVersion}"
echo "[INFO] Run 'dotnet' to build bin/Square.Connect.dll"
dotnet build src/Square.Connect/Square.Connect.csproj \
-o ../../bin \
-f $frameworkVersion \
-c Release

if [ $? -ne 0 ]
then
  echo -e "\033[1;31m[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo -e "\033[1;32m[INFO] bin/Square.Connect.dll was created successfully"
fi

# pack
packageVersion="${releaseVersion}.${TRAVIS_BUILD_NUMBER}"
echo "Packing version ${packageVersion} for release..."
dotnet pack src/Square.Connect/Square.Connect.csproj /p:PackageVersion=$packageVersion -c Release -o .

# publish when it's not a pull request and it's on master branch.
if [ "${TRAVIS_PULL_REQUEST_BRANCH}" = "" -a "${TRAVIS_BRANCH}" = "master" ];
then
  echo -e "\033[1;32mPublishing version ${packageVersion} to Nuget..."
  dotnet nuget push src/Square.Connect/*.nupkg -k $NUGET_APIKEY -s https://api.nuget.org/v3/index.json
else
  echo -e "\033[1;32mNot uploading pending changes until it's merged into master."
fi
