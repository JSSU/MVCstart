using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6.Models
{
    public class ITodoRepository
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem> GetAll();
        public TodoItem Find(string key);
        public TodoItem Remove(string key);
        public void Update(TodoItem item);
    }
}
