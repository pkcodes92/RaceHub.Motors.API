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