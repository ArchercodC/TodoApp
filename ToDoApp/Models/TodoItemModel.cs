using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TodoItemModel
    {
        public int Id { get; }

        public string Title { get; }

        public DateTime DueDate { get; }

        public bool IsCompleted { get; set; }

        public TodoItemModel(int id, string title, DateTime dueDate, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }
    }
}
