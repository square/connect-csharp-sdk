#!/bin/bash
set -eu

if [ ! -f ".release" ]
then
  echo "Missing release file"
  exit 1
fi

if [ ! -f ".version" ]
then
  echo "Missing version file"
  exit 1
fi

# Setup proxy access
export http_proxy=http://webproxy.vip:3128
export https_proxy=${http_proxy}
export no_proxy='vip,square,corp.squareup.com'

# setup git
git config --global user.name "Connect API Specification Generator"
git config --global user.email "devplat-external-sdk-accounts@squareup.com"

# Push release
access_token=$(cat /secrets/prod-jenkins-github-sdk-deployer.txt)
release_message=$(cat .release)
release_version=$(cat .version)
repo_dir=./github-repo
branch_name=release/$release_version

git clone https://$access_token@github.com/square/connect-csharp-sdk.git $repo_dir
cd $repo_dir
if [ `git branch -r | grep -i "^\s*origin/${branch_name}$"` ];
then
  git checkout $branch_name
else
  git checkout -f master
  git branch -D $branch_name || true
  git checkout -b $branch_name
fi

cp -rv ../docs                   .
cp -rv ../src                    .
cp -rv ../travis-ci              .
cp -v ../.gitignore              .
cp -v ../.swagger-codegen-ignore .
cp -v ../.travis.yml             .
cp -v ../build.bat               .
cp -v ../build.sh                .
cp -v ../CHANGES.md              .
cp -v ../LICENSE                 .
cp -v ../mono_nunit_test.sh      .
cp -v ../README.md               .
cp -v ../Square.Connect.sln      .

if [[ -z $(git status -s) ]]
then
  echo "No changes"
else
  git add --all .
  git commit -m "$release_message"
  git push origin release/$release_version
fi

cd ..
rm -rf $repo_dir
