#!/bin/bash

VERSION_SUFFIX=$1

echo "$VERSION_SUFFIX"

if [ "$VERSION_SUFFIX" ]; then
  VERSION_SUFFIX="--version-suffix $VERSION_SUFFIX"
fi

# rm -rf ./output

cd ./src/CQRS/Pachman.MediatoR.CQRS

dotnet build -c Release
dotnet pack -c Release --no-restore -o ../../../output $VERSION_SUFFIX
