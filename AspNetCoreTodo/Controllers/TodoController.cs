using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        public async Task<IActionResult> Index()
        {
            // Obtener las tareas desde la base de datos
            var items = await _todoItemService.GetIncompleteItemsAsync();
            // Colocar los tareas en un modelo
            var model = new TodoViewModel()
            {
                Items = items
            };
            // Genera la vista usando el modelo
            return View(model);
        }
    }
}
