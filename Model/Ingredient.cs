/*
  ____  _                _____ _                
 |  _ \(_)__________ _  |_   _(_)_ __ ___   ___ 
 | |_) | |_  /_  / _` |   | | | | '_ ` _ \ / _ \
 |  __/| |/ / / / (_| |   | | | | | | | | |  __/
 |_|   |_/___/___\__,_|   |_| |_|_| |_| |_|\___|
                        © Copyright 2021                      
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.Model
{
    public class Ingredient {
        public static Dictionary<string, double> Ingredients = new Dictionary<string, double>() {
            { "Dough", 2.50},
            { "Base", 2.00},
            { "Tomato", 3.20},
            { "Cheese", 3.00},
            { "Onion", 2.00},
            { "Olive", 3.40},
            { "Pineapple", 110.01 }, // Pineapple doesn't go on pizza but we make money from it
            { "tofu", 4.00}, // Tofu doesn''t go on pizza 
            { "Mandarin", 5.00 },
            { "Satay Sauce", 5.00},
            { "Chicken", 5.00}
        };

        public string IngredientName { get; }

        public Ingredient(string ingredient)
        {
            IngredientName = ingredient;
        }

        public static double GetPrice(string ingredientName)
        {
            foreach (var ingredient in Ingredients) {
                if (ingredient.Key == ingredientName) {
                    return ingredient.Value;
                }
            }

            return 0.0;
        }
    }
}
