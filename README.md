# Data Management Lab

University project

Табличный интерфейс для удобной работы с базой данных найма. Основной функционал включает управление кадидатами, их видами деятельности, работотаделями, должностями, вакансиями и сделками наймов.

Сделка найма должна содержать базовую информацию: информацию об участниках сделки (кандидат и работодатель), информацию о вакансии и заработную плату 

## Prerequisites

- **Client-Side**
  - Node.js v16.13.1
  - Yarn `(npm i -g yarn)`

- **Server-Side**
  - .NET 6
  - MSSQL Server (you can use Docker instead)

- **Optional**
  - docker
  - docker-compose
 
## How to run

# Without Docker

Run each part separatly:

```sh
# Client
cd ./client
yarn run dev
```

```sh
# Server
cd ./server/DataManagementLab.Web
dotnet run
```

Also you need to start MSSQL Server

# With Docker

```sh
docker-compose up
```

