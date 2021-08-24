using Xamarin.Forms;

namespace MyCoffeeApp.ViewModels
{
    [QueryProperty(nameof(NameOfCoffee), nameof(NameOfCoffee))]
    public class TesteImageViewModel : ViewModelBase
    {
        private string nameOfCoffee;

        public string NameOfCoffee
        {
            get => nameOfCoffee;
            set => SetProperty(ref nameOfCoffee, value);
        }
    }
}
