FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Iwenli.IdentityServer4.Admin.Api/Iwenli.IdentityServer4.Admin.Api.csproj", "src/Iwenli.IdentityServer4.Admin.Api/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.Shared/Iwenli.IdentityServer4.Admin.EntityFramework.Shared.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.Shared/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.MySql/Iwenli.IdentityServer4.Admin.EntityFramework.MySql.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/Iwenli.IdentityServer4.Admin.Api/Iwenli.IdentityServer4.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/Iwenli.IdentityServer4.Admin.Api"
RUN dotnet build "Iwenli.IdentityServer4.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iwenli.IdentityServer4.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Iwenli.IdentityServer4.Admin.Api.dll"]