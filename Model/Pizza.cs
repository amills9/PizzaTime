using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaTime.Model;

namespace PizzaTime.Model
{
    public class Pizza
    {
        public List<Ingredient> Ingredients { get; }

        public Pizza(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public string IngredientsToCSV() {
            string tmp = "";

            foreach(Ingredient ingredient in Ingredients) {
                tmp += $"{ingredient.IngredientName},";
            }

            return tmp;
        }
    }
}
