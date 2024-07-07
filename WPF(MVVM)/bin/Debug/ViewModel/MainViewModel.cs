using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_MVVM_.Model;

namespace WPF_MVVM_.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand OpenProductsWindowCommand { get; }
        //private ObservableCollection<Model.Product> _Product;

        //public ObservableCollection<Model.Product> Product { get => _Product; set { _Product = value; OnPropertyChanged(); } }
        public MainViewModel()
        {
            OpenProductsWindowCommand = new RelayCommand<string>(OpenProductsWindow);
            //Product = new ObservableCollection<Model.Product>(DataProvider.Ins.DB.Products);
        }

        private void OpenProductsWindow(string commandName)
        {
            Mediator.Instance.SelectedAction  = commandName;
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.Show();
        }
    }
}
