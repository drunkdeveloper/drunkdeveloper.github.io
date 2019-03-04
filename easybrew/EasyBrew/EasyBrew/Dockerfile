FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["EasyBrew/EasyBrew.csproj", "EasyBrew/"]
RUN dotnet restore "EasyBrew/EasyBrew.csproj"
COPY . .
WORKDIR "/src/EasyBrew/"
RUN dotnet build "EasyBrew.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EasyBrew.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EasyBrew.dll"]