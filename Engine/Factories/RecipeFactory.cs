using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe energyPotion = new Recipe(1, "Energy Potion");
            energyPotion.AddIngredient(9001, 1);
            energyPotion.AddIngredient(3007, 1);
            energyPotion.AddOutputItem(9005, 1);
            _recipes.Add(energyPotion);
        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}
