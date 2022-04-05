using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using ToDoApp.Commands;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class MyTodosViewModel : BaseViewModel 
    {
        private readonly DispatcherTimer _dispatcherTimer;
        private ObservableCollection<TodoItemViewModel> _todoItems;
        public IEnumerable<TodoItemViewModel> TodoItems
        {
            get { return _todoItems.Where(x => !x.IsCompleted); }
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

        public void dispatcherTimer_Tick(object sender, EventArgs args)
        {
            if (sender is TodoItemViewModel)
            {
                
            }
        }

        public ICommand ExportCommand { get; }

        public MyTodosViewModel(TodoListModel todoList)
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Tick += dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            _dispatcherTimer.Start();
            _todoItems = new ObservableCollection<TodoItemViewModel>();

            InitializeView(todoList);

            ExportCommand = new ExportCommand(todoList);
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
