FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Iwenli.IdentityServer4.STS.Identity/Iwenli.IdentityServer4.STS.Identity.csproj", "src/Iwenli.IdentityServer4.STS.Identity/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.Shared/Iwenli.IdentityServer4.Admin.EntityFramework.Shared.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.Shared/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.SqlServer/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/Iwenli.IdentityServer4.Admin.EntityFramework.MySql/Iwenli.IdentityServer4.Admin.EntityFramework.MySql.csproj", "src/Iwenli.IdentityServer4.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/Iwenli.IdentityServer4.STS.Identity/Iwenli.IdentityServer4.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/Iwenli.IdentityServer4.STS.Identity"
RUN dotnet build "Iwenli.IdentityServer4.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iwenli.IdentityServer4.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Iwenli.IdentityServer4.STS.Identity.dll"]