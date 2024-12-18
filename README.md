# Test Assignment

## How to run?

Git clone the project:

`git clone https://github.com/derweisskrag/upgraded-lamp.git`

Then using `cd`, you can go to the directory:

`cd upgraded-lamp`

After, go to C# directory 

`cd src/solution_1` 

Then run

`dotnet restore`

Build the project:

`dotnet build`

And run it:

`dotnet run`

If some DB issue:

`dotnet-ef database upgrade`

> NB! Please, notice that I have migration folder, so you should run the code without this command.

### Tests

Go to 

`cd MoneyTests`

and run

`dotnet test`

All tests should pass

## Description

The most important thing to notice: I am implementing the SERVICE. Not a controller, entity; or program, but SERVICE.
It is of great essence to take this fact into account, as I can misinterpret the task and go off on a tangent.

My task is to simulate the slot machine logic (bussiness logic inside the service). It can be `SlotMachine.cs` or `Machine.cs`
- some hierarchy in OOP classes as long as everything is work. 

### Objective

The ultimate goal is to maintain the user session, their balance, history (wins/losses and statistics), as well as to ensure 
that the machine performs accurately and efficiently.


### Solution

Link: [Solution](/src/solution_1/)

Console application. No external programming languagues (C/C++ or Rust integration for performance).

I try to think outside of the box, and not overcomplicate, but make my code modular, abstract, efficient and deliver
the product to target audience. Tools: Rust for random logic, and C# for OOP, Users and State management.

There is a slight chance of the third solution. My goal is to use this current assignment task to sharpen my skills. Hence,
I will test & benchmark both solutions. 

> Integration tests won't be used. Only unittests, exploratory, and parametrized testing. Keeping things simple! I do NOT reinvent the wheel!
