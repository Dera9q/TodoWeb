using System.Collections.Generic;
using System.Threading.Tasks;
using Todoweb.data.Entities;
using TodoWeb.web.Models;

namespace TodoWeb.web.Interfaces
{
    public interface ITodolistService
    {
         Task AddTodolist(TodolistModel model);
         IEnumerable<Todolist> GetTodolist();
    }
}