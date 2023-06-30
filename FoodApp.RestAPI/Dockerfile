#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FoodApp.RestAPI/FoodApp.RestAPI.csproj", "FoodApp.RestAPI/"]
COPY ["FoodApp.DataService/FoodApp.ORM.csproj", "FoodApp.DataService/"]
COPY ["Models/FoodApp.Models.csproj", "Models/"]
COPY ["FoodApp.DI/FoodApp.DI.csproj", "FoodApp.DI/"]
COPY ["FoodApp.DTO/FoodApp.DTO.csproj", "FoodApp.DTO/"]
RUN dotnet restore "FoodApp.RestAPI/FoodApp.RestAPI.csproj"
COPY . .
WORKDIR "/src/FoodApp.RestAPI"
RUN dotnet build "FoodApp.RestAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoodApp.RestAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodApp.RestAPI.dll"]