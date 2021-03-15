FROM mcr.microsoft.com/dotnet/runtime:5.0
COPY bin/Release/net5.0/publish /app

ENTRYPOINT [ "dotnet", "/app/DaHo.FileSystemGlobbing.Repro.dll" ]
