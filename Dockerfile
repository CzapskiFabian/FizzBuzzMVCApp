FROM microsoft/aspnetcore
WORKDIR /app
COPY ./FizzBuzzApp.Web/publish .
ENTRYPOINT ["dotnet", "FizzBuzzApp.Web.dll"]