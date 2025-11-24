## Build

A projekt buildeléséhez nyiss egy terminált, navigálj a projekt gyökerébe (ahol a `HelloDevOpsApp.csproj` található), majd futtasd az alábbi parancsot:

```bash
dotnet build
```

## Docker 

### Image build
```bash
docker build -t hellodevopsapp:v1 .
```

### Container run
```bash
docker run -p 8080:8080 --name hellodevopsapp hellodevopsapp:v1
```

## Dev Container

A DevContainer használatához telepíteni kell a VS Code 'Dev Containers' bővítményét.

1. Nyisd meg a repository gyökerét VS Code-ban.
2. Nyomd meg: Ctrl+Shift+P, majd válaszd: Dev Containers: Reopen in Container
3. A konténer felépülése után a projekt az alábbi parancsokkal buildelhető és futtatható a terminálból:

```bash
dotnet build ./HelloDevOpsApp/HelloDevOpsApp.csproj
dotnet run --project ./HelloDevOpsApp/HelloDevOpsApp.csproj --urls http://0.0.0.0:8080
```