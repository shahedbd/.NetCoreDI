# .Net Core DI
Dependency injection into controllers in ASP.NET Core

### What is Dependency Injection?
In software engineering, dependency injection is a technique whereby one object (or static method) 
supplies the dependencies of another object. A dependency is an object that can be used (a service).  <br />

An injection is the passing of a dependency to a dependent object (a client) that would use it. 
The service is made part of the client's state.[1] Passing the service to the client, rather than 
allowing a client to build or find the service, is the fundamental requirement of the pattern. <br />

This fundamental requirement means that using values (services) produced within the class from 
new or static methods is prohibited. The client should accept values passed in from outside. 
This allows the client to make acquiring dependencies someone else's problem. <br />

The intent behind dependency injection is to decouple objects to the extent that no client code 
has to be changed simply because an object it depends on needs to be changed to a different one.  <br />



## Dependency Injection 
![Dependency Injection](https://github.com/shahedbd/.NetCoreDI/blob/master/Sln.DotNetCoreDI/DotNetCoreDI/Resources/DBObjects.jpg)

<br />

![Dependency Injection](https://github.com/shahedbd/.NetCoreDI/blob/master/Sln.DotNetCoreDI/DotNetCoreDI/Resources/dependency-injection-golf.png)

<br />

![Dependency Injection](https://github.com/shahedbd/.NetCoreDI/blob/master/Sln.DotNetCoreDI/DotNetCoreDI/Resources/Source.png)

<br />
