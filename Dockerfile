FROM microsoft/aspnetcore
WORKDIR /app
COPY ./FizzBuzzApp.Web/bin/Debug/netcoreapp1.1/publish .
ENTRYPOINT ["dotnet", "FizzBuzzApp.Web.dll"]