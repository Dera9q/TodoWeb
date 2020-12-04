using System;
namespace Todoweb.data.Entities
{
    public class Todolist : BaseEntity
    {
        public string Title {get; set;} //what to do
        public DateTime DueDate {get; set;} //expected execusion time
        public string Status {get; set;} // completed or uncompleted
    }
}