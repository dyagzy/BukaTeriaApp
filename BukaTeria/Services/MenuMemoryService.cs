using Buka.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukaTeria.Services
{
    public class MenuMemoryService : IMenuService
    {
        private readonly List<MenuModel> menus = new List<MenuModel>();


        public MenuMemoryService()
        {
            menus.Add(new MenuModel { Id = 1, ChiefName = "Samson", MenuName = "Eforiro", Price = 12.34m});
            menus.Add(new MenuModel { Id = 2, ChiefName = "Igwe", MenuName = "Afang", Price = 9.20m });
            menus.Add(new MenuModel { Id = 3, ChiefName = "Joy", MenuName = "Jollof" , Price = 10.04m});
        }
        public Task Add(MenuModel model)
        {
           model.Id =  menus.Max(p => p.Id) + 1;
            menus.Add(model);
            return Task.CompletedTask;
        }

        public Task<MenuModel> Approval(int menuId)
        {
            return Task.Run(() =>
            {
                var menu = menus.First(m => m.Id == menuId);
                menu.Approved = true;
                return menu;
            });
        }

        public Task<IEnumerable<MenuModel>> GetAll(int bukaId)
        {
            return Task.Run(() => menus.AsEnumerable());
            
        }
    }
}
