FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Arishma.Crm.Api/Arishma.Crm.Api.csproj src/Arishma.Crm.Api/
COPY src/Arishma.Crm.Application/Arishma.Crm.Application.csproj src/Arishma.Crm.Application/
COPY src/Arishma.Crm.Domain/Arishma.Crm.Domain.csproj src/Arishma.Crm.Domain/
COPY src/Arishma.Crm.Infrastructure/Arishma.Crm.Infrastructure.csproj src/Arishma.Crm.Infrastructure/
RUN dotnet restore src/Arishma.Crm.Api/Arishma.Crm.Api.csproj
COPY . .
RUN dotnet publish src/Arishma.Crm.Api/Arishma.Crm.Api.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://*:5005
ENTRYPOINT ["dotnet", "Arishma.Crm.Api.dll"]
