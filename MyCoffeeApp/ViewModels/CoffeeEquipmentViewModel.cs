using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; set; }
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public CoffeeEquipmentViewModel()
        {
            Coffee = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();
            Title = "Coffee Equipment";

            var image = "https://www.graogourmet.com/wp-content/uploads/2016/07/bulletproof-coffee-cafe-com-mct-manteiga-ghee-190718-1280x720.jpg";

            Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Sip of sunshine", Image = image });
            Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Potent Portable", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu", Image = image });

            CoffeeGroups.Add(new Grouping<string, Coffee>("Blue Bottle", Coffee.Where(c => c.Roaster == "Blue Bottle")));
            CoffeeGroups.Add(new Grouping<string, Coffee>("Yes Plz", Coffee.Where(c => c.Roaster == "Yes Plz")));
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            IsBusy = false;
        }
    }
}