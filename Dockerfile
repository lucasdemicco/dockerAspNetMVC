FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="2.0" description="Aplicação ASP NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT [ "dotnet", "dockerMvc.dll" ]
