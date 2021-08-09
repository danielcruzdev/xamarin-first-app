using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        int count = 0;
        string countDisplay = "Click Me!";
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
            BindingContext = this;
        }

        private void ButtonClick_Clicked(object sender, System.EventArgs e)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}