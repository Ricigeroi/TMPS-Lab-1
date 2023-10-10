# TMPS-Lab-1
----
#### University: _Technical University of Moldova_
#### Faculty: _FCIM_
#### Author: _Bardier Andrei FAF-213_
----
## Objectives:
&ensp; &ensp; __1. Study and understand the SOLID Principles.__

&ensp; &ensp; __2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.__

&ensp; &ensp;__3. Create a sample project that respects SOLID Principles.__

## Theory:
&ensp; &ensp; SOLID is a set of five object-oriented design principles intended to make software designs more maintainable, flexible, and easy to understand. The acronym stands for Single Responsibility Principle, Open-Closed Principle, Liskov Substitution Principle, Interface Segregation Principle, and Dependency Inversion Principle. Each principle addresses a specific aspect of software design, such as the organization of responsibilities, the handling of dependencies, and the design of interfaces. By following these principles, software developers can create more modular, testable, and reusable code that is easier to modify and extend over time. These principles are widely accepted and adopted in the software development community and can be applied to any object-oriented programming language.
   
## Main tasks:
&ensp; &ensp; __1. Choose an OO programming language and a suitable IDE or Editor (No frameworks/libs/engines allowed).__

&ensp; &ensp; __2. Select a domain area for the sample project.__

&ensp; &ensp; __3. Define the main involved classes and think about what instantiation mechanisms are needed.__

&ensp; &ensp; __4. Respect SOLID Principles in your project.__

## Implementation:
Here is a small console application that tries to recreate a taxi company.
At the moment there are 13 classes and 5 interfaces, which are the basis for this application.
The project structure consists of several folders in which class or interface files are grouped according to their meaning.
    
In my humble opinion, all SOLID principles were followed to one degree or another. Since the application is quite small, it is quite difficult to fully implement them (due to the lack of code amount). However, I can try to explain each principle and its implementation.  
<ol>
  <li> The 1st principle is observed in that each class has its own single clear role that it fulfills. </li>
  <li> The 2nd principle is met, since the code is made in such a way that if new functions and capabilities are added, there is no need to rewrite the existing part of the code (by using interfaces). </li>
  <li> The 3rd principle is observed, since all inherited classes can replace the parent class. (Example: Driver.cs and Client.cs inherit from Person.cs) </li>
  <li> The 4th principle is observed due to the fact that all interfaces are clearly separated and fully implemented. There are no interfaces that force a class to implement functionality it does not need. </li>
  <li> The 5th principle is observed, since large and important elements do not depend on small and unimportant details and things. </li>
</ol>
