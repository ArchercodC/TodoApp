using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using ToDoApp.IServices;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class FileService : IFileService
    {
        public async Task ExportData(string filePath, TodoListModel list)
{

            using StreamWriter file = new(filePath);
            foreach (var item in list.GetList())
            {
                await file.WriteAsync($"{item.Title},{item.DueDate:d},{(item.IsCompleted ? "Completed" : "Incompleted")}\n");
            }
        }
    }
}
