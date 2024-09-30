# Use the SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContactManagement.csproj", "./"]   # Adjust this line to match the location of the .csproj file
RUN dotnet restore "ContactManagement.csproj"
COPY . .

ENTRYPOINT ["dotnet", "watch", "run", "--project", "ContactManagement.csproj"];
