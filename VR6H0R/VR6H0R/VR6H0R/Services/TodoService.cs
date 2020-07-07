using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VR6H0R.Models;

namespace VR6H0R.Services
{
    public class TodoService
    {
        public static TodoService Instance { get; } = new TodoService();
        private Dictionary<int, TodoItem> items = new Dictionary<int, TodoItem>
        {
            {0, new TodoItem{Description="Nagybevásárlást elintézni",Title="Bevásárlás",IsFinished=true } },
            {1, new TodoItem{Description="Lemenni a tóhoz és horgászni egy jót", Title="Horgászat", IsFinished=false} },

        };

        protected TodoService() { }

        public void AddItem(string title, string description, bool isFinished)
        {
            items.Add(items.Keys.Max() + 1, new TodoItem { Title = title, Description = description, IsFinished= isFinished });
        }
        public TodoItem GetItem(int id)
        {
            return items[id];
        }

        public List<TodoItem> GetAll()
        {
            return items.Values.ToList();
        }
    }
}
