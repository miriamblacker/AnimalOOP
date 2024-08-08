
### `README.md`

```markdown
# Animal Simulation in C#

This project is a simulation of various animals and their behaviors using Object-Oriented Programming (OOP) principles in C#. The project defines an abstract base class `Animal` and several concrete subclasses like `Dog`, `Cat`, and `Frog`. Each subclass implements specific behaviors typical for the corresponding animal, including responses based on different moods. The project also includes interfaces for land and water animals.

## Table of Contents

- [Introduction](#introduction)
- [Project Structure](#project-structure)
- [Classes Overview](#classes-overview)
- [Interfaces](#interfaces)
- [UML Diagram](#uml-diagram)
- [How to Run](#how-to-run)
- [Example Output](#example-output)
- [License](#license)

## Introduction

This program demonstrates the use of abstract classes, inheritance, and interfaces in C#. It includes three animal subclasses (`Dog`, `Cat`, `Frog`) that inherit from the abstract class `Animal`. Each animal can greet, react when comfortable, and react when frightened. The `Dog` and `Cat` classes implement the `ILand` interface, while the `Frog` class implements both the `ILand` and `IWater` interfaces.

## Project Structure

```plaintext
AnimalVeriSoft/
│
├── Animal.cs        # Defines the abstract Animal class
├── IWater.cs        # Interface for animals living in water
├── ILand.cs         # Interface for animals living on land
├── Frog.cs          # Defines the Frog class
├── Cat.cs           # Defines the Cat class
├── Dog.cs           # Defines the Dog class
└── Program.cs       # Main program that initializes and tests the animals
```

## Classes Overview

### `Animal` (Abstract Class)
- **Properties:**
  - `mammals`: Indicates whether the animal is a mammal.
  - `carnivorous`: Indicates whether the animal is carnivorous.
  - `mood`: Represents the mood of the animal (`MOOD_HAPPY` or `MOOD_SCARE`).
- **Methods:**
  - `IsMammal()`: Returns whether the animal is a mammal.
  - `IsCarnivorous()`: Returns whether the animal is carnivorous.
  - `SayHello()`: Prints a default greeting.
  - `SayHello(int mood)`: Abstract method that subclasses implement to greet based on mood.

### `Dog` (Subclass of `Animal`, Implements `ILand`)
- **Properties:**
  - `numberOfLegs`: The number of legs the dog has.
- **Methods:**
  - `SayHello()`: Displays different messages based on the dog's mood (e.g., "bark loudly" when happy).
  - `GetNumberOfLegs()`: Returns the number of legs.

### `Cat` (Subclass of `Animal`, Implements `ILand`)
- **Properties:**
  - `numberOfLegs`: The number of legs the cat has.
- **Methods:**
  - `SayHello()`: Displays different messages based on the cat's mood (e.g., "purr, purr" when happy).
  - `GetNumberOfLegs()`: Returns the number of legs.

### `Frog` (Subclass of `Animal`, Implements `ILand`, `IWater`)
- **Properties:**
  - `numberOfLegs`: The number of legs the frog has.
- **Methods:**
  - `SayHello()`: Displays different messages based on the frog's mood (e.g., "quack quack quack" when happy).
  - `GetNumberOfLegs()`: Returns the number of legs.
  - `HasGills()`: Returns whether the frog has gills.
  - `HasLaysEggs()`: Returns whether the frog lays eggs.

## Interfaces

### `ILand`
- **Methods:**
  - `GetNumberOfLegs()`: Returns the number of legs of the animal.

### `IWater`
- **Methods:**
  - `HasGills()`: Returns whether the animal has gills.
  - `HasLaysEggs()`: Returns whether the animal lays eggs.

## UML Diagram

Here's the updated UML diagram representing the structure of the project, including the interfaces, subclasses, and their relationships:

```plaintext
             +------------------------+
             |        Animal           | 
             |------------------------|
             | - mammals: bool         |
             | - carnivorous: bool     |
             | - mood: int             |
             |------------------------|
             | + SayHello()            |
             | + SayHello(int)         |
             | + IsMammal(): bool      |
             | + IsCarnivorous(): bool |
             +--------+---------------+
                      |
            +---------+----------------+
            |                          |
      +-----+--------+          +------+---------+
      |    Dog       |          |    Cat         |
      |--------------|          |---------------|
      | + GetNumberOfLegs(): int| + GetNumberOfLegs(): int|
      | + SayHello()            | + SayHello()            |
      +--------------+          +---------------+
                      |
                 +-----+--------+
                 |    Frog      |
                 |--------------|
                 | + GetNumberOfLegs(): int |
                 | + HasGills(): bool       |
                 | + HasLaysEggs(): bool    |
                 | + SayHello()             |
                 +--------------+
                       ^
                       |
              +--------+-------+
              |     ILand      |
              |----------------|
              | + GetNumberOfLegs(): int |
              +----------------+

              +----------------+
              |     IWater     |
              |----------------|
              | + HasGills(): bool       |
              | + HasLaysEggs(): bool    |
              +----------------+
```

### Explanation:

- **Animal** is the abstract base class, inherited by **Dog**, **Cat**, and **Frog**.
- **Dog** and **Cat** implement the `ILand` interface, indicating they are land animals with legs.
- **Frog** implements both `ILand` and `IWater`, as it can live both on land and in water.
- Mood states (`MOOD_HAPPY`, `MOOD_SCARE`) are implemented in each subclass to handle specific behavior based on the animal's mood.

## How to Run

1. **Clone the repository:**

    ```bash
    git clone https://github.com/miriamblacker/AnimalOOP.git
    cd AnimalOOP
    ```

2. **Build the project:**

    If you have the .NET SDK installed, run:

    ```bash
    dotnet build
    ```

3. **Run the project:**

    Execute the program with:

    ```bash
    dotnet run
    ```

## Example Output

When you run the program, it will initialize an array of animals (`Dog`, `Cat`, `Frog`) and test their behaviors:

```plaintext
wagging the tail
whooping
bark loudly
Mammal: True
Carnivorous: True
Hi, I'm a dog &:
Number of my legs: 4
-----------
meow~
hiss
purr, purr
Mammal: True
Carnivorous: True
Hi, I'm a cat &:
Number of my legs: 4
-----------
quack quack quack
plop into the water
Mammal: False
Carnivorous: False
Hi, I'm a frog &:
Number of my legs: 4
Gills: False
Lays eggs: True
-----------
```

