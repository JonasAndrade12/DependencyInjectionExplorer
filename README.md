## Context
This is a simple project in .net6 to see the behavior of the service injection.
By the Hash Code we can see the instance being created and see if it is new or not.

## Result

![Result](https://github.com/JonasAndrade12/DependencyInjectionExplorer/blob/master/img/result.png)

***The singleton*** - Services are null and is initialized when requested. When it is initialized, it always will use the same instance. The lifetime of the instance is the same as the application

***The Scoped*** - The lifetime of the request. Same as Singleton but the instance will die after the request ends. It will always return the same instance. This is most recommended for WEB applications.

***The Transient*** - Services are created each time they are requested. It gets a new instance of the injected object, on each request of this object. For each time you inject this object is injected in the class, it will create a new instance.