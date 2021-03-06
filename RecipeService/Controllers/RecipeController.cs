﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecipeServiceApi.Common.Contract;
using RecipeServiceApi.Common.Response;

namespace RecipeService.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class RecipeController : Controller
    {
        private readonly IRecipeDataAccess _recipeDataAccess;

        public RecipeController(IRecipeDataAccess recipeDataAccess)
        {
            _recipeDataAccess = recipeDataAccess;
        }

        [HttpGet]
        public RecipeResponse Get()
        {
            return new RecipeResponse
            {
                Recipe = _recipeDataAccess.FetchRecipes()
            };
        }
    }
}
