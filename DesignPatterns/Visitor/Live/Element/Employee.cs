﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live
{
    public class Employee : Element
    {
        public string Name { get; set;}
        public double Income { get; set; }
        public int VacationDays { get; set; }

        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
