using System.Collections.ObjectModel;
using System;
using System.Windows.Input;
using WPF_MVVM_.Model;

namespace WPF_MVVM_.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _products;
        private int _selectedAction;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }
        private string _yearDay;
        public string YearDay
        {
            get => _yearDay;
            set => SetProperty(ref _yearDay, value);
        }
        private string _serial;
        public string Serial
        {
            get => _serial;
            set => SetProperty(ref _serial, value);
        }
        public ICommand LoadData1Command { get; }
        public ICommand LoadData2Command { get; }
        public ICommand LoadData3Command { get; }
        public ICommand OpenProductsWindowCommand { get; }
        public ICommand ExecuteActionCommand { get; }
        public string commandName;
        private ObservableCollection<Model.Product> _Product;

        public ObservableCollection<Model.Product> Product { get => _Product; set { _Product = value; OnPropertyChanged(); } }
        public ProductViewModel()
        {
            ExecuteActionCommand = new RelayCommand<string>(_ => ExecuteAction());
            OpenProductsWindowCommand = new RelayCommand<string>(OpenProductsWindow1);
            Product = new ObservableCollection<Model.Product>(DataProvider.Ins.DB.Products);
            Products = new ObservableCollection<Product>();
            commandName = Mediator.Instance.SelectedAction;
            LoadData();
        }
        private void LoadData()
        {
            switch (commandName)
            {
                case "LoadData1":
                    LoadData1();
                    break;
                case "LoadData2":
                    LoadData2();
                    break;
                case "LoadData3":
                    LoadData3();
                    break;
            }
        }
        public void ExecuteAction()
        {
            switch (commandName)
            {
                case "LoadData1":
                    Func1();
                    break;
                case "LoadData2":
                    Func2();
                    break;
                case "LoadData3":
                    Func3();
                    break;
            }
        }
        private void LoadData1()
        {
            Products.Clear();
            foreach (var item in Product)
            {
                Products.Add(item);
            }
            YearDay = DateTime.Now.ToString("yyMMdd");
            Serial = "465";
        }
        private void LoadData2()
        {
            Products.Clear();
            Products.Add(new Product { Id = 2, Name = "Product 2" });
            YearDay = DateTime.Now.ToString("yyMMdd");
            Serial = "465";
        }

        private void LoadData3()
        {
            Products.Clear();
            Products.Add(new Product { Id = 3, Name = "Product 3" });
            YearDay = DateTime.Now.ToString("yyMMdd");
            Serial = "465";
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

        private void OpenProductsWindow1(object parameter)
        {
            if (parameter is string commandName)
            {
                switch (commandName)
                {
                    case "ExecuteActionCommand":
                        ExecuteAction();
                        break;
                    case "SendDataCommand":
                        ExecuteAction();
                        break;
                }
            }
        }
    }
}
