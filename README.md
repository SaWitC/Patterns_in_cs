### Patterns_in_cs
this reposiotory include alot of application where used some patterns.




# Patterns

## Behavioral
### Mediator(USEFUl)

## Generative patterns
### FactoryMethod(USEFUL)
### AbstracFactory(USEFUL)
### simple Factory(USEFUL)


### Repository(USEFUl)
Repostory it is one of the most easiers patterns. We can create a class that is titled something like ObjectRepository, where object is our model. and this class.and this class will contain all the functions that use to work with the database.

### AbstractRepository(USEFUl)
Abstarctrepository is a pattern similar to the repository pattern but rewritted using generic.



### CQRS(USEFUl)

### MVC(EASY)
MVC it's a pattern that based on the deviding the application into the folloving components:
Model - data model -for example UserModel and etc.
Contoller - get request and Handle it.
View - returned result can be an html page,


### Dependency injection(REQUIRED)
Dependency injection (DI) it's a pattern based on the reflection and allow us to create dependencies betwen objects.
So we can create some service for example the weatherService and IWeatherService interface and with use DI we can create the dependencies betwen this two. 
after that, in our application, we can create a new variable with the type IWeatherService and use it as a WeatherService, it will work fine.
and if one day you need to change realisation to WeatherService2 you only should change it in DI. 



### Specification(RARELY USED)

### Facade
