using Bogus;
using CreazioneFatture.Backend.MVVM.Models;
using CreazioneFatture.Ui.Page;
using System.Windows.Input;

namespace CreazioneFatture.Ui.ViewModes
{
    public class MainViewModel
    {
        public List<TAB_Clienti> Clienti { get; set; } 
        public TAB_Clienti? CurrentCliente { get; set; }
        public ICommand AddOrUpdateCommand { get; set; }

        public MainViewModel()
        {
            CreaNuovoCliente();
            AddOrUpdateCommand = new Command(async () =>
            {
                CreaNuovoCliente();
                
                App.CustomerRepo.AddOrUpdate(CurrentCliente);
                App.Current.MainPage.Navigation.PushAsync(new Vista_Clienti());
                Console.WriteLine(App.CustomerRepo.StatusMessage);
            });

        }

        private void CreaNuovoCliente()
        {
            CurrentCliente = new Faker<TAB_Clienti>()
                .RuleFor(c => c.CL_Nome, f => f.Name.FirstName())
                .RuleFor(c => c.CL_Cognome, f => f.Name.LastName())
                .RuleFor(c => c.CL_PIva, f => f.Random.Number(-2147483648, 2147483647))
                .RuleFor(c => c.CL_Cell1, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.CL_Cell2, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.CL_Mail1, f => f.Internet.Email())
                .RuleFor(c => c.CL_Mail2, f => f.Internet.Email())
                .RuleFor(c => c.CL_Pec, f => f.Internet.Email())
                .Generate();
        }
    }
}
