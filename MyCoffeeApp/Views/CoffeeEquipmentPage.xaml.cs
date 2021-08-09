using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        int count = 0;
        string countDisplay = "Click Me!";
        public ICommand IncreaseCount { get; }
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;

                countDisplay = value;
                OnPropertyChanged();
            }
        }

        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            IncreaseCount = new Command(OnIncrease);
            BindingContext = this;
        }

        void OnIncrease(object obj)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}