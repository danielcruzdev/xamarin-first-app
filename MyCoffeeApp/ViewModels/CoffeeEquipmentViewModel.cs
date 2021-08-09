using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<string> Coffee { get; set; }

        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Coffee = new ObservableRangeCollection<string>();
            Title = "Coffee Equipment";
        }

        int count = 0;
        string countDisplay = "Click Me!";
        public ICommand IncreaseCount { get; }
        public ICommand CallServerCommand { get; }

        async Task CallServer()
        {
            var items = new List<string> { "Yes, please!", "No, thanks!", "No! I Hate Coffee" };
            Coffee.AddRange(items);
        }

        void OnIncrease(object obj)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
