using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Live
{
    internal class DropdownControl : Control
    {
        public List<string> Options { get; set; }

        public DropdownControl(Form form) : base(form)
        {
        }

        public void SelectOption(int index)
        {
            Console.WriteLine("Dropdown value is changing manually");
            if (index > Options.Count)
                return;

            this.Value = Options[index];

            form.ControlChanged(this);
        }
    }
}
