using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using AvaloniaApplication1.Database;
namespace AvaloniaApplication1.ViewModels;

public partial class DashboardViewModel : ViewModelBase
{
    [ObservableProperty]
    private string totalCalories = "0";

    [ObservableProperty]
    private string totalProtein = "0";

    [ObservableProperty]
    private string totalCarbs = "0";

    [ObservableProperty]
    private string totalFat = "0";

    [ObservableProperty]
private string calorieGoal = "2500";

[ObservableProperty]
private string caloriesRemaining = "0";

    public DashboardViewModel()
    {
        LoadStats();
    
    }
    

    private void LoadStats()
    {
        using var db = new NutritionDbContext();

        TotalCalories = db.Meals.Sum(m => m.Calories).ToString();
        TotalProtein = db.Meals.Sum(m => m.Protein).ToString("F1");
        TotalCarbs = db.Meals.Sum(m => m.Carbs).ToString("F1");
        TotalFat = db.Meals.Sum(m => m.Fat).ToString("F1");
        TotalCalories = db.Meals.Sum(m => m.Calories).ToString();

        int consumed = db.Meals.Sum(m => m.Calories);
        int goal = 2500;

        CalorieGoal = goal.ToString();
        CaloriesRemaining = (goal - consumed).ToString();
    }
}