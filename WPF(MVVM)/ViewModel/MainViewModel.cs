using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_MVVM_.Model;

namespace WPF_MVVM_.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _products;
        private readonly IWindowService _windowService;
        private int _selectedAction;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public ICommand LoadData1Command { get; }
        public ICommand LoadData2Command { get; }
        public ICommand LoadData3Command { get; }
        public ICommand OpenProductsWindowCommand { get; }
        public ICommand ExecuteActionCommand { get; }

        public MainViewModel(IWindowService windowService)
        {
            _windowService = windowService;

            LoadData1Command = new RelayCommand(_ => LoadData1());
            LoadData2Command = new RelayCommand(_ => LoadData2());
            LoadData3Command = new RelayCommand(_ => LoadData3());
            OpenProductsWindowCommand = new RelayCommand(OpenProductsWindow);
            ExecuteActionCommand = new RelayCommand(_ => ExecuteAction());

            Products = new ObservableCollection<Product>();
        }

        private void LoadData1()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 1, Name = "Product A1" },
                new Product { Id = 2, Name = "Product A2" }
            };
        }

        private void LoadData2()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 3, Name = "Product B1" },
                new Product { Id = 4, Name = "Product B2" }
            };
        }

        private void LoadData3()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 5, Name = "Product C1" },
                new Product { Id = 6, Name = "Product C2" }
            };
        }

        private void OpenProductsWindow(object parameter)
        {
            if (parameter is string commandName)
            {
                switch (commandName)
                {
                    case "LoadData1":
                        _selectedAction = 1;
                        LoadData1();
                        break;
                    case "LoadData2":
                        _selectedAction = 2;
                        LoadData2();
                        break;
                    case "LoadData3":
                        _selectedAction = 3;
                        LoadData3();
                        break;
                }
            }

            _windowService.OpenProductsWindow(this);
        }

        private void ExecuteAction()
        {
            switch (_selectedAction)
            {
                case 1:
                    Func1();
                    break;
                case 2:
                    Func2();
                    break;
                case 3:
                    Func3();
                    break;
            }
        }

        private void Func1()
        {
            System.Windows.MessageBox.Show("Function 1 executed!");
        }

        private void Func2()
        {
            System.Windows.MessageBox.Show("Function 2 executed!");
        }

        private void Func3()
        {
            System.Windows.MessageBox.Show("Function 3 executed!");
        }
    }
}
