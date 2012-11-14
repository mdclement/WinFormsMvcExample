using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;

namespace MvcPattern
{
    [TestFixture]
    public class TodoListTests
    {
        [Test]
        public void ModelGetListInFormat()
        {
            var list = new TodoListModel();
            list.AddToList("Ron to buy pizza");
            list.AddToList("Dallan learn to read");
            list.AddToList("Mike learn to shut up");
            Assert.That(list.ListAsAString(), 
                Is.EqualTo("Ron to buy pizza, Dallan learn to read, Mike learn to shut up"));
        }

        [Test]
        public void ControllerTest()
        {
            var model = MockRepository.GenerateMock<ITodoListModel>();
            var controller = new ListController(model);
            controller.Add("bob");
            model.AssertWasCalled(x => x.AddToList("bob"));
        }
    }
}
