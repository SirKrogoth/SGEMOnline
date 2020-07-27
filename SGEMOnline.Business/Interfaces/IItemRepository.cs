using SGEMOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGEMOnline.Business.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        Task<IEnumerable<Item>> ObterTodosItens();
        Task<Item> ObterItemPorCodigo(Guid Codigo);
    }
}
