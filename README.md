# Ford Api! [![Build Status](https://travis-ci.org/magicnova/FordApi.svg?branch=master)](https://travis-ci.org/magicnova/FordApi)

 - Developed using Net Core V 2.14, it runs on Localhost:5000 by default.
 - Mongo database is required. This is defined in the config file.


## Routes
| Method  | Route | Description |
|---|---|---|
| GET  | /api/ford  | Get all cars  |
| GET  | /api/ford/model/{model}  | Get cars by model  |
| GET  | /api/ford/motor/{motor}  | Get cars by motor  |
| GET  | /api/ford/gearbox/{gearbox}  | Get cars by gearbox  |
| GET  | /api/ford/year/{year}  | Get cars by year |
| GET  | /api/ford/id/{id}  | Get car by id  |
| POST  | /api/ford  | Create new car  |
| PUT  | /api/ford  |  Update car |
