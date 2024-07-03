using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_.ViewModel;

namespace WPF_MVVM_
{
    public interface IWindowService
    {
        void OpenProductsWindow(MainViewModel viewModel);
    }
}
