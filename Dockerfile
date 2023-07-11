FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env-des


WORKDIR /app


EXPOSE 8085

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./DB/*.csproj ./DB/
COPY ./DBOld/*.csproj ./DBOld/
COPY ./MicroservicioCatalogos/*.csproj ./MicroservicioCatalogos/
RUN dotnet restore


# copy everything else and build app
COPY . ./
WORKDIR /app/MicroservicioCatalogos
RUN dotnet publish -c Release -o publish


FROM mcr.microsoft.com/dotnet/aspnet:6.0

RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/' /etc/ssl/openssl.cnf ; \
 sed -i 's/CipherString = DEFAULT@SECLEVEL=2/CipherString = DEFAULT@SECLEVEL=1/' /etc/ssl/openssl.cnf

WORKDIR /app


COPY --from=build-env-des /app/MicroservicioCatalogos/publish .


ENTRYPOINT ["dotnet", "MicroservicioCatalogos.dll"]
