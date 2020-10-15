using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Live
{
    class Control 
    {
        protected Form form;
        private string value;

        public Control(Form form)
        {
            this.form = form;
        }

        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;

                Console.WriteLine(this.GetType() + " changed value to " + value);
            }
        }
    }
}
