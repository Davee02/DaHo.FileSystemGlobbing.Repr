# Reproduce Docker problem with Microsoft.Extensions.FileSystemGlobbing

1) Clone this repo
2) Navigate your terminal to this directory
3) Run the application: `dotnet run` - Expected output: `Assertion successful` - Actual output: `Assertion successful`
4) Publish the application with the release configuration: `dotnet publish -c Release`
5) Build the docker image: `docker build -t daho/filesystemglobbing-repro .`
6) Run the docker image: `docker run daho/filesystemglobbing-repro` - Expected output: `Assertion successful` - Actual output: `Process terminated. Assertion Failed`
