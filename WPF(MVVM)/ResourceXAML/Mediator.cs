using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_.ViewModel
{
    public class Mediator
    {
        public static Mediator Instance { get; } = new Mediator();

        private string _selectedAction;

        public string SelectedAction
        {
            get => _selectedAction;
            set
            {
                _selectedAction = value;
            }
        }
    }
}
