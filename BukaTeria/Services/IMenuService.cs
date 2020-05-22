using Buka.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukaTeria.Services
{
    public interface IMenuService
    {
        Task Add(MenuModel model);
        Task<MenuModel> Approval(int menuId);
        Task<IEnumerable<MenuModel>> GetAll(int bukaId);


    }
}
