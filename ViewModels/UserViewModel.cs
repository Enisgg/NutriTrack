
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.Database;

namespace AvaloniaApplication1.ViewModels;

public partial class UserViewModel : ViewModelBase
{
    [ObservableProperty]
    private string name = "";

    [ObservableProperty]
    private string weight = "";

    [ObservableProperty]
    private string height = "";

    [ObservableProperty]
    private string sex = "";

    [ObservableProperty]
    private string goal = "";

    [ObservableProperty]
    private string statusMessage = "";

    [RelayCommand]
    private void SaveUser()
    {
        try
        {
            using var db = new NutritionDbContext();

            var user = new User
            {
                Name = Name,
                Weight = double.Parse(Weight),
                Height = double.Parse(Height),
                Sex = Sex,
                Goal = Goal
            };

            db.Users.Add(user);
            db.SaveChanges();

            StatusMessage = "User saved successfully!";
        }
      catch (Exception ex)
{
    StatusMessage = ex.ToString();
}
    }
}