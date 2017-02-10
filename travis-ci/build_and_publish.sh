#!/usr/bin/env bash

frameworkVersion=net45
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

mozroots --import --sync
mono nuget.exe install src/Square.Connect/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.8.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net45/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Square.Connect.dll"

mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Square.Connect.dll \
-recurse:"src/Square.Connect/*.cs" \
-doc:bin/Square.Connect.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Square.Connect.dll was created successfully"
fi

# pack
echo "Packing..."
mono nuget.exe pack -basepath . src/Square.Connect/Square.Connect.nuspec

# publish when it's not a pull request and it's on master branch.
if [ "${TRAVIS_PULL_REQUEST_BRANCH}" = "" -a "${TRAVIS_BRANCH}" = "master" ];
then
  echo "Uploading..."
  mono nuget.exe push -apikey $NUGET_APIKEY *.nupkg
else
  echo "Not uploading pending changes."
fi