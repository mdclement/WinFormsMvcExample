using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPattern
{
    public interface ITodoListModel
    {
        event Action<string> ModelChanged;
        void AddToList(string todo);
    }

    public class TodoListModel : ITodoListModel
    {
        private IList<string> todos = new List<string>();

        public event Action<string> ModelChanged;

        public void OnModelChanged(string obj)
        {
            Action<string> handler = ModelChanged;
            if (handler != null)
            {
                handler(obj);
            }
        }

        public void AddToList(string todo)
        {
            todos.Add(todo);
            OnModelChanged(ListAsAString());
        }
        public string ListAsAString()
        {
            return string.Join(", ", todos);
        }
    }
}
