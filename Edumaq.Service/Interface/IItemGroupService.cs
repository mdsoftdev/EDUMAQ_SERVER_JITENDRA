using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Edumaq.DataAccess.Models;

namespace Edumaq.Service.Interface
{
    public interface IItemGroupService:IServiceBase<ItemGroup>
    {
        Task<ItemGroup> InsertItemGroup(ItemGroup itemGroup);
        //bool IsCurrentAcademicyearExists();
        ItemGroup ModifyItemGroup(long id, ItemGroup itemGroup);
    }
}
