using CreazioneFatture.Ui.ViewModes;

namespace CreazioneFatture.Ui.Page;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}