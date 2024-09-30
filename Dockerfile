# Use the official .NET image for building the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["ContactManagement.csproj", "."]
RUN dotnet restore

# Copy the entire project and build
COPY . .
WORKDIR "/src"  
RUN dotnet build "ContactManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactManagement.dll"]
