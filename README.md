# Biblio API
C'est une application de gestion de livres, en C#.

### Technologies : 
- C# .NET 8
- SQLite
- Docker

## Installation
```sh
npm i 
``` 

## Via le local celui de dotnet : 

### Build l'app
```sh
dotnet build
```

### Lancer l'app
```sh
dotnet run
``` 

### Accéder au Swagger : 
-> [localhost:5143/swagger/](http://localhost:5143/swagger/index.html)



## Via le Docker :

### Build l'app
```sh
docker build --no-cache -t biblioapi .
```

### Lancer l'app
```sh
docker run -p 5000:8080 biblioapi
```

### Accéder au Swagger : 
-> [localhost:5000/swagger/](http://localhost:5000/swagger/index.html)
