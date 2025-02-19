# ESCAPE

A time-based puzzle game built with C# in Visual Studio, challenging players to crack codes under pressure.

## Overview

"ESCAPE" is an engaging puzzle game that tests players' agility, attention, and deductive reasoning. Players must decode and input the correct sequence within a time limit, with increasing difficulty as they progress through levels.

Try the original inspiration here: [Math Playground - 40x Escape](https://www.mathplayground.com/logic_40x_escape.html)

## Game Features

- Time-based puzzle solving
- Progressive difficulty system
- Dynamic code sequences
- Visual progress indicators
- Multiple difficulty levels
- Real-time feedback system

## Project Structure

```
ESCAPE/
├── Tests settings/
├── Game/
│   ├── Properties/
│   ├── References/
│   ├── Resources/
│   ├── Code/
│   └── Tests/
```

## Technical Implementation

The project demonstrates several design patterns to create a robust and maintainable codebase:

### Builder Pattern
- Manages the construction of complex objects step by step
- Implements three main components:
  - Director: Controls object construction
  - Builder: Declares construction functions
  - EscapeImageBuild: Handles actual object construction
- Used for creating dynamic "ESCAPE" text elements with progress visualization

### Decorator Pattern
- Enables dynamic behavior modification
- Implements background customization
- Core components:
  - Decorator: Main wrapper class
  - BackgroundDecorator: Handles random background color assignment

### Factory Method Pattern
- Creates different difficulty categories
- Manages button labeling for difficulty selection
- Optimizes object creation through inheritance

### Observer Pattern
- Implements real-time game state updates
- Components:
  - Observer: Manages update calls
  - ConcreteObserver: Handles text updates based on game state
- Maintains synchronized game state across components

## Technical Details

- **Programming Language**: C#
- **Development Environment**: Visual Studio
- **Design Patterns**:
  - Builder
  - Decorator
  - Factory Method
  - Observer


## UML Diagram



## References

- [Refactoring Guru - Design Patterns](https://refactoring.guru/design-patterns)
- [DoFactory - Factory Method Pattern](https://www.dofactory.com/net/factory-method-design-pattern)
- [DoFactory - Observer Pattern](https://www.dofactory.com/net/observer-design-pattern)
- [DoFactory - Decorator Pattern](https://www.dofactory.com/net/decorator-design-pattern)
- [DoFactory - Builder Pattern](https://www.dofactory.com/net/builder-design-pattern)

## License

[License information to be added]
