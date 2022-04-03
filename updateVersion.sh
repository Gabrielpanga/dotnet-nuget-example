#!/bin/bash

echo "::set-output name=new_release_version::$1"
sed -i "s#<PackageVersion>.*#<PackageVersion>$1</PackageVersion>#" ../Gpanga.Example.SDK/Gpanga.Example.SDK.csproj
sed -i "s#<Version>.*#<Version>$1</Version>#" ../Gpanga.Example.SDK/Gpanga.Example.SDK.csproj