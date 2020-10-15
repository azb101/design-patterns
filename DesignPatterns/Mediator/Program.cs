using Mediator.Canonical;
using Mediator.Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical
            var mediator = new ConcreteMediator();

            var coll1 = new ConcreteColleague1(mediator);
            var coll2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = coll1;
            mediator.Colleague2 = coll2;

            coll1.Send("yoyoy");
            coll2.Send("what");

            Console.WriteLine("------------------------------------------");


            // live
            var form = new LoginForm();

            var dropdown = new DropdownControl(form);
            dropdown.Options = new List<string>() { "one", "two", "tree" };
            var textbox = new TextControl(form);

            form.dropdown = dropdown;
            form.textControl = textbox;

            dropdown.SelectOption(0);

            Console.WriteLine();

            textbox.ChangeText("two");
        }
    }
}
