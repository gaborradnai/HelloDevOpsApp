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