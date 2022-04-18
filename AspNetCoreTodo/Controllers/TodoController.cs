using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            // Obtener las tareas desde la base de datos

            // Colocar los tareas en un modelo

            // Genera la vista usando el modelo
            return Index();
        }
    }
}
