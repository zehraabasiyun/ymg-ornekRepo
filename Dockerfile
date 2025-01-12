# Build aşaması için .NET 8.0 SDK imajını kullan
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Çalışma dizini olarak /src belirle
WORKDIR /src

# Projeyi kopyala ve bağımlılıkları yükle
COPY ["REST-API/REST-API.csproj", "REST-API/"]
RUN dotnet restore "REST-API/REST-API.csproj"

# Geriye kalan dosyaları kopyala
COPY . .

# Uygulamayı derle
WORKDIR "/src/REST-API"
RUN dotnet publish "REST-API.csproj" -c Release -o /app/publish

# Çalıştırma aşaması için .NET 8.0 runtime imajını kullan
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Çalışma dizini olarak /app belirle
WORKDIR /app

# Yayınlanan dosyaları kopyala
COPY --from=build /app/publish .

# Uygulamayı başlat
ENTRYPOINT ["dotnet", "REST-API.dll"]

