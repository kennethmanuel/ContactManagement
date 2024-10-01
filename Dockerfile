FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContactManagement.csproj", "./"]
RUN dotnet restore "ContactManagement.csproj"
COPY . .
ENTRYPOINT ["dotnet", "watch", "run", "--project", "ContactManagement.csproj"]
