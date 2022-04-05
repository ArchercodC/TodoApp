using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class CompletedViewModel : BaseViewModel
    {
        private ObservableCollection<TodoItemViewModel> _todoItems;

        public IEnumerable<TodoItemViewModel> TodoItems
        {
            get { return _todoItems.Where(x => x.IsCompleted); }
            set
            {
                _todoItems = (ObservableCollection<TodoItemViewModel>)value;
                foreach (var item in value)
                {
                    item.PropertyChanged += OnListPropertyChanged;
                }
                OnPropertyChanged(nameof(TodoItems));
            }
        }
        public void OnListPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (sender is TodoItemViewModel)
            {
                if (args.PropertyName == nameof(TodoItemViewModel.IsCompleted))
                {
                    OnPropertyChanged(nameof(TodoItems));
                }
            }
        }
        public CompletedViewModel(TodoListModel todoList)
        {
            _todoItems = new ObservableCollection<TodoItemViewModel>();

            InitializeView(todoList);
        }

        public void InitializeView(TodoListModel todoList)
        {

            foreach (var item in todoList.GetList())
            {
                var todoitem = new TodoItemViewModel(item);
                todoitem.PropertyChanged += OnListPropertyChanged;
                _todoItems.Add(todoitem);
            }
        }
    }
}
