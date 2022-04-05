using System;
using System.Windows.Input;
using ToDoApp.ViewModels;
using System.Linq;

namespace ToDoApp.Commands
{
    public class UpdateViewCommand : BaseCommand
    {

        private readonly MainViewModel _viewModel;
        private readonly SettingsViewModel _settingsViewModel;


        public UpdateViewCommand(MainViewModel viewModel)
        {
            this._viewModel = viewModel;
            _settingsViewModel = new SettingsViewModel();
        }

        public override void Execute(object? parameter)
        {
            switch (parameter?.ToString())
            {
                case "MyTodos":
                    _viewModel.SelectedViewModel = new MyTodosViewModel(_viewModel.TodoList) { Color = _settingsViewModel.Color };
                    break;
                case "NewTodo":
                    _viewModel.SelectedViewModel = new NewTodoViewModel(_viewModel.TodoList) { Color = _settingsViewModel.Color };
                    break;
                case "Completed":
                    _viewModel.SelectedViewModel = new CompletedViewModel(_viewModel.TodoList) { Color = _settingsViewModel.Color };
                    break;
                case "Settings":
                    _viewModel.SelectedViewModel = _settingsViewModel;
                    _viewModel.SelectedViewModel.PropertyChanged += _viewModel.OnViewModelPropertyChanged;
                    break;
                default:
                    break;
            }
        }
    }
}
