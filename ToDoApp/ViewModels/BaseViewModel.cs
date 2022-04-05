using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToDoApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private Brush _mainColor = (Brush)new BrushConverter().ConvertFrom("#D3D3D3");

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }

        public Brush Color
        {
            get { return _mainColor; }
            set 
            { 
                _mainColor = value; 
                OnPropertyChanged(nameof(Color));
            }
        }
    }
}
