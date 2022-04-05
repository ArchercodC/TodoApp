using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.ViewModels;

namespace ToDoApp.Commands
{
    public class AddTodoCommand : BaseCommand
    {
        private readonly TodoListModel _list;
        private readonly NewTodoViewModel _newTodo;

        public AddTodoCommand(NewTodoViewModel newTodo, TodoListModel list)
        {
            _list = list;
            _newTodo = newTodo;
        }

        public override void Execute(object? parameter)
        {
            TodoItemModel item = new(
                _newTodo.Id,
                _newTodo.Title,
                _newTodo.DueDate
                );

            _list.AddItem(item);
        }
    }
}
