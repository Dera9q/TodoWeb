using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoWeb.web.Interfaces;
using TodoWeb.web.Models;
using TodoWeb.web.Services;

namespace TodoWeb.web.Controllers
{
    public class TodolistController : Controller
    {
       private readonly ITodolistService _todolistService;
        public TodolistController(ITodolistService todolistService)
        {
            _todolistService = todolistService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var todolist = _todolistService.GetAllTodolist();
            return View(todolist);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TodolistModel model)
        {
            try
            {
                await _todolistService.AddTodolist(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}