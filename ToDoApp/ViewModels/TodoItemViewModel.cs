using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class TodoItemViewModel : BaseViewModel
    {
        private readonly TodoItemModel _todoItem;

        public string Id => _todoItem.Id.ToString();

        public string Title => _todoItem.Title;

        public string DueDate => _todoItem.DueDate.ToString("d");

        public Brush TextColor => DateTime.Now > _todoItem.DueDate ? (Brush)new BrushConverter().ConvertFrom("#FFA500") : (Brush)new BrushConverter().ConvertFrom("#000000");

        public bool IsCompleted
        {
            get { return _todoItem.IsCompleted; }
            set 
            { 
                _todoItem.IsCompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }

        public TodoItemViewModel(TodoItemModel todoItem)
        {
            _todoItem = todoItem;
        }
    }
}
