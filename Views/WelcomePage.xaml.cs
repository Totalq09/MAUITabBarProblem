using TabBarProblem.ViewModels;

namespace TabBarProblem.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage(WelcomePageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }        
    }
}