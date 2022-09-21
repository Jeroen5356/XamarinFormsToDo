using System;

namespace ToDo.Models
{
    public class ToDoModel
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public bool IsDone { get; set; }
    }
}
