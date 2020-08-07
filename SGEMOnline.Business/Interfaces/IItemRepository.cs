using SGEMOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Business.Interfaces
{
    public interface IItemRepository : IRepository<Item>, IDisposable
    {
        
    }
}
