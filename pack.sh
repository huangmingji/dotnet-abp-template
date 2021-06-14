#!/bin/sh
version=$1
echo $version

dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.Domain.Shared.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.Domain.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.EntityFrameworkCore.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.EntityFrameworkCore.DbMigrations.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.Application.Contracts.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.Application.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.HttpApi.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.HttpApi.Client.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.Host.csproj -o ./pack/
dotnet pack -p:PackageVersion=$version --no-build --no-restore Lemon.Abp.Template.DbMigrations.csproj -o ./pack/