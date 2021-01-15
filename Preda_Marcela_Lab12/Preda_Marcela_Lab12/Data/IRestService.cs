using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Preda_Marcela_Lab12.Models;

namespace Preda_Marcela_Lab12.Data
{
   public interface IRestService
    {
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }

        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int iD);
    }
}
