using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.Database;
using System.Collections.ObjectModel;

namespace AvaloniaApplication1.ViewModels;

public partial class MealViewModel : ViewModelBase
{
    public ObservableCollection<Meal> Meals { get; } = new();

    private void LoadMeals()
{
    using var db = new NutritionDbContext();

    Meals.Clear();

    foreach (var meal in db.Meals)
    {
        Meals.Add(meal);
    }
}

    [ObservableProperty]
    private string mealName = "";

    [ObservableProperty]
    private string calories = "";

    [ObservableProperty]
    private string protein = "";

    [ObservableProperty]
    private string carbs = "";

    [ObservableProperty]
    private string fat = "";

    [ObservableProperty]
    private string statusMessage = "";

    [RelayCommand]
private void DeleteMeal(Meal meal)
{
    using var db = new NutritionDbContext();

    db.Meals.Remove(meal);
    db.SaveChanges();

    LoadMeals();
}

    [RelayCommand]
    private void SaveMeal()
    {
        try
        {
            using var db = new NutritionDbContext();

            var meal = new Meal
            {
                Name = MealName,
                Calories = int.Parse(Calories),
                Protein = double.Parse(Protein),
                Carbs = double.Parse(Carbs),
                Fat = double.Parse(Fat),
                Date = DateTime.Now
            };

            db.Meals.Add(meal);
            db.SaveChanges();
            LoadMeals();

            StatusMessage = "Meal saved!";
        }
        catch (Exception ex)
        {
            StatusMessage = ex.Message;
        }
    }
    public MealViewModel()
{
    LoadMeals();
}
}