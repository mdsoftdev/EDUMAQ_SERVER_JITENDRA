using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class ItemGroupService:ServiceBase<ItemGroup>, IItemGroupService
    {
        private readonly IItemGroupRepository _itemGroupRepository;
        public ItemGroupService(IItemGroupRepository repository) : base(repository)
        {
            _itemGroupRepository = repository;
        }

        public async Task<ItemGroup> InsertItemGroup(ItemGroup itemGroup)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}
            return await _itemGroupRepository.Create(itemGroup);
        }

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        public ItemGroup ModifyItemGroup(long id, ItemGroup itemGroup)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            _itemGroupRepository.Update(id, itemGroup);
            return itemGroup;
        }
    }
}
