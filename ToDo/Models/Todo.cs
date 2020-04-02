using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.WebAPI.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
    }
}
