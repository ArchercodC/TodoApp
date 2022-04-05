using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.IServices
{
    public interface IFileService
    {
        Task ExportData(string filePath, TodoListModel list);
    }
}
