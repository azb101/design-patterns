﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_and_Repository.Initial
{
    public interface ICompanyDataContext
    {
        IDBContext NewContext();
    }
}