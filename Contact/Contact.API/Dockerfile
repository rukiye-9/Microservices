#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Contact/Contact.API/Contact.API.csproj", "Contact/Contact.API/"]
COPY ["Contact.API.Services/Contact.API.Services.csproj", "Contact.API.Services/"]
COPY ["Contact/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "Contact/Contact.API.Infrastructure/"]
COPY ["Contact/Contact.API.Models/Contact.API.Models.csproj", "Contact/Contact.API.Models/"]
RUN dotnet restore "Contact/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Contact/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]