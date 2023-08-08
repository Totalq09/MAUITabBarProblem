using TabBarProblem.ViewModels;

namespace TabBarProblem.Views;

public partial class EmptyPage : ContentPage
{
	public EmptyPage(EmptyPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}