Run it via visual studio or using Docker with the following commands from the root of the project:
dotnet restore
dotner publish
docker build -t fizzbuzzapp .
docker run -p 80:80 fizzbuzzapp