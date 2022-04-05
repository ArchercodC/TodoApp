using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToDoApp.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public Brush Color => IsEnabled ? (Brush)new BrushConverter().ConvertFrom("#00008b") : (Brush)new BrushConverter().ConvertFrom("#D3D3D3");

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
                OnPropertyChanged(nameof(Color));
            }
        }

    }
}
