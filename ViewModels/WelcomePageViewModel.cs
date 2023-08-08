using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TabBarProblem.Infrastructure;

namespace TabBarProblem.ViewModels
{
    public partial class WelcomePageViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task NavigateToHomePageWithTabs()
        {
            await Shell.Current.GoToAsync($"//{Routes.MainPageWithTabs}", false);
        }
    }
}
