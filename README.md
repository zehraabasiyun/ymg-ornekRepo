Docker imajını oluşturma:
docker build -t my-rest-api .


Docker konteynerini çalıştırma:
docker run -d -p 8080:8080 my-rest-api



Container'ın Çalıştığını Doğrulama
docker ps


Docker Compose ile çalıştırma:
docker-compose up -d
