using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TabBarProblem.Infrastructure;

namespace TabBarProblem.ViewModels
{
    public partial class EmptyPageViewModel : ObservableObject
    {
        [RelayCommand]
        public void ToggleTheme()
        {
            Application.Current.UserAppTheme = Application.Current.RequestedTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
        }

        [RelayCommand]
        public async Task GoToWelcomePage()
        {
            await Shell.Current.GoToAsync($"//{Routes.WelcomePage}", false);
        }
    }
}
