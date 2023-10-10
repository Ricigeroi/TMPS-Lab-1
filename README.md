# TMPS-Lab-2
----
#### University: _Technical University of Moldova_
#### Faculty: _FCIM_
#### Author: _Bardier Andrei FAF-213_
----
## Objectives:
&ensp; &ensp; __1. Study and understand the Creational Design Patterns.__

&ensp; &ensp; __2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.__

&ensp; &ensp; __3. Use some creational design patterns for object instantiation in a sample project.__

## Some Theory:
&ensp; &ensp; Creational design patterns are a category of design patterns that focus on the process of object creation. They provide a way to create objects in a flexible and controlled manner, while decoupling the client code from the specifics of object creation. Creational design patterns address common problems encountered in object creation, such as how to create objects with different initialization parameters, how to create objects based on certain conditions, or how to ensure that only a single instance of an object is created. There are several creational design patterns that have their own strengths and weaknesses. Each of it is best suited for solving specific problems related to object creation. By using creational design patterns, developers can improve the flexibility, maintainability, and scalability of their code.

&ensp; &ensp; Some examples of this kind of design patterns are:

   * Singleton
   * Builder
   * Prototype
   * Object Pooling
   * Factory Method
   * Abstract Factory
   
## Main tasks:
&ensp; &ensp; __1. Choose an OO programming language and a suitable IDE or Editor (No frameworks/libs/engines allowed).__

&ensp; &ensp; __2. Select a domain area for the sample project.__

&ensp; &ensp; __3. Define the main involved classes and think about what instantiation mechanisms are needed.__

&ensp; &ensp; __4. Based on the previous point, implement at least 2 creational design patterns in your project.__

## Implementation:
Here is a small console application that tries to recreate a taxi company.

### Singleton Pattern
The TaxiCompany class implements the Singleton pattern. Here’s a step-by-step explanation:

Private Static Instance: A private static instance of TaxiCompany is declared within the class. This instance represents the single instance of the class that will be created and used.
```c#
private static TaxiCompany instance;
```
Private Constructor: The constructor of TaxiCompany is private, ensuring that no other class can instantiate it.
```c#
private TaxiCompany() { ... }
```
GetInstance Method: This method is used to obtain the single instance of TaxiCompany. If instance is null, it is instantiated; otherwise, the existing instance is returned.
```c#
public static TaxiCompany GetInstance() { ... }
```
### Builder Pattern
Implemented through the IBuilder interface, CarBuilderSimple class, and CarBuilderPremium class:

IBuilder Interface: Defines methods that the concrete builders must implement to construct different parts of the product (Car).
```c#
internal interface IBuilder
{
    void Reset(Car car);
    void AddABS();
    void AddClimate();
    void AddInterior();
    void AddMultimedia();
    Car GetCar();  
}
```
Example of one of the implementations:
```c#
namespace TMPS_Lab_1.Cars
{
    internal class CarBuilderPremium : IBuilder
    {
        Car car;

        public void Reset(Car car)
        {
            this.car = car;
        }
        public void AddABS()
        {
            this.car.AddPart("ABS system");
        }
        public void AddInterior()
        {
            this.car.AddPart("Leather Interior");
        }
        
        public void AddClimate()
        {
            this.car.AddPart("Automatic Conditioner");
        }
        
        public void AddMultimedia()
        {
            this.car.AddPart("GPS multimedia");
        }

        public Car GetCar()
        {
            return this.car;
        }

    }
}
```
Director class:
```c#
namespace TMPS_Lab_1.Cars
{
    internal class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }


        public Car BuildCarWithABS (Car car)
        {
            this._builder.Reset(car);
            this._builder.AddABS();
            this._builder.AddClimate();
            this._builder.AddInterior();
            this._builder.AddMultimedia();
            return this._builder.GetCar();
        }
        public Car BuildCarWithoutABS(Car car)
        {
            this._builder.Reset(car);
            this._builder.AddClimate();
            this._builder.AddInterior();
            this._builder.AddMultimedia();
            return this._builder.GetCar();
        }


    }
}
```
CarBuilderSimple & CarBuilderPremium Classes: These classes implement IBuilder and provide specific implementations for building simple and premium cars, respectively.
CarBuilderSimple.cs,
CarBuilderPremium.cs and 
Director Class: Uses an IBuilder to construct a car. It has methods to build a car with or without ABS, demonstrating the flexibility provided by the Builder pattern.
Director.cs
### Prototype Pattern
Implemented in the Engine class:

Copy Method: The Engine class has a Copy method that creates and returns a shallow copy of the current object. This method utilizes the MemberwiseClone method to perform the copying process.
```c#
public Engine Copy() { ... }
```
```c#
// Prototype pattern
Engine toyota_hybrid_engine = new("petrol-hybrid fuel", 140);
Engine prius_engine = toyota_hybrid_engine.Copy();
Engine auris_engine = toyota_hybrid_engine.Copy();
```
This allows for creating new Engine objects that are copies of existing ones without having to go through the regular construction process, demonstrating the Prototype pattern.

## Conclusion
In this repository, I've diligently implemented three fundamental design patterns: Singleton, Builder, and Prototype in a C# environment. The Singleton pattern is embodied in the TaxiCompany class, ensuring centralized control and unique instance creation, which is pivotal for maintaining a consistent state throughout the application. Through the IBuilder interface, alongside CarBuilderSimple and CarBuilderPremium classes, the Builder pattern is showcased. This implementation simplifies the process of constructing intricate Car objects, promoting code modularity and readability. Furthermore, the Prototype pattern is incorporated within the Engine class, enabling efficient object cloning and mitigating the overhead associated with instantiating objects traditionally. This approach is instrumental in optimizing performance, especially when dealing with resource-intensive objects. Overall, this repository is a testament to my commitment to applying best practices and design principles in software development, providing a robust foundation for scalable and maintainable code.
