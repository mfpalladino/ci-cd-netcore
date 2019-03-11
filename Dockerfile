FROM microsoft/dotnet:2.1-sdk AS build

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM build AS publish
COPY . .
RUN dotnet publish "/WebApplication1/WebApplication1.csproj" -c Debug -o /app

FROM base AS final
ENV ASPNETCORE_URLS http://+:4000

WORKDIR /app
COPY --from=publish /app .

EXPOSE 4000
ENTRYPOINT ["dotnet", "WebApplication1.dll"]