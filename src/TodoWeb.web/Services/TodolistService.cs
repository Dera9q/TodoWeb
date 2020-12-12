using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todoweb.data.DatabaseContext;
using Todoweb.data.Entities;
using TodoWeb.web.Interfaces;
using TodoWeb.web.Models;

namespace TodoWeb.web.Services
{
    public class TodolistService : ITodolistService
    {
         private readonly ApplicationDbContext _dbContext;

        public TodolistService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Todolist> GetTodolist()
        {
            return _dbContext.Todolist;
            
        }
        public async Task AddTodolist(TodolistModel model)
        {
            var todolist = new Todolist
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                DueDate = model.DueDate,
                Status = model.Status
            };

            await _dbContext.AddAsync(todolist);
            await _dbContext.SaveChangesAsync();
        }
    }
}