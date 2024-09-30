# Use the official .NET 8 SDK image to build the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContactManagement.csproj", "./"]   # Adjust this line to match the location of the .csproj file
RUN dotnet restore "ContactManagement.csproj"
COPY . .
RUN dotnet build "ContactManagement.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "ContactManagement.csproj" -c Release -o /app/publish

# Final stage: run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactManagement.dll"]
