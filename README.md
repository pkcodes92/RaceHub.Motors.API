# RaceHub.Motors.API

## Project Description
This code repository will be take into account the following problem statement:  

_You are part of the global automotive company, or GAC. They require you to develop an API that has the ability to get information on all the vehicles throughout the world. Along with that, GAC wants you to be able to create in the **same** API to be able to build custom vehicles._

_When it comes to the necessary data store, you have to use the latest SQL Server Express edition to be able to store the necessary vehicle information. Keep in mind, there will not be any PII being shared outside of the API, so there is no need to store any VIN information. However, you should be able to implement some form of authentication/authorization._

## Project Layout

With the API, the necessary project requires there to be a multi-layered web service to be able to accommodate the necessary secure coding practices. These include the following:

1. Having one layer responsible to communicate with a SQL Server database
2. Having a middle layer that will transform the data retrieved from the database into objects that will be communicated to the caller (web app).
3. Having one layer that is available as a web contract to consuming web apps (Angular UI app for example).

# Project Breakdown
In this section, the ReadMe will talk about the layers of this Web API and the role that each layer plays in terms of the overall scheme of this web service.

1. RaceHubMotors.API
2. RaceHubMotors.API.DAL
3. RaceHubMotors.API.DTO
4. RaceHubMotors.API.Services

## RaceHubMotors.API
This is the application layer for the API, which means that here, only the methods that are available are exposed to the consuming applications.

## RaceHubMotors.API.DAL
This is the data access layer (DAL) which interacts directly with the database. In this layer, technologies like Entity Framework Core are being used to be able to query a database, using extension methods like `.ToListAsync()` which in SQL represents something similar to `SELECT * FROM Cfg.VehicleColor`.

## RaceHubMotors.API.DTO
This is the layer that contains all of the models which can be used in the translation from UI entities to the database entities, and in the opposite direction.

## RaceHubMotors.API.Services
For this layer in the API, the code is written such that it would take information from form inputs, and build objects which could be inserted, removed, or updated in the database accordingly. Also, this code will be able to take the necessary information that is retrieved from the database and transform the data retrieved into the entities which the UI can properly understand.