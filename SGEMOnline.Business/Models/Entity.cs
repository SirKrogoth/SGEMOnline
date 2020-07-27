using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Business.Models
{
    public abstract class Entity
    {
        public Guid Codigo { get; set; }

        protected Entity()
        {
            Codigo = Guid.NewGuid();
        }
    }
}
