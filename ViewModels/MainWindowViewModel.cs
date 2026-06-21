using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.Views;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [RelayCommand]
    private void OpenUserView()
    {
        var window = new UserView();
        window.DataContext = new UserViewModel();
        window.Show();
    }

    [RelayCommand]
    private void OpenMealView()
    {
        var window = new MealView();
        window.DataContext = new MealViewModel();
        window.Show();
    }

    [RelayCommand]
    private void OpenDashboardView()
    {
        var window = new DashboardView();
        window.DataContext = new DashboardViewModel();
        window.Show();
    }

    [RelayCommand]
    private void OpenWeightView()
    {
        var window = new WeightView();
        window.DataContext = new WeightViewModel();
        window.Show();
    }
}