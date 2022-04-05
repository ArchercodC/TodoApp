using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using ToDoApp.Commands;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        private readonly TodoListModel _todoList;

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel)); 
            }
        }

        public void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (sender is SettingsViewModel)
            {
                if (args.PropertyName == nameof(Color))
                {
                    Color = ((SettingsViewModel)sender).Color;
                }
            }
        }

        public TodoListModel TodoList => _todoList;

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel(TodoListModel todoList)
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            _todoList = todoList;
        }
    }
}
