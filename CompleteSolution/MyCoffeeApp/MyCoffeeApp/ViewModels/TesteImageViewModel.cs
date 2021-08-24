using Xamarin.Forms;

namespace MyCoffeeApp.ViewModels
{
    [QueryProperty(nameof(ImageOfCoffe), nameof(ImageOfCoffe))]
    public class TesteImageViewModel : ViewModelBase
    {
        private string imageOfCoffe;

        public string ImageOfCoffe
        {
            get => imageOfCoffe;
            set => SetProperty(ref imageOfCoffe, value);
        }
    }
}
