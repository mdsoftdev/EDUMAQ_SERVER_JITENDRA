using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edumaq.Service
{
    public class UnitService : ServiceBase<Unit>, IUnitService
    {
        private readonly IUnitRepository _unitRepository;
        public UnitService(IUnitRepository repository) : base(repository)
        {
            _unitRepository = repository;
        }
    }
}
