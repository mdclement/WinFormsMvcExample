using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPattern
{
    public interface IListController
    {
        void Add(string item);
    }

    public class ListController : IListController
    {
        private readonly ITodoListModel model;

        public ListController(ITodoListModel model)
        {
            this.model = model;
        }

        public void Add(string item)
        {
            model.AddToList(item);
        }
    }
}
