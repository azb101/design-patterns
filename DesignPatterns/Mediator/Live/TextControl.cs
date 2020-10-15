using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Live
{
    class TextControl : Control
    {
        public TextControl(Form form) : base(form)
        {
        }

        public void ChangeText(string newText)
        {
            Console.WriteLine("Textbox value is changing manually");

            this.Value = newText;

            form.ControlChanged(this);
        }
    }
}
