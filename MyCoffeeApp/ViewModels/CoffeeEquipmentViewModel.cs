using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ObservableObject
    {
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

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        int count = 0;
        string countDisplay = "Click Me!";
        public ICommand IncreaseCount { get; }

        void OnIncrease(object obj)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
