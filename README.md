# .NET CORE Docker Microservices
This project is for study/exam for the subject Design Patterns
It could be done in any language (I choose .NET because i´m going to use for work)
It needs to use the Microservices Architecture with Service Discovery and a Gateway
It needs to use Docker
It needs to have at least 2 REST Microservices

# Environment
It´s being developed in

- MacOS Mojave
- Visual Studio Community 2019
- SQL Server (soon)
- SQL Server Management Studio (soon)
- .NET Core SDK v2.2
- Docker Desktop Community Version 2.0.0.3

# Setup

1. Download/clone repo.

2. From the root folder (where _docker-compose.yml_ resides) use the Docker CLI to build and start the containers for the solution: `$ docker-compose up -d`.  This step will take a few minutes or more as all the base images must be downloaded. 

3. Start the Containers with `$ docker run -d -p 8080:80 --name Music music` and `$ docker run -d -p 8081:80 --name Movie movie`
