# Use the official .NET image for building the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContactManagement/ContactManagement.csproj", "ContactManagement/"]
RUN dotnet restore "ContactManagement/ContactManagement.csproj"
COPY . .
WORKDIR "/src/ContactManagement"
RUN dotnet build "ContactManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactManagement.dll"]
