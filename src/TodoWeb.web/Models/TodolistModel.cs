using System;

namespace TodoWeb.web.Models
{
    public class TodolistModel
    {
        public string Title {get; set;} //what to do
        public DateTime DueDate {get; set;} //expected execusion time
        public string Status {get; set;} // completed or uncompleted
    }
}