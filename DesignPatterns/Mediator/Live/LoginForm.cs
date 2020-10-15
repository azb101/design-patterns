using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Live
{
    class LoginForm : Form
    {
        public DropdownControl dropdown { get; set; }
        public TextControl textControl { get; set; }


        public override void ControlChanged(Control control)
        {
            if(control is DropdownControl)
            {
                textControl.Value = control.Value;
            }
            else if(control is TextControl)
            {
                dropdown.Value = control.Value;
            }
        }
    }
}
