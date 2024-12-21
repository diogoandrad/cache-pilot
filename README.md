# Cache Pilot

Project for studies, focusing on implementing functions for cache management.

## Technologies

* .NET 8
* Blazor
* Redis

## Functionalities

* Manage users

## Run Cache

```bash
docker run --name redis -d -p 6379:6379 -v redis-data:/data redis redis-server --requirepass "4dp8$2mk"
```

## Run

Clone the project:
```bash
git clone https://github.com/diogoandrad/cache-pilot.git
```

Enter the project folder:
```bash
cd cache-pilot
```

Run the application:
```bash
dotnet run
```

## Autor

Built by [Diogo Andrade](https://github.com/diogoandrad).

## License

This project is on [MIT license](./LICENSE).
