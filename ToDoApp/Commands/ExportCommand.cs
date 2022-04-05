using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using System.IO;
using ToDoApp.Services;

namespace ToDoApp.Commands
{
    public class ExportCommand : AsyncBaseCommand
    {
        private const string EXPORT_FILE_PATH = "C:/Users/1/source/repos/ToDoApp/ToDoApp/Downloads/ExportFile.txt";
        private readonly TodoListModel _list;
        private readonly FileService _fileService;

        public ExportCommand(TodoListModel todoList)
        {
            _list = todoList;
            _fileService = new FileService();
        }

        public override async Task ExecuteAsync()
        {
            await _fileService.ExportData(EXPORT_FILE_PATH, _list);
        }
    }
}
