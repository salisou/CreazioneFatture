using CreazioneFatture.Ui.ViewModes;

namespace CreazioneFatture.Ui.Page;

public partial class Vista_Clienti : ContentPage
{
	public Vista_Clienti()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

    }
}