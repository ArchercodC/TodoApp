using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Commands;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class NewTodoViewModel : BaseViewModel
    {
        private string _title;
        private DateTime _dueDate = DateTime.Now;

        private static int Count = 0;

        public int Id => Count++;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                _dueDate = value;
                OnPropertyChanged(nameof(DueDate));
            }
        } 

        public ICommand AddItemCommand { get; }

        public NewTodoViewModel(TodoListModel todoList)
        {
            AddItemCommand = new AddTodoCommand(this, todoList);
        }
    }
}
