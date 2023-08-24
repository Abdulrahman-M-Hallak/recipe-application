﻿namespace RecipeApplication.Models.ViewModels;

public class RecipeDetailsVM
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Method { get; set; } = string.Empty;
    public string TimeToCook { get; set; } = string.Empty;
    public IEnumerable<Ingredient> Ingredients { get; set; } = default!;
}
