# Animal Feeding Program

This is a simple C# program that simulates the feeding of animals, specifically squirrels. It includes a parent class Animal, a derived class Squirrel, and a test program TestAnimal to demonstrate their functionality.


Overview

The program defines two classes, Animal and Squirrel, which are used to calculate the food consumption of squirrels over a given time period. The code is designed to be extensible to other animals with minor modifications.


Classes


Animal (Parent Class)

    public abstract double GetFoodConsumption(double time): An abstract method that calculates the food consumption for an animal given a time period.

    public double GetTotalFoodConsumption(double time, int count): A method that calculates the total food consumption for a group of animals based on the individual food consumption rate and count.

Squirrel (Derived Class)

    private const double FoodConsumptionRate: A constant representing the food consumption rate for squirrels.

    public override double GetFoodConsumption(double time): An overridden method to calculate food consumption for squirrels based on the time provided.
