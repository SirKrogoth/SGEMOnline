using SGEMOnline.Business.Interfaces;
using SGEMOnline.Business.Models;
using SGEMOnline.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Data.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(SGEMOnlineDBContext context) : base(context) { }
    }
}
