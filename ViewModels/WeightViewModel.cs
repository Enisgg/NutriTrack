using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.Database;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;

public partial class WeightViewModel : ViewModelBase
{
    [ObservableProperty]
    private string currentWeight = "";

    public ObservableCollection<WeightEntry> Weights { get; } = new();

    public WeightViewModel()
    {
        LoadWeights();
    }

    [RelayCommand]
    private void SaveWeight()
    {
        using var db = new NutritionDbContext();

        db.WeightEntries.Add(new WeightEntry
        {
            Weight = double.Parse(CurrentWeight),
            Date = DateTime.Now
        });

        db.SaveChanges();

        LoadWeights();
    }

    private void LoadWeights()
    {
        using var db = new NutritionDbContext();

        Weights.Clear();

        foreach(var weight in db.WeightEntries)
        {
            Weights.Add(weight);
        }
    }
}