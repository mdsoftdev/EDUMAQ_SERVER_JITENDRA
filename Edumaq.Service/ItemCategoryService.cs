using System;
using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Repository.Interfaces;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class ItemCategoryService:ServiceBase<ItemCategory>, IItemCategoryService
    {
        private readonly IItemCategoryRepository _itemCategoryRepository;
        public ItemCategoryService(IItemCategoryRepository repository) : base(repository)
        {
            _itemCategoryRepository = repository;
        }

        public async Task<ItemCategory> InsertItemCategory(ItemCategory itemCategory)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}
            return await _itemCategoryRepository.Create(itemCategory);
        }

        //public bool IsCurrentAcademicyearExists()
        //{
        //    return _academicYearRepository.IsCurrentAcademicYear();
        //}

        public async Task<ItemCategory> ModifyItemCategory(long id, ItemCategory itemCategory)
        {
            //if (academicYear.IsCurrentAcademicYear)
            //{
            //    _academicYearRepository.RemoveCurrentAcademicYear();
            //}

            await _itemCategoryRepository.Update(id, itemCategory);
            return itemCategory;
        }
    }
}
