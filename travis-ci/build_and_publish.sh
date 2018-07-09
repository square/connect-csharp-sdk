#!/usr/bin/env bash

if [ ! `git diff --name-only ${TRAVIS_COMMIT_RANGE/.../..} -- src/Square.Connect` ]
then
  echo -e "\033[1;32mSkip packaging because no change was made to 'src/Square.Connect'"
  echo -e "\033[1;32mThis could also because of missing commit caused by force push."
  exit 0
fi

netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

mozroots --import --sync
mono nuget.exe install src/Square.Connect/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.8.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.106.2.2/lib/net452/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Square.Connect.dll"

mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Web.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Square.Connect.dll \
-recurse:"src/Square.Connect/*.cs" \
-doc:bin/Square.Connect.xml \
-platform:anycpu

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
mono nuget.exe pack -version ${packageVersion} -basepath . src/Square.Connect/Square.Connect.nuspec

# publish when it's not a pull request and it's on master branch.
if [ "${TRAVIS_PULL_REQUEST_BRANCH}" = "" -a "${TRAVIS_BRANCH}" = "master" ];
then
  echo -e "\033[1;32mPublishing version ${packageVersion} to Nuget..."
  mono nuget.exe push -apikey $NUGET_APIKEY *.nupkg -Source https://api.nuget.org/v3/index.json
else
  echo -e "\033[1;32mNot uploading pending changes until it's merged into master."
fi
