using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGEMOnline.Business.Models
{
    public abstract class Entity
    {
        [Key]
        public Guid Codigo { get; set; }

        protected Entity()
        {
            Codigo = Guid.NewGuid();
        }
    }
}
