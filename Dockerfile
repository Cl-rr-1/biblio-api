# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY BiblioApi.csproj .
RUN dotnet restore

# Copy the rest of the files and publish the application
COPY . .
RUN dotnet publish BiblioApi.csproj -c Release -o out

# Use the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "BiblioApi.dll"]

# Lancer avec docker : 
    # docker build -t bookapi .
    # docker run -p 5000:8080 bookapi
