FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["FEShop.WebApi/FEShop.WebApi.csproj", "FEShop.WebApi/"]
COPY ["FEShop.Application/FEShop.Application.csproj", "FEShop.Application/"]
COPY ["FEShop.Domain/FEShop.Domain.csproj", "FEShop.Domain/"]
COPY ["FEShop.Infrastructure/FEShop.Infrastructure.csproj", "FEShop.Infrastructure/"]

RUN dotnet restore "FEShop.WebApi/FEShop.WebApi.csproj"

COPY . .

RUN dotnet publish "FEShop.WebApi/FEShop.WebApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "FEShop.WebApi.dll"]