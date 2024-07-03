using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_.ViewModel;

namespace WPF_MVVM_
{
    public class WindowService : IWindowService
    {
        public void OpenProductsWindow(MainViewModel viewModel)
        {
            var productsWindow = new ProductsWindow(viewModel);
            productsWindow.ShowDialog();
        }
    }
}
