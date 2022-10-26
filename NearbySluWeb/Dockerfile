#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#FROM node:16
#WORKDIR "/src/NearbySluWeb/ClientApp"
#RUN npm install
#COPY . .
#EXPOSE 8080
#CMD [ "ng", "serve" ]
FROM node:latest as node
WORKDIR "/src/NearbySluWeb/ClientApp"
COPY . .
RUN npm install
RUN npm run build --prod
RUN node aspnetcore-https
RUN run-script-os


FROM nginx:alpine
COPY . .
Run ng serve --port 44456 --ssl --ssl-cert %APPDATA%\ASP.NET\https\%npm_package_name%.pem --ssl-key %APPDATA%\ASP.NET\https\%npm_package_name%.key

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NearbySluWeb/NearbySluWeb.csproj", "NearbySluWeb/"]
RUN dotnet restore "NearbySluWeb/NearbySluWeb.csproj"
COPY . .
WORKDIR "/src/NearbySluWeb"
RUN dotnet build "NearbySluWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NearbySluWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NearbySluWeb.dll"]