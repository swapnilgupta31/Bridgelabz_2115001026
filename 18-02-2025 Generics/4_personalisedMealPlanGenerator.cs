
using System;
using System.Collections.Generic;

// Interface for meal plans
interface IMealPlan {
    string GetMealType();
}

// Vegetarian meal
class VegetarianMeal : IMealPlan {
    public string GetMealType() { return "Vegetarian Meal"; }
}

// Vegan meal
class VeganMeal : IMealPlan {
    public string GetMealType() { return "Vegan Meal"; }
}

// Generic Meal class
class Meal<T> where T : IMealPlan {
    private List<T> meals = new List<T>();

    public void AddMeal(T meal) {
        meals.Add(meal);
    }

    public void DisplayMeals() {
        foreach (T meal in meals) {
            Console.WriteLine("Meal Type: " + meal.GetMealType());
        }
    }
}

// Test the meal generator
class Program {
    static void Main() {
        Meal<VegetarianMeal> vegetarianMealPlan = new Meal<VegetarianMeal>();
        vegetarianMealPlan.AddMeal(new VegetarianMeal());

        Meal<VeganMeal> veganMealPlan = new Meal<VeganMeal>();
        veganMealPlan.AddMeal(new VeganMeal());

        Console.WriteLine("Vegetarian Meal Plan:");
        vegetarianMealPlan.DisplayMeals();

        Console.WriteLine("\nVegan Meal Plan:");
        veganMealPlan.DisplayMeals();
    }
}

