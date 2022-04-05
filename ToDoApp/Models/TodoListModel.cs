using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TodoListModel
    {
        private readonly List<TodoItemModel> _todoItems;

        public TodoListModel(DispatcherTimer timer)
        {
            _todoItems = new List<TodoItemModel>();
        }

        public IEnumerable<TodoItemModel> GetList()
        {
            return _todoItems;
        }

        public void AddItem(TodoItemModel item)
        {
            _todoItems.Add(item);
        }
    }
}
