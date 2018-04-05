﻿
using RecipeServiceApi.Common.Models;
using System.Collections.Generic;

namespace RecipeServiceApi.Concrete.DataAccess
{
    /// <summary>
    /// RecipeRepository
    /// </summary>
    public interface IRecipeRepository
    {
        /// <summary>
        /// Fetch a list of all existing Recipes
        /// </summary>
        /// <returns></returns>
        IEnumerable<IRecipe> FetchRecipes();
    }
}
