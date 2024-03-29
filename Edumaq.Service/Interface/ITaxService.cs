﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface ITaxService : IServiceBase<Tax>
    {
        Task<Tax> InsertTax(Tax tax);
        //bool IsCurrentAcademicyearExists();
        Task<Tax> ModifyTax(long id, Tax tax);
    }
}
