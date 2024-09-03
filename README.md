# Individual_Project

## 1. Overview of the Code

This project is a simple implementation of the Strategy design pattern in C#. It features two types of characters, `Warrior` and `Archer`, that can perform different movement and attack behaviors. The behaviors are encapsulated in interfaces, allowing the characters to change their behavior dynamically at runtime.

## 2. Design of the Code

The project uses the Strategy design pattern to define and switch between different movement and attack behaviors. The core components are:

- **Character (Abstract Class)**: The base class for all characters, containing references to movement and attack patterns.
- **IMovePattern (Interface)**: Defines a method `Move()` for movement behaviors.
- **IAttackPattern (Interface)**: Defines a method `Attack()` for attack behaviors.
- **Walk and Run (Classes)**: Implement the `IMovePattern` interface, representing different movement styles.
- **MeleeAttack and RangedAttack (Classes)**: Implement the `IAttackPattern` interface, representing different attack styles.
- **Warrior and Archer (Classes)**: Concrete implementations of `Character`, initialized with specific movement and attack patterns.

## 3. Class Diagram

![image](https://github.com/user-attachments/assets/6a0dc179-9b48-49b1-938c-5ca4587f0f3b)

## 4. Environment

- **Programming Language Used**: C#
- **IDE**: Microsoft Visual Studio 2022
- **.NET Framework**: .NET 8.0

## 5. References
 ![Readme File]{https://github.com/chittur/observer-pattern-demo}
 ![Bridge Design Pattern]{https://www.geeksforgeeks.org/bridge-design-pattern/}
 ![Code Idea]{https://refactoring.guru/design-patterns/bridge}
 ![UML diagram]{https://www.plantuml.com/plantuml/uml/fLDVQy8m47_FfpXyKZRz0394tM3iGHZ2sFEjEJMOf9ASCfZxxajBMPjRsN3sfUJw-_ExotKU6GCVdLLis18iWz5RWWUAPklX6PafUDYK0HxH4TplC62HQb4fuzDxWmN1qweyqP9sU389-A4WFJVWKd4uciAfD5fzPlW5CnRx7moiorrEOJ56U4Mx1-CEbXnvZh_x2UxwwFzBNP4bggDcxfUcNwFVahv61zyYLsE7Mh2zX8Po22LJEclHdUiS151wOtPKJP9les4cV2lfexun_dMb8LJ6zCxajUpfGh55A7PqjLPB6uzdOfHJ6Bn4YWC14dDeOKrx2NIUjNbK4rHKSwkxysHIRtnVFMspagRrXywkzWAoBLHgJbvNFxtw0W00}
