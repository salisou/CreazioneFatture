using CreazioneFatture.Ui.Page;

namespace CreazioneFatture.Ui
{
    public partial class App : Application
    {
        public static CustomerRepository? CustomerRepo {  get; private set; }
        public App(CustomerRepository repo)
        {
            InitializeComponent();

            CustomerRepo = repo;
            MainPage = new NavigationPage (new MainPage());
            //MainPage = new AppShell();
        }
    }
}
