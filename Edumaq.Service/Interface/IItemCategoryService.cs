using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface IItemCategoryService : IServiceBase<ItemCategory>
    {
        Task<ItemCategory> InsertItemCategory(ItemCategory itemCategory);
        //bool IsCurrentAcademicyearExists();
        Task<ItemCategory> ModifyItemCategory(long id, ItemCategory itemCategory);
    }
}
