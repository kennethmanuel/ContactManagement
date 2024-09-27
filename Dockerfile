# Use the SDK image for building and running the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

# Install any additional tools or dependencies you need
# (Optional, uncomment if needed)
# RUN apt-get update && apt-get install -y some-package

# Expose the application port
EXPOSE 80

# Copy the project files
COPY ["ContactManagement.csproj", "./"]
RUN dotnet restore "./ContactManagement.csproj"
COPY . .

# Set the environment to Development
ENV ASPNETCORE_ENVIRONMENT=Development

# Build and run the application
ENTRYPOINT ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:80"]
